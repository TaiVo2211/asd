using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avaya.Core.UoW
{
    public class UnitOfWorkBase<TContext> : IUnitOfWork where TContext : DbContext
    {
        private readonly TContext _gmcContext;

        public UnitOfWorkBase(TContext gmcContext)
        {
            _gmcContext = gmcContext;
        }

        public bool SaveChanges()
        {
            
                return _gmcContext.SaveChanges() > 0;
           
        }

       
    }
}
