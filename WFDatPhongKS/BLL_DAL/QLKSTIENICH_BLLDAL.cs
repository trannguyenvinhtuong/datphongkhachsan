using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QLKSTIENICH_BLLDAL
    {
        QLDPKSDataContext data = new QLDPKSDataContext();
        
        public List<KSTIENICH> lstksti()
        {
            return data.KSTIENICHes.ToList();
        }

        public bool themtienich(string maks, int matienich, string ghichu)
        {
            try
            {
                KSTIENICH ti = new KSTIENICH();
                ti.MAKHACHSAN = maks;
                ti.IDTIENICH = (int)matienich;
                ti.GHICHU = ghichu;
                data.KSTIENICHes.InsertOnSubmit(ti);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool suatienich(string maks, int matienich, string ghichu)
        {
            try
            {
                KSTIENICH ksti = data.KSTIENICHes.Where(n => n.MAKHACHSAN == maks).FirstOrDefault();
                ksti.IDTIENICH = (int)matienich;
                ksti.GHICHU = ghichu;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoatienich(string maks, int idtt)
        {
            try
            {
                KSTIENICH t = data.KSTIENICHes.Where(n => n.MAKHACHSAN == maks && n.IDTIENICH == idtt).SingleOrDefault();
                data.KSTIENICHes.DeleteOnSubmit(t);
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
