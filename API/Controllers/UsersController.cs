using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    //  /api/users
    [Authorize]
    public class UsersController(IUserRepository userRepository) : BaseApiController
    {
        //[AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            //var users = await context.Users.ToListAsync();
            var users = await userRepository.GetMembersAsync();
            return Ok(users);
        }

        // [Authorize]
        // [HttpGet("{id}")]   //  /api/users/3
        // public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(int id)
        // {
        //     var users = await context.Users.ToListAsync();
        //     return users;
        // }

        //[Authorize]
        [HttpGet("{username}")]   //  /api/users/3
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
            var user = await userRepository.GetMemberAsync(username);

            if (user == null)
                return NotFound();

            return user;
        }
    }
}
