using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintrakBanking.Entities.Models
{
    [Table("TBL_ORIGINATION_FEE")]
    public class TBL_ORIGINATION_FEE
    {
        public int ID { get; set; }
        public int PRODUCTID { get; set; }
        public decimal PERCENTAGE { get; set; }
    }
}
