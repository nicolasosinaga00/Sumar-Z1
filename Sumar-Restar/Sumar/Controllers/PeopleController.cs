﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sumar.Models;

namespace Sumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public Person listar()
        {
            Person person = new Person()
            {
                PersonId = 1,
                Name = "Nicolas Osinaga"
            };
            return person;
        }
    }
}
