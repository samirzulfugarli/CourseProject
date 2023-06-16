using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AuthDtos
{
    public record LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
