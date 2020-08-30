using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HRprogram
{
    public class FileHelper<T> where T : new()
    {
        private string _filePath;
        public FileHelper(string filepath)
        {
            _filePath = filepath;
        }
        public void SerializeToFile(T employees)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, employees);
                streamWriter.Close();
            }
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new T();

            var serializer = new XmlSerializer(typeof(T));
            using (var streamReader = new StreamReader(_filePath))
            {
                var employees = (T)serializer.Deserialize(streamReader);
                streamReader.Close();
                return employees;
            }
        }
    }
}
