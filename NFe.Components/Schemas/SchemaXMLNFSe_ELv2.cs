using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NFe.Components;

namespace NFSe.Components
{
    public class SchemaXMLNFSe_ELv2
    {
        public static void CriarListaIDXML()
        {
            #region XML de lote RPS

            SchemaXML.InfSchemas.Add("NFSE-ELv2-EnviarLoteRpsEnvio", new InfSchema()
            {
                Tag = "EnviarLoteRpsEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\ELv2\\nfse_v2-04.xsd",
                Descricao = "XML de Lote RPS",
                TagAssinatura = "",
                TagAtributoId = "",
                TagLoteAssinatura = "",
                TagLoteAtributoId = "",
                TargetNameSpace = "http://nfse.abrasf.org.br"
            });
            #endregion XML de lote RPS

            #region XML de lote RPS Síncrono

            SchemaXML.InfSchemas.Add("NFSE-ELv2-EnviarLoteRpsSincronoEnvio", new InfSchema()
            {
                Tag = "EnviarLoteRpsSincronoEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\ELv2\\nfse_v2-04.xsd",
                Descricao = "XML de Lote RPS",
                TagAssinatura = "",
                TagAtributoId = "",
                TagLoteAssinatura = "",
                TagLoteAtributoId = "",
                TargetNameSpace = "http://nfse.abrasf.org.br"
            });
            #endregion XML de lote RPS Síncrono

            #region XML de Cancelamento de NFS-e

            SchemaXML.InfSchemas.Add("NFSE-ELv2-CancelarNfseEnvio", new InfSchema()
            {
                Tag = "CancelarNfseEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\ELv2\\nfse_v2-04.xsd",
                Descricao = "XML de Cancelamento da NFS-e",
                TagAssinatura = "",
                TagAtributoId = "",
                TargetNameSpace = "http://nfse.abrasf.org.br"
            });
            #endregion XML de Cancelamento de NFS-e

            #region XML de Consulta de Lote RPS

            SchemaXML.InfSchemas.Add("NFSE-ELv2-ConsultarLoteRpsEnvio", new InfSchema()
            {
                Tag = "ConsultarLoteRpsEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\ELv2\\nfse_v2-04.xsd",
                Descricao = "XML de Consulta de Lote RPS",
                TagAssinatura = "",
                TagAtributoId = "",
                TargetNameSpace = "http://nfse.abrasf.org.br"
            });
            #endregion XML de Consulta de Lote RPS

            #region XML de Consulta de NFSe por Rps

            SchemaXML.InfSchemas.Add("NFSE-ELv2-ConsultarNfseRpsEnvio", new InfSchema()
            {
                Tag = "ConsultarNfseRpsEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\ELv2\\nfse_v2-04.xsd",
                Descricao = "XML de Consulta de NFSe por Rps",
                TagAssinatura = "",
                TagAtributoId = "",
                TargetNameSpace = "http://nfse.abrasf.org.br"
            });
            #endregion XML de Consulta de NFSe por Rps

            #region XML de Consulta de NFSe por Faixa

            SchemaXML.InfSchemas.Add("NFSE-ELv2-ConsultarNfseFaixaEnvio", new InfSchema()
            {
                Tag = "ConsultarNfseFaixaEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\ELv2\\nfse_v2-04.xsd",
                Descricao = "XML de Consulta de NFSe por Faixa",
                TagAssinatura = "",
                TagAtributoId = "",
                TargetNameSpace = "http://nfse.abrasf.org.br"
            });

            #endregion XML de Consulta de NFSe por Faixa

            #region Gerar NFSe Envio

            SchemaXML.InfSchemas.Add("NFSE-ELv2-GerarNfseEnvio", new InfSchema()
            {
                Tag = "EnviarLoteRpsEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\ELv2\\nfse_v2-04.xsd",
                Descricao = "XML de Lote RPS",
                TagAssinatura = "",
                TagAtributoId = "",
                TargetNameSpace = "http://nfse.abrasf.org.br"
            });
            #endregion Gerar NFSe Envio

            #region Substituir Nfse

            SchemaXML.InfSchemas.Add("NFSE-ELv2-SubstituirNfseEnvio", new InfSchema()
            {
                Tag = "SubstituirNfseEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\ELv2\\nfse_v2-04.xsd",
                Descricao = "XML de Substituição de NFSe",
                TagAssinatura0 = "",
                TagAtributoId0 = "",
                TagAssinatura = "",
                TagAtributoId = "",
                TagLoteAssinatura = "",
                TagLoteAtributoId = "",
                TargetNameSpace = "http://nfse.abrasf.org.br"
            });

            #endregion Substituir Nfse

            #region Consulta NFSe Servico Tomado

            SchemaXML.InfSchemas.Add("NFSE-ELv2-ConsultarNfseServicoPrestadoEnvio", new InfSchema()
            {
                Tag = "ConsultarNfseServicoPrestadoEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\ELv2\\nfse_v2-04.xsd",
                Descricao = "XML de Consulta da NFSe Servicos Tomados",
                TagAssinatura = "",
                TagAtributoId = "",
                TargetNameSpace = "http://nfse.abrasf.org.br"
            });

            #endregion Consulta NFSe Servico Tomado
        }
    }
}
