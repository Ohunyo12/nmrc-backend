using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintrakBanking.Entities.Models
{
    [Table("TBL_CUSTOMER_ADDITIONAL_INCOME")]
    public class TBL_CUSTOMER_ADDITIONAL_INCOME
    {
        public int ID { get; set; }
        public int CUSTOMERID { get; set; }
        public string SOURCE { get; set; }
        public string EMPLOYER { get; set; }
        public decimal AMOUNT { get; set; }
    }
}
