using System;

namespace StudentAccounting.Shared
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
