//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using BusinessLayer.Services;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserRegistrationBL _userRegistrationBL;
        private readonly ResponseDTO<string> _responseDTO;

        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpGet]
        public IActionResult GetAllUser()
        {
            var result  = _userRegistrationBL.GetUsers();

            var responseDTO = new ResponseDTO<List<UserDTO>>
            {
                Success = true,
                Message = result.Count > 0 ? "User Retrived Succesfully." : "No User Found",
                Data = result
            };

            return Ok(responseDTO);
        }

        [HttpPost]
        public IActionResult RegisterNewUser(UserDTO userDTO)
        {
            try
            {
                ResponseDTO<string> _responseDTO = new ResponseDTO<string>();
                var result = _userRegistrationBL.RegisterUser(userDTO);

                if (result != null)
                {
                    _responseDTO.Success = true;
                    _responseDTO.Message = "User Add Succesfull.";
                    _responseDTO.Data = result.ToString();
                    return Ok(_responseDTO);
                }
                _responseDTO.Success = false;
                _responseDTO.Message = "Failed to add user.";
                return BadRequest(_responseDTO);
            }
            catch (Exception ex)
            {
                _responseDTO.Success = false;
                _responseDTO.Message = ex.Message;
                
                return BadRequest(_responseDTO);
            }

        }
        
    }
}
