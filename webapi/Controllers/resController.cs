using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApp.Models;
using WebApp.rep;

namespace WebApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class resController : ApiController
    {
        public readonly resinterface Res;
        public resController() { }
        public resController(resinterface Res)
        {
            this.Res = Res;
        }
        [Route("api/res/GetResDetails")]
        [HttpGet]
        public IHttpActionResult GetResDetails()
        {
            var abc = Res.GetResDetails();
            if (abc == null)
            {
                return NotFound();
            }
            return Ok(abc);
        }
        [Route("api/res/InsertResDetails")]
        [HttpPost]
        public HttpResponseMessage InsertResDetails(Class2 Sl_No)
        {
            var abc = Res.InsertResDetails(Sl_No);
           return Request.CreateResponse(HttpStatusCode.OK, abc);   
         
        }
        [Route("api/res/DeleteResDetails/{Sl_No}")]
        [HttpDelete]
        public IHttpActionResult DeleteResDetails(int Sl_No)
        {
            var abc = Res.DeleteResDetails(Sl_No);
            if (abc != null)
            {
                return Ok(abc);

            }
            return NotFound();
        }
        [Route("api/Res/UpdateResDetails")]
        [HttpPost]
        public IHttpActionResult UpdateResDetails(Class2 Sl_No)
        {
            var abc = Res.UpdateResDetails(Sl_No);
            if (abc != null)
            {
                return Ok("Updated");
            }
            return NotFound();

        }

    }
}
