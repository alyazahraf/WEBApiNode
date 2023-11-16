using WebAPI.Models;
using WebAPI.Models.Dto;

namespace WebAPI.Data
{
    public static class UserStore
    {
        public static List<UserDTO> userList = new List<UserDTO>
{
new UserDTO{ Username = "user1", Password = "password1" },
};
    }
}
