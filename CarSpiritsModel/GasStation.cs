using System;
namespace CarSpiritsModel
{
    [Serializable]
    public class gasstation
    {
        public int resultcode { get; set; }
        public string reason { get; set; }
        public result result { get; set; }
        public string error_code { get; set; }

    }
    [Serializable]
    public class result
    {
        public data data { get; set; }
        public pageinfo pageinfo { get; set; }
    }
    [Serializable]
    public  class data
    {
        public int id { get; set; }
        public string name { get; set; }
        public string area { get; set; }
        public string areaname { get; set; }
        public string address { get; set; }
        public string brandname { get; set; }
        public string type { get; set; }
        public string dicount { get; set; }
        public string exhaust { get; set; }
        public string position { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public price price { get; set; }
    }
    [Serializable]
        public class price
        {
        public string E90 { get; set; }
        public string E93 { get; set; }
        public string E97 { get; set; }
        public string E0 { get; set; }

        }
     [Serializable]
    public class gastprice
    {

    }
    [Serializable]
        public class pageinfo
        {
        public int pnums { get; set; }
        public int current { get; set; }
        public int allpage { get; set; }
        }
}
