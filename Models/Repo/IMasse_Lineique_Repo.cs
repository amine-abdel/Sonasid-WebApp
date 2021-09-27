using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repo
{
    public interface IMasse_Lineique_Repo<TEntity>
    {
        public static int nbr_v {  get; set; }
        
        IList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity entity);
        void Update(TEntity entity,int id);
        void Delete(int id);
        void Add(List<TEntity> entity);
        public void setNbr_V(int a);

    }
}
