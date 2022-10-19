using APIAssigment1.Models;
namespace APIAssigment1.Services
{
    public interface IPersonServices
    {
        List<PersonModel> GetAll();
        PersonModel? GetOne(Guid id);
        PersonModel Create(PersonModel model);
        PersonModel? Update(Guid id, PersonModel model);
        PersonModel? Delete(Guid id);
    }
}