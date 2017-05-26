using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter
{
    public class GeradorXML
    {
        public string GeraXML(object o)
        {
            var serializer = new XmlSerializer(o.GetType());
            var writer = new StringWriter();
            serializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
