using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usecase;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class CheckLoginInfras
    {
        private static CheckLoginInfras instance;

        public static CheckLoginInfras Instance 
        {
            get { if (instance == null) instance = new CheckLoginInfras(); return CheckLoginInfras.instance; }
            private set { CheckLoginInfras.instance = value; }
        }

        private CheckLoginInfras() { }

        public static CheckLoginUseCase cli = new CheckLoginUseCase();

        public int Login(string username, string password)
        {
            return cli.Login(username, password);
        }

        //Lấy 1 nhân viên để kiểm tra chức vụ
        public NHANVIEN GetNhanVienByMaNV(string manv)
        {
            return cli.GetNhanVienByMaNV(manv);
        }
    }
}
