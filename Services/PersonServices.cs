using APIAssigment1.Models;
namespace APIAssigment1.Services
{
    public class PersonServices : IPersonServices
    {
        private static List<PersonModel> _listPerson = new List<PersonModel>
        {
            new PersonModel
            {
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
            return _listPerson;
        }

        public PersonModel? GetOne(Guid id)
        {
            return _listPerson.SingleOrDefault(p => p.Id.Equals(id));
        }

        public PersonModel Create(PersonModel model)
        {
            _listPerson.Add(model);
            return model;
        }

        public PersonModel? Update(Guid id, PersonModel model)
        {
            var index = _listPerson.FindIndex(p => p.Id.Equals(id));
            if (index >= 0)
            {
                _listPerson[index] = model;
                return _listPerson[index];
            }
            return null;
        }

        public PersonModel? Delete(Guid id)
        {
            var index = _listPerson.FindIndex(p => p.Id.Equals(id));
            if (index >= 0)
            {
                
                _listPerson.RemoveAt(index);
                return  _listPerson[index];
            }
            return null;
        }

    }
}
