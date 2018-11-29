using System.Threading.Tasks;
using ApiDesign.Dtos;
using ApiDesign.Models;
using Microsoft.AspNetCore.Identity;

namespace ApiDesign.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(UserForRegisterDto user);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}