#pragma checksum "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "185eb204c805f8f81e14823c1545f8a737fdd755"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bots_List), @"mvc.1.0.view", @"/Views/Bots/List.cshtml")]
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
#line 1 "D:\project\SimpleLineBot\SimpleLineBot\Views\_ViewImports.cshtml"
using SimpleLineBot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project\SimpleLineBot\SimpleLineBot\Views\_ViewImports.cshtml"
using SimpleLineBot.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"185eb204c805f8f81e14823c1545f8a737fdd755", @"/Views/Bots/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1962c5fa5566d4f331b60e45ef43f7c940cc7235", @"/Views/_ViewImports.cshtml")]
    public class Views_Bots_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimpleLineBot.Models.DB.Bot>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "changestatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function _delete(id, name) {
        if (window.confirm(""確定要刪除"" + name + ""嗎?"")) {
            window.location.href = ""delete/"" + id;
        }
    }
    function copy(text) {
        let d = document.getElementById(""copy"");
        d.innerText = '");
#nullable restore
#line 15 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
                  Write(ViewBag.RootPath);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + text;
        copyEvent('copy');
    }
    function copyEvent(id) {

        var str = document.getElementById(id);
        str.hidden = '';
        window.getSelection().selectAllChildren(str);
        document.execCommand(""Copy"")
        str.hidden = 'hidden';
    }
</script>

<h1>List</h1>
<p hidden=""hidden"" id=""copy""></p>
<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185eb204c805f8f81e14823c1545f8a737fdd7555751", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<div class=\"table-responsive table-bordered\">\r\n    <table class=\"table table-dark  text-nowrap\">\r\n        <thead>\r\n            <tr>\r\n                <th>Access</th>\r\n                <th>Token</th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayNameFor(model => model.ChannelSecret));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayNameFor(model => model.ChannelAccessToken));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 49 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayNameFor(model => model.Enable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 52 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayNameFor(model => model.Remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 55 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 58 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayNameFor(model => model.Updated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 64 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185eb204c805f8f81e14823c1545f8a737fdd7559733", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2100, "\"", 2141, 6);
            WriteAttributeValue("", 2110, "_delete(", 2110, 8, true);
#nullable restore
#line 70 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
WriteAttributeValue("", 2118, item.Id, 2118, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2126, ",", 2126, 1, true);
            WriteAttributeValue(" ", 2127, "\'", 2128, 2, true);
#nullable restore
#line 70 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
WriteAttributeValue("", 2129, item.Name, 2129, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2139, "\')", 2139, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.UrlToken));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <a class=\"btn btn-sm btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2321, "\"", 2353, 3);
            WriteAttributeValue("", 2331, "copy(\'", 2331, 6, true);
#nullable restore
#line 75 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
WriteAttributeValue("", 2337, item.UrlToken, 2337, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2351, "\')", 2351, 2, true);
            EndWriteAttribute();
            WriteLiteral(">複製Hook網址</a>\r\n\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ChannelSecret));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 85 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ChannelAccessToken));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 88 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Enable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185eb204c805f8f81e14823c1545f8a737fdd75515038", async() => {
                WriteLiteral("Change");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 93 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 99 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Updated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 103 "D:\project\SimpleLineBot\SimpleLineBot\Views\Bots\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimpleLineBot.Models.DB.Bot>> Html { get; private set; }
    }
}
#pragma warning restore 1591