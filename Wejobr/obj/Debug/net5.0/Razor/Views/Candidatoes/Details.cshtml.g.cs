#pragma checksum "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "762d7b1521bf94bd1d5a444e1eab07f248920d1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidatoes_Details), @"mvc.1.0.view", @"/Views/Candidatoes/Details.cshtml")]
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
#line 1 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\_ViewImports.cshtml"
using Wejobr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\_ViewImports.cshtml"
using Wejobr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"762d7b1521bf94bd1d5a444e1eab07f248920d1a", @"/Views/Candidatoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce6b53a90b1a9d2cb8f686b2b94175c02529ff8", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidatoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wejobr.Models.Candidato>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btnFechar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Detalhes do candidato</h3>
<hr />
<div class=""container d-flex flex-column justify-content-center mt-4 mb-4 border border-light shadow-sm bg-light rounded"">


    <dl class=""row mt-3"">
        <dt class=""col-sm-2"">
            Nome completo
        </dt>
        <dd class=""col-sm-10"">
            ");
#nullable restore
#line 17 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome_candidato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Nascimento\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nascimento_candidato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Estado civil\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado_civil_candidato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Nacionalidade\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nacionalidade_candidato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            RNE\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rne_candidato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Idioma\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Idioma_candidato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            E-mail\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email_candidato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Cargo1\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cargo1_candidato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Cargo2\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cargo2_candidato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Cargo3\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Carla\Documents\Recode\Materias\Wejobr\Wejobr - Definitivo\Wejobr\Views\Candidatoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cargo3_candidato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "762d7b1521bf94bd1d5a444e1eab07f248920d1a8631", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wejobr.Models.Candidato> Html { get; private set; }
    }
}
#pragma warning restore 1591
