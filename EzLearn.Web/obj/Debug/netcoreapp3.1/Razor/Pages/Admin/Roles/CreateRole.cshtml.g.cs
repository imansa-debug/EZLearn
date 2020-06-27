#pragma checksum "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "278ce8ce948e801e5a671b2dd7978d8d57b5f987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_CreateRole), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/CreateRole.cshtml")]
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
#line 3 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
using EzLearn.DataLayer.Entities.Permissions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"278ce8ce948e801e5a671b2dd7978d8d57b5f987", @"/Pages/Admin/Roles/CreateRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_CreateRole : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
  
    ViewData["Title"] = "افزودن نقش جدید";
    List<Permission> permissions = ViewData["Permissions"] as List<Permission>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">افزودن نقش جدید</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n");
            WriteLiteral("<div class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "278ce8ce948e801e5a671b2dd7978d8d57b5f9875067", async() => {
                WriteLiteral(@"
        <div class=""col-md-8"">
            <div class=""panel panel-primary"">
                <div class=""panel-heading"">
                   نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label>عنوان نقش</label>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "278ce8ce948e801e5a671b2dd7978d8d57b5f9875710", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitle);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                
                    <input type=""submit"" value=""ذخیره اطلاعات"" class=""btn btn-success"" />
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
               دسترسی های نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                  <ul>
");
#nullable restore
#line 45 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                       foreach(var permission in permissions.Where(p=>p.ParentID==null))
                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                          <li>\r\n                              <input type=\"checkbox\" style=\"margin:0 0 0 3px\" name=\"SelectedPermission\"");
                BeginWriteAttribute("value", " value=\"", 1677, "\"", 1709, 1);
#nullable restore
#line 48 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 1685, permission.PermissionId, 1685, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>");
#nullable restore
#line 48 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                                     Write(permission.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 49 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                           if (permissions.Any(p => p.ParentID == permission.PermissionId))
                          {

#line default
#line hidden
#nullable disable
                WriteLiteral("                              <ul>\r\n");
#nullable restore
#line 52 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                   foreach(var sub in permissions.Where(p => p.ParentID == permission.PermissionId))
                                  {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                  <li>\r\n                                      <input type=\"checkbox\" style=\"margin:0 0 0 3px\" name=\"SelectedPermission\"");
                BeginWriteAttribute("value", " value=\"", 2205, "\"", 2230, 1);
#nullable restore
#line 55 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2213, sub.PermissionId, 2213, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 55 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                                       Write(sub.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 57 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                       if (permissions.Any(p => p.ParentID == sub.PermissionId))
                                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                      <ul>\r\n");
#nullable restore
#line 60 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                           foreach (var subsub in permissions.Where(p=>p.ParentID==sub.PermissionId))
                                          {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                          <li>\r\n                                              <input type=\"checkbox\" style=\"margin:0 0 0 3px\" name=\"SelectedPermission\"");
                BeginWriteAttribute("value", " value=\"", 2772, "\"", 2800, 1);
#nullable restore
#line 63 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2780, subsub.PermissionId, 2780, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 63 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                                                  Write(subsub.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                                          </li>\r\n");
#nullable restore
#line 67 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                          }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                      </ul>\r\n");
#nullable restore
#line 70 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                      
                                      
                                      }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                      </li>\r\n");
#nullable restore
#line 75 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("                              </ul>\r\n");
#nullable restore
#line 77 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                          }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                          </li>\r\n");
#nullable restore
#line 80 "F:\Projects\Asp.net core\EZLearn\EzLearn\EzLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                  </ul>\r\n                </div>\r\n                <!-- /.panel-body -->\r\n            </div>\r\n\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EzLearn.Web.CreateRoleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EzLearn.Web.CreateRoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EzLearn.Web.CreateRoleModel>)PageContext?.ViewData;
        public EzLearn.Web.CreateRoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591