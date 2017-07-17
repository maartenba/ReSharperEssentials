using System;

namespace ResharperEssentials.CodingAssistance
{
    public class DonePerson
    {
        private int age;
        public string Name { get; set; }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public DonePerson(string name, int age)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            Name = name;
            Age = age;
        }
    }
}