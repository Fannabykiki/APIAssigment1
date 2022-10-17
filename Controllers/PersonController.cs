using APIAssigment1.Models;
using APIAssigment1.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIAssigment1.Controllers;

[ApiController]
[Route("person-management")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    private readonly IPersonServices _personServices;

    public PersonController(ILogger<PersonController> logger, IPersonServices personServices)
    {
        _logger = logger;
        _personServices = personServices;
    }

    [HttpGet("users")]
    public IEnumerable<PersonDetailModel> GetAll()
    {
        var data = _personServices.GetAll();
        return from item in data
               select new PersonDetailModel
               {
                   ID = item.ID,
                   FirstName = item.FirstName,
                   LastName = item.LastName,
                   Gender = item.Gender,
                   DateOfBirth = item.DateOfBirth,
                   PhoneNumber = item.PhoneNumber,
                   BirthPlace = item.BirthPlace
               };
    }
    [HttpGet("users/{index:int}")]
    public IActionResult GetOne(int index)
    {
        try
        {
            var data = _personServices.GetOne(index);
            if (data == null)
            {
                return NotFound();
            }
            return new JsonResult(new PersonDetailModel
            {
                ID = data.ID,
                FirstName = data.FirstName,
                LastName = data.LastName,
                Gender = data.Gender,
                DateOfBirth = data.DateOfBirth,
                PhoneNumber = data.PhoneNumber,
                BirthPlace = data.BirthPlace
            });
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpPost("users/")]
    public IActionResult Create(PersonCreateModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        try
        {
            var person = new PersonModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                DateOfBirth = model.DateOfBirth,
                BirthPlace = model.BirthPlace,
                PhoneNumber = model.PhoneNumber,
                IsGraduated = false
            };
            var result = _personServices.Create(person);

            return StatusCode(StatusCodes.Status201Created, result);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpPut("users/{index:int}")]
    public IActionResult Update(int index, PersonUpdateModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        try
        {
            var data = _personServices.GetOne(index);
            if (data == null)
            {
                return NotFound();
            }
            data.FirstName = model.FirstName;
            data.LastName = model.LastName;
            data.PhoneNumber = model.PhoneNumber;
            data.BirthPlace = model.BirthPlace;

            var result = _personServices.Update(index, data);
            return new JsonResult(result);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpDelete("users/{index:int}")]
    public IActionResult Delete(int index)
    {
        try
        {
            var data = _personServices.GetOne(index);
            if (data == null)
            {
                return NotFound();
            }
            var result = _personServices.Delete(index);
            return new JsonResult(result);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
}
