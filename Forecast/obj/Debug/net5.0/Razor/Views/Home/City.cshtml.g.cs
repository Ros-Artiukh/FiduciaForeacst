#pragma checksum "C:\Users\Oleg\Desktop\FiduciaForeacst-master\Forecast\Views\Home\City.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec765d390d987ded5c320d2698c9ca29dabaf755"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_City), @"mvc.1.0.view", @"/Views/Home/City.cshtml")]
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
#line 1 "C:\Users\Oleg\Desktop\FiduciaForeacst-master\Forecast\Views\_ViewImports.cshtml"
using Forecast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oleg\Desktop\FiduciaForeacst-master\Forecast\Views\_ViewImports.cshtml"
using Forecast.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec765d390d987ded5c320d2698c9ca29dabaf755", @"/Views/Home/City.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"546f92e0cabcf502c957be42a440e4e66e56e749", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_City : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Task<SeparatorResponse>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Oleg\Desktop\FiduciaForeacst-master\Forecast\Views\Home\City.cshtml"
  
    ViewData["Title"] = "Weather";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Weather</h1>
    </br>
    <table class=""table"">
        <thead>
            <tr><th>Weather</th><th>Min Temperature</th><th>Max Temperature</th></tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 15 "C:\Users\Oleg\Desktop\FiduciaForeacst-master\Forecast\Views\Home\City.cshtml"
               Write(Model.Result.Weather[0].Main);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 16 "C:\Users\Oleg\Desktop\FiduciaForeacst-master\Forecast\Views\Home\City.cshtml"
               Write(Model.Result.Main.Temp_min);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 17 "C:\Users\Oleg\Desktop\FiduciaForeacst-master\Forecast\Views\Home\City.cshtml"
               Write(Model.Result.Main.Temp_max);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n\n        </tbody>\n    </table>\n</div>\n        <script>\n                localStorage[\"weather\"] = ");
#nullable restore
#line 24 "C:\Users\Oleg\Desktop\FiduciaForeacst-master\Forecast\Views\Home\City.cshtml"
                                     Write(Model.Result.Weather[0].Main);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n        </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task<SeparatorResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591