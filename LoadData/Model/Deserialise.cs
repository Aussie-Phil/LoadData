using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LoadData.Model
{
    /// <summary>
    /// Deserialises the generic type (if it can)
    /// </summary>
    public static class Deserialise
    {
        public static object XmlDeserialise<Model>(string data) where Model : class
        {
            object result = null;

            try
            {
                var serializer = new XmlSerializer(typeof(Model));

                using (var reader = new StringReader(data))
                {
                    var deserialised = (Model)serializer.Deserialize(reader);
                    result = deserialised;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to deserialise file. " + ex.Message);
            }

            return result;
        }
    }
}
