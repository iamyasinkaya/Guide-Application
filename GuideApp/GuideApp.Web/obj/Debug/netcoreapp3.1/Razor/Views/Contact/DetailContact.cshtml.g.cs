#pragma checksum "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "257eb9797f1e18fbbf05c5a3f7f274174bc34b77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_DetailContact), @"mvc.1.0.view", @"/Views/Contact/DetailContact.cshtml")]
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
#line 1 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\_ViewImports.cshtml"
using GuideApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\_ViewImports.cshtml"
using GuideApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\_ViewImports.cshtml"
using GuideApp.Web.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"257eb9797f1e18fbbf05c5a3f7f274174bc34b77", @"/Views/Contact/DetailContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea27077a1bb53c6f051af141702c76d767523d9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_DetailContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GuideApp.Web.Models.Contact>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
  
    ViewData["Title"] = "Detaylar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h4>Kişiye ait detaylar</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayFor(model => model.ContactId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactInformation.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayFor(model => model.ContactInformation.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactInformation.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayFor(model => model.ContactInformation.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactInformation.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
       Write(Html.DisplayFor(model => model.ContactInformation.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 59 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
Write(Html.ActionLink("Güncelle", "UpdateContact", new { id = Model.ContactId },new {@class="btn btn-outline-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n    ");
#nullable restore
#line 61 "C:\Users\iamys\source\repos\GuideApp\GuideApp.Web\Views\Contact\DetailContact.cshtml"
Write(Html.ActionLink("İletişim Ekle", "NewContactInfo", "ContactInformation",null,new {@class="btn btn-outline-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "257eb9797f1e18fbbf05c5a3f7f274174bc34b779746", async() => {
                WriteLiteral("Listeye Dön");
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
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GuideApp.Web.Models.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591