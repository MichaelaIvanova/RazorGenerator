﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleRazorHelperLibrary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorSingleFileGenerator", "0.6.0.0")]
    public class WebPagesHelperSample : System.Web.WebPages.HelperPage
    {
#line hidden
#line hidden
public static System.Web.WebPages.HelperResult Header(){
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {


                 
    if (!Page.Header.IsEmpty()) {

WriteLiteralTo(@__razor_helper_writer, "        <h1>\r\n            ");


WriteTo(@__razor_helper_writer, Page.Header);

WriteLiteralTo(@__razor_helper_writer, "\r\n        </h1>\r\n");


    }

});

}


        public WebPagesHelperSample()
        {
        }
        protected static System.Web.HttpApplication ApplicationInstance
        {
            get
            {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
    }
}
#pragma warning restore 1591
