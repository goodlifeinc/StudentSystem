using StudentSystemDbContext.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentSystem.Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
            : this(new StudentSystemData())
        {
        }

        public BaseController(IStudentSystemData data)
        {
            this.Data = data;
        }

        public IStudentSystemData Data { get; private set; }
    }
}