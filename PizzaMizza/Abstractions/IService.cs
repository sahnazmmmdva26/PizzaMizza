using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Abstractions
{
    internal interface IService<T>
    {
        void Create(T model);
        void Update(T model);
        void Delete(int id);
        List<T> GetAll();

    }
}
