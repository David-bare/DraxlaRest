using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DraxlaRest.Models
{
    public class StaffDetails
    {
        public string role { get; set; }
        public string branch { get; set; }
        public string staff_name { get; set; }
        public string fullname { get; set; }
        public int usertype { get; set; }
        public int response_code { get; set; }
        public string response_description { get; set; }

        //globus
        //public object businessPhones { get; set; }
        //public string displayName { get; set; }
        //public string givenName { get; set; }
        //public string jobTitle { get; set; }
        //public string mail { get; set; }
        //public object mobilePhone { get; set; }
        //public object officeLocation { get; set; }
        //public object preferredLanguage { get; set; }
        //public string surname { get; set; }
        //public string userPrincipalName { get; set; }
        //public object id { get; set; }
        //public string employeeId { get; set; }
        //public object department { get; set; }
        //public string message { get; set; }
        //public bool success { get; set; }
    }
}