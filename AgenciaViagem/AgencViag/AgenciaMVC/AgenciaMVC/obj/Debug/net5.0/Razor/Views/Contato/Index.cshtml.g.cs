#pragma checksum "C:\Users\intel\Desktop\AgenciaViagem\AgencViag\AgenciaMVC\AgenciaMVC\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54f6afae3a39ea7a25644067369e0ae4484fa144"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\intel\Desktop\AgenciaViagem\AgencViag\AgenciaMVC\AgenciaMVC\Views\_ViewImports.cshtml"
using AgenciaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\intel\Desktop\AgenciaViagem\AgencViag\AgenciaMVC\AgenciaMVC\Views\_ViewImports.cshtml"
using AgenciaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54f6afae3a39ea7a25644067369e0ae4484fa144", @"/Views/Contato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56287a7638eab33fd641d309d34c21a49108cc12", @"/Views/_ViewImports.cshtml")]
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\intel\Desktop\AgenciaViagem\AgencViag\AgenciaMVC\AgenciaMVC\Views\Contato\Index.cshtml"
  
    ViewData["Title"] = "Contato";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h2 class=\"text-center\">Contatos</h2>\r\n        <p style=\"text-align: center;\">Faça seu orçamento</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54f6afae3a39ea7a25644067369e0ae4484fa1443646", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""usr"">Nome:</label>
                <input type=""text"" class=""form-control"" id=""usr"" name=""username"">
                <label for=""email"">Email:</label>
                <input type=""email"" class=""form-control"" id=""email"" placeholder="" email"" name=""email"">
                <div class=""custom-control custom-checkbox mb-3"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"" name=""ck1"">
                    <label class=""custom-control-label"" for=""customCheck1"">Notícias</label>
                  </div>
                  <div class=""custom-control custom-checkbox mb-3"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""customCheck2"" name=""ck2"">
                    <label class=""custom-control-label"" for=""customCheck2"">Produtos</label>
                   </div>
                  <div class=""custom-control custom-checkbox mb-3"">
                    <input type=""checkbox"" class");
                WriteLiteral(@"=""custom-control-input"" id=""customCheck3"" name=""ck3"">
                    <label class=""custom-control-label"" for=""customCheck3"">Reforços</label>
                  </div>
                  <div class=""custom-control custom-checkbox mb-3"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""customCheck4"" name=""ck4"">
                    <label class=""custom-control-label"" for=""customCheck4"">Jogos Históricos</label>
                  </div>
                  <div class=""custom-control custom-checkbox mb-3"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""customCheck5"" name=""ck5"">
                    <label class=""custom-control-label"" for=""customCheck5"">Promoções de Ingresso</label>
                  </div>
                  <br>
                  <button type=""submit"" class=""btn btn-primary"">Fazer Envio</button>
           
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591