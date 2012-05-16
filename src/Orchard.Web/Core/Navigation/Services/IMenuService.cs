using System.Collections.Generic;
using Orchard.Core.Navigation.Models;

namespace Orchard.Core.Navigation.Services {
    public interface IMenuService : IDependency {
        IEnumerable<MenuPart> Get();
        IEnumerable<MenuPart> GetMenu(int menuId);
        MenuPart Get(int menuPartId);
        void Delete(MenuPart menuPart);
    }
}