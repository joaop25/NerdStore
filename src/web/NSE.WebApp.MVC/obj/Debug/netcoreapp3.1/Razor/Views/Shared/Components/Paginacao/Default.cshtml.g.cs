#pragma checksum "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f0863900d8c69fa61cfeacde11b1fcc5b2789aaef6414a7318cb50d150bc751f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components_Paginacao_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Paginacao/Default.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\_ViewImports.cshtml"
using NSE.WebApp.MVC

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\_ViewImports.cshtml"
using NSE.WebApp.MVC.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f0863900d8c69fa61cfeacde11b1fcc5b2789aaef6414a7318cb50d150bc751f", @"/Views/Shared/Components/Paginacao/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"53aa81ca7cc0b5684a9be4acad6d987b1af9e6862759e971876237f94580c182", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components_Paginacao_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
       IPagedList

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<nav>\r\n    <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 5 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
          
            for (var i = 1; i < Model.TotalPages + 1; i++)
            {
                if (i == Model.PageIndex)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <li class=\"page-item active\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0863900d8c69fa61cfeacde11b1fcc5b2789aaef6414a7318cb50d150bc751f4796", async() => {
                Write(
#nullable restore
#line 11 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                                                                                                                                                                i

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(" <span class=\"sr-only\">(current)</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 11 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                                                          Model.ReferenceAction

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 11 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                                                                                                  i

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 11 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                                                                                                                    Model.PageSize

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ps"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ps", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ps"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 11 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                                                                                                                                                  Model.Query

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["q"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-q", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["q"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 13 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0863900d8c69fa61cfeacde11b1fcc5b2789aaef6414a7318cb50d150bc751f10579", async() => {
                Write(
#nullable restore
#line 16 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                                                                                                                                                                                  i

#line default
#line hidden
#nullable disable
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 16 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                                                                            Model.ReferenceAction

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ps", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 16 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                                                                                                                  Model.PageSize

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ps"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ps", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ps"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 16 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                                                                                                                                                   i

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 16 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                                                                                                                                                                    Model.Query

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["q"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-q", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["q"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\Users\joao.fernandes\Desktop\JOAO PEDRO\Codigos\Desenvolvedor.Io - Aula - NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Shared\Components\Paginacao\Default.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable

            WriteLiteral("    </ul>\r\n</nav>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
