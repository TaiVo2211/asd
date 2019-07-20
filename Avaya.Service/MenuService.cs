using Avaya.Core.Repositories;
using Avaya.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avaya.Service
{
    public class MenuService : IMenuService
    {
        private readonly IRepository<Menu> _menuRepository;

        public MenuService(IRepository<Menu> menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public List<Menu> GetAll()
        {
            var list = _menuRepository.GetAll().OrderBy(x => x.DisplayOrder).ToList();
            return list.ToList();
        }
    }
}
