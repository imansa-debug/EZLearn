#pragma checksum "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Views\Account\SuccessRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06b9d5f006c79f1237317267834cb395db87e07b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SuccessRegister), @"mvc.1.0.view", @"/Views/Account/SuccessRegister.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06b9d5f006c79f1237317267834cb395db87e07b", @"/Views/Account/SuccessRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SuccessRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EzLearn.DataLayer.Entities.User.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Views\Account\SuccessRegister.cshtml"
  
    ViewData["Title"] = "پایان ثبت نام";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav aria-label=""breadcrumb"">
    <ul class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""/"">تاپ لرن</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">پایان ثبت نام</li>
    </ul>
</nav>

<div class=""alert alert-success"">
    <h2>");
#nullable restore
#line 14 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Views\Account\SuccessRegister.cshtml"
   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" عزیز !</h2>\r\n    <p>ثبت نام شما انجام شد ، ایمیلی حاوی لینک فعالسازی به ایمیمل \"");
#nullable restore
#line 15 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Views\Account\SuccessRegister.cshtml"
                                                              Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" ارسال شد .</p>\r\n    <p>جهت ادامه ثبت نام وارد ایمیل خود شوید و روی لینک کلیک کنید .</p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EzLearn.DataLayer.Entities.User.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
