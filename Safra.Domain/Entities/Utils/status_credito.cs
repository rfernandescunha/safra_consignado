using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Domain.Entities
{
    public class status_credito
    {
        public string status { get; set; }
        public string vl_total_com_juros { get; set; }
        public string vl_juros { get; set; }
    }
}
