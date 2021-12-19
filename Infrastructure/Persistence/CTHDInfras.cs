using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Usecase;

namespace Infrastructure.Persistence
{
    public class CTHDInfras
    {
        private static CTHDInfras instance;

        public static CTHDInfras Instance
        {
            get { if (instance == null) instance = new CTHDInfras(); return CTHDInfras.instance; }
            private set { CTHDInfras.instance = value; }
        }

        private CTHDInfras() { }

        public static CTHDUseCase cthd = new CTHDUseCase();

        public List<CTHD> GetListCTHD(string id)
        {
            return cthd.GetListCTHD(id);
        }

        public int InsertCTHD(string mahd,int mab, string mam, int slmon, decimal tongtien)
        {
            return cthd.InsertCTHD(mahd,mab, mam, slmon, tongtien);
        }

        public int UpdateSLMonCTHD(string mahd,int mab, string mam, int slmon, decimal tongtien)
        {
            return cthd.UpdateSLMonCTHD(mahd, mab, mam, slmon, tongtien);
        }

        public int DeleteCTHD(string mahd, string mam,int mab)
        {
            return cthd.DeleteCTHD(mahd, mam,mab);
        }
    }
}
