using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintrakBanking.Entities.Models
{
    public class TblCustomerUUSReview
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeNhfNumber { get; set; }
        public int ItemId { get; set; }
        public int SystemOption { get; set; }
        public int OfficerOption { get; set; }
        public string OfficerComment { get; set; }
        public int ReviewedBy { get; set; }
        public DateTime ReviewedAt { get; set; }

    }
}
