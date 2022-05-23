using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Aplication.Repostories
{
    public interface IRepostory<T> where T : BaseEntity
    {
        public DbSet<T> Table { get; }
    }
}
