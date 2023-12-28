using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.models
{
    internal class Job
    {
        public string Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string specialisms { get; set; }
        public string type { get; set; }
        public string salary { get;     set; }
        public string experience { get; set; }
        public string qualification { get; set; }
        public string gender { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string deadline { get; set; }

        public Job() { }

        public Job(string id, string title, string description, string specialisms, string type, string salary, string experience, string qualification, string gender, string country, string city, string address, string deadline)
        {
            Id = id;
            this.title = title;
            this.description = description;
            this.specialisms = specialisms;
            this.type = type;
            this.salary = salary;
            this.experience = experience;
            this.qualification = qualification;
            this.gender = gender;
            this.country = country;
            this.city = city;
            this.address = address;
            this.deadline = deadline;
        }
    }
}
