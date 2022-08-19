using Existencias.Context;
using Existencias.Entities;
using Existencias.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Existencias.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class Existencias : ControllerBase

    {
        Functions functions;
        Respuesta res;
        private readonly AppDbContext context;
        public Existencias(AppDbContext context)
        {
            this.context = context;
            functions = new Functions(context);
        }

        // GET: api/<Existencias>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Existencias>/5
        [HttpGet("{id}/{WhsCode}/{type}")]
        public Respuesta Get(string id,string WhsCode, string type)
        {

            res = functions.BuscarExistencias(id, WhsCode,type);

            return res;
        }

        // POST api/<Existencias>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Existencias>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Existencias>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
