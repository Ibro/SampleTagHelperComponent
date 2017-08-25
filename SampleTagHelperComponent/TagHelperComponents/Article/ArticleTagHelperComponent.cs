using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace SampleTagHelperComponent
{
    public class ArticleTagHelperComponent: TagHelperComponent
    {   
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "article", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml("<script>console.log('article tag');</script>");
            }           

            return Task.CompletedTask;
        }
    }
}
