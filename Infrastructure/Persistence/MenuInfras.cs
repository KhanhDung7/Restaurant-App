using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Usecase;

namespace Infrastructure.Persistence
{
    public class MenuInfras
    {
        private static MenuInfras instance;
        public static MenuInfras Instance
        {
            get { if (instance == null) instance = new MenuInfras(); return MenuInfras.instance; }
            private set { MenuInfras.instance = value; }
        }
        private MenuInfras() { }
        public MenuUseCase menu = new MenuUseCase();

        public List<MENU> GetListMenuByTable(int id)
        {
            return menu.GetListMenuByTable(id);
        }
    }
}
