using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication5.Models;

namespace WebApplication5.Controllers

{
    // [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        static List<Country> countrylist = new List<Country>()
        {
            new Country{Id=1, Cname="Kamal",Capital="Pune"},
            new Country{Id=2, Cname="Prem",Capital="Hyderabad"},
            new Country{Id=3, Cname="Shivam",Capital="Bangalore"},

        };
        // [HttpGet]
        // [Route("Countrydetails")]

        public IEnumerable<Country> Get()
        {
            return countrylist;
        }
    }
}

           /* [HttpGet]
            [Route("personlist")]

            public HttpResponseMessage GetPersonList()
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personlist);
                return response;
            }

            [HttpGet]
            [Route("p")]
            public HttpResponseMessage GetP(int pid)
            {
                var person = personlist.Find(x => x.Id == pid);

                if (person == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, pid);
                }
                return Request.CreateResponse(HttpStatusCode.OK, person);
            }


            //Post

            public Person Post([FromBody] Person p)
            {
                personlist.Add(p);
                return p;
            }

            //put
            public IEnumerable<Person> Put(int id, [FromBody] Person person)
            {
                personlist[id - 1] = person;
                return personlist;
            }

            [HttpGet]
            [Route("ById")]
            public IHttpActionResult GetID(int pid)
            {
                var person = personlist.Find(x => x.Id == pid);

                if (person == null)
                {
                    return NotFound();
                }
                return Ok(person);
            }

            [HttpGet]
            [Route("Name")]
            public IHttpActionResult GetName(int pid)
            {
                string person = personlist.Where(x => x.Id == pid).SingleOrDefault()?.Name;

                if (person == null)
                {
                    return NotFound();
                }
                return Ok(person);
                //return new MyResult(person, Request);


            }
        }
           }
    

        */