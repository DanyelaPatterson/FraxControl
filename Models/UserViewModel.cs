using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFraccionamiento.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            
        }
        public string User { get; set; }

        public string Email { get; set;}

        public bool Confirmed { get; set; }

    }
}