using System.Collections.Generic;

namespace xmr_stak_sharp
{
    public class Connection
    {
        public List<object> error_log { get; set; }
        public int ping { get; set; }
        public string pool { get; set; }
        public int uptime { get; set; }
    }
}