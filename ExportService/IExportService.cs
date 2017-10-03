using System;
using System.Collections.Generic;
using System.Text;

namespace ExportService
{
    public interface IExportService
    {
        IEnumerable<ExportFormat> GetAllFormats();
        ExportFormat GetFormat(int id);
        void SaveFormat(ExportFormat format);
        //todo: other crud operations

        bool Start(ExportFormat format);
    }
}
