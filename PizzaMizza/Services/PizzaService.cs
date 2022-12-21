using PizzaMizza.Abstractions;
using PizzaMizza.Helper;
using PizzaMizza.Models;

namespace PizzaMizza.Services
{
    class PizzaService : IService<Pizza>
    {
        public void Create(Pizza model)
        {
            Sql.ExecCommand($"insert into Pizzas ('{model.Name}','{model.Image}')");
        }

        public void Delete(int id) v
        {
            Sql.ExecCommand($"");
        }

        public List<Pizza> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Pizza model)
        {
            throw new NotImplementedException();
        }
    }
}
