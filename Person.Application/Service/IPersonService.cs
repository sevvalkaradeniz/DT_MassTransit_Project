
using Person.Model.Models;

namespace Person.Application.Service
{
    public interface IPersonService
    {

        Task Add(PersonModel person);
        Task Delete(PersonModel person);
        Task AddPerson(PersonModel person);
        Task Update(PersonModel person);

        Task<IEnumerable<PersonModel>> GetAll();

        Task<PersonModel> GetById(int id);
    }
}
