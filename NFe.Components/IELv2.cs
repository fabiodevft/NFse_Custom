using System.Net;
using System.Xml;

namespace NFe.Components
{
    public interface IELv2
    {
        IWebProxy Proxy { get; set; }

        string urlWSDL { get; set; }

        string CancelarNfse(XmlNode xml);
        string ConsultarLoteRps(XmlNode xml);
        string ConsultarNfsePorRps(XmlNode xml);
        string RecepcionarLoteRps(XmlNode xml);
    }
}
