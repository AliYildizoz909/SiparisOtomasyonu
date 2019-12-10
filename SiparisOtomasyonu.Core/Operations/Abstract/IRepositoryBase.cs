using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity.Abstract;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.Core.DataAccess.Abstract
{
    public interface IRepositoryBase<T> where T : class, new()
    {
        List<T> GetAll();
        List<T> GetByFilter(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Delete(int index);
        void Update(T entity);
        void PathCheck();
    }
}
