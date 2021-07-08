using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webks.Models
{
    public class TienIchModel
    {
        public int IDTIENICH { get; set; }
        public string TENTIENICH { get; set; }
        public string ICON { get; set; }
        public string MAKHACHSAN { get; set; }
        public string GHICHU { get; set; }

        public float DIEM { get; set; }
    }
}