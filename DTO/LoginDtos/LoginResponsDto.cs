using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.LoginDtos
{
    public record LoginResponsDto
    {
        public User User { get; set; } = new();
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }

    }
}
