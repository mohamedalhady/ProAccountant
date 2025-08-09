using Microsoft.EntityFrameworkCore;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.Base;
using System.Collections.Immutable;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;


namespace MyFarmWeb.Repository
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        protected MyFarmContext contextdb { get; set; }
        public MainRepository(MyFarmContext myFarmContext)
        {
            contextdb = myFarmContext;
        }
 


    
        public IEnumerable<T> GetAll(params string[] args)
        {
            IQueryable<T> query = contextdb.Set<T>();
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    query = query.Include(arg);
                }
            }
          
            return query.ToList();
        }

        public void AddOne(T entity)
        {
            
            contextdb.Set<T>().Add(entity);
            contextdb.SaveChanges();
        }

        public void UpdateOne(T entity)
        {
          
            contextdb.Set<T>().Update(entity);
            contextdb.SaveChanges();
        }

        public void DeleteOne(T entity)
        {
            contextdb.Set<T>().Remove(entity);
            contextdb.SaveChanges();
        }

        public void AddList(IEnumerable<T> entity)
        {
            contextdb.Set<T>().AddRange(entity);
            contextdb.SaveChanges();
        }

        public void UpdateList(IEnumerable<T> entity)
        {
            contextdb.Set<T>().UpdateRange(entity);
            contextdb.SaveChanges();
        }

        public void DeleteList(IEnumerable<T> entity)
        {
            contextdb.Set<T>().RemoveRange(entity);
            contextdb.SaveChanges();
        }

        public T SelectOne(Expression<Func<T, bool>> match)
        {
           return contextdb.Set<T>().FirstOrDefault(match);
        }


        
        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await contextdb.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(params string[] args)
        {
            IQueryable<T> query = contextdb.Set<T>();
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    query = query.Include(arg);
                }
            }
            return await query.ToListAsync();
        }


        public T GetById(int id)
        {
          return   contextdb.Set<T>().Find(id);
        }

        public async Task<T>GetByIdAsync(int id)
        {
            return await contextdb.Set<T>().FindAsync(id);
        }

        public IEnumerable<T> GetAll()
        {
          return  contextdb.Set<T>().ToList();
        }

        public bool Any(Expression<Func<T, bool>> match)
        {
            return contextdb.Set<T>().AsNoTracking().Any(match);
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> match)
        {
            return await contextdb.Set<T>().Where(match).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> match, params string[] args)
        {
            IQueryable<T> query = contextdb.Set<T>();
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    query = query.Include(arg);
                }
            }
            return await query.Where(match).ToListAsync();
        }

        public  decimal GetItemBalance( Expression<Func<T, bool>> match1, Expression<Func<T, decimal>> match)
        {
            var q =  contextdb.Set<T>().Where(match1).Sum(match);
            return q;
        }

        public int GetMaxId(Expression<Func<T, int>> match)
        {
            int max = 0;
            if (contextdb.Set<T>().ToList().Count > 0)
            {
                max = contextdb.Set<T>().Max(match) ;
            }
            return max;
        }
        public int GetMaxId(Expression<Func<T, int>> match, Expression<Func<T, bool>> match2)
        {
            IQueryable<T> query = contextdb.Set<T>();
            int max = 0;
            if (query.Where(match2).ToList().Count > 0)
            {
                max = query.Where(match2).Max(match);
            }
            return max;
        }

        public void AddManyEntityTransaction(params(List<T> args1,T args2)[] args)
        {
            if (args.Length > 0)
            {
                using (contextdb.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var (itemlist, item) in args)
                        {
                            contextdb.Set<T>().Add(item);
                            contextdb.Set<T>().AddRange(itemlist);

                        }
                        contextdb.Database.CommitTransaction();
                    }
                    catch (Exception)
                    {

                       contextdb.Database.RollbackTransaction();
                    }
                  
                }
               
               
            }
        }

        public T GetById(int id, Expression<Func<T, bool>> match)
        {
            return contextdb.Set<T>().FirstOrDefault(match);
        }

        public  async Task<T> GetByIdAsync(Expression<Func<T, bool>> match1, Expression<Func<T, bool>> match2)
        {
            return await contextdb.Set<T>().Where(match1).FirstOrDefaultAsync(match2);
        }

        public string GetMaxStringId(Expression<Func<T, string>> match)
        {
            string max = "";
            if (contextdb.Set<T>().ToList().Count > 0)
            {
                max = contextdb.Set<T>().Max(match);
            }
            return max;
        }

        public string GetMaxStringId(Expression<Func<T, string>> match, Expression<Func<T, bool>> match2)
        {
            IQueryable<T> query = contextdb.Set<T>();
            string max = "";
            if (query.Where(match2).ToList().Count > 0)
            {
                max = query.Where(match2).Max(match);
            }
            return max;
        }
    }
}
