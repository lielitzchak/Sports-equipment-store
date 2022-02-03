using Sports_equipment_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sports_equipment_store.Controllers.API
{
    public class EquipmentsApiController : ApiController
    {
        public SportsEquipmentStoreDataContext dataContext = new SportsEquipmentStoreDataContext();
        // GET: api/EquipmentsApi
        public IHttpActionResult Get()
        {
            try
            {
                List<SportsEquipment> equipments = dataContext.SportsEquipments.ToList();
                return Ok(new { equipments });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // GET: api/EquipmentsApi/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                SportsEquipment equipments = dataContext.SportsEquipments.Single(item => item.Id == id);
                return Ok(new { equipments });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST: api/EquipmentsApi
        public IHttpActionResult Post([FromBody] SportsEquipment equipment)
        {
            try
            {
                dataContext.SportsEquipments.InsertOnSubmit(equipment);
                dataContext.SubmitChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/EquipmentsApi/5
        public IHttpActionResult Put(int id, [FromBody] SportsEquipment equipment)
        {

            try
            {

                SportsEquipment singleEquipment = dataContext.SportsEquipments.Single(item => item.Id == id);
                if (singleEquipment != null)
                {

                    singleEquipment.sportType = equipment.sportType;
                    singleEquipment.company = equipment.company;
                    singleEquipment.price = equipment.price;
                    singleEquipment.Amount = equipment.Amount;
                    singleEquipment.groupID = equipment.groupID;
                    singleEquipment.picture = equipment.picture;
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


        // DELETE: api/EquipmentsApi/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                SportsEquipment singleEquipment = dataContext.SportsEquipments.Single(item => item.Id == id);
                if (singleEquipment != null)
                {
                    dataContext.SportsEquipments.DeleteOnSubmit(singleEquipment);
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
