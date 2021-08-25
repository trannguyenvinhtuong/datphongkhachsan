using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class HOADON_DLLDAL
    {
        QLDPKSDataContext data = new QLDPKSDataContext();
        
        public List<BOOKING> lsthd()
        {
            return data.BOOKINGs.ToList();
        }
    }
}
