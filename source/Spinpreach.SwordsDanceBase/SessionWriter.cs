using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization.Json;

namespace Spinpreach.SwordsDanceBase
{
    public static class SessionWriter
    {
        #region JsonWriter

        public static void JsonWriter(string filename, string json)
        {
            try
            {
                string path = string.Format(@"{0}\{1}", Directory.GetCurrentDirectory(), "JSON");
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
                StreamWriter sw = new StreamWriter(string.Format(@"{0}\{1}.txt", path, filename), false, Encoding.GetEncoding("UTF-8"));
                sw.Write(json);
                sw.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }

        #endregion

        #region XmlWriter

        public static void XmlWriter(string filename, string json)
        {
            try
            {
                string path = string.Format(@"{0}\{1}", Directory.GetCurrentDirectory(), "XML");
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
                byte[] bytes = Encoding.UTF8.GetBytes(json);
                using (XmlDictionaryReader reader = JsonReaderWriterFactory.CreateJsonReader(bytes, new XmlDictionaryReaderQuotas()))
                {
                    XDocument doc = XDocument.Load(reader);
                    doc.Save(string.Format(@"{0}\{1}.xml", path, filename));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}
