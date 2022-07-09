﻿using BookStoreNew.Models.Models;
using BookStoreNew.Models.ViewModels;
using BookStoreNew.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreNew.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserRepository _repository = new UserRepository();
        RoleRepository _role = new RoleRepository();
        [HttpGet]
        [Route("list")]
        public IActionResult GetUsers(int pageIndex = 1, int pageSize = 10, string keyword = "")
        {
            ListResponse<User> response = _repository.GetUsers(pageIndex, pageSize, keyword);
            ListResponse<UserModel> users = new ListResponse<UserModel>()
            {
                Results = response.Results.Select(u => new UserModel(u)),
                TotalRecords = response.TotalRecords,
            };

            return Ok(users);
        }

        [HttpGet]
        [Route("Roles")]
        public IActionResult GetAllRoles()
        {
            var roles = _role.GetRoles();
            return Ok(roles);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser(int id)
        {
            User user = _repository.GetUser(id);
            if (user == null)
                return NotFound();

            UserModel userModel = new UserModel(user);
            return Ok(userModel);
        }

        [HttpPut]
        [Route("update")]
        public IActionResult UpdateUser(UserModel model)
        {
            if (model != null)
                return BadRequest();

            User user = new User()
            {
                Id = model.Id,
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Email = model.Email,
                Roleid = model.Roleid,
            };

            user = _repository.UpdateUser(user);
            return Ok(user);
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteUser(int id)
        {
            bool isDeleted = _repository.DeleteUser(id);
            return Ok(isDeleted);
        }
    }
}
