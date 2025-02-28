using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Services;

namespace BusinessLayer.Services
{
    public class UserRegistrationBL
    {
        private readonly UserRegistrationRL _userRegistrationRL;
     
        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }



        public UserDTO RegisterUser(UserDTO frontuserDTO)
        {
            var _user = _userRegistrationRL.SendList();
            var add = AddUser(frontuserDTO, _user);
            return add; 
        }

        public UserDTO AddUser(UserDTO userdata,List<UserDTO> users )
        {
            try
            {
                users.Add(userdata);
                return userdata;
            }catch(Exception ex)
            {
                throw new Exception("Error adding user: " + ex.Message);
            }
        }

        public List<UserDTO> GetUsers()
        {
            return _userRegistrationRL.SendList();
        }
    }
}
