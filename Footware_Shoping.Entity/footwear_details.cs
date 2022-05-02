using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Footware_Shoping.Entity
{
    class footwear_details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Product_code { get; set; }
        public string producty_Name { get; set; }
        public int product_cost { get; set; }
        public string kids{ get; set; }
        public string women { get; set; }
        public string men { get; set; }
        
       
        
    }
}
