using NFe.Components.Abstract;
using System.Security.Cryptography.X509Certificates;

namespace NFe.Components.SIAP
{
    public abstract class SIAPBase : EmiteNFSeBase
    {
        #region locais/ protegidos

        private int CodigoMun = 0;
        private string ProxyUser = string.Empty;
        private string ProxyPass = string.Empty;
        private string ProxyServer = string.Empty;
        private X509Certificate2 Certificado;
        private EmiteNFSeBase siapService;

        protected EmiteNFSeBase SIAPService
        {
            get
            {
                if (siapService == null)
                {
                    //if (tpAmb == TipoAmbiente.taHomologacao)
                    //    switch (CodigoMun)
                    //    {
                    //        case 1506807: //Santarém-PA
                    //            siapService = new .h.TinusH(tpAmb, PastaRetorno, ProxyUser, ProxyPass, ProxyServer, Certificado);
                    //            break;

                    //        default:
                    //            throw new Exceptions.ServicoInexistenteException();
                    //    }
                    //else
                    //    switch (CodigoMun)
                    //    {
                    //        case 1506807: //Santarém-PA
                    //            siapService = new SaoJoseDoRibamarMA.p.TinusP(tpAmb, PastaRetorno, ProxyUser, ProxyPass, ProxyServer, Certificado);
                    //            break;

                    //        default:
                    //            throw new Exceptions.ServicoInexistenteException();
                    //    }
                }

                return siapService;
            }
        }

        #endregion locais/ protegidos

        #region Construtores

        public SIAPBase(TipoAmbiente tpAmb, string pastaRetorno, int codMun, string proxyuser, string proxypass, string proxyserver, X509Certificate2 certificado)
            : base(tpAmb, pastaRetorno)
        {
            CodigoMun = codMun;
            ProxyUser = proxyuser;
            ProxyPass = proxypass;
            ProxyServer = proxyserver;
            Certificado = certificado;
        }

        #endregion Construtores

        #region Métodos

        public override void EmiteNF(string file)
        {
            SIAPService.EmiteNF(file);
        }

        public override void CancelarNfse(string file)
        {
            SIAPService.CancelarNfse(file);
        }

        public override void ConsultarLoteRps(string file)
        {
            SIAPService.ConsultarLoteRps(file);
        }

        public override void ConsultarSituacaoLoteRps(string file)
        {
            SIAPService.ConsultarSituacaoLoteRps(file);
        }

        public override void ConsultarNfse(string file)
        {
            SIAPService.ConsultarNfse(file);
        }

        public override void ConsultarNfsePorRps(string file)
        {
            SIAPService.ConsultarNfsePorRps(file);
        }

        #endregion Métodos

    }
}
