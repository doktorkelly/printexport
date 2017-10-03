using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportService
{
    public class ExportFormatReposInMemory : IExportFormatRepository
    {
        private static readonly IEnumerable<ExportFormat> ExportFormatList = new List<ExportFormat>() {
            new ExportFormat(1, "export01", new DateTime(2017,10,01), new DateTime(2017,10,07)),
            new ExportFormat(2, "export02", new DateTime(2017,10,01), new DateTime(2017,10,07)),
            new ExportFormat(3, "export03", new DateTime(2017,10,01), new DateTime(2017,10,07)),
            new ExportFormat(4, "export04", new DateTime(2017,10,01), new DateTime(2017,10,07))
        };

        public IEnumerable<ExportFormat> GetAllFormats()
        {
            return ExportFormatList;
        }

        public ExportFormat GetFormat(int id)
        {
            return ExportFormatList.FirstOrDefault(exp => exp.Number == id);
        }

        public void Save(ExportFormat expFormat)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, ExportFormat expFormat)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
