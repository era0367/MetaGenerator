using Newtonsoft.Json;

namespace Common
{
    public class Target
    {
        public bool no { get; set; }
        public bool all { get; set; }
        public bool family { get; set; }
        public bool medicalInstitution { get; set; }
        public bool publicInstitution { get; set; }
        public bool researchInstitution { get; set; }
        public bool insuranceCompany { get; set; }
        public bool privateCompany { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}