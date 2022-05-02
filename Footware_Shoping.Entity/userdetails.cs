using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Footware_Shoping.Entity
{
    class userdetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string User_Name { get; set; }
        public string User_Address { get; set; }
        public string User_Gender { get; set; }
        public string User_Phone { get; set; }
        public string User_Mail { get; set; }
        public string User_Password { get; set; }

    }
}
