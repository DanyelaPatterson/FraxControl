using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFraccionamiento.Models
{
    public class UserListViewModel
    {
        public UserListViewModel()
        {

        }
        
        public List<UserViewModel> UserList { get; set; }

        public string Message { get; set; } 
    }
}