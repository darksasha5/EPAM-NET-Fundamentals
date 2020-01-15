﻿using ClassLibrary.BL.Interfaces;
using ClassLibrary.BL.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworkController : BaseWithIncludeController<Homework>
    {
        public HomeworkController(IHomeworkRepository repository) : base(repository) { }
    }
}