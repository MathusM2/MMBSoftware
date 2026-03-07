using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models.Enums;

namespace MMBSoftware.Models
{
    public interface IFilter
    {
        bool? ExpirationFilter { get; set; }
        bool? SituationFilter { get; set; }
        UnitType? UnitType { get; set; }
    }
}
