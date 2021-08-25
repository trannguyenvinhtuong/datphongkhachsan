using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QLTIENICH_BLLDAL
    {
        QLDPKSDataContext data = new QLDPKSDataContext();
        
        public List<TIENICH> lsttienich()
        {
            return data.TIENICHes.ToList();
        }

        public bool themti(string ten, string maicon)
        {
            try
            {
                TIENICH ti = new TIENICH();
                ti.TENTIENICH = ten;
                ti.ICON = maicon;
                data.TIENICHes.InsertOnSubmit(ti);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public bool suati(int id, string ten, string maicon)
        {
            try
            {
                TIENICH ti = data.TIENICHes.Where(n=>n.IDTIENICH==id).FirstOrDefault();
                ti.TENTIENICH = ten;
                ti.ICON = maicon;
                
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool xoati(int id)
        {
            try
            {
                TIENICH ti = data.TIENICHes.Where(n => n.IDTIENICH == id).SingleOrDefault();
                data.TIENICHes.DeleteOnSubmit(ti);
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
