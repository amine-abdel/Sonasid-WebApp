using BookStore.Models.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SONASID.Models.Repo
{
    public class FARDEAUXRepo : IMasse_Lineique_Repo<FARDEAUX>
    {
        List<FARDEAUX> Lf;
        public FARDEAUXRepo()
        {
            Lf = new List<FARDEAUX>(6)
                {
                    new FARDEAUX(){Idicateur="longueur des barres",Non_Conforme=0,Derogeable=0,conforme=0},

                    new FARDEAUX(){Idicateur="Alignement des barres",Non_Conforme=0,Derogeable=0,conforme=0},

                    new FARDEAUX(){Idicateur="nombre de ligature ",Non_Conforme=0,Derogeable=0,conforme=0},

                    new FARDEAUX(){Idicateur="Etat de verrous et réctitude des barres",Non_Conforme=0,Derogeable=0,conforme=0},

                    new FARDEAUX(){Idicateur="Propreté du fardeau",Non_Conforme=0,Derogeable=0,conforme=0},

                    new FARDEAUX(){Idicateur="identification (Etiquette) ",Non_Conforme=0,Derogeable=0,conforme=0}







            };
        }
        public void Add(FARDEAUX entity)
        {
            throw new NotImplementedException();
        }
        public void Add(List<FARDEAUX> entity)
        {
            Lf = entity.Select(s => new FARDEAUX
            {
                Idicateur = s.Idicateur,
                Non_Conforme = s.Non_Conforme,
                Derogeable=s.Derogeable,
                conforme=s.conforme

            }).ToList();
            foreach (var item in Lf)
            {
                item.Moyenne = averrage(item.Non_Conforme, item.Derogeable, item.conforme);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public FARDEAUX Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<FARDEAUX> List()
        {
            return Lf;
        }

        public void setNbr_V(int a)
        {
            throw new NotImplementedException();
        }

        public void Update(FARDEAUX entity, int id)
        {
            throw new NotImplementedException();
        }
        public double averrage(double a, double b, double c)
        {
            double av;
            av = (a + b + c) / 3;
            return av;
        }
    }
}
