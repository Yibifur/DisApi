﻿using DisApi.DataAccessLayer.Abstract;
using DisApi.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisApi.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context context;
        public GenericRepository(Context _context)
        {
            context = _context;
        }
        public void Delete(T t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            context.Update(t);
            context.SaveChanges();
        }
    }
}
