using System;
using System.Collections.Generic;
using StudentAccounting.Shared.Enums;

namespace StudentAccounting.Shared.DTOs.Student
{
    public class GetStudentResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public Gender Gender { get; set; }
        public string UniqueStudentId { get; set; }

        public IEnumerable<Guid> Groups { get; set; }
    }
}
