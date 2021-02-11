using NFe.Components.Abstract;
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using NFe.Components.PSantarem_SIAP_ConsultarLoteRPS;
using NFe.Components.PSantarem_SIAP_RecepcionarLoteRPS;

namespace NFe.Components.SIAP.SantaremPA.p
{
    public class SIAPP : EmiteNFSeBase
    {
        private System.Web.Services.Protocols.SoapHttpClientProtocol Service;
        private X509Certificate2 Certificado;

        public override string NameSpaces => "http://nfse.abrasf.org.br/";

        #region construtores

        public SIAPP(TipoAmbiente tpAmb, string pastaRetorno, string proxyuser, string proxypass, string proxyserver, X509Certificate2 certificado)
            : base(tpAmb, pastaRetorno)
        {
            ServicePointManager.Expect100Continue = false;
            Certificado = certificado;
        }

        #endregion construtores

        public override void CancelarNfse(string file)
        {
            throw new NotImplementedException();
        }

        public override void ConsultarLoteRps(string file)
        {
            ConsultarLoteRps Service = new ConsultarLoteRps();

            Service.ClientCertificates.Add(Certificado);
            DefinirProxy<ConsultarLoteRps>(Service);

            ConsultarLoteRpsEnvio envio = DeserializarObjeto<ConsultarLoteRpsEnvio>(file);
            HSantarem_SIAP_ConsultarLoteRPS.cabecalho cab = new HSantarem_SIAP_ConsultarLoteRPS.cabecalho();

            cab.Versao = "1.0";
            cab.versaoDados = "2.03";

            var strResult = SerializarObjeto(Service.Execute(ref cab, envio));

            GerarRetorno(file,
                strResult,
                Propriedade.Extensao(Propriedade.TipoEnvio.EnvLoteRps).EnvioXML,
                Propriedade.Extensao(Propriedade.TipoEnvio.EnvLoteRps).RetornoXML);
        }

        public override void ConsultarNfse(string file)
        {
            throw new NotImplementedException();
        }

        public override void ConsultarNfsePorRps(string file)
        {
            throw new NotImplementedException();
        }

        public override void ConsultarSituacaoLoteRps(string file)
        {
            throw new NotImplementedException();
        }

        public override void EmiteNF(string file)
        {
            RecepcionarLoteRpsSincrono Service = new RecepcionarLoteRpsSincrono();

            Service.ClientCertificates.Add(Certificado);
            DefinirProxy<RecepcionarLoteRpsSincrono>(Service);

            EnviarLoteRpsSincronoEnvio envio = DeserializarObjeto<EnviarLoteRpsSincronoEnvio>(file);
            HSantarem_SIAP_RecepcionarLoteRPS.cabecalho cab = new HSantarem_SIAP_RecepcionarLoteRPS.cabecalho();

            cab.Versao = "1.0";
            cab.versaoDados = "2.03";

            var strResult = SerializarObjeto(Service.Execute(ref cab, envio));

            GerarRetorno(file,
                strResult,
                Propriedade.Extensao(Propriedade.TipoEnvio.EnvLoteRps).EnvioXML,
                Propriedade.Extensao(Propriedade.TipoEnvio.EnvLoteRps).RetornoXML);
        }
    }
}
