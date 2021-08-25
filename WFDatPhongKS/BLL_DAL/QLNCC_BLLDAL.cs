using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QLNCC_BLLDAL
    {
        QLDPKSDataContext data = new QLDPKSDataContext();

        public List<NCC> lstncc()
        {
            return data.NCCs.ToList();
        }

        public bool themncc(string mancc, string tencc)
        {
            try
            {
                NCC nc = new NCC();
                nc.MANCC = mancc;
                nc.TENNCC = tencc;
                data.NCCs.InsertOnSubmit(nc);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suacc(string mancc, string tenncc)
        {
            try
            {
                NCC nc = data.NCCs.Where(n => n.MANCC == mancc).FirstOrDefault();
                nc.TENNCC = tenncc;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoancc(string mancc)
        {
            try
            {
                NCC nc = data.NCCs.Where(n => n.MANCC == mancc).SingleOrDefault();
                data.NCCs.DeleteOnSubmit(nc);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
