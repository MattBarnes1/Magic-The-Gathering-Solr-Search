#pragma checksum "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf1ab08b8760fecc040d222adf96529b63690ae9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MagicTheGatheringSearchPage.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(MagicTheGatheringSearchPage.Pages.Pages_Index), null)]
namespace MagicTheGatheringSearchPage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\_ViewImports.cshtml"
using MagicTheGatheringSearchPage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf1ab08b8760fecc040d222adf96529b63690ae9", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6e760f707b61aa82deaef5d28a3330ded94c6e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
  
    ViewData["Title"] = "";

#line default
#line hidden
            BeginContext(62, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
 if (Model.myModel != null && Model.myModel.SearchItemError != null)
{

#line default
#line hidden
            BeginContext(139, 35, true);
            WriteLiteral("<p />\r\n<p />\r\n<p />\r\n<p />\r\n<label>");
            EndContext();
            BeginContext(175, 29, false);
#line 14 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
  Write(Model.myModel.SearchItemError);

#line default
#line hidden
            EndContext();
            BeginContext(204, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 15 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"

}

#line default
#line hidden
            BeginContext(219, 24, true);
            WriteLiteral("<div id=\"typeahead\">\r\n\r\n");
            EndContext();
#line 19 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
 if (Model.myModel != null)
{
    

#line default
#line hidden
#line 21 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
     foreach (var CardInfo in Model.myModel.CardInfoList)
    {

#line default
#line hidden
            BeginContext(341, 176, true);
            WriteLiteral("    <div class=\"card mx-auto\" style=\"width: 100rem;\">\r\n        <img class=\"card-img-top\" src=\"...\" alt=\"\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(518, 16, false);
#line 26 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                              Write(CardInfo.name[0]);

#line default
#line hidden
            EndContext();
            BeginContext(534, 42, true);
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">\r\n");
            EndContext();
#line 28 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                 if(CardInfo.colorIdentity != null && CardInfo.colorIdentity.Count > 0)
                {

#line default
#line hidden
            BeginContext(684, 48, true);
            WriteLiteral("                <label>Color Identity:</label>  ");
            EndContext();
            BeginContext(733, 25, false);
#line 30 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                                           Write(CardInfo.colorIdentity[0]);

#line default
#line hidden
            EndContext();
#line 30 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                                                                          
                }

#line default
#line hidden
            BeginContext(779, 19, true);
            WriteLiteral("            <p />\r\n");
            EndContext();
#line 33 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
             if(CardInfo.colors != null && CardInfo.colors.Count > 0)
                {

#line default
#line hidden
            BeginContext(888, 34, true);
            WriteLiteral("            <label>Colors:</label>");
            EndContext();
            BeginContext(923, 18, false);
#line 35 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                             Write(CardInfo.colors[0]);

#line default
#line hidden
            EndContext();
            BeginContext(941, 7, true);
            WriteLiteral("<p />\r\n");
            EndContext();
#line 36 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(967, 47, true);
            WriteLiteral("            <label>Converted Mana Cost:</label>");
            EndContext();
            BeginContext(1015, 29, false);
#line 37 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                                          Write(CardInfo.convertedManaCost[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1044, 41, true);
            WriteLiteral("<p />\r\n            <label>Layout:</label>");
            EndContext();
            BeginContext(1086, 18, false);
#line 38 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                             Write(CardInfo.layout[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1104, 7, true);
            WriteLiteral("<p />\r\n");
            EndContext();
#line 39 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
             if(CardInfo.manacost != null && CardInfo.manacost.Count > 0)
            {

#line default
#line hidden
            BeginContext(1201, 37, true);
            WriteLiteral("            <label>Mana Cost:</label>");
            EndContext();
            BeginContext(1239, 20, false);
#line 41 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                                Write(CardInfo.manacost[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1259, 7, true);
            WriteLiteral("<p />\r\n");
            EndContext();
#line 42 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1281, 39, true);
            WriteLiteral("            <label>Printings:</label>\r\n");
            EndContext();
#line 44 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
             foreach(String A in @CardInfo.printings)
                {
            

#line default
#line hidden
            BeginContext(1407, 1, false);
#line 46 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
       Write(A);

#line default
#line hidden
            EndContext();
#line 46 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
              
                }

#line default
#line hidden
            BeginContext(1429, 56, true);
            WriteLiteral("            <p />\r\n            <label>Oracle ID:</label>");
            EndContext();
            BeginContext(1486, 28, false);
#line 49 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                                Write(CardInfo.scryfallOracleId[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1514, 48, true);
            WriteLiteral("<p />\r\n            <label>Description:</label>  ");
            EndContext();
            BeginContext(1563, 16, false);
#line 50 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                                    Write(CardInfo.text[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1579, 41, true);
            WriteLiteral("<p />\r\n            <label>Type:</label>  ");
            EndContext();
            BeginContext(1621, 16, false);
#line 51 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                             Write(CardInfo.type[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1637, 42, true);
            WriteLiteral("<p />\r\n            <label>Types:</label>  ");
            EndContext();
            BeginContext(1680, 17, false);
#line 52 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                              Write(CardInfo.types[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1697, 46, true);
            WriteLiteral("<p />\r\n            <label>Unique ID:</label>  ");
            EndContext();
            BeginContext(1744, 16, false);
#line 53 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                                  Write(CardInfo.uuid[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1760, 39, true);
            WriteLiteral("<p />\r\n            <label>ID:</label>  ");
            EndContext();
            BeginContext(1800, 11, false);
#line 54 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                           Write(CardInfo.id);

#line default
#line hidden
            EndContext();
            BeginContext(1811, 7, true);
            WriteLiteral("<p />\r\n");
            EndContext();
#line 55 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
             if(CardInfo.version != null)
            {

#line default
#line hidden
            BeginContext(1876, 37, true);
            WriteLiteral("            <label>Version:</label>  ");
            EndContext();
            BeginContext(1914, 16, false);
#line 57 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
                                Write(CardInfo.version);

#line default
#line hidden
            EndContext();
            BeginContext(1930, 7, true);
            WriteLiteral("<p />\r\n");
            EndContext();
#line 58 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1952, 70, true);
            WriteLiteral("\r\n\r\n            </p>\r\n            <hr />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 65 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"

    }

#line default
#line hidden
#line 66 "D:\MagicAssignment\MagicTheGatheringSearchPage\Pages\Index.cshtml"
     
}

#line default
#line hidden
            BeginContext(2034, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591