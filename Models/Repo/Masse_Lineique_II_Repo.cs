
using BookStore.Models.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonacid.Models.Rep
{
    public class Masse_Lineique_II_Repo : IMasse_Lineique_Repo<Masse_Lineique_II>
    {
        List<Masse_Lineique_II> ml_II;
        public Masse_Lineique_II_Repo()
        {
            ml_II = new List<Masse_Lineique_II>()
            {
                new Masse_Lineique_II(){Id=1,N_ech=8, Nombre=2,MLDivMoy=887,Max=-4,Min=-6,Cible=-5,Conforme=2,Reduction=2}
            };


        }
        public void Add(Masse_Lineique_II entity)
        {

            if (ml_II.Count() == 0)
            {
                entity.Id = 1;

            }
            else
            {
                entity.Id = ml_II.Max(b => b.Id) + 1;
            }
            ml_II.Add(entity);
        }

        public void Delete(int id)
        {
            var ml = Find(id);
            ml_II.Remove(ml);
        }

        public Masse_Lineique_II Find(int id)
        {
            var ml = ml_II.SingleOrDefault(ml => ml.Id == id);
            return ml;
        }

        public IList<Masse_Lineique_II> List()
        {
            return ml_II;
        }

        public void Update(Masse_Lineique_II entity, int id)
        {
            var ml = Find(id);

            Affectation(ml, entity);
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
