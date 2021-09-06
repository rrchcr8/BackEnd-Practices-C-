using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class HtmlParentElement : HtmlTag
    {
        private string tagName;
        private string startTag;
        private string endTag;
        private string tagBody;
        public List<HtmlTag> childrenTags;


        public HtmlParentElement(string tagName)
        {

            this.tagName = tagName;
            this.childrenTags = new List<HtmlTag>();
        }

        public override void addChildtag(HtmlTag htmlTag)
        {
            this.childrenTags.Add(htmlTag);
        }

        public override void generateHtml()
        {
            Console.WriteLine(startTag+"\n");

            foreach (var tag in childrenTags)
            {
                tag.generateHtml();

            }
            Console.WriteLine(endTag + "\n");

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
            this.endTag = EndTag;
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
