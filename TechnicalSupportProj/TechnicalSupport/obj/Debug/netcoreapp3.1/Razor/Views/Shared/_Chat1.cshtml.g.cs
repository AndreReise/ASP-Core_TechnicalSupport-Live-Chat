#pragma checksum "E:\яЯя\ВСЕ\GL\PROJ\TechnicalSupportProj\TechnicalSupport\Views\Shared\_Chat1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8c2baed67253dc4108b7bce2eb81fa58701674b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Chat1), @"mvc.1.0.view", @"/Views/Shared/_Chat1.cshtml")]
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
#line 1 "E:\яЯя\ВСЕ\GL\PROJ\TechnicalSupportProj\TechnicalSupport\Views\_ViewImports.cshtml"
using TechnicalSupport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\яЯя\ВСЕ\GL\PROJ\TechnicalSupportProj\TechnicalSupport\Views\_ViewImports.cshtml"
using TechnicalSupport.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c2baed67253dc4108b7bce2eb81fa58701674b", @"/Views/Shared/_Chat1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa7be1d9acbcd8199cee5ef8d8ecf1148067c343", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Chat1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral(@"<div id=""Modal"" class=""modal"">
    <div class=""modal-content"">
        <div class=""modal-header"">
            <span class=""closeModal"">&times;</span>
            <h2>Do you want to complete this dialog?</h2>
        </div>
        <div class=""modal-body"">
            <div class=""row"">
                <label for=""surname"">Please select a reason <span class=""req"">*</span></label>
                <div>
                    <ul>
                        <li>
                            <label for=""status_lable_1"">Solved</label>
                            <input type=""radio"" id=""status_lable_1"" name=""status"" value=""Solved"">
                        </li>
                        <li>
                            <input type=""radio"" id=""status_lable_2"" name=""status"" value=""Not solved"">
                            <label for=""status_lable_2"">Not solved</label>
                        </li>
                        <li>
                            <input checked type=""radio"" id=""status_lable_3"" name=""s");
            WriteLiteral("tatus\" value=\"waiting solution\">\r\n                            <label for=\"status_lable_3\">Waiting solution</label>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n");
            WriteLiteral(@"            </div>

            <div class=""row"">
                <label for=""email"">E-mail</label>
                <input type=""email"" name=""email"" id=""email"" class=""txt"" tabindex=""4"" placeholder="" address@mail.ru"" required autocomplete=""on"">
            </div>
        </div>
        <div class=""modal-footer"">
            <button class=""modalConfirn btn btn-5"" tabindex=""5"" id=""modalYes""><h3>Yes</h3></button>
            <button class=""modalConfirn btn btn-5"" tabindex=""6"" id=""modalNo""><h3>No</h3></button>
        </div>
    </div>
</div>

<div id=""body"">

    <div id=""chat-circle"" class=""btn btn-raised"">
        <div id=""chat-overlay""></div>
        <i class=""material-icons"">speaker_phone</i>
    </div>

    <div class=""chat-box"">
        <div class=""chat-box-header"">
            ChatBot
            <span class=""chat-box-toggle""><i class=""material-icons"">close</i></span>
        </div>
        <div class=""chat-box-body"">
            <div class=""chat-box-overlay"">
            </div>");
            WriteLiteral("\r\n            <div class=\"chat-logs\">\r\n\r\n            </div><!--chat-log -->\r\n        </div>\r\n        <div class=\"chat-input\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8c2baed67253dc4108b7bce2eb81fa58701674b5851", async() => {
                WriteLiteral("\r\n                <input type=\"text\" id=\"chat-input\" placeholder=\"Send a message...\" />\r\n                <button type=\"submit\" class=\"chat-submit\" id=\"chat-submit\"><i class=\"material-icons\">send</i></button>\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n</div>");
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
