using Sonacid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repo
{
    public class Masse_Lineique_IRepo : IMasse_Lineique_Repo<Masse_Lineique_I>
    {
        List<Masse_Lineique_I> masse_Lineique_s;
        public Masse_Lineique_IRepo()
        {
            masse_Lineique_s = new List<Masse_Lineique_I>()
            {
                new Masse_Lineique_I(){Id=1,N_ech=1, Nombre=1,MLDivMoy=887,Max=-4,Min=-6,Cible=-5,Conforme=2}
            };


        }
        public void Add(Masse_Lineique_I entity)
        {
            if(masse_Lineique_s.Count()==0)
            {
                entity.Id = 1;

            }
            else
            {
                entity.Id = masse_Lineique_s.Max(b => b.Id) + 1;
            }
           
            masse_Lineique_s.Add(entity);
        }

        public void Delete(int id)
        {
            var ml = Find(id);
            masse_Lineique_s.Remove(ml);
        }

        public Masse_Lineique_I Find(int id)
        {
            var ml = masse_Lineique_s.SingleOrDefault(ml => ml.Id == id);
            return ml;
        }

        public IList<Masse_Lineique_I> List()
        {
            return masse_Lineique_s;
        }

        public void Update(Masse_Lineique_I entity, int id)
        {
            var ml = Find(id);

            Affectation(ml, entity);
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
