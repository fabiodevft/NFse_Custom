﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace NFe.Components.PWebfiscoTecnologia_Enviar {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="webserviceBinding", Namespace="http://201.16.156.170/issqn/wservice/wsnfeenvia.php")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(EnvNfe))]
    public partial class webservice : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback EnvNfeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public webservice() {
            this.Url = global::NFe.Components.Properties.Settings.Default.NFe_Components_PBarraBonitaSP_Enviar_webservice;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event EnvNfeCompletedEventHandler EnvNfeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("https://www.webfiscotecnologia.com.br/issqn/wservice/wsnfeenvia.php/EnvNfe", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public EnvNfe[] EnvNfe(
                    string usuario, 
                    string pass, 
                    string prf, 
                    string usr, 
                    string ctr, 
                    string cnpj, 
                    string cnpjn, 
                    string ie, 
                    string im, 
                    string lgr, 
                    string num, 
                    string cpl, 
                    string bai, 
                    string cid, 
                    string est, 
                    string cep, 
                    string fon, 
                    string mail, 
                    string dat, 
                    string f1n, 
                    string f1d, 
                    string f1v, 
                    string f2n, 
                    string f2d, 
                    string f2v, 
                    string f3n, 
                    string f3d, 
                    string f3v, 
                    string f4n, 
                    string f4d, 
                    string f4v, 
                    string f5n, 
                    string f5d, 
                    string f5v, 
                    string f6n, 
                    string f6d, 
                    string f6v, 
                    string item1, 
                    string item2, 
                    string item3, 
                    string aliq1, 
                    string aliq2, 
                    string aliq3, 
                    string val1, 
                    string val2, 
                    string val3, 
                    string loc, 
                    string ret, 
                    string txt, 
                    string val, 
                    string valtrib, 
                    string iss, 
                    string issret, 
                    string desci, 
                    string desco, 
                    string binss, 
                    string birrf, 
                    string bcsll, 
                    string bpis, 
                    string bcofins, 
                    string ainss, 
                    string airrf, 
                    string acsll, 
                    string apis, 
                    string acofins, 
                    string inss, 
                    string irrf, 
                    string csll, 
                    string pis, 
                    string cofins, 
                    string item4, 
                    string item5, 
                    string item6, 
                    string item7, 
                    string item8, 
                    string aliq4, 
                    string aliq5, 
                    string aliq6, 
                    string aliq7, 
                    string aliq8, 
                    string val4, 
                    string val5, 
                    string val6, 
                    string val7, 
                    string val8, 
                    string iteser1, 
                    string iteser2, 
                    string iteser3, 
                    string iteser4, 
                    string iteser5, 
                    string iteser6, 
                    string iteser7, 
                    string iteser8, 
                    string alqser1, 
                    string alqser2, 
                    string alqser3, 
                    string alqser4, 
                    string alqser5, 
                    string alqser6, 
                    string alqser7, 
                    string alqser8, 
                    string valser1, 
                    string valser2, 
                    string valser3, 
                    string valser4, 
                    string valser5, 
                    string valser6, 
                    string valser7, 
                    string valser8, 
                    string paisest, 
                    string ssrecbr, 
                    string ssanexo, 
                    string ssdtini, 
                    string percded, 
                    string itemsac1, 
                    string itemsaq1, 
                    string itemsav1, 
                    string itemsat1, 
                    string itemsac2, 
                    string itemsaq2, 
                    string itemsav2, 
                    string itemsat2, 
                    string itemsac3, 
                    string itemsaq3, 
                    string itemsav3, 
                    string itemsat3, 
                    string itemsac4, 
                    string itemsaq4, 
                    string itemsav4, 
                    string itemsat4, 
                    string itemsac5, 
                    string itemsaq5, 
                    string itemsav5, 
                    string itemsat5) {
            object[] results = this.Invoke("EnvNfe", new object[] {
                        usuario,
                        pass,
                        prf,
                        usr,
                        ctr,
                        cnpj,
                        cnpjn,
                        ie,
                        im,
                        lgr,
                        num,
                        cpl,
                        bai,
                        cid,
                        est,
                        cep,
                        fon,
                        mail,
                        dat,
                        f1n,
                        f1d,
                        f1v,
                        f2n,
                        f2d,
                        f2v,
                        f3n,
                        f3d,
                        f3v,
                        f4n,
                        f4d,
                        f4v,
                        f5n,
                        f5d,
                        f5v,
                        f6n,
                        f6d,
                        f6v,
                        item1,
                        item2,
                        item3,
                        aliq1,
                        aliq2,
                        aliq3,
                        val1,
                        val2,
                        val3,
                        loc,
                        ret,
                        txt,
                        val,
                        valtrib,
                        iss,
                        issret,
                        desci,
                        desco,
                        binss,
                        birrf,
                        bcsll,
                        bpis,
                        bcofins,
                        ainss,
                        airrf,
                        acsll,
                        apis,
                        acofins,
                        inss,
                        irrf,
                        csll,
                        pis,
                        cofins,
                        item4,
                        item5,
                        item6,
                        item7,
                        item8,
                        aliq4,
                        aliq5,
                        aliq6,
                        aliq7,
                        aliq8,
                        val4,
                        val5,
                        val6,
                        val7,
                        val8,
                        iteser1,
                        iteser2,
                        iteser3,
                        iteser4,
                        iteser5,
                        iteser6,
                        iteser7,
                        iteser8,
                        alqser1,
                        alqser2,
                        alqser3,
                        alqser4,
                        alqser5,
                        alqser6,
                        alqser7,
                        alqser8,
                        valser1,
                        valser2,
                        valser3,
                        valser4,
                        valser5,
                        valser6,
                        valser7,
                        valser8,
                        paisest,
                        ssrecbr,
                        ssanexo,
                        ssdtini,
                        percded,
                        itemsac1,
                        itemsaq1,
                        itemsav1,
                        itemsat1,
                        itemsac2,
                        itemsaq2,
                        itemsav2,
                        itemsat2,
                        itemsac3,
                        itemsaq3,
                        itemsav3,
                        itemsat3,
                        itemsac4,
                        itemsaq4,
                        itemsav4,
                        itemsat4,
                        itemsac5,
                        itemsaq5,
                        itemsav5,
                        itemsat5});
            return ((EnvNfe[])(results[0]));
        }
        
        /// <remarks/>
        public void EnvNfeAsync(
                    string usuario, 
                    string pass, 
                    string prf, 
                    string usr, 
                    string ctr, 
                    string cnpj, 
                    string cnpjn, 
                    string ie, 
                    string im, 
                    string lgr, 
                    string num, 
                    string cpl, 
                    string bai, 
                    string cid, 
                    string est, 
                    string cep, 
                    string fon, 
                    string mail, 
                    string dat, 
                    string f1n, 
                    string f1d, 
                    string f1v, 
                    string f2n, 
                    string f2d, 
                    string f2v, 
                    string f3n, 
                    string f3d, 
                    string f3v, 
                    string f4n, 
                    string f4d, 
                    string f4v, 
                    string f5n, 
                    string f5d, 
                    string f5v, 
                    string f6n, 
                    string f6d, 
                    string f6v, 
                    string item1, 
                    string item2, 
                    string item3, 
                    string aliq1, 
                    string aliq2, 
                    string aliq3, 
                    string val1, 
                    string val2, 
                    string val3, 
                    string loc, 
                    string ret, 
                    string txt, 
                    string val, 
                    string valtrib, 
                    string iss, 
                    string issret, 
                    string desci, 
                    string desco, 
                    string binss, 
                    string birrf, 
                    string bcsll, 
                    string bpis, 
                    string bcofins, 
                    string ainss, 
                    string airrf, 
                    string acsll, 
                    string apis, 
                    string acofins, 
                    string inss, 
                    string irrf, 
                    string csll, 
                    string pis, 
                    string cofins, 
                    string item4, 
                    string item5, 
                    string item6, 
                    string item7, 
                    string item8, 
                    string aliq4, 
                    string aliq5, 
                    string aliq6, 
                    string aliq7, 
                    string aliq8, 
                    string val4, 
                    string val5, 
                    string val6, 
                    string val7, 
                    string val8, 
                    string iteser1, 
                    string iteser2, 
                    string iteser3, 
                    string iteser4, 
                    string iteser5, 
                    string iteser6, 
                    string iteser7, 
                    string iteser8, 
                    string alqser1, 
                    string alqser2, 
                    string alqser3, 
                    string alqser4, 
                    string alqser5, 
                    string alqser6, 
                    string alqser7, 
                    string alqser8, 
                    string valser1, 
                    string valser2, 
                    string valser3, 
                    string valser4, 
                    string valser5, 
                    string valser6, 
                    string valser7, 
                    string valser8, 
                    string paisest, 
                    string ssrecbr, 
                    string ssanexo, 
                    string ssdtini, 
                    string percded, 
                    string itemsac1, 
                    string itemsaq1, 
                    string itemsav1, 
                    string itemsat1, 
                    string itemsac2, 
                    string itemsaq2, 
                    string itemsav2, 
                    string itemsat2, 
                    string itemsac3, 
                    string itemsaq3, 
                    string itemsav3, 
                    string itemsat3, 
                    string itemsac4, 
                    string itemsaq4, 
                    string itemsav4, 
                    string itemsat4, 
                    string itemsac5, 
                    string itemsaq5, 
                    string itemsav5, 
                    string itemsat5) {
            this.EnvNfeAsync(usuario, pass, prf, usr, ctr, cnpj, cnpjn, ie, im, lgr, num, cpl, bai, cid, est, cep, fon, mail, dat, f1n, f1d, f1v, f2n, f2d, f2v, f3n, f3d, f3v, f4n, f4d, f4v, f5n, f5d, f5v, f6n, f6d, f6v, item1, item2, item3, aliq1, aliq2, aliq3, val1, val2, val3, loc, ret, txt, val, valtrib, iss, issret, desci, desco, binss, birrf, bcsll, bpis, bcofins, ainss, airrf, acsll, apis, acofins, inss, irrf, csll, pis, cofins, item4, item5, item6, item7, item8, aliq4, aliq5, aliq6, aliq7, aliq8, val4, val5, val6, val7, val8, iteser1, iteser2, iteser3, iteser4, iteser5, iteser6, iteser7, iteser8, alqser1, alqser2, alqser3, alqser4, alqser5, alqser6, alqser7, alqser8, valser1, valser2, valser3, valser4, valser5, valser6, valser7, valser8, paisest, ssrecbr, ssanexo, ssdtini, percded, itemsac1, itemsaq1, itemsav1, itemsat1, itemsac2, itemsaq2, itemsav2, itemsat2, itemsac3, itemsaq3, itemsav3, itemsat3, itemsac4, itemsaq4, itemsav4, itemsat4, itemsac5, itemsaq5, itemsav5, itemsat5, null);
        }
        
        /// <remarks/>
        public void EnvNfeAsync(
                    string usuario, 
                    string pass, 
                    string prf, 
                    string usr, 
                    string ctr, 
                    string cnpj, 
                    string cnpjn, 
                    string ie, 
                    string im, 
                    string lgr, 
                    string num, 
                    string cpl, 
                    string bai, 
                    string cid, 
                    string est, 
                    string cep, 
                    string fon, 
                    string mail, 
                    string dat, 
                    string f1n, 
                    string f1d, 
                    string f1v, 
                    string f2n, 
                    string f2d, 
                    string f2v, 
                    string f3n, 
                    string f3d, 
                    string f3v, 
                    string f4n, 
                    string f4d, 
                    string f4v, 
                    string f5n, 
                    string f5d, 
                    string f5v, 
                    string f6n, 
                    string f6d, 
                    string f6v, 
                    string item1, 
                    string item2, 
                    string item3, 
                    string aliq1, 
                    string aliq2, 
                    string aliq3, 
                    string val1, 
                    string val2, 
                    string val3, 
                    string loc, 
                    string ret, 
                    string txt, 
                    string val, 
                    string valtrib, 
                    string iss, 
                    string issret, 
                    string desci, 
                    string desco, 
                    string binss, 
                    string birrf, 
                    string bcsll, 
                    string bpis, 
                    string bcofins, 
                    string ainss, 
                    string airrf, 
                    string acsll, 
                    string apis, 
                    string acofins, 
                    string inss, 
                    string irrf, 
                    string csll, 
                    string pis, 
                    string cofins, 
                    string item4, 
                    string item5, 
                    string item6, 
                    string item7, 
                    string item8, 
                    string aliq4, 
                    string aliq5, 
                    string aliq6, 
                    string aliq7, 
                    string aliq8, 
                    string val4, 
                    string val5, 
                    string val6, 
                    string val7, 
                    string val8, 
                    string iteser1, 
                    string iteser2, 
                    string iteser3, 
                    string iteser4, 
                    string iteser5, 
                    string iteser6, 
                    string iteser7, 
                    string iteser8, 
                    string alqser1, 
                    string alqser2, 
                    string alqser3, 
                    string alqser4, 
                    string alqser5, 
                    string alqser6, 
                    string alqser7, 
                    string alqser8, 
                    string valser1, 
                    string valser2, 
                    string valser3, 
                    string valser4, 
                    string valser5, 
                    string valser6, 
                    string valser7, 
                    string valser8, 
                    string paisest, 
                    string ssrecbr, 
                    string ssanexo, 
                    string ssdtini, 
                    string percded, 
                    string itemsac1, 
                    string itemsaq1, 
                    string itemsav1, 
                    string itemsat1, 
                    string itemsac2, 
                    string itemsaq2, 
                    string itemsav2, 
                    string itemsat2, 
                    string itemsac3, 
                    string itemsaq3, 
                    string itemsav3, 
                    string itemsat3, 
                    string itemsac4, 
                    string itemsaq4, 
                    string itemsav4, 
                    string itemsat4, 
                    string itemsac5, 
                    string itemsaq5, 
                    string itemsav5, 
                    string itemsat5, 
                    object userState) {
            if ((this.EnvNfeOperationCompleted == null)) {
                this.EnvNfeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEnvNfeOperationCompleted);
            }
            this.InvokeAsync("EnvNfe", new object[] {
                        usuario,
                        pass,
                        prf,
                        usr,
                        ctr,
                        cnpj,
                        cnpjn,
                        ie,
                        im,
                        lgr,
                        num,
                        cpl,
                        bai,
                        cid,
                        est,
                        cep,
                        fon,
                        mail,
                        dat,
                        f1n,
                        f1d,
                        f1v,
                        f2n,
                        f2d,
                        f2v,
                        f3n,
                        f3d,
                        f3v,
                        f4n,
                        f4d,
                        f4v,
                        f5n,
                        f5d,
                        f5v,
                        f6n,
                        f6d,
                        f6v,
                        item1,
                        item2,
                        item3,
                        aliq1,
                        aliq2,
                        aliq3,
                        val1,
                        val2,
                        val3,
                        loc,
                        ret,
                        txt,
                        val,
                        valtrib,
                        iss,
                        issret,
                        desci,
                        desco,
                        binss,
                        birrf,
                        bcsll,
                        bpis,
                        bcofins,
                        ainss,
                        airrf,
                        acsll,
                        apis,
                        acofins,
                        inss,
                        irrf,
                        csll,
                        pis,
                        cofins,
                        item4,
                        item5,
                        item6,
                        item7,
                        item8,
                        aliq4,
                        aliq5,
                        aliq6,
                        aliq7,
                        aliq8,
                        val4,
                        val5,
                        val6,
                        val7,
                        val8,
                        iteser1,
                        iteser2,
                        iteser3,
                        iteser4,
                        iteser5,
                        iteser6,
                        iteser7,
                        iteser8,
                        alqser1,
                        alqser2,
                        alqser3,
                        alqser4,
                        alqser5,
                        alqser6,
                        alqser7,
                        alqser8,
                        valser1,
                        valser2,
                        valser3,
                        valser4,
                        valser5,
                        valser6,
                        valser7,
                        valser8,
                        paisest,
                        ssrecbr,
                        ssanexo,
                        ssdtini,
                        percded,
                        itemsac1,
                        itemsaq1,
                        itemsav1,
                        itemsat1,
                        itemsac2,
                        itemsaq2,
                        itemsav2,
                        itemsat2,
                        itemsac3,
                        itemsaq3,
                        itemsav3,
                        itemsat3,
                        itemsac4,
                        itemsaq4,
                        itemsav4,
                        itemsat4,
                        itemsac5,
                        itemsaq5,
                        itemsav5,
                        itemsat5}, this.EnvNfeOperationCompleted, userState);
        }
        
        private void OnEnvNfeOperationCompleted(object arg) {
            if ((this.EnvNfeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EnvNfeCompleted(this, new EnvNfeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://201.16.156.170/issqn/wservice/wsnfeenvia.php")]
    public partial class EnvNfe {
        
        private string okkField;
        
        /// <remarks/>
        public string okk {
            get {
                return this.okkField;
            }
            set {
                this.okkField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void EnvNfeCompletedEventHandler(object sender, EnvNfeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EnvNfeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EnvNfeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public EnvNfe[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((EnvNfe[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591