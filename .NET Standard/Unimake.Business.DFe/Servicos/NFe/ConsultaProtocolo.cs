﻿using System;
using System.Runtime.InteropServices;
using Unimake.Business.DFe.Servicos.Interop;
using Unimake.Business.DFe.Utility;
using Unimake.Business.DFe.Xml.NFe;

namespace Unimake.Business.DFe.Servicos.NFe
{
    public class ConsultaProtocolo: ServicoBase, IInteropService<ConsSitNFe>
    {
        #region Protected Methods

        /// <summary>
        /// Definir o valor de algumas das propriedades do objeto "Configuracoes"
        /// </summary>
        protected override void DefinirConfiguracao()
        {
            var xml = new ConsSitNFe();
            xml = xml.LerXML<ConsSitNFe>(ConteudoXML);

            if(!Configuracoes.Definida)
            {
                Configuracoes.Servico = Servico.NFeConsultaProtocolo;
                Configuracoes.CodigoUF = Convert.ToInt32(xml.ChNFe.Substring(0, 2));
                Configuracoes.TipoAmbiente = xml.TpAmb;
                Configuracoes.Modelo = (ModeloDFe)int.Parse(xml.ChNFe.Substring(20, 2));
                Configuracoes.SchemaVersao = xml.Versao;

                base.DefinirConfiguracao();
            }
        }

        #endregion Protected Methods

        #region Public Properties

        public RetConsSitNFe Result
        {
            get
            {
                if(!string.IsNullOrWhiteSpace(RetornoWSString))
                {
                    return XMLUtility.Deserializar<RetConsSitNFe>(RetornoWSXML);
                }

                return new RetConsSitNFe
                {
                    CStat = 0,
                    XMotivo = "Ocorreu uma falha ao tentar criar o objeto a partir do XML retornado da SEFAZ."
                };
            }
        }

        #endregion Public Properties

        #region Public Constructors

        public ConsultaProtocolo()
            : base()
        {
        }

        public ConsultaProtocolo(ConsSitNFe consSitNFe, Configuracao configuracao)
            : base(consSitNFe?.GerarXML() ?? throw new ArgumentNullException(nameof(consSitNFe)), configuracao) { }

        #endregion Public Constructors

        #region Public Methods

        [ComVisible(true)]
        public void Executar(ConsSitNFe consSitNFe, Configuracao configuracao)
        {
            PrepararServico(consSitNFe?.GerarXML() ?? throw new ArgumentNullException(nameof(consSitNFe)), configuracao);
            Executar();
        }

        public override void GravarXmlDistribuicao(string pasta, string nomeArquivo, string conteudoXML) => throw new System.Exception("Não existe XML de distribuição para consulta de protocolo.");

        #endregion Public Methods
    }
}