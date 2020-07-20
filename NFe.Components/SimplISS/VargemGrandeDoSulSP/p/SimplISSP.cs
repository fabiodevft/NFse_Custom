﻿using System;
using NFe.Components.Abstract;
using NFe.Components.PVargemGrandeDoSulSP;
using System.Net;
using System.Xml;

namespace NFe.Components.SimplISS.VargemGrandeDoSulSP.p
{
    public class SimplISSP : EmiteNFSeBase
    {
        #region Propriedades
        /// <summary>
        /// Objeto de conexão com o Webservice
        /// </summary>
        private NfseService Service = new NfseService();

        /// <summary>
        /// Dados de login e senha para autenticação
        /// </summary>
        private ddDuasStrings DadosConexao = new ddDuasStrings();

        /// <summary>
        /// Namespace utilizada para deserialização do objeto
        /// </summary>
        public override string NameSpaces
        {
            get
            {
                return "http://www.sistema.com.br/Nfse/arquivos/nfse_3.xsd";
            }
        }
        #endregion

        #region Construtores
        public SimplISSP(TipoAmbiente tpAmb, string pastaRetorno, string usuario, string senhaWs, string proxyuser, string proxypass, string proxyserver)
            : base(tpAmb, pastaRetorno)
        {
            if (!String.IsNullOrEmpty(proxyuser))
            {
                NetworkCredential credentials = new System.Net.NetworkCredential(proxyuser, proxypass, proxyserver);
                WebRequest.DefaultWebProxy.Credentials = credentials;

                Service.Proxy = WebRequest.DefaultWebProxy;
                Service.Proxy.Credentials = new NetworkCredential(proxyuser, proxypass);
                Service.Credentials = new NetworkCredential(proxyuser, proxypass);
            }

            DadosConexao.P1 = usuario;
            DadosConexao.P2 = senhaWs;
        }
        #endregion

        #region Métodos
        public override void EmiteNF(string file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            string strResult = string.Empty;
            switch (doc.DocumentElement.Name)
            {
                case "GerarNovaNfseEnvio":
                    GerarNovaNfseEnvio envio = DeserializarObjeto<GerarNovaNfseEnvio>(file);
                    strResult = SerializarObjeto(Service.GerarNfse(envio, DadosConexao));
                    break;

                case "EnviarLoteRpsEnvio":
                    EnviarLoteRpsEnvio envioLote = DeserializarObjeto<EnviarLoteRpsEnvio>(file);
                    strResult = SerializarObjeto(Service.RecepcionarLoteRps(envioLote, DadosConexao));
                    break;
            }

            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.EnvLoteRps).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.EnvLoteRps).RetornoXML);
        }

        public override void CancelarNfse(string file)
        {
            CancelarNfseEnvio envio = DeserializarObjeto<CancelarNfseEnvio>(file);
            string strResult = SerializarObjeto(Service.CancelarNfse(envio, DadosConexao));

            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.PedCanNFSe).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.PedCanNFSe).RetornoXML);
        }

        public override void ConsultarLoteRps(string file)
        {
            ConsultarLoteRpsEnvio envio = DeserializarObjeto<ConsultarLoteRpsEnvio>(file);
            string strResult = SerializarObjeto(Service.ConsultarLoteRps(envio, DadosConexao));
            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.PedLoteRps).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.PedLoteRps).RetornoXML);
        }

        public override void ConsultarSituacaoLoteRps(string file)
        {
            ConsultarSituacaoLoteRpsEnvio envio = DeserializarObjeto<ConsultarSituacaoLoteRpsEnvio>(file);
            string strResult = SerializarObjeto(Service.ConsultarSituacaoLoteRps(envio, DadosConexao));
            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.PedSitLoteRps).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.PedSitLoteRps).RetornoXML);
        }

        public override void ConsultarNfse(string file)
        {
            ConsultarNfseEnvio envio = DeserializarObjeto<ConsultarNfseEnvio>(file);
            string strResult = SerializarObjeto(Service.ConsultarNfse(envio, DadosConexao));
            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.PedSitNFSe).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.PedSitNFSe).RetornoXML);
        }

        public override void ConsultarNfsePorRps(string file)
        {
            ConsultarNfseRpsEnvio envio = DeserializarObjeto<ConsultarNfseRpsEnvio>(file);
            string strResult = SerializarObjeto(Service.ConsultarNfsePorRps(envio, DadosConexao));
            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.PedSitNFSeRps).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.PedSitNFSeRps).RetornoXML);
        }
        #endregion
    }
}
