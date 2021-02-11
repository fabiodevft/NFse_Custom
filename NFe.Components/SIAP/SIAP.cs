using System;
using System.Security.Cryptography.X509Certificates;

namespace NFe.Components.SIAP
{
    public class SIAP : SIAPBase
    {
        public override string NameSpaces => throw new NotImplementedException();

        #region Construtures

        public SIAP(TipoAmbiente tpAmb, string pastaRetorno, int codMun, string proxyuser, string proxypass, string proxyserver, X509Certificate2 certificado)
            : base(tpAmb, pastaRetorno, codMun, proxyuser, proxypass, proxyserver, certificado)
        { }

        #endregion Construtures

    }
}
