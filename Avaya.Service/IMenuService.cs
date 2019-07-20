using Avaya.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avaya.Service
{
    public interface IMenuService
    {
        List<Menu> GetAll();
    }
}
