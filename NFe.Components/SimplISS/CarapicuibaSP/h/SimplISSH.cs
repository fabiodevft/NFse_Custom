using NFe.Components.Abstract;
using NFe.Components.HCarapicuibaSP;
using System;
using System.Net;
using System.Xml;

namespace NFe.Components.SimplISS.CarapicuibaSP.h
{
    public class SimplISSH : EmiteNFSeBase
    {
        #region Propriedades
        /// <summary>
        /// Objeto de conexão com o Webservice
        /// </summary>
        private readonly NfseService Service = new NfseService();

        /// <summary>
        /// Namespace utilizada para deserialização do objeto
        /// </summary>
        private ddDuasStrings DadosConexao = new ddDuasStrings();

        public override string NameSpaces => "http://www.abrasf.org.br/nfse.xsd";

        #endregion

        #region Construtores

        public SimplISSH(TipoAmbiente tpAmb, string pastaRetorno, string usuario, string senhaWs, string proxyuser, string proxypass, string proxyserver)
            : base(tpAmb, pastaRetorno)
        {
            if (!string.IsNullOrEmpty(proxyuser))
            {
                var credentials = new System.Net.NetworkCredential(proxyuser, proxypass, proxyserver);
                System.Net.WebRequest.DefaultWebProxy.Credentials = credentials;

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
            var envio = DeserializarObjeto<CancelarNfseEnvio>(file);
            var strResult = SerializarObjeto(Service.CancelarNfse(envio, DadosConexao));

            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.PedCanNFSe).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.PedCanNFSe).RetornoXML);
        }

        public override void ConsultarLoteRps(string file)
        {
            var envio = DeserializarObjeto<ConsultarLoteRpsEnvio>(file);
            var strResult = SerializarObjeto(Service.ConsultarLoteRps(envio, DadosConexao));
            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.PedLoteRps).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.PedLoteRps).RetornoXML);
        }

        public override void ConsultarSituacaoLoteRps(string file)
        {
            var envio = DeserializarObjeto<ConsultarSituacaoLoteRpsEnvio>(file);
            var strResult = SerializarObjeto(Service.ConsultarSituacaoLoteRps(envio, DadosConexao));
            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.PedLoteRps).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.PedLoteRps).RetornoXML);
        }

        public override void ConsultarNfse(string file)
        {
            var envio = DeserializarObjeto<ConsultarNfseEnvio>(file);
            var strResult = SerializarObjeto(Service.ConsultarNfse(envio, DadosConexao));
            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.PedSitNFSe).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.PedSitNFSe).RetornoXML);
        }

        public override void ConsultarNfsePorRps(string file)
        {
            ConsultarNfseRpsEnvio envio = DeserializarObjeto<ConsultarNfseRpsEnvio>(file);
            string strResult = SerializarObjeto(Service.ConsultarNfsePorRps(envio, DadosConexao));
            GerarRetorno(file, strResult, Propriedade.Extensao(Propriedade.TipoEnvio.PedSitNFSeRps).EnvioXML,
                                          Propriedade.Extensao(Propriedade.TipoEnvio.PedSitNFSeRps).RetornoXML, System.Text.Encoding.UTF8);
        }

        #endregion
    }
}