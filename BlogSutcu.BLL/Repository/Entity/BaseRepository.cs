using BlogSutcu.DAL.ORM.Context;
using BlogSutcu.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSutcu.BLL.Repository
{
    public class BaseRepository <T> where T : BaseEntity
    {
        private ProjectContext db;

        protected DbSet<T> tablo;

        public BaseRepository()
        {
            db = new ProjectContext();
            tablo = db.Set<T>();
        }

        public List<T> GetAll()
        {
            return tablo.ToList();
        }

        public List<T> GetActive()
        {
            return tablo.Where(a => a.Status == DAL.ORM.Enum.Status.Active).ToList();  //for list 
        }

        public T GetById(Guid id)  // ask ?
        {
            return tablo.Find(id);
        }

        public void Remove(Guid id)
        {
            T item = GetById(id);
            item.Status = DAL.ORM.Enum.Status.Deleted;
        }


        public void Add(T item)  // Using adding a just one thing 
        {
            item.Status = BlogSutcu.DAL.ORM.Enum.Status.Active;
            tablo.Add(item);
            Save();//you have to add save method ;

        }

        public void Add(List<T> items)  // using adding depend on some parameters (Like an article needs an appuser and Categeory)
        {
            tablo.AddRange(items);
            Save();////you have to add save method ;
        }
        public int Save()                         //save method is int ??
        {
            return db.SaveChanges();
        }


    }
}
