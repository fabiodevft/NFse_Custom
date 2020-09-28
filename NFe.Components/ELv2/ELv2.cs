using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace NFe.Components
{
    public class ELv2 : IELv2
    {
        public IWebProxy Proxy { get; set; }

        public string urlWSDL { get; set; }

        public string NameSpaces
        {
            get
            {
                return "http://nfse.abrasf.org.br/";
            }
        }

        public string CabecMsg
        {
            get
            {
                return "<cabecalho versao=\"2.04\" xmlns=\"http://www.abrasf.org.br/nfse.xsd\"><versaoDados>2.04</versaoDados></cabecalho>";
            }
        }


        #region CancelarNfse

        public string CancelarNfse(XmlNode xml)
        {
            string retornar = string.Empty;

            string XMLRetorno = RequestWS(Envelopar(xml, CabecMsg, "CancelarNfse"), urlWSDL, this.NameSpaces + "CancelarNfse");

            MemoryStream stream = Functions.StringXmlToStream(XMLRetorno);
            XmlDocument doc = new XmlDocument();
            doc.Load(stream);

            XmlNodeList xmlList = doc.GetElementsByTagName("outputXML");
            retornar = ReadInnerText(xmlList[0].OuterXml).Replace("<outputXML>", "").Replace("</outputXML>", "");


            return retornar;
        }

        #endregion

        #region ConsultarLoteRps

        public string ConsultarLoteRps(XmlNode xml)
        {
            string retornar = string.Empty;

            string XMLRetorno = RequestWS(Envelopar(xml, CabecMsg, "ConsultarLoteRps"), urlWSDL, this.NameSpaces + "ConsultarLoteRps");

            MemoryStream stream = Functions.StringXmlToStream(XMLRetorno);
            XmlDocument doc = new XmlDocument();
            doc.Load(stream);

            XmlNodeList xmlList = doc.GetElementsByTagName("outputXML");
            retornar = ReadInnerText(xmlList[0].OuterXml).Replace("<outputXML>", "").Replace("</outputXML>", "");


            return retornar;
        }

        #endregion

        #region ConsultarNfsePorRps

        public string ConsultarNfsePorRps(XmlNode xml)
        {
            string retornar = string.Empty;

            string XMLRetorno = RequestWS(Envelopar(xml, CabecMsg, "ConsultarNfsePorRps"), urlWSDL, this.NameSpaces + "ConsultarNfsePorRps");

            MemoryStream stream = Functions.StringXmlToStream(XMLRetorno);
            XmlDocument doc = new XmlDocument();
            doc.Load(stream);

            XmlNodeList xmlList = doc.GetElementsByTagName("outputXML");
            retornar = ReadInnerText(xmlList[0].OuterXml).Replace("<outputXML>", "").Replace("</outputXML>", "");

            return retornar;
        }

        #endregion

        #region RecepcionarLoteRps

        public string RecepcionarLoteRps(XmlNode xml)
        {
            string retornar = string.Empty;

            string XMLRetorno = RequestWS(Envelopar(xml, CabecMsg, "RecepcionarLoteRps"), urlWSDL, this.NameSpaces + "RecepcionarLoteRps");

            MemoryStream stream = Functions.StringXmlToStream(XMLRetorno);
            XmlDocument doc = new XmlDocument();
            doc.Load(stream);

            XmlNodeList xmlList = doc.GetElementsByTagName("outputXML");
            retornar = ReadInnerText(xmlList[0].OuterXml).Replace("<outputXML>", "").Replace("</outputXML>", "");

            return retornar.ToString();

        }

        #endregion

        #region Envelopar()
        /// <summary>
        /// Envelopa o XML (Soap)
        /// </summary>
        /// <param name="xml">XML a ser envelopado</param>
        /// <returns>Retorna o xml envelopado</returns>
        private string Envelopar(XmlNode xml, string strCabecMsg, string metodo)
        {
            StringBuilder env = new StringBuilder("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");

            env.Append("<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:nfse=\"http://nfse.abrasf.org.br\">");
            env.Append("<soapenv:Header/>");
            env.Append("<soapenv:Body>");
            env.Append($"<nfse:{metodo}>");
            env.Append($"<nfse:{metodo}Request>");
            env.Append("<nfseCabecMsg><![CDATA[" + strCabecMsg + "]]></nfseCabecMsg>");
            env.Append("<nfseDadosMsg><![CDATA[" + xml.OuterXml.ToString() + "]]></nfseDadosMsg>");
            env.Append($"</nfse:{metodo}Request>");
            env.Append($"</nfse:{metodo}>");
            env.Append("</soapenv:Body>");
            env.Append("</soapenv:Envelope>");

            return env.ToString();
        }
        #endregion

        #region RequestWS

        public string RequestWS(string envelope, string url, string soapAction)
        {
            string XMLRetorno = string.Empty;

            HttpWebRequest request = CreateSOAPWebRequest(url, soapAction);

            XmlDocument SOAPReqBody = new XmlDocument();
            SOAPReqBody.LoadXml(envelope);

            //Envio
            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }

            //Resposta  
            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    //reading stream    
                    var ServiceResult = rd.ReadToEnd();
                    //writting stream result on console    
                    XMLRetorno = ServiceResult;
                }
            }

            //XmlDocument xmldoc = new XmlDocument();
            //xmldoc.LoadXml(retorno);
            //XmlNodeList xmldocAux = xmldoc.GetElementsByTagName("outputXML");

            return XMLRetorno;
        }

        private HttpWebRequest CreateSOAPWebRequest(string url, string sopaAction)
        {
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(url);
            Req.Headers.Add($"SOAPAction:{sopaAction}");
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            //Req.ContentType = "text/xml; charset=ISO-8859-1";
            Req.Accept = "text/xml";
            Req.Method = "POST";
            
            return Req;
        }

        private string ReadInnerText(string value)
        {
            value = value.Replace("&#231;", "ç");
            value = value.Replace("&#227;", "ã");
            value = value.Replace("&amp;", "&");
            value = value.Replace("&lt;", "<");
            value = value.Replace("&gt;", ">");
            value = value.Replace("&quot;", "\"");
            value = value.Replace("&#39;", "'");

            return value;
        }

        #endregion

    }
}
