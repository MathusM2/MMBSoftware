using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models.Enums;

namespace MMBSoftware.Models
{
    public class Filter : IFilter
    {
        public bool? ExpirationFilter { get; set; }
        public bool? SituationFilter { get; set; }
        public UnitType? UnitType { get; set; }

        public Filter(bool? expFilter, bool? statusFilter, UnitType? uTypeFilter)
        {
            ExpirationFilter = expFilter;
            SituationFilter = statusFilter;
            UnitType = uTypeFilter;
        }
    }
}
