using Newtonsoft.Json;

namespace Common
{
    public class Author
    {
        public Institution institution { get; set; }
        public Person person { get; set; }

        public Author() { }

        public Author(Institution institution, Person person)
        {
            this.institution = institution;
            this.person = person;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}