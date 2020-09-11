﻿using System;

namespace Composite
{
    public static class TestCompositePattern
    {
        public static void Main(string[] args)
        {
            HtmlTag parentTag = new HtmlParentElement("<html>");
            parentTag.StartTag = "<html>";
            parentTag.EndTag = "</html>";

            HtmlTag p1 = new HtmlParentElement("<body>");
            p1.StartTag = "<body>";
            p1.EndTag = "</body>";
            parentTag.AddChildTag(p1);

            HtmlTag child1 = new HtmlElement("<P>");
            child1.StartTag = "<P>";
            child1.EndTag = "</P>";
            child1.TagBody = "Testing html tag library";
            p1.AddChildTag(child1);

            child1 = new HtmlElement("<P>");
            child1.StartTag = "<P>";
            child1.EndTag = "</P>";
            child1.TagBody = "Paragraph 2";

            p1.AddChildTag(child1);
            parentTag.GenerateHtml();
        }
    }
}