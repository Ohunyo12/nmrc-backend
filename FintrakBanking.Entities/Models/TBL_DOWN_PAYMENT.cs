using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FintrakBanking.Entities.Enums;

namespace FintrakBanking.Entities.Models
{
    [Table("TBL_DOWN_PAYMENT")]
    public class TBL_DOWN_PAYMENT
    {
        public int ID { get; set; }
        public decimal MAXAMOUNT { get; set; }
        public decimal MINAMOUNT { get; set; }
        public EMPLOYMENTTYPE EMPLOYMENTTYPEID { get; set; }
        public int PRODUCTID { get; set; }
        public decimal PERCENTAGE { get; set; }

    }
}
