using Newtonsoft.Json;
using static Common.Enums;

namespace Common
{
    public class Person
    {
        public string identifier { get; set; }
        public string name { get; set; }

        public TYPE_CODE type { get; set; }

        public Person() { }
        public Person(string identifier, string name, Enums.TYPE_CODE type)
        {
            this.identifier = identifier;
            this.name = name;
            this.type = type;
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}