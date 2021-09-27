using BookStore.Models.Repo;
using Sonacid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SONASID.Models.Repo
{
    public class H_V_DbRepo : IMasse_Lineique_Repo<H_V>
    {
        SonacidDbContext db;
        public H_V_DbRepo (SonacidDbContext _db)
        {

            db = _db;
        }
        public void Add(H_V entity)
        {
            db.HV.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var ml = Find(id);
            db.HV.Remove(ml);
            db.SaveChanges();
        }

        public H_V Find(int id)
        {
            var ml = db.HV.SingleOrDefault(ml => ml.Id == id);
            return ml;
        }

        public IList<H_V> List()
        {
            return db.HV.ToList();
        }

        public void Update(H_V entity, int id)
        {
            db.Update(entity);
            db.SaveChanges();
        }
        public void Affectation(H_V ml, H_V entity)
        {

        }

        public void Add(List<H_V> entity)
        {
            throw new NotImplementedException();
        }

        public void setNbr_V(int a)
        {
            throw new NotImplementedException();
        }

       
    }
}
