#pragma checksum "C:\Users\olech\OneDrive\Desktop\Лабораторная работа 3\Laba3\Views\Calculator\Calculator3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b41eeec5abf28e4fbc9ba5f9b94e3c87863f0414"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Calculator3), @"mvc.1.0.view", @"/Views/Calculator/Calculator3.cshtml")]
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
#line 1 "C:\Users\olech\OneDrive\Desktop\Лабораторная работа 3\Laba3\Views\_ViewImports.cshtml"
using Laba3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\olech\OneDrive\Desktop\Лабораторная работа 3\Laba3\Views\Calculator\Calculator3.cshtml"
using Laba3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b41eeec5abf28e4fbc9ba5f9b94e3c87863f0414", @"/Views/Calculator/Calculator3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71b7e56f11c7237cf1f38403339ecc425a312bb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Calculator3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\olech\OneDrive\Desktop\Лабораторная работа 3\Laba3\Views\Calculator\Calculator3.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\olech\OneDrive\Desktop\Лабораторная работа 3\Laba3\Views\Calculator\Calculator3.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41eeec5abf28e4fbc9ba5f9b94e3c87863f04143746", async() => {
                WriteLiteral(@"
    <style>

        .center {
            text-align: center;
            padding: 10px;
            margin: auto;
            color: gray;
        }

        .calc {
            width: 400px;
            padding: 10px;
            margin: auto;
        }

    html, body { width: auto; height: auto; margin: auto; background-image: url(""https://i.pinimg.com/originals/ef/9d/1a/ef9d1a5386d76e1a202034b3c1e92117.png""); background-repeat: no-repeat; background-position-x: center; background-size: cover; }

        .but1 {
            width: 100px;
            height: 100px;
            font-size: 50pt;
            color: gray;
            outline-color: white;
            background-color: seashell;
        }

        .but2 {
            width: 100px;
            height: 100px;
            font-size: 50pt;
            color: gray;
            outline-color: white;
            background-color: lightpink;
        }

    </style>
    <meta name=""viewport"" content=""width=device-w");
                WriteLiteral("idth\" />\r\n    <title>Калькулятор</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41eeec5abf28e4fbc9ba5f9b94e3c87863f04145820", async() => {
                WriteLiteral("\r\n    <div class=\"center\">\r\n        <h1> Калькулятор с одиннадцатиричной системой счисления</h1>\r\n    </div>\r\n\r\n    <div class=\"calc\">\r\n        <table>\r\n            <tr>\r\n");
#nullable restore
#line 60 "C:\Users\olech\OneDrive\Desktop\Лабораторная работа 3\Laba3\Views\Calculator\Calculator3.cshtml"
                 using (Html.BeginForm("Calculate3", "Calculator"))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td><input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1505, "\"", 1519, 1);
#nullable restore
#line 62 "C:\Users\olech\OneDrive\Desktop\Лабораторная работа 3\Laba3\Views\Calculator\Calculator3.cshtml"
WriteAttributeValue("", 1513, Model, 1513, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"ip\" name=\"InputStr\" style=\"width: 406px;height: 50px;font-size:25pt\"></td>\r\n                    <td><input type=\"submit\" value=\"=\" style=\"width: 100px; height: 53px; font-size:25pt; color:white; background-color:lightblue;\"></td>\r\n");
#nullable restore
#line 64 "C:\Users\olech\OneDrive\Desktop\Лабораторная работа 3\Laba3\Views\Calculator\Calculator3.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n        </table>\r\n\r\n        <table>\r\n            <tr>\r\n                <td><button onclick=\"Clean()\" class=\"but2\">AC</button></td>\r\n                <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 1953, "\"", 1963, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""but2""></button></td>
                <td><button onclick=""Power()"" class=""but2"">^</button></td>
                <td><button onclick=""Division()"" class=""but2"">/</button></td>
            </tr>
            <tr>
                <td><button onclick=""Seven()"" class=""but1"">7</button></td>
                <td><button onclick=""Eight()"" class=""but1"">8</button></td>
                <td><button onclick=""Nine()"" class=""but1"">9</button></td>
                <td><button onclick=""Multiplication()"" class=""but2"">*</button></td>
            </tr>

            <tr>
                <td><button onclick=""Four()"" class=""but1"">4</button></td>
                <td><button onclick=""Five()"" class=""but1"">5</button></td>
                <td><button onclick=""Six()"" class=""but1"">6</button></td>
                <td><button onclick=""Substraction()"" class=""but2"">-</button></td>
            </tr>
            <tr>
                <td><button onclick=""One()"" class=""but1"">1</button></td>
                <td><button oncli");
                WriteLiteral(@"ck=""Two()"" class=""but1"">2</button></td>
                <td><button onclick=""Three()"" class=""but1"">3</button></td>
                <td><button onclick=""Addition()"" class=""but2"">+</button></td>
            </tr>
            <tr>
                <td><button onclick=""A()"" class=""but1"">A</button></td>
                <td><button onclick=""Zero()"" class=""but1"">0</button></td>
                <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 3395, "\"", 3405, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"but1\"></button></td>\r\n                <td>\r\n                    <div>\r\n");
#nullable restore
#line 100 "C:\Users\olech\OneDrive\Desktop\Лабораторная работа 3\Laba3\Views\Calculator\Calculator3.cshtml"
                         using (Html.BeginForm("Main", "Calculator"))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"submit\" value=\"Меню\" style=\"width: 100px; height: 100px; font-size: 25pt; color:white; background-color:gray;\">\r\n");
#nullable restore
#line 103 "C:\Users\olech\OneDrive\Desktop\Лабораторная работа 3\Laba3\Views\Calculator\Calculator3.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </td>
            </tr>
        </table>
    </div>

    <script>
        function One()
        {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + 1;
        }
        function Two()
        {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + 2;
        }
        function Three()
        {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + 3;
        }
        function Four()
        {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + 4;
        }
        function Five()
        {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + 5;
        }
        function Six()
        {
            var Val");
                WriteLiteral(@"ue = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + 6;
        }
        function Seven()
        {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + 7;
        }
        function Eight()
        {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + 8;
        }
        function Nine() {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + 9;
        }
        function Zero()
        {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + 0;
        }
        function Addition() {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + ""+"";
        }
        function Substraction() {
            var Value = docu");
                WriteLiteral(@"ment.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + ""-"";
        }
        function Multiplication() {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + ""*"";
        }
        function Division() {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + ""/"";
        }
        function Power() {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + ""^"";
        }
        function A() {
            var Value = document.getElementById(""ip"").value;
            document.getElementById(""ip"").value = Value + ""A"";
        }
        function Clean()
        {
            document.getElementById(""ip"").value = """";
        }</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
