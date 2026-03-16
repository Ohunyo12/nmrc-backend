using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintrakBanking.Entities.Models
{
    [Table("TBL_CUSTOMER_ADDITIONAL_LIABILITY")]
    public class TBL_CUSTOMER_ADDITIONAL_LIABILITY
    {
        public int ID { get; set; }
        public string LIABILITY_TYPE { get; set; }
        public decimal OUTSTANDING { get; set; }
        public decimal MONTHLY_REPAYMENT { get; set; }
        public int CUSTOMERID { get; set; }
    }
}
