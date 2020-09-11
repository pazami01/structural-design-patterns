using System;

namespace Composite
{
    public class HtmlElement: HtmlTag
    {
        public HtmlElement(string s)
        {
            base.StartTag = s;
        }

        public override void GenerateHtml()
        {
            Console.WriteLine($"{base.StartTag}{base.TagBody}{base.EndTag}");
        }
    }
}