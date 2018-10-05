using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactList.Models
{
    public class Person
    {
        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
                public string DateOfBirth { get; set; }
        public string HomeAddress { get; set; }
        public string HomeCity { get; set; }
        public string FaceBookAccountId { get; set; }
        public string LinkedInId { get; set; }
        public string TwitterId { get; set; }
        public string EmailId { get; set; }
        public DateTime AdededOn { get; set; }
        public string AddedBy { get; set; }
        public bool UpdateOn { get; set; }

    }
    public class Contact : Person
    {
        public string ContactId { get; set; }
        public int ContactNumber { get; set; }
        public string Type { get; set; }

    }
}