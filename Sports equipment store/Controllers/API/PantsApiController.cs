using Sports_equipment_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sports_equipment_store.Controllers.API
{
    public class PantsApiController : ApiController
    {
        public SportsEquipmentStoreDataContext dataContext = new SportsEquipmentStoreDataContext();

        // GET: api/PantsApi
        public IHttpActionResult Get()
        {
            try
            {
                List<Clothing> clothingsPants = dataContext.Clothings.Where(item => item.TypeGarment.ToUpper() == "PANTS").ToList();
                return Ok(new { clothingsPants });
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }

        // GET: api/PantsApi/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Clothing Clothing = dataContext.Clothings.Single(item => item.Id == id);
                return Ok(new { Clothing });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/PantsApi
        public IHttpActionResult Post([FromBody] Clothing Pants)
        {
            try
            {
                dataContext.Clothings.InsertOnSubmit(Pants);
                dataContext.SubmitChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/PantsApi/5
        public IHttpActionResult Put(int id, [FromBody] Clothing clothing)
        {
            try
            {
                Clothing singlePant = dataContext.Clothings.Single(item => item.Id == id);
                if (singlePant != null)
                {
                    singlePant.TypeGarment = clothing.TypeGarment;
                    singlePant.Company = clothing.Company;
                    singlePant.Model = clothing.Model;
                    singlePant.Price = clothing.Price;
                    singlePant.Amount = clothing.Amount;
                    singlePant.IsShort = clothing.IsShort;
                    singlePant.ImageLink_ = clothing.ImageLink_;
                    dataContext.SubmitChanges();
                    return Ok("This item has been updated");
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/PantsApi/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Clothing SinglePant = dataContext.Clothings.Single(item => item.Id == id);
                if (SinglePant != null)
                {
                    dataContext.Clothings.DeleteOnSubmit(SinglePant);
                    dataContext.SubmitChanges();
                    return Ok("This item has been deleted");
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
