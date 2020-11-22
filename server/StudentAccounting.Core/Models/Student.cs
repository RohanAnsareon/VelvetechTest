using System;
using StudentAccounting.Shared.Enums;

namespace StudentAccounting.Core.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public Gender Gender { get; set; }
        public string UniqueStudentId { get; set; }
    }
}
