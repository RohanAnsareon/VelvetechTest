using System;
using System.Collections.Generic;
using StudentAccounting.Shared;
using StudentAccounting.Shared.Enums;

namespace StudentAccounting.Infrastructure.Entities
{
    public class Student : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public Gender Gender { get; set; }
        public string UniqueStudentId { get; set; }

        public virtual ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
