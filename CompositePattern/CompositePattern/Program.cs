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

        }
    }
}
