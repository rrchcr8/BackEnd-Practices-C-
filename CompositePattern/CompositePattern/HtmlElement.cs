using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class HtmlElement : HtmlTag
    {
        private string tagName;
        private string startTag;
        private string endTag;
        private string tagBody;


        public HtmlElement(string tagName) {
            this.tagName = tagName;
        }

        public override void addChildtag(HtmlTag htmlTag)
        {
            throw new NotImplementedException();
        }

        public override void generateHtml()
        {
            Console.WriteLine(startTag +"\n"+tagBody+ "\n"+endTag);
        }

        public override List<HtmlTag> getChildren()
        {
            throw new NotImplementedException();
        }

        public override string getTagName()
        {
            throw new NotImplementedException();
        }

        public override void removeChildtag(HtmlTag htmlTag)
        {
            throw new NotImplementedException();
        }

        public override void setEndTag(string EndTag)
        {
            this.endTag=EndTag;
        }

        public override void setStartTag(string StartTag)
        {
            this.startTag = StartTag;
        }

        public override void setTagBody(string body)
        {
            this.tagBody = body;
        }
    }
}
