#pragma checksum "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2066d19de642470dd80ba1342e314f3de5131373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grupa1_Index), @"mvc.1.0.view", @"/Views/Grupa1/Index.cshtml")]
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
#line 1 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\_ViewImports.cshtml"
using Zadaća_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\_ViewImports.cshtml"
using Zadaća_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2066d19de642470dd80ba1342e314f3de5131373", @"/Views/Grupa1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460c7271c4cba02325645e41d89e1cce477d1bf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Grupa1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Zadaća_4.Models.Knjiga>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 5%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<h1 style=""text-align: center"">Books.ba - Web-stranica za registraciju knjiga</h1>
<img src=""https://resi.ze-robot.com/dl/th/the-library-2560%C3%971080.jpg"" style=""width: 100%"" />
<h3 style=""margin-top: 3%"">Volite knjige? Napravite vlastitu bazu podataka sa svim svojim najdražim knjigama!</h3>
<h2 style=""margin-top: 3%"">Registrovane knjige:</h2>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 11 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ISBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DatumIzdavanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Žanr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BrojStranica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Izdanje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Izdavač));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ISBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DatumIzdavanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Žanr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BrojStranica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Izdanje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Izdavač));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa1\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div style=\"text-align: center;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2066d19de642470dd80ba1342e314f3de513137310104", async() => {
                WriteLiteral("Dodaj novu knjigu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <a class=\"btn btn-primary\" href=\"https://www.youtube.com/watch?v=BQrxsyGTztM&t\" style=\"margin-top: 5%\">Muzika za knjigoljupce</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Zadaća_4.Models.Knjiga>> Html { get; private set; }
    }
}
#pragma warning restore 1591
