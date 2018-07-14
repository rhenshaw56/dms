using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetDMS.Data;
using dotnetDMS.Models;
using System.Net.Http;

namespace dotnetDMS.Controllers
{
    [Route("api/[controller]")]
    public class DocumentController : Controller
    {
        private DmsContext _context;
        public DocumentController()
        {
            _context = new DmsContext();
        }
        // GET api/document
        [HttpGet]
        public IEnumerable<Documents> Get()
        {

            return _context.Documents.AsEnumerable();
        }

        // GET api/document/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "doc";
        }

        // POST api/document
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/document/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/document/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
