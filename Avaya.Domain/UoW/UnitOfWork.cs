using Avaya.Core.UoW;
using Avaya.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avaya.Domain.UoW
{
    public class UnitOfWork : UnitOfWorkBase<MovieTheaterContext>
    {
        public UnitOfWork(MovieTheaterContext gmcContext) : base(gmcContext)
        {
        }
    }
}
