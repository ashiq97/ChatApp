using AutoMapper;
using ChattingApp.Data;
using ChattingApp.DTOs;
using ChattingApp.Entities;
using ChattingApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChattingApp.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userrepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository,IMapper mapper)
        {
            _userrepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsersAsync()
        {
            var users = await _userrepository.GetUsersAsync();
            var userToReturn = _mapper.Map<IEnumerable<MemberDto>>(users);
            return Ok(userToReturn);
        }


        // api/users/3
        [HttpGet("{username}")]  
        public async Task<ActionResult<MemberDto>> GetUserAsync(string username)
        {
            var user = await _userrepository.GetUserByNameAsync(username);
            return _mapper.Map<MemberDto>(user);
        }
    }
}
