using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ShortcutListManager : IShortcutListService
    {
        IShortcutListDal _shortcutListDal;

        public ShortcutListManager(IShortcutListDal shortcutListDal)
        {
            _shortcutListDal = shortcutListDal;
        }
        public IResult Add(ShortcutList shortcutList)
        {
            _shortcutListDal.Add(shortcutList);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(ShortcutList shortcutList)
        {
            _shortcutListDal.Delete(shortcutList);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<List<ShortcutList>> GetAll()
        {
            return new SuccessDataResult<List<ShortcutList>>(_shortcutListDal.GetAll(), Messages.Listed);
        }
        public IDataResult<ShortcutList> GetById(int id)
        {
            return new SuccessDataResult<ShortcutList>(_shortcutListDal.GetById(id), Messages.Listed);
        }
    }
}
