

using DAL.DataContext;
using DTO.AuthDtos;
using DTO.LoginDtos;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyCourseProject.Utility
{
    public class Auth
    {
        private readonly MyContext _ctx;

        public Auth(MyContext ctx)
        {
            _ctx = ctx;
        }
        public LoginResponsDto Login(LoginDto dto)
        {

            LoginResponsDto loginResponsDto = new LoginResponsDto();
            User user = _ctx.Users.Include(m => m.Role).SingleOrDefault(m => m.Username == dto.Username && m.Password == dto.Password);
            if (user != null)
            {
                loginResponsDto.Success = true;
                loginResponsDto.Message = "Daxil oldunuz";
                loginResponsDto.User = user;
            }
            else
            {
                loginResponsDto.Message = "Melumat yalnisdir";
            }
            return loginResponsDto;
        }
    }
}
