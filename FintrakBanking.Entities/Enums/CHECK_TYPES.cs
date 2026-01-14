using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintrakBanking.Entities.Enums
{
    public enum CHECK_TYPES
    {
        AUTO,
        MANUAL,
        HYBRID
    }

    public enum Options
    {
        Met = 1,
        NotMet,
        Waived,
        Defer
    }
}
