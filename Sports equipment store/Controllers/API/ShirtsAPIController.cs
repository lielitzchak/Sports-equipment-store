using Sports_equipment_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sports_equipment_store.Controllers.API
{
    public class ShirtsAPIController : ApiController
    {
        static public SportsEquipmentStoreDataContext dataContext = new SportsEquipmentStoreDataContext();
        private static readonly List<Clothing> clothingsShirts = dataContext.Clothings.Where(item => item.TypeGarment.ToUpper() == "SHIRT").ToList();

        // GET: api/ShirtsAPI
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(new { clothingsShirts });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/ShirtsAPI/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Clothing singleShirt = dataContext.Clothings.Single(item => item.Id == id);
                return Ok(new { singleShirt });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/ShirtsAPI
        public IHttpActionResult Post([FromBody] Clothing shirt)
        {
            try
            {
                dataContext.Clothings.InsertOnSubmit(shirt);
                dataContext.SubmitChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/ShirtsAPI/5
        public IHttpActionResult Put(int id, [FromBody] Clothing newShirt)
        {
            try
            {
                Clothing singleShirt = dataContext.Clothings.Single(item => item.Id == id);
                if (singleShirt != null)
                {
                    singleShirt.TypeGarment = newShirt.TypeGarment;
                    singleShirt.Company = newShirt.Company;
                    singleShirt.Model = newShirt.Model;
                    singleShirt.Price = newShirt.Price;
                    singleShirt.Amount = newShirt.Amount;
                    singleShirt.IsShort = newShirt.IsShort;
                    singleShirt.ImageLink_ = newShirt.ImageLink_;
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


        // DELETE: api/ShirtsAPI/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Clothing singleShirt = dataContext.Clothings.Single(item => item.Id == id);
                if (singleShirt != null)
                {
                    dataContext.Clothings.DeleteOnSubmit(singleShirt);
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
