namespace Gestion_Stock.Models.Repositories
{
    public interface IGestionStockRepository<TEntity>
    {
        IList<TEntity> list();
        TEntity Find(Guid id);
        void Add(TEntity entity);   
        void Update(Guid Id, TEntity entity);    
        void Delete(Guid id);
       // object Find(int id);
        //void Delete(int id);
    }
}
