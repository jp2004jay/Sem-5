using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AdminThemeBC
{
    public class CustomeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "https:google.com");
            output.Content.SetContent("Go to google");
        }
    }
}
