using System;
using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;

namespace StudentProject.Controllers
{
    [ApiController]
    [Route("[controller]s")]

    public class AdminController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<Admin> GetAdmins()
        {
            return;

        }

        [HttpGet("{id}")]
        public IActionResult<Admin> GetAdmin(int id)
        {

        }

        [HttpDelete()]





    }
}
