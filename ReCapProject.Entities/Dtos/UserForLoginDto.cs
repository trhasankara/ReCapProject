using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Entities;

namespace ReCapProject.Entities.Dtos
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
