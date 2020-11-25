using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StudentAccounting.Infrastructure.Entities;
using StudentAccounting.Shared.DTOs.Student;

namespace StudentAccounting.Core.Services.Abstractions
{
    public interface IStudentService
    {
        Task Add(CreateStudentRequest request);
        Task Update(Guid id, EditStudentRequest request);
        Task<IEnumerable<GetStudentResponse>> GetAll();
        Task<GetStudentResponse> GetById(Guid id);
        Task Delete(Guid id);
    }
}
