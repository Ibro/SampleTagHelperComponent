using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace SampleTagHelperComponent
{
    [HtmlTargetElement("article")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class ArticleTagHelperComponentTagHelper : TagHelperComponentTagHelper
    {
        public ArticleTagHelperComponentTagHelper(ITagHelperComponentManager componentManager, ILoggerFactory loggerFactory)
            : base(componentManager, loggerFactory)
        {
        }
    }
}
