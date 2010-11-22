using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string EmailAddress { get; set; }
        public string IMHandle { get; set; }
        public string IMService { get; set; }
        public string PhoneNumberOffice { get; set; }
        public string PhoneNumberOfficeExt { get; set; }
        public string PhoneNumberMobile { get; set; }
        public string PhoneNumberHome { get; set; }
        public string PhoneNumberFax { get; set; }
        public DateTime LastLogin { get; set; }
        public int CompanyID { get; set; }
        public int ClientID { get; set; }
        public string AvatarURL { get; set; }
        public string UserName { get; set; }
        public bool Administrator { get; set; }
        public bool Deleted { get; set; }
        public bool HasAccesToNewProjects { get; set; }
    }
}
