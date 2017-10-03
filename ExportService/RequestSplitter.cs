using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportService
{
    public class RequestSplitter
    {
        public static IEnumerable<Tuple<DateTime,DateTime>> Split(SplitMode mode, DateTime from, DateTime until)
        {
            //TODO
            // a) by channel
            Tuple<DateTime,DateTime> timeRange = Tuple.Create(from, until);
            return new List<Tuple<DateTime, DateTime>>() { timeRange };
        }

        internal static IEnumerable<string> CreateUrls(
            IEnumerable<Tuple<DateTime, DateTime>> timeRanges, 
            IEnumerable<ExportChannel> channels)
        {
            //TODO
            IEnumerable<string> urls = channels
                .SelectMany(chan => CreateUrls(chan, timeRanges))
                .ToList();
            return urls;
        }

        private static IEnumerable<string> CreateUrls(ExportChannel chan, IEnumerable<Tuple<DateTime, DateTime>> timeRanges)
        {
            //TODO
            IEnumerable<string> urls = timeRanges
                .Select(range => CreateUrl(chan, range))
                .ToList();
            return urls;
        }

        private static string CreateUrl(ExportChannel chan, Tuple<DateTime, DateTime> range)
        {
            string baseUrl = "http://exportservice.world.com";
            string url = baseUrl + "?channel=" + chan + "&from=" + range.Item1 + "&until=" + range.Item2;
            return url;
        }
    }
}
