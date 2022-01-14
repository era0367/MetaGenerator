using Newtonsoft.Json;

namespace Common
{
    public class TypeCode
    {
        public string code { get; set; }
        public string system { get; set; }
        public TypeCode() { }
        public TypeCode(string code, string system)
        {
            this.code = code;
            this.system = system;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}