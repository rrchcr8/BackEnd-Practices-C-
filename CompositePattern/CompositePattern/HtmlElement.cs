using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class HtmlElement : HtmlTag
    {
        public override void addChildtag(HtmlTag htmlTag)
        {
            throw new NotImplementedException();
        }

        public override void generateHtml()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public override void setStartTag(string StartTag)
        {
            throw new NotImplementedException();
        }

        public override void setTagBody(string body)
        {
            throw new NotImplementedException();
        }
    }
}
