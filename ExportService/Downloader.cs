using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportService
{
    public class Downloader
    {
        public static IEnumerable<string> Download(IEnumerable<string> requests)
        {
            //TODO
            IEnumerable<string> files = requests
                .Select(req => "fileFor_" + req + ".txt")
                .ToList();
            return files;
        }
    }
}
