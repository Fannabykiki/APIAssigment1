using APIAssigment1.Models;
namespace APIAssigment1.Services
{
    public interface IPersonServices
    {
        List<PersonModel> GetAll();
        PersonModel? GetOne(int index);
        PersonModel Create(PersonModel model);
        PersonModel? Update(int index, PersonModel model);
        PersonModel? Delete(int index);
    }
}