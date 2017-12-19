using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SkillSelectRestfulService.Controllers
{
    public class SkillSelectController : ApiController
    {
        // GET: api/SkillSelect
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SkillSelect/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SkillSelect
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SkillSelect/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SkillSelect/5
        public void Delete(int id)
        {
        }
    }
}
