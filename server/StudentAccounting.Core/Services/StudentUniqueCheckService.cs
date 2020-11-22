using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentAccounting.Core.Services.Abstractions;
using StudentAccounting.Infrastructure;

namespace StudentAccounting.Core.Services
{
    public class StudentUniqueCheckService : IUniqueCheckService
    {
        private readonly StudentAccountingDbContext _context;

        public StudentUniqueCheckService(StudentAccountingDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CheckAsync(object value) => 
            await _context.Students.FirstOrDefaultAsync(s => s.UniqueStudentId == value as string) == null;
        
    }
}
