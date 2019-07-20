using Avaya.Core.Repositories;
using Avaya.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avaya.Domain.Repositories
{
    public class Repository<TEntity> : RepositoryBase<TEntity, SmartPhoneStoreContext>
        where TEntity : class
    {
        public Repository(SmartPhoneStoreContext context) : base(context)
        {
        }
    }
}
