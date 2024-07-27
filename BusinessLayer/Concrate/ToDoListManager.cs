using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _todoListDal;

        public ToDoListManager(IToDoListDal todoListDal)
        {
            _todoListDal = todoListDal;
        }

        public void TAdd(ToDoList t)
        {
            _todoListDal.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _todoListDal.Delete(t);
        }

        public ToDoList TGetByID(int id)
        {
            return _todoListDal.GetById(id);
        }

        public List<ToDoList> TGetList()
        {
            return _todoListDal.GetList();
        }

        public List<ToDoList> TGetListbyFilter()
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(ToDoList t)
        {
            _todoListDal.Update(t);
        }
    }
}
