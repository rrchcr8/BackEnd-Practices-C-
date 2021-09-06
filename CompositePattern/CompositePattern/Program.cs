using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlTag parentTag = new HtmlParentElement("<html>");
            parentTag.setStartTag("<html>");
            parentTag.setEndTag("</html>");
            HtmlTag p1 = new HtmlParentElement("<body>");
            p1.setStartTag("<body>");
            p1.setEndTag("</body>");
            parentTag.addChildtag(p1);
            HtmlTag child1 = new HtmlElement("<p>");
            child1.setStartTag("<p>");
            child1.setEndTag("</p>");
            child1.setTagBody("testing html tag library");
            p1.addChildtag(child1);
            HtmlTag child2 = new HtmlElement("<p>");
            child2.setStartTag("<p>");
            child2.setEndTag("</p>");
            child2.setTagBody("Paragraph 2");
            p1.addChildtag(child2);
            parentTag.generateHtml();

        }
    }
}
