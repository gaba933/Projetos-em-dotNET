using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Dominio.DTOs
{
    public class LoginDTO
{
    public string email { get; set; } = default!;
    public string senha { get; set; } = default!;
}
}