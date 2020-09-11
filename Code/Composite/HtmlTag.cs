using System.Collections.Generic;

namespace Composite
{
    public abstract class HtmlTag
    {
        public string StartTag { get; set; }
        public string EndTag { get; set; }
        public string TagBody { get; set; }

        // Allows the client to be oblivious of the composite class (HtmlParentElement)
        public virtual void AddChildTag(HtmlTag htmlTag) { }

        // Allows the client to be oblivious of the composite class (HtmlParentElement)
        public virtual void RemoveChildTag(HtmlTag htmlTag) { }

        public abstract void GenerateHtml();
    }
}