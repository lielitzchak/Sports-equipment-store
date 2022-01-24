using Sports_equipment_store.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Sports_equipment_store.Controllers.API
{
    public class ShoeController : ApiController
    {
        public ShoesDataContextDataContext dataContext = new ShoesDataContextDataContext();
        // GET: api/Shoe
        public IHttpActionResult Get()
        {
            try
            {
                Table<Shoe> shoes = dataContext.Shoes;
                return Ok(new { shoes });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // GET: api/Shoe/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Shoe SingleShoe = dataContext.Shoes.Single(item => item.Id == id);
                if (SingleShoe != null)
                {
                    return Ok(SingleShoe);

                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //// POST: api/Shoe
        public async Task<IHttpActionResult> Post([FromBody] Shoe Shoe)
        {
            try
            {
                //HospitalDB.Patients.Add(patient);
                //await HospitalDB.SaveChangesAsync();
                //return Ok("saved");


                dataContext.Shoes.Add(Shoe);
                await dataContext.asyn
                //shoe.Add(shoe);
                dataContext.SubmitChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //// PUT: api/Shoe/5
        public IHttpActionResult Put(int id, [FromBody] string value)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //// DELETE: api/Shoe/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
