//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Runtime.Remoting.Contexts;
//using System.Text;
//using System.Threading.Tasks;

//namespace DotNet
//{
//    public class Repository<T>
//    {
//        private readonly DbContext dbContext;
//        private readonly DbSet<T> dbSet;
//        public Repository(DbContext context)
//        {
//            dbContext = context;
//            dbSet = context.Set<T>();
//        }

//        public async Task<IEnumerable<T>>GetAll()
//        {
//            return await dbSet.ToListAsync();
//        }

//        public async Task<T> GetByIdAsync(T id)
//        {
//            return await dbSet.FindAsync(id);
//        }

//        public  void  Add1(T item)
//        {
//             dbSet.Add(item);
//            dbContext.SaveChanges();
//        }

//        public void Update2(T item)
//        {
//            if (dbSet.Find(item) != null)
//            {
//                dbSet.Attach(item);
//            }
//        }

//        public void Delete(T item) 
//        { 
//            if(dbSet.Find(item) != null)
//            dbSet.Remove(item);
//        }
//    }
//}
