using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentAccounting.Infrastructure.Entities;
using StudentAccounting.Shared.DTOs.Student;
using StudentAccounting.Shared.Interfaces;

namespace StudentAccounting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IRepository<Student> _repository;

        public StudentController(IRepository<Student> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task Post([FromBody] CreateStudentRequest request)
        {
            await _repository.Insert(new Student
            {
                Name = request.Name,
                Surname = request.Surname,
                Middlename = request.Middlename,
                UniqueStudentId = request.UniqueStudentId,
                Gender = request.Gender
            });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            return Ok(await _repository.GetById(id));
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _repository.GetAll());
        }

        [HttpPut]
        public async Task Put(Guid id, EditStudentRequest request)
        {
            await _repository.Update(new Student
            {
                Id = id,
                Name = request.Name,
                Surname = request.Surname,
                Middlename = request.Middlename,
                Gender = request.Gender,
                UniqueStudentId = request.UniqueStudentId
            });
        }

        [HttpDelete]
        public async Task Delete(Guid id)
        {
            await _repository.Delete(id);
        }
    }
}
