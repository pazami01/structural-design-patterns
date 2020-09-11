using System;
using System.Collections.Generic;

namespace Composite
{
    public class HtmlParentElement: HtmlTag
    {
        private List<HtmlTag> children = new List<HtmlTag>();

        public HtmlParentElement(string s)
        {
            base.StartTag = s;
        }

        public override void AddChildTag(HtmlTag htmlTag)
        {
            children.Add(htmlTag);
        }

        public override void RemoveChildTag(HtmlTag htmlTag)
        {
            children.Remove(htmlTag);
        }

        public override void GenerateHtml()
        {
            Console.WriteLine(base.StartTag);

            // I was assuming that a parent element could also hold a string in its body. 
            Console.WriteLine(base.TagBody);

            foreach (HtmlTag htmlTag in children)
            {
                htmlTag.GenerateHtml();
            }

            Console.WriteLine(base.EndTag);
        }
    }
}