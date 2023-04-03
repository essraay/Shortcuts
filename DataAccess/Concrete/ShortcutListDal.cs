using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ShortcutListDal : EfEntityRepositoryBase<ShortcutList, ShortcutContext>, IShortcutListDal
    {
        public List<ShortcutList> GetAll()
        {
            using (ShortcutContext context = new ShortcutContext())
            {
                var query = context.ShortcutList.AsQueryable();
                return query.ToList();

            }
        }

        public ShortcutList GetById(int id)
        {
            using (ShortcutContext context = new ShortcutContext())
            {
                var query = context.ShortcutList.Where(item => item.Id == id).AsQueryable();
                return query.SingleOrDefault();
            }
        }
    }
}
