using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NHANVIEN_BLLDAL
    {
        QLDPKSDataContext QLDP = new QLDPKSDataContext();

        public List<NHANVIEN> GetNhanVien()
        {
            return QLDP.NHANVIENs.ToList<NHANVIEN>();
        }
    }
}
