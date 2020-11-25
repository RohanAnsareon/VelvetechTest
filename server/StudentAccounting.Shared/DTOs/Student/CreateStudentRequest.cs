using System;
using StudentAccounting.Shared.Enums;

namespace StudentAccounting.Shared.DTOs.Student
{
    public class CreateStudentRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string UniqueStudentId { get; set; }
        public Gender Gender { get; set; }

        public Guid[] Groups { get; set; }
    }
}
