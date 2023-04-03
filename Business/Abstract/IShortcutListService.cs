using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IShortcutListService
    {
        IDataResult<List<ShortcutList>> GetAll();
        IDataResult<ShortcutList> GetById(int id);
        IResult Add(ShortcutList shortcutList);
        IResult Delete(ShortcutList shortcutList);
    }
}
