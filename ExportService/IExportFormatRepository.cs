using System;
using System.Collections.Generic;
using System.Text;

namespace ExportService
{
    public interface IExportFormatRepository
    {
        IEnumerable<ExportFormat> GetAllFormats();
        ExportFormat GetFormat(int id);
        void Save(ExportFormat expFormat);
        void Update(string id, ExportFormat expFormat);
        void Delete(string id);
    }
}
