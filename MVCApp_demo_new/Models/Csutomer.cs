using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp_demo_new.Models
{
    public class Customer
    {
        public int CustId;
        [Required(ErrorMessage ="Name Field is Reuired")]
        public string CustFName { get; set; }
        public string CustLName { get; set; }
        [DataType(DataType.Date)]
        public DateTime CustBday { get; set; }

        public string CustGender { get;set; }
        public string CustEmail { get; set; }  
        [Required(ErrorMessage ="Phone Number 10 digit")]
        [Range(0,10)]
        public int CustPhno { get; set; }
        public state sname { get;set; }

        

       


    }
    public enum state
    {
        Delhi,
        Chennai
    }
    

}