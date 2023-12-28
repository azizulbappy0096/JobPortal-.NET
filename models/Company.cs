using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.models
{
    internal class Company
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string established { get; set; }
        public string teamSize { get; set; }
        public string bio { get; set; }

        public Company()
        {

        }
        public Company(string id, string name, string phone, string website, string established, string teamSize, string bio)
        {
            Id = id;
            this.name = name;
            this.phone = phone;
            this.website = website;
            this.established = established;
            this.teamSize = teamSize;
            this.bio = bio;
        }
    }
}
