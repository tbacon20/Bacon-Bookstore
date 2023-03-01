using BaconBookstore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaconBookstore.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-turner")]
    public class PaginationTagHelper : TagHelper
    {
        // Dynamically build page links

        private IUrlHelperFactory uhf;

        public PaginationTagHelper (IUrlHelperFactory uhf_temp)
        {
            uhf = uhf_temp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }

        // Different than the view context
        public PageInfo PageTurner { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext thc, TagHelperOutput tho)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);

            TagBuilder finalResult = new TagBuilder("div");
        
            for (int i = 1; i <= PageTurner.TotalPages; i++)
            {
                TagBuilder tb = new TagBuilder("a");
                tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });
                tb.InnerHtml.Append(i.ToString());

                finalResult.InnerHtml.AppendHtml(tb);
            }

            tho.Content.AppendHtml(finalResult.InnerHtml);
        }
    }
}
