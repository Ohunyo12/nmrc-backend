using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintrakBanking.Entities.Models
{
    [Table("TBL_REFINANCE_PERIOD")]
    public class TBL_REFINANCE_PERIOD
    {
        public int ID { get; set; }
        public int DURATION { get; set; }
        public int PRODUCTID { get; set; }
    }
}
