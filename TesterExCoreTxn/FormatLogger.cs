using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterExCoreTxn
{
    public class FormatLogger
    {
        [Index(0)]
        public string Timestamp { get; set; }
        [Index(1)]
        public string Message { get; set; }
        [Index(2)]
        public string Status { get; set; }
    }
}
