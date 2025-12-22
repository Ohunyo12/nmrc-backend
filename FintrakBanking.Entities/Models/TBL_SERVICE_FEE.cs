using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintrakBanking.Entities.Models
{
    [Table ("TBL_SERVICE_FEE")]
    public class TBL_SERVICE_FEE
    {
        public int ID { get; set; }
        public int PRODUCTID { get; set; }
        public int PERCENTAGE { get; set; }
    }
}
