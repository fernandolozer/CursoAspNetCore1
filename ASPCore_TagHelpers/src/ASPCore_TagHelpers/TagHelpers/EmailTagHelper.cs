using Microsoft.AspNet.Razor.TagHelpers;

namespace ASPCore_TagHelpers.TagHelpers
{

    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "servidor.com.br";
        public string ParaQuem { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a"; // troca o <email> pela tag <a> 
            var email = $"{ParaQuem}@{EmailDomain}";
            // montando a saida do tagHelper
            output.Attributes["href"] = $"mailto:{email}";
            output.Content.SetContent(email);
        }
    }    
}
