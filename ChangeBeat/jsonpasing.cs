using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Net;

namespace ChangeBpm
{
    class jsonpasing
    {
        public static void Main(string[] args)
        {
            changeToBpm c = new changeToBpm();
            c.Zxcv();
            Console.Read();
            //Console.WriteLine("나는  빡 빡이 다~~!");
            //Console.Read();

            //void cry() { }

            //bool _ = false;
            //for ( ;_;)
            //    cry();
        }

        public static qwer[][] parseNotes(Asdf asdf)
            => (from note in asdf.Notes
                select (from c in note.Replace(" ", "")
                        select (qwer)"0123<>".IndexOf(c)).ToArray()).ToArray();

        // => asdf.Notes
        //     .Select(s => s.Replace(" ", ""))
        //     .Select(s => s.Select(c => (qwer)"0123<>".IndexOf(c)).ToArray()).ToArray();

        public static Asdf LoadJson(string file)
        {
            using (StreamReader j = new StreamReader(file, Encoding.UTF8))
            {
                using (var jr = new JsonTextReader(j))
                {
                    var serializer = new JsonSerializer();
                    return serializer.Deserialize<Asdf>(jr);
                }
            }
        }
    }

    public readonly struct Asdf //이름 나중에 바꿔야 되는 데 결정하면 바꾸는 걸로 ^!^
    {
        [JsonProperty(PropertyName = "title")]
        public readonly string Title;
        [JsonProperty(PropertyName = "bpm")]
        public readonly int Bpm;
        [JsonProperty(PropertyName = "notes")]
        public readonly string[] Notes;
    }
}
