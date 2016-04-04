using Microsoft.AspNet.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_TagHelpers.TagHelpers
{
    [HtmlTargetElement(Attributes = nameof(Condicao))]
    public class CondicaoTagHelper : TagHelper
    {
        public bool Condicao { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condicao)
            {
                output.SuppressOutput();
            }
        }
    }
}
