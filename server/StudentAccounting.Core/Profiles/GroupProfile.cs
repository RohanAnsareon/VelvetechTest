using AutoMapper;
using StudentAccounting.Infrastructure.Entities;
using StudentAccounting.Shared.DTOs.Group;

namespace StudentAccounting.Core.Profiles
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<Group, GetGroupResponse>();
        }
    }
}
