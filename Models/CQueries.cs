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
}