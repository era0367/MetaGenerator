using Newtonsoft.Json;

namespace Common
{
    public class Institution
    {
        public string identifier { get; set; }
        public string name { get; set; }

        public Institution() { }
        public Institution(string identifier, string name)
        {
            this.identifier = identifier;
            this.name = name;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
