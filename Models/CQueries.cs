using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAL.Portal.v4.Models
{
    public class CQueries
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONENO { get; set; }
        public string COMPANYNAME { get; set; }
        public string QSUBJECT { get; set; }
        public string QMESSAGE { get; set; }
        public DateTime CREATEDAT { get; set; }
    }
    public class CustQuery
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string CompanyName { get; set; }
        public string QSubject { get; set; }
        public string QMessage { get; set; }
    }
}