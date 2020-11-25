using System;
using System.Collections.Generic;
using StudentAccounting.Shared;

namespace StudentAccounting.Infrastructure.Entities
{
    public class Group : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StudentGroup> StudentGroups { get; set; }

    }
}
