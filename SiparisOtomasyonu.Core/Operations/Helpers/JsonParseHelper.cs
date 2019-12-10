using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SiparisOtomasyonu.Core.Operations.Helpers
{
    public static class JsonParseHelper<T>
    {
        public static T GetDeserialize(string jsonText)
        {
            T type = JsonConvert.DeserializeObject<T>(jsonText);
            return type;
        }
        public static string GetSerialize(T type)
        {
            string jsonText = JsonConvert.SerializeObject(type);
            return jsonText;
        }

        public static List<T> GetDeserializeList(string jsonText)
        {
            List<T> typeList = JsonConvert.DeserializeObject<List<T>>(jsonText);
            return typeList;
        }

        public static string GetSerializeList(List<T> typeList)
        {
            string jsonText = JsonConvert.SerializeObject(typeList);
            return jsonText;
        }
    }
}
