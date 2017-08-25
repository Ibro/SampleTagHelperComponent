using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace SampleTagHelperComponent
{
    public class HeadTagHelperComponent: TagHelperComponent
    {   
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "head", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml("<script>console.log('head tag');</script>");
            }
           
            return Task.CompletedTask;
        }
    }
}
