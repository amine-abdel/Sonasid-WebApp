using BookStore.Models.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonacid.Models.Rep
{
    public class H_V_Repo : IMasse_Lineique_Repo<H_V>
    {
        List<H_V> Hv;
        public H_V_Repo()
        {
            Hv = new List<H_V>()
            {
                new H_V(){Id=1,Diametre="10",Mesures="0.7",Max="1",Min="1",Cible="1",Poste=2}
            };


        }
        public void Add(H_V entity)
        {

            if (Hv.Count() == 0)
            {
                entity.Id = 1;

            }
            else
            {
                entity.Id = Hv.Max(b => b.Id) + 1;
            }
            Hv.Add(entity);
        }

        public void Delete(int id)
        {
            var hv = Find(id);
            Hv.Remove(hv);
        }

        public H_V Find(int id)
        {
            var hv = Hv.SingleOrDefault(hv => hv.Id == id);
            return hv;
        }

        public IList<H_V> List()
        {
            return Hv;
        }

        public void Update(H_V entity, int id)
        {
            var hv = Find(id);

            Affectation(hv, entity);
        }
        public void Affectation(H_V hv, H_V entity)
        {
            hv.Diametre = entity.Diametre;

            hv.Mesures = entity.Mesures;        
            
            hv.Min = entity.Min;

            hv.Max = entity.Max;

            hv.Cible = entity.Cible;

            hv.Poste = entity.Poste;

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

