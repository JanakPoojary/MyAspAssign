using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PromactAsp.Models
{
    public class Message
    {
        [Key]
        public int messageid { get; set; }
        public string message { get; set; }

        public string username { get; set; }
        public int msglikes { get; set; }
        public int iscomment { get; set; }
        public int parentid {get;set;}
        public int isshared { get; set; }
        public int shareid { get; set; }
    }
}
