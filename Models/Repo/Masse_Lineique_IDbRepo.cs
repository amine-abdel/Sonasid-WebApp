using BookStore.Models.Repo;
using Sonacid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SONASID.Models.Repo
{
    public class Masse_Lineique_IDbRepo : IMasse_Lineique_Repo<Masse_Lineique_I>
    {
        SonacidDbContext db;
        public Masse_Lineique_IDbRepo( SonacidDbContext _db)
        {

            db = _db;
        }
        public void Add(Masse_Lineique_I entity)
        {
            db.MLI.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var ml = Find(id);
            db.MLI.Remove(ml);
            db.SaveChanges();
        }

        public Masse_Lineique_I Find(int id)
        {
            var ml = db.MLI.SingleOrDefault(ml => ml.Id == id);
            return ml;
        }

        public IList<Masse_Lineique_I> List()
        {
            return db.MLI.ToList();
        }

        public void Update(Masse_Lineique_I entity, int id)
        {
            db.Update(entity);
            db.SaveChanges();
        }
        public void Affectation(Masse_Lineique_I ml, Masse_Lineique_I entity)
        {
            ml.N_ech = entity.N_ech;
            ml.Nombre = entity.Nombre;
            ml.SP_EBOU = entity.SP_EBOU;
            ml.Mesures = entity.Mesures;
            ml.MLDivMoy = entity.MLDivMoy;
            ml.Reduction = entity.Reduction;
            ml.Min = entity.Min;
            ml.Max = entity.Max;
            ml.Cible = entity.Cible;
            ml.Conforme = entity.Conforme;

        }

        public void Add(List<Masse_Lineique_I> entity)
        {
            throw new NotImplementedException();
        }

        public void setNbr_V(int a)
        {
            throw new NotImplementedException();
        }
    }
}
