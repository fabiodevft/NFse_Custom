using NFe.Components;

namespace NFSe.Components
{
    public class SchemaXMLNFSe_CIGA
    {
        public static void CriarListaIDXML()
        {
            #region Fraiburgo-SC

            #region NFSe

            #region XML de lote RPS

            SchemaXML.InfSchemas.Add("NFSE-CIGA-GerarNfseEnvio", new InfSchema()
            {
                Tag = "GerarNfseEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\CIGA\\nfse.xsd",
                Descricao = "XML de Lote RPS",
                TagAssinatura = "Rps",
                TagAtributoId = "InfDeclaracaoPrestacaoServico",
                TargetNameSpace = "http://www.abrasf.org.br/nfse.xsd"
            });

            SchemaXML.InfSchemas.Add("NFSE-CIGA-EnviarLoteRpsSincronoEnvio", new InfSchema()
            {
                Tag = "EnviarLoteRpsSincronoEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\CIGA\\nfse.xsd",
                Descricao = "XML de Lote RPS",
                TagLoteAssinatura = "EnviarLoteRpsSincronoEnvio",
                TagLoteAtributoId = "LoteRps",
                TargetNameSpace = "http://www.abrasf.org.br/nfse.xsd"
            });

            SchemaXML.InfSchemas.Add("NFSE-CIGA-EnviarLoteRpsEnvio", new InfSchema()
            {
                Tag = "EnviarLoteRpsEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\CIGA\\nfse.xsd",
                Descricao = "XML de Lote RPS",
                TagLoteAssinatura = "EnviarLoteRpsEnvio",
                TagLoteAtributoId = "LoteRps",

                //TagAssinatura = "InfDeclaracaoPrestacaoServico",
                //TagAtributoId = "Rps",
                TargetNameSpace = "http://www.abrasf.org.br/nfse.xsd"
            });

            #endregion XML de lote RPS

            #region XML de Cancelamento de NFS-e

            SchemaXML.InfSchemas.Add("NFSE-CIGA-CancelarNfseEnvio", new InfSchema()
            {
                Tag = "CancelarNfseEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\CIGA\\nfse.xsd",
                Descricao = "XML de Cancelamento da NFS-e",
                TagAssinatura = "Pedido",
                TagAtributoId = "InfPedidoCancelamento",
                TargetNameSpace = "http://www.abrasf.org.br/nfse.xsd"
            });

            #endregion XML de Cancelamento de NFS-e

            #region XML de Consulta de Lote RPS

            SchemaXML.InfSchemas.Add("NFSE-CIGA-ConsultarLoteRpsEnvio", new InfSchema()
            {
                Tag = "ConsultarLoteRpsEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\CIGA\\nfse.xsd",
                Descricao = "XML de Consulta de Lote RPS",
                TagAssinatura = "",
                TagAtributoId = "",
                TargetNameSpace = "http://www.abrasf.org.br/nfse.xsd"
            });

            #endregion XML de Consulta de Lote RPS

            #region XML de Consulta de NFSe por Faixa

            SchemaXML.InfSchemas.Add("NFSE-CIGA-ConsultarNfseFaixaEnvio", new InfSchema()
            {
                Tag = "ConsultarNfseFaixaEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\CIGA\\nfse.xsd",
                Descricao = "XML de Consulta de NFSe por Faixa",
                TagAssinatura = "",
                TagAtributoId = "",
                TargetNameSpace = "http://www.abrasf.org.br/nfse.xsd"
            });

            #endregion XML de Consulta de NFSe por Faixa

            #region XML de Consulta de NFSe por RPS

            SchemaXML.InfSchemas.Add("NFSE-CIGA-ConsultarNfseRpsEnvio", new InfSchema()
            {
                Tag = "ConsultarNfseRpsEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\CIGA\\nfse.xsd",
                Descricao = "XML de Consulta de NFSe por Rps",
                TagAssinatura = "",
                TagAtributoId = "",
                TargetNameSpace = "http://www.abrasf.org.br/nfse.xsd"
            });

            #endregion XML de Consulta de NFSe por RPS

            #region XML de Consulta da Situação do Lote RPS

            SchemaXML.InfSchemas.Add("NFSE-CIGA-ConsultarSituacaoLoteRpsEnvio", new InfSchema()
            {
                Tag = "ConsultarSituacaoLoteRpsEnvio",
                ID = SchemaXML.InfSchemas.Count + 1,
                ArquivoXSD = "NFSe\\CIGA\\nfse.xsd",
                Descricao = "XML de Consulta Situação do Lote RPS",
                TagAssinatura = "",
                TagAtributoId = "",
                TargetNameSpace = "http://www.abrasf.org.br/nfse.xsd"
            });

            #endregion XML de Consulta da Situação do Lote RPS

            #endregion NFSe


            #endregion Fraiburgo-SC

        }
    }
}