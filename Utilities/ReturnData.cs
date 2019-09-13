using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thyme.Utilities
{
    public class ReturnData
    {
        public String SQLText { set; get; }
        public DataTable QueryResult { set; get; }
    }
}
