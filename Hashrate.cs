using System.Collections.Generic;

namespace xmr_stak_sharp
{
    public class Hashrate
    {
        public List<List<double>> threads { get; set; }
        public List<double> total { get; set; }
        public double highest { get; set; }
    }
}
