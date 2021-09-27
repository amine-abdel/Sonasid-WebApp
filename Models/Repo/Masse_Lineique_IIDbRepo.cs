using BookStore.Models.Repo;
using Sonacid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SONASID.Models.Repo
{
    public class Masse_Lineique_IIDbRepo : IMasse_Lineique_Repo<Masse_Lineique_II>
    {
        SonacidDbContext db;
        public Masse_Lineique_IIDbRepo(SonacidDbContext _db)
        {

            db = _db;
        }
        public void Add(Masse_Lineique_II entity)
        {
            db.MLII.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var ml = Find(id);
            db.MLII.Remove(ml);
            db.SaveChanges();
        }

        public Masse_Lineique_II Find(int id)
        {
            var ml = db.MLII.SingleOrDefault(ml => ml.Id == id);
            return ml;
        }

        public IList<Masse_Lineique_II> List()
        {
            return db.MLII.ToList();
        }

        public void Update(Masse_Lineique_II entity, int id)
        {
            db.Update(entity);
            db.SaveChanges();
        }
        public void Affectation(Masse_Lineique_II ml, Masse_Lineique_II entity)
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

        public void Add(List<Masse_Lineique_II> entity)
        {
            throw new NotImplementedException();
        }

        public void setNbr_V(int a)
        {
            throw new NotImplementedException();
        }
    }
}
