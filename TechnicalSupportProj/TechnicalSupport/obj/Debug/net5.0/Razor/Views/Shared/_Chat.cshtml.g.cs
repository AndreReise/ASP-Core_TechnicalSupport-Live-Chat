#pragma checksum "E:\яЯя\ВСЕ\GL\PROJ\TechnicalSupportProj\TechnicalSupport\Views\Shared\_Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28049b595ff1a4ec42ad0a4d0489658742cf3f3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Chat), @"mvc.1.0.view", @"/Views/Shared/_Chat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28049b595ff1a4ec42ad0a4d0489658742cf3f3f", @"/Views/Shared/_Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa7be1d9acbcd8199cee5ef8d8ecf1148067c343", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Icons/Footer/telegram.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div id=""Modal"" class=""modal"">
    <div class=""modal-content"">
        <div class=""modal-header"">
            <h2>Do you want to complete this dialog?</h2>
            <span class=""closeModal"">&times;</span>
        </div>
        <div class=""modal-body"">
            <div class=""row"">
                <label>Please select a reason <span class=""req"">*</span></label>
                <div class=""reason-buttons"">
                    <ul>
                        <li>
                            <button onclick=""SetReasone(this)"" class=""modal-status btn btn-warning"" tabindex=""1"" data-reason=""1""><h3>Not solved</h3></button>
                        </li>
                        <li>
                            <button onclick=""SetReasone(this)"" class=""modal-status btn btn-success"" tabindex=""2"" data-reason=""3""><h3>Solved</h3></button>
                        </li>
                        <li>
                            <button onclick=""SetReasone(this)"" class=""modal-status btn btn-info"" tabindex=""3"" ");
            WriteLiteral(@"data-reason=""2""><h3>Waiting solution</h3></button>
                        </li>
                    </ul>
                </div>
            </div>

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


<div class=""chat header"">
    <div>Welcome</div>

    <span class=""enterName""><i class=""fas fa-user-edit""></i>;</span>
    <span class=""enterEmail""><i class=""fas fa-envelope""></i></span>
    <span class=""closeChat"">&times;</span>
    <span class=""minimizeChat"">&#128469;</span>
</div>

<div class=""chat-messages"">
    <");
            WriteLiteral(@"div class=""chat first"">
        <i class=""fas fa-users""></i>
        <span class=""name"">Name</span>
        <p class=""chat"">Sweet! So, what do you wannweet! So, what do you wannweet! So, what do you wannweet! So, what do you wanna do </p>
        <span class=""time"">11:02</span>
    </div>

    <div class=""chat second"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "28049b595ff1a4ec42ad0a4d0489658742cf3f3f6720", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <span class=""name"">Name2</span>
        <p class=""chat"">Nah, I dunnoweet! So, coding perhaps?</p>
        <span class=""time"">11:05</span>
    </div>

    <div class=""chat first"">
        <i class=""fas fa-users""></i>
        <span class=""name"">Name</span>
        <p class=""chat"">Sweet! So, what do you wt! So, what do you wanna do </p>
        <span class=""time"">11:02</span>
    </div>

</div>


<div class=""chat footer"">
");
            WriteLiteral("    <div class=\"chat-input\">\r\n        <input type=\"text\" id=\"chat-input\" placeholder=\"Send a message...\" />\r\n        <button type=\"submit\" class=\"chat-submit\" id=\"chat-submit\"><i class=\'fas fa-paper-plane fa-lg\'></i></button>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
