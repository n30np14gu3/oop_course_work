using System.IO;
using Newtonsoft.Json;

namespace oop_sdk.io
{
    public class Config<T>
    {
        public T Data;
        public readonly string FileName;

        public Config(string fileName)
        {
            FileName = fileName;
            Load();
        }


        public void Load()
        {
            if(!File.Exists(FileName))
                return;

            Data = JsonConvert.DeserializeObject<T>(File.ReadAllText(FileName));
        }
        public void Save()
        {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(Data, Formatting.Indented));
        }
    }
}