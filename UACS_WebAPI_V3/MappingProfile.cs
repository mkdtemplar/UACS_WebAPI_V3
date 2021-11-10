using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace UACS_WebAPI_V3
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>().ForMember(c => c.FullName,
                opt => opt.MapFrom(x => string.Join(' ', x.FirstName, x.LastName)));

            CreateMap<Address, AddressDto>();

            CreateMap<StudentForCreationDto, Student>();

            CreateMap<AddressForCreation, Address>();

            CreateMap<AddressForUpdateDto, Address>();

            CreateMap<StudentForUpdateDto, Student>();

            CreateMap<AddressForUpdateDto, Address>().ReverseMap();
        }
    }
}
