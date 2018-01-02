using System.Collections.Generic;

namespace xmr_stak_sharp
{
    public class Results
    {
        public double avg_time { get; set; }
        public List<object> best { get; set; }
        public int diff_current { get; set; }
        public List<object> error_log { get; set; }
        public int hashes_total { get; set; }
        public int shares_good { get; set; }
        public int shares_total { get; set; }
    }
}