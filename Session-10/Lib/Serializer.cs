using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lib
{
   public class Serializer
    {
        public void Serialize(object obj)
        {
            string jsonString = JsonSerializer.Serialize(obj);
        }


        public void SerializeToFile(object obj, string fileName)
        {

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(obj, options);

            File.WriteAllText(fileName, jsonString);
        }


        public List<T> Deserialize <T>(string fileName)
        {

            string jsonString = File.ReadAllText(fileName);
            List<T>? obj = JsonSerializer.Deserialize<List<T>>(jsonString);

            return obj;
        }


    }
}
