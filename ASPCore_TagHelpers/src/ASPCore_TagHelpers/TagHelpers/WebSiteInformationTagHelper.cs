using ASPCore_TagHelpers.Models;
using ASPCore_TagHelpers.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_TagHelpers.TagHelpers
{
    public class WebSiteInformationTagHelper : TagHelper
    {

        public WebSiteInfo Info { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            output.Content.AppendHtml(
            //output.Content.SetHtmlContent(
            $@"<ul><li><strong>Versao:</strong> {Info.Version}</li>
            <li><strong>Copyright:</strong> {Info.CopyrightAno}</li>
            <li><strong>Aprovado:</strong> {(Info.Aprovado? "Sim" : "Nao")}</li>
            <li><strong>Numero de tags:</strong> {Info.NumeroTags}</li></ul>");

            output.TagMode = TagMode.StartTagAndEndTag;

        }
    }
}
