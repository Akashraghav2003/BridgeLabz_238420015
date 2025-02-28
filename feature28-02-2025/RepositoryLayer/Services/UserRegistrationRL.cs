using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
namespace RepositoryLayer.Services
{
    public class UserRegistrationRL
    {
        
        private List<UserDTO> _user = new List<UserDTO>();

        public List<UserDTO> SendList()
        {
            return _user;
        }

        

       
    } 
}


