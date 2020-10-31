using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication3.TagHelpers
{
    public class TimerTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetContent($"{DateTime.Now.ToString("HH:mm:ss")}");
        }
    }
}