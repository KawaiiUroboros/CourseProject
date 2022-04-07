using AutoMapper;
using WebApp.Models;
using WebApp.Models.Requests;

namespace WebApp.Jwt
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterRequest, User>();
            CreateMap<UpdateRequest, User>();
        }
    }
}
