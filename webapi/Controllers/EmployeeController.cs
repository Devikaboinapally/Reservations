using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;
using WebApp.rep;

namespace WebApp.Controllers
{
    public class EmployeeController : ApiController
    {
        public readonly Interface1 Emp;
        public EmployeeController() { }
        public EmployeeController(Interface1 Emp)
        {
            this.Emp = Emp;
        }
        [Route("api/Employee/GetEmpDetails")]
        [HttpGet]
        public IHttpActionResult GetEmpDetails()
        {
            var abc = Emp.GetEmpDetails();
            if (abc == null)
            {
                return NotFound();
            }
            return Ok(abc);
        }

        [Route("api/Employee/InsertEmpDetails")]
        [HttpPost]
        public IHttpActionResult InsertEmpDetails(Class1 empid)
        {
            var abc = Emp.InsertEmpDetails(empid);
            if(abc== "inserted")
            {
                return Ok(abc);
            }
            return NotFound();
        }

        [Route("api/Employee/DeleteEmpDetails/{empid}")]
        [HttpDelete]
        public IHttpActionResult DeleteEmpDetails(int empid)
        {
            var abc = Emp.DeleteEmpDetails(empid);
            if (abc != null)
            {
                return Ok(abc);

            }
            return NotFound();
        }
        [Route("api/Employee/UpdateEmpDetails")]
        [HttpPost]
        public IHttpActionResult UpdateEmpDetails(Class1 empid)
        {
            var abc = Emp.UpdateEmpDetails(empid);
            if(abc != null)
            {
                return Ok("Updated");
            }
            return NotFound();

        } 
        [Route("api/Employee/BulkInsertEmpDetails")]

        [HttpPost]
       public IHttpActionResult PostAll(List<Class1> em)
        {
            var ret = Emp.BulkInsertEmpDetails(em);
            if(ret== "Bulk inserted")
            {
                return Ok(ret);
            }
            return NotFound();
        }
        [Route("api/Employee/BulkDeleteEmpDetails")]
        [HttpPost]
        public HttpResponseMessage BulkDeleteEmpDetails(List<Class1>em)
        {
            var abc = Emp.BulkDeleteEmpDetails(em);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }



        [Route("api/Employee/GetEmpDetailsId/{empid}")]
        [HttpGet]
        public IHttpActionResult GetEmpDetailsId(int empid)
        {
            var abc = Emp.GetEmpDetailsId(empid);
            if (abc == null)
            {
                return NotFound();
            }
            return Ok(abc);
        }
    }
}

        
         







