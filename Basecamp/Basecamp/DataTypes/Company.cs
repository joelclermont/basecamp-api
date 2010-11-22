using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string WebAddress { get; set; }
        public string PhoneNumberOffice { get; set; }
        public string PhoneNumberFax { get; set; }
        public string TimeZoneID { get; set; }
        public bool CanSeePrivate { get; set; }
        public string URLName { get; set; }
    }
}
