using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usecase;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class UpdateAccountProfileInfras
    {
        private static UpdateAccountProfileInfras instance;

        public static UpdateAccountProfileInfras Instance
        {
            get { if (instance == null) instance = new UpdateAccountProfileInfras(); return UpdateAccountProfileInfras.instance; }
            private set { UpdateAccountProfileInfras.instance = value; }
        }

        private UpdateAccountProfileInfras() { }

        public static UpdateAccountProfileUseCase updateacc = new UpdateAccountProfileUseCase();

        public int UpdateAccountProfile(string manv, string hotennv, string cmnd, string sdtnv, string diachi, string chucvu, string matkhau)
        {
            return updateacc.UpdateAccountProfile(manv, hotennv, cmnd, sdtnv, diachi, chucvu, matkhau);
        }
    }
}
