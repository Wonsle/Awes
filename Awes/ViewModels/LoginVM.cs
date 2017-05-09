using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Awes
{
    public class LoginVM
    {
        public string Account { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
