using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactDAL;
using ContactLibrary;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace ContactAPI.Controllers
{
    [EnableCors("*","*","*")]
    public class PersonController : ApiController
    {
        PersonCrud crud = new PersonCrud();
        //READ
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var person= crud.GetPersons();
            return person;
        }
        //ADD Person
        [HttpPost]
        public IHttpActionResult Post([FromBody]Person p)
        {
            if (p != null)
            {
                // Make a call to CRUD Method to insert in to DB

                return Ok("Person Added Successfully!!");
            }
            else
            {
                return BadRequest();
            }
        }
        // to do  Put

        // to do Delete

    }
}
