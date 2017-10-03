using System;
using System.Collections.Generic;
using System.Text;

namespace ExportService
{
    public enum SplitMode { ByChannel, ByDay }

    public class ExportFormat
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateUntil { get; set; }
        public SplitMode SplitMode { get; set; }
        public IEnumerable<ExportChannel> ChannelList { get; set; }

        public ExportFormat(int num, string name, DateTime from, DateTime until, 
            SplitMode mode = SplitMode.ByChannel,
            IEnumerable<ExportChannel> channels = null)
        {
            this.Number = num;
            this.Name = name;
            this.DateFrom = from;
            this.DateUntil = until;
            this.SplitMode = mode;
            this.ChannelList = channels;
        }
    }
}
