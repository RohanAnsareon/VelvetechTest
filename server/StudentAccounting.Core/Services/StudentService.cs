using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using StudentAccounting.Core.Services.Abstractions;
using StudentAccounting.Infrastructure;
using StudentAccounting.Infrastructure.Entities;
using StudentAccounting.Shared.DTOs.Student;
using StudentAccounting.Shared.Interfaces;

namespace StudentAccounting.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _repository;
        private readonly StudentAccountingDbContext _context;
        private readonly IMapper _mapper;

        public StudentService(IRepository<Student> repository, StudentAccountingDbContext context, IMapper mapper)
        {
            _repository = repository;
            _context = context;
            _mapper = mapper;
        }

        public async Task Add(CreateStudentRequest request)
        {
            var id = await _repository.Insert(new Student
            {
                Name = request.Name,
                Surname = request.Surname,
                Middlename = request.Middlename,
                UniqueStudentId = request.UniqueStudentId,
                Gender = request.Gender
            });

            var studentGroups = request.Groups.Select(g => new StudentGroup { GroupId = g, StudentId = id });

            await _context.StudentGroups.AddRangeAsync(studentGroups);

            await _context.SaveChangesAsync();
        }

        public async Task Update(Guid id, EditStudentRequest request)
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

            var studentGroups =
                request.Groups.Select(g => new StudentGroup
                {
                    GroupId = g,
                    StudentId = id
                });

            _context.StudentGroups.UpdateRange(studentGroups);
        }

        public async Task<IEnumerable<GetStudentResponse>> GetAll() => _mapper.Map<IEnumerable<GetStudentResponse>>(await _repository.GetAll());

        public async Task<GetStudentResponse> GetById(Guid id) => _mapper.Map<GetStudentResponse>(await _repository.GetById(id));

        public async Task Delete(Guid id) => await _repository.Delete(id);
    }
}
