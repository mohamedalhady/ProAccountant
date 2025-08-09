using System.Linq.Expressions;

namespace MyFarmWeb.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        T GetById(int id, Expression<Func<T, bool>> match);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(params string[] args);
        void AddOne(T entity);
        void UpdateOne(T entity);
        void DeleteOne(T entity);

        void AddList(IEnumerable<T> entity);
        void UpdateList(IEnumerable<T> entity);
        void DeleteList(IEnumerable<T> entity);
        T SelectOne(Expression<Func<T, bool>> match);

        bool Any(Expression<Func<T, bool>> match);
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(Expression<Func<T, bool>> match1, Expression<Func<T, bool>> match2);
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllAsync(params string[] args);

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> match);

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> match,params string[] args);
   
        decimal GetItemBalance(Expression<Func<T, bool>> match1, Expression<Func<T, decimal>> match);

        int GetMaxId(Expression<Func<T, int>> match);
        string GetMaxStringId(Expression<Func<T, string>> match);
        int GetMaxId(Expression<Func<T, int>> match, Expression<Func<T, bool>> match2);
        string GetMaxStringId(Expression<Func<T, string>> match, Expression<Func<T, bool>> match2);

        
        void AddManyEntityTransaction(params (List<T> args1, T args2)[] args);
        
    }
}
