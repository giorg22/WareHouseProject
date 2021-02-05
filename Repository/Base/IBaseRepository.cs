﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;

namespace Repository.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById();
        void Insert(T toInsert);
        void Delete(int toDelete);
        void Update(T toUpdate);
        bool SaveChanges();
    }
}
