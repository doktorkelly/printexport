using System;
using System.Collections.Generic;
using System.Text;

namespace ExportService
{
    public class ExportConfig
    {
        public IEnumerable<ExportFormat> FormatList { get; set; }
    }
}
