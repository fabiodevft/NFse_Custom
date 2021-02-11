using NFe.Components.Abstract;
using NFe.Components.HSantarem_SIAP_ConsultarLoteRPS;
using NFe.Components.HSantarem_SIAP_RecepcionarLoteRPS;
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace NFe.Components.SIAP.SantaremPA.h
{
    public class SIAPH : EmiteNFSeBase
    {
        private System.Web.Services.Protocols.SoapHttpClientProtocol Service;
        private X509Certificate2 Certificado;

        public override string NameSpaces => "http://nfse.abrasf.org.br/";

        #region construtores

        public SIAPH(TipoAmbiente tpAmb, string pastaRetorno, string proxyuser, string proxypass, string proxyserver, X509Certificate2 certificado)
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
            HSantarem_SIAP_ConsultarLoteRPS.cabecalho cabConsulta = new HSantarem_SIAP_ConsultarLoteRPS.cabecalho();

            cabConsulta.Versao = "1.0";
            cabConsulta.versaoDados = "2.03";

            var strResult = SerializarObjeto(Service.Execute(ref cabConsulta, envio));

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
            HSantarem_SIAP_RecepcionarLoteRPS.cabecalho cabEnv = new HSantarem_SIAP_RecepcionarLoteRPS.cabecalho();

            cabEnv.Versao = "1.0";
            cabEnv.versaoDados = "2.03";

            var strResult = SerializarObjeto(Service.Execute(ref cabEnv, envio));

            GerarRetorno(file,
                strResult,
                Propriedade.Extensao(Propriedade.TipoEnvio.EnvLoteRps).EnvioXML,
                Propriedade.Extensao(Propriedade.TipoEnvio.EnvLoteRps).RetornoXML);
        }
    }
}
