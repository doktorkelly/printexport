using System;
using System.Collections.Generic;
using System.Text;

namespace ExportService
{
    public class ExportLauncher
    {
        public bool Start(ExportFormat exportFormat)
        {
            //TODO
            try {
                IEnumerable<ExportChannel> channels = exportFormat.ChannelList;
                DateTime from = exportFormat.DateFrom;
                DateTime until = exportFormat.DateUntil;
                SplitMode splitMode = exportFormat.SplitMode;
                IEnumerable<Tuple<DateTime, DateTime>> timeRanges = RequestSplitter.Split(splitMode, from, until);
                IEnumerable<string> requests = RequestSplitter.CreateUrls(timeRanges, channels);
                IEnumerable<string> fileNames = Downloader.Download(requests);
                IEnumerable<string> convertedFileNames = FormatConverter.Convert(fileNames);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
    }
}
