#pragma checksum "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb3f0507edf665fd4fb1e046790609ebc81c5ba4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__IndexArticles), @"mvc.1.0.view", @"/Views/Home/_IndexArticles.cshtml")]
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
#line 1 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\_ViewImports.cshtml"
using Flutterweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\_ViewImports.cshtml"
using Flutterweb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb3f0507edf665fd4fb1e046790609ebc81c5ba4", @"/Views/Home/_IndexArticles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3755c1dc7f5c71c4ba2cb29c44d5ed07aafb81", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__IndexArticles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataSet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    .titletext {\r\n        color: black;\r\n    }\r\n\r\n        .titletext:hover {\r\n            color: darkslateblue;\r\n            text-decoration: none;\r\n        }\r\n</style>\r\n\r\n\r\n<div class=\"row\">\r\n\r\n\r\n");
#nullable restore
#line 19 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
     if (Model.Tables[0].Rows.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-info\">\r\n            <strong>Info!</strong> You have reached to the Bottom of the page.\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"col-sm-8\">\r\n");
#nullable restore
#line 28 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
          

            var k = 0;
            foreach (DataRow row in Model.Tables[0].Rows)
            {
                k++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>\r\n");
#nullable restore
#line 37 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                     if (Convert.ToInt32(row["ID"]) > 1200)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                   Write(Html.ActionLink(Html.Raw(row["Title"]).ToString(), "Post", "Articles", new
                        {
                            id = row["ID"],
                            urlstring =
        System.Text.RegularExpressions.Regex.Replace(System.Text.RegularExpressions.Regex.Replace(row["Title"].ToString().Trim(), @"[?]+", ""), @"[^0-9a-zA-Z]+", "_")
                        }, new { @class = "titletext" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                                                        
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                   Write(Html.ActionLink(Html.Raw(row["Title"]).ToString(), "Post", "Articles", new { id = row["ID"] }, new { @class = "titletext" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                                                                                                                                                     
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <br />\r\n");
#nullable restore
#line 53 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                     if (String.IsNullOrEmpty(row["Description"].ToString()))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                                                                                            
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <small>\r\n                            ");
#nullable restore
#line 60 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                       Write(System.Text.RegularExpressions.Regex.Replace(row["Description"].ToString(), "<[^>]*>", String.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </small>\r\n");
#nullable restore
#line 62 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </h2>\r\n");
            WriteLiteral("                <p class=\"text-muted\" style=\"font-size:12px;\">Posted by ");
#nullable restore
#line 65 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                                                                   Write(row["Owner"].ToString().Substring(0, @row["Owner"].ToString().IndexOf('@')));

#line default
#line hidden
#nullable disable
            WriteLiteral(" on ");
#nullable restore
#line 65 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                                                                                                                                                   Write(row["PostedOn"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 65 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
                                                                                                                                                                    Write(row["Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("                <hr />\r\n");
#nullable restore
#line 68 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <div class=""col-sm-4"">

        <!-- Ezoic - In-Content Ad - mid_content -->
        <div id=""ezoic-pub-ad-placeholder-103"">

            <script async src=""//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js""></script>
            <!-- Fluttercentralads -->
            <ins class=""adsbygoogle""
                 style=""display:block""
                 data-ad-client=""ca-pub-9799612439562237""
                 data-ad-slot=""1773362238""
                 data-ad-format=""auto""
                 data-full-width-responsive=""true""></ins>
            <script>
                (adsbygoogle = window.adsbygoogle || []).push({});
            </script>
        </div>
        <!-- End Ezoic - In-Content Ad - mid_content -->

    </div>

</div>

<div");
            BeginWriteAttribute("class", " class=\"", 3360, "\"", 3395, 2);
            WriteAttributeValue("", 3368, "articleslist_", 3368, 13, true);
#nullable restore
#line 94 "C:\Users\seven\source\repos\Flutterweb\Flutterweb\Views\Home\_IndexArticles.cshtml"
WriteAttributeValue("", 3381, ViewBag.index, 3381, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataSet> Html { get; private set; }
    }
}
#pragma warning restore 1591
