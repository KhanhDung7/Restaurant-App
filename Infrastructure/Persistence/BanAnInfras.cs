using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Usecase;
namespace Infrastructure.Persistence
{
    public class BanAnInfras
    {
        private static BanAnInfras instance;
        public static BanAnInfras Instance
        {
            get { if (instance == null) instance = new BanAnInfras(); return BanAnInfras.instance; }
            private set { BanAnInfras.instance = value; }
        }
        private BanAnInfras() { }
        public BanAnUseCase table = new BanAnUseCase();
        public List<BANAN> LoadTableListI()
        {
            return table.LoadTableListUC();
        }
        public int SuaBanAn(int mab, int sokhach_toida, int tinhtrang)
        {
            return table.SuaBanAn(mab, sokhach_toida, tinhtrang);
        }

        public int SwitchTable(int mab, int tinhtrang)
        {
            return table.SwitchTable(mab, tinhtrang);
        }

        public int LaySoKhachToiDa(int id)
        {
            return table.LaySoKhachToiDa(id);
        }
        public List<BANAN> TimBanAn(string noidung)
        {
            return table.TimBanAn(noidung);
        }

        public List<BANAN> LoadTableList()
        {
            return table.LoadTableList();
        }
    }
}
