using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QLDV_BLLDAL
    {
        QLDPKSDataContext data = new QLDPKSDataContext();

        public List<DICHVU> lstdv()
        {
            return data.DICHVUs.ToList();
        }

        public bool themdv(string madv, string tendv)
        {
            try
            {
                DICHVU dv = new DICHVU();
                dv.MADV = madv;
                dv.TENDV = tendv;
                data.DICHVUs.InsertOnSubmit(dv);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<DICHVU> lstmotdv(string madv)
        {
            return data.DICHVUs.Where(n => n.MADV == madv).ToList();
        }

        public bool suadv(string madv, string tendv)
        {
            try
            {
                DICHVU dv = data.DICHVUs.Where(n => n.MADV == madv).FirstOrDefault();
                dv.TENDV = tendv;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deletedv(string madv)
        {
            try
            {
                DICHVU dv = data.DICHVUs.Where(n => n.MADV == madv).SingleOrDefault();
                data.DICHVUs.DeleteOnSubmit(dv);
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
