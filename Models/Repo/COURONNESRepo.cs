using BookStore.Models.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SONASID.Models.Repo
{
    public class COURONNESRepo : IMasse_Lineique_Repo<COURONNES>
    {
        

        List<COURONNES> Lc;
        public COURONNESRepo()
        {
            Lc = new List<COURONNES>(6)
                {
                    new COURONNES(){Idicateur="longueur des barres",Non_Conforme=0,Derogeable=0,conforme=0,Moyenne=0},

                    new COURONNES(){Idicateur="Alignement des barres",Non_Conforme=0,Derogeable=0,conforme=0,Moyenne=0},

                    new COURONNES(){Idicateur="nombre de ligature ",Non_Conforme=0,Derogeable=0,conforme=0,Moyenne=0},

                    new COURONNES(){Idicateur="Etat de verrous et réctitude des barres",Non_Conforme=0,Derogeable=0,conforme=0,Moyenne=0},

                    new COURONNES(){Idicateur="Propreté du fardeau",Non_Conforme=0,Derogeable=0,conforme=0,Moyenne=0},

                    new COURONNES(){Idicateur="identification (Etiquette) ",Non_Conforme=0,Derogeable=0,conforme=0,Moyenne=0}

            };
        }
        public void Add(COURONNES entity)
        {
            throw new NotImplementedException();
        }
        public void Add(List<COURONNES> entity)
        {
            Lc = entity.Select(s => new COURONNES
            {
                Idicateur = s.Idicateur,
                Non_Conforme = s.Non_Conforme,
                Derogeable = s.Derogeable,
                conforme = s.conforme

            }).ToList();
            foreach(var item in Lc)
            {
                item.Moyenne = averrage(item.Non_Conforme, item.Derogeable, item.conforme);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public COURONNES Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<COURONNES> List()
        {
            return Lc;
        }

        public void Update(COURONNES entity, int id)
        {
            throw new NotImplementedException();
        }
        public double averrage(double a,double b, double c)
        {
            double av;
            av = (a + b + c) / 3;
            return av;
        }
        public void setNbr_V(int a)
        {
        }
    }
}
