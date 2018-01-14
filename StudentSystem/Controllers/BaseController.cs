using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentSystemDbContext.Data;

namespace StudentSystemDbContext.Controllers
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