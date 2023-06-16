using AutoMapper;
using DTO.MySiteDtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public class AutoMapperProfiles:Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<MySiteToAddDto, MySite>();
            CreateMap<MySite, MySiteToListDto>();
            CreateMap<MySite, MySiteByIdDto>();
            CreateMap<MySiteToUpdateDto, MySite>();
        }
    }
}
