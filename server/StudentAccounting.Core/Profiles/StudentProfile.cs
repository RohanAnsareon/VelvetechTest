using System.Linq;
using AutoMapper;
using StudentAccounting.Infrastructure.Entities;
using StudentAccounting.Shared.DTOs.Student;

namespace StudentAccounting.Core.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, GetStudentResponse>()
                .ForMember(
                    dest => dest.Groups,
                    opt => opt.MapFrom(src => src.StudentGroups.Select(s => s.GroupId))
                );
        }
    }
}
