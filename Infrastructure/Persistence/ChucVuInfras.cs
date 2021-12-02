using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Usecase;
using System.Data;

namespace Infrastructure.Persistence
{
    public class ChucVuInfras
    {
        private static ChucVuInfras instance;

        public static ChucVuInfras Instance
        {
            get { if (instance == null) instance = new ChucVuInfras(); return ChucVuInfras.instance; }
            private set { ChucVuInfras.instance = value; }
        }

        private ChucVuInfras() { }

        public static ChucVuUseCase cv = new ChucVuUseCase();
        public List<CHUCVU> LoadDSChucVu()
        {
            return cv.LoadDSChucVu();
        }
    }
}
