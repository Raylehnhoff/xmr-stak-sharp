namespace xmr_stak_sharp
{
    public class XmrStakRoot
    {
        public Connection connection { get; set; }
        public Hashrate hashrate { get; set; }
        public Results results { get; set; }
        public string version { get; set; }
    }
}