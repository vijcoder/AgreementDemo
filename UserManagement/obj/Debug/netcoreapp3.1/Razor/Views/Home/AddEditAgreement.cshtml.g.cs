#pragma checksum "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a84cb4220d87b982526be6256e288a9dbabe7db2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddEditAgreement), @"mvc.1.0.view", @"/Views/Home/AddEditAgreement.cshtml")]
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
#line 1 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\_ViewImports.cshtml"
using UserManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\_ViewImports.cshtml"
using UserManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84cb4220d87b982526be6256e288a9dbabe7db2", @"/Views/Home/AddEditAgreement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49da211b1c35ec911bb8f94c53c5e3c8e53492f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddEditAgreement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domains.ViewModels.AgreementViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
  
    var userid = User.Identity.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a84cb4220d87b982526be6256e288a9dbabe7db24794", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a84cb4220d87b982526be6256e288a9dbabe7db25833", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a84cb4220d87b982526be6256e288a9dbabe7db26872", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
 using (Html.BeginForm("AddEditAgreement", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <hr />\r\n    ");
#nullable restore
#line 19 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 21 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
   Write(Html.HiddenFor(u => u.Id, new { @id = "Id" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 24 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
   Write(Html.Label("", "Select Project Group", new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-sm-12\">\r\n            ");
#nullable restore
#line 26 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.DropDownList("ProductGroupId", ViewBag.ProjectGroup as
IEnumerable<SelectListItem>, "-Select-", new { @id = "ProductGroupId", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.HiddenFor(m => m.ProductGroupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.ValidationMessageFor(model => model.ProductGroupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 33 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
   Write(Html.Label("", "Select Project", new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-sm-12\">\r\n            ");
#nullable restore
#line 35 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.DropDownList("ProductId", ViewBag.Project as
IEnumerable<SelectListItem>, "-Select-", new { @id = "ProductId", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.HiddenFor(m => m.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 38 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.ValidationMessageFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 42 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
   Write(Html.Label("", "Select User", new { @class = "control-label col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-sm-12\">\r\n            ");
#nullable restore
#line 44 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.DropDownList("UserId", ViewBag.UserList as
IEnumerable<SelectListItem>, "-Select-", new { @id = "UserId", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 46 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.HiddenFor(m => m.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 47 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 58 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
   Write(Html.Label("", "EffectiveDate", new { @class = "control-label col-sm-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 60 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.EditorFor(model => model.EffectiveDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 61 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.ValidationMessageFor(model => model.EffectiveDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 65 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
   Write(Html.Label("", "ExpirationDate", new { @class = "control-label col-sm-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 67 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.EditorFor(model => model.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 68 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.ValidationMessageFor(model => model.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 72 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
   Write(Html.Label("", "ProductPrice", new { @class = "control-label col-sm-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 74 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.EditorFor(model => model.ProductPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 75 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.ValidationMessageFor(model => model.ProductPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 79 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
   Write(Html.Label("", "NewPrice", new { @class = "control-label col-sm-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 81 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.EditorFor(model => model.NewPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 82 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.ValidationMessageFor(model => model.NewPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 86 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
   Write(Html.Label("", "IsActive", new { @class = "control-label col-sm-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 88 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
       Write(Html.CheckBoxFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Submit\" />\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 95 "C:\Projects\RnD\WebApp\UserManagement\UserManagement\Views\Home\AddEditAgreement.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domains.ViewModels.AgreementViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591