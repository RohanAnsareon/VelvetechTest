using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentAccounting.Core.Services.Abstractions;
using StudentAccounting.Infrastructure;
using StudentAccounting.Infrastructure.Entities;
using StudentAccounting.Shared.DTOs.Student;
using StudentAccounting.Shared.Interfaces;

namespace StudentAccounting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task Post([FromBody] CreateStudentRequest request) =>
            await _service.Add(request);

        [HttpGet("{id}")]
        public async Task<GetStudentResponse> Get(Guid id) =>
            await _service.GetById(id);

        [HttpGet]
        public async Task<IEnumerable<GetStudentResponse>> Get() =>
            await _service.GetAll();

        [HttpPut("{id}")]
        public async Task Put(Guid id, [FromBody] EditStudentRequest request) =>
            await _service.Update(id, request);

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) =>
            await _service.Delete(id);
    }
}
