using System;
using System.Collections.Generic;
using System.Text;

namespace ExportService
{
    public class ExportService : IExportService
    {
        private IExportFormatRepository FormatRepos { get; set; }
        private ExportLauncher Launcher { get; set; }

        public ExportService(IExportFormatRepository formatRepos, ExportLauncher launcher)
        {
            this.FormatRepos = formatRepos;
            this.Launcher = launcher;
        }

        public IEnumerable<ExportFormat> GetAllFormats()
        {
            IEnumerable<ExportFormat> expFormats = FormatRepos.GetAllFormats();
            return expFormats;
        }

        public ExportFormat GetFormat(int id)
        {
            ExportFormat expFormat = FormatRepos.GetFormat(id);
            return expFormat;
        }

        public void SaveFormat(ExportFormat format)
        {
            FormatRepos.Save(format);
        }

        public bool Start(ExportFormat format)
        {
            bool result = Launcher.Start(format);
            return result;
        }
    }
}
