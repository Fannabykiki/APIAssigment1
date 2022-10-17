using APIAssigment1.Models;
namespace APIAssigment1.Services
{
    public class PersonServicesExtended : IPersonServices
    {
        private static List<PersonModel> listPerson = new List<PersonModel>
        {
            new PersonModel
            {   
                ID = Guid.NewGuid(),
                FirstName = "Phan",
                LastName = "Nam",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 10, 18),
                PhoneNumber = "0396373132",
                BirthPlace = "Ha Noi",
                IsGraduated = true
            },
            new PersonModel
            {
                ID = Guid.NewGuid(),
                FirstName = "Tran",
                LastName = "Linh",
                Gender = "Male",
                DateOfBirth = new DateTime(2003, 10, 15),
                PhoneNumber = "0396373132",
                BirthPlace = "Bac Ninh",
                IsGraduated = false
            },
            new PersonModel
            {
                ID = Guid.NewGuid(),
                FirstName = "Dao",
                LastName = "Trang",
                Gender = "FeMale",
                DateOfBirth = new DateTime(2003, 07, 13),
                PhoneNumber = "0396373132",
                BirthPlace = "SG",
                IsGraduated = true
            },
            new PersonModel
            {
                ID = Guid.NewGuid(),
                FirstName = "Duy",
                LastName = "Anh",
                Gender = "FeMale",
                DateOfBirth = new DateTime(2000, 11, 30),
                PhoneNumber = "0396373132",
                BirthPlace = "Ha Noi",
                IsGraduated = true
            }
        };

        public List<PersonModel> GetAll()
        {
            return listPerson;
        }

        public PersonModel? GetOne(int index)
        {
            if (index >= 0 && index < listPerson.Count)
            {
                return listPerson[index];
            }
            return null;
        }

        public PersonModel Create(PersonModel model)
        {
            listPerson.Add(model);
            return model;
        }

        public PersonModel? Update(int index, PersonModel model)
        {
            if (index >= 0 && index < listPerson.Count)
            {
                listPerson[index] = model;
                return model;
            }
            return null;
        }

        public PersonModel? Delete(int index)
        {
            if (index >= 0 && index < listPerson.Count)
            {
                var person = listPerson[index];
                listPerson.RemoveAt(index);
                return person; 
            }
            return null;
        }
    }
}