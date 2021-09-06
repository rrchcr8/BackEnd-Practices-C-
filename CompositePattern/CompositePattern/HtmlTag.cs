using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    abstract class HtmlTag
    {
        public abstract string getTagName();
        public abstract void setStartTag(string StartTag);
        public abstract void setEndTag(string EndTag);
        public abstract void generateHtml();
        public abstract List<HtmlTag> getChildren();
        public abstract void removeChildtag(HtmlTag htmlTag);
        public abstract void addChildtag(HtmlTag htmlTag);
        public abstract void setTagBody(string body);
    }
}
