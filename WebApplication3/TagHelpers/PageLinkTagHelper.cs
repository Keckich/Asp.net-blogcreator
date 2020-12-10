using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.TagHelpers
{
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory _urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            _urlHelperFactory = urlHelperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "div";

            TagBuilder tag = new TagBuilder("ul");
            tag.AddCssClass("pagination");

            TagBuilder currentItem = CreateTag(urlHelper, PageViewModel.PageNumber);
            if (PageViewModel.HasPreviousPage && PageViewModel.PageNumber > 3)
            {
                TagBuilder firstItem = CreateTag(urlHelper, 1);
                TagBuilder dots = CreateTag(urlHelper, 0, "...");
                tag.InnerHtml.AppendHtml(firstItem);
                tag.InnerHtml.AppendHtml(dots);
            }
            if (PageViewModel.HasPreviousPage)
            {
                TagBuilder prevItem = CreateTag(urlHelper, PageViewModel.PageNumber - 1);
                tag.InnerHtml.AppendHtml(prevItem);
            }
            tag.InnerHtml.AppendHtml(currentItem);
            if (PageViewModel.HasNextPage)
            {
                TagBuilder nextItem = CreateTag(urlHelper, PageViewModel.PageNumber + 1);
                tag.InnerHtml.AppendHtml(nextItem);
            }
            if (PageViewModel.HasNextPage && PageViewModel.getTotal - PageViewModel.PageNumber > 2)
            {
                TagBuilder lastItem = CreateTag(urlHelper, PageViewModel.getTotal);
                TagBuilder dots = CreateTag(urlHelper, 0, "...");
                tag.InnerHtml.AppendHtml(dots);
                tag.InnerHtml.AppendHtml(lastItem);
            }
            output.Content.AppendHtml(tag);
        }

        TagBuilder CreateTag(IUrlHelper urlHelper, int pageNumber, string str="")
        {
            TagBuilder item = new TagBuilder("li");            
            TagBuilder link = new TagBuilder("a");
            TagBuilder dots = new TagBuilder("text");
            if (pageNumber == this.PageViewModel.PageNumber)
            {
                item.AddCssClass("active");
            }
            else 
            {                
                link.Attributes["href"] = urlHelper.Action(PageAction, new { page = pageNumber });
            }
            item.AddCssClass("page-item");
            item.AddCssClass("page-link");           
            
            if (str != "")
            {                         
                dots.InnerHtml.Append(str);
                item.InnerHtml.AppendHtml(dots);
            }
            else
            {
                link.InnerHtml.Append(pageNumber.ToString());
                item.InnerHtml.AppendHtml(link);
            }
            //item.InnerHtml.AppendHtml(link);


            return item;
        }
    }
}
