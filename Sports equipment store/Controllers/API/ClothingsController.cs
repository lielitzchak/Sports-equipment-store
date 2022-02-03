using Sports_equipment_store.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sports_equipment_store.Controllers.API
{
    public class ClothingsController : ApiController
    {
        static string StringConnection = "Data Source=LIEL-ITZCHAK;Initial Catalog=SportsEquipmentSoreDB;Integrated Security=True;Pooling=False";
        public SportsEquipmentStoreDataContext clothing = new SportsEquipmentStoreDataContext(StringConnection);

        //GET: api/Clothings
        public IHttpActionResult Get()
        {
            try
            {
                List<Clothing> allClothing = clothing.Clothings.ToList();
                return Ok(new { allClothing });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        // GET: api/Clothings/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Clothings
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Clothings/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Clothings/5
        public void Delete(int id)
        {
        }
    }
}
