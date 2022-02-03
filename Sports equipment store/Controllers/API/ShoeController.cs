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
        static string StringConnection = "Data Source=LIEL-ITZCHAK;Initial Catalog=SportsEquipmentSoreDB;Integrated Security=True;Pooling=False";
        public SportsEquipmentStoreDataContext shoesDB = new SportsEquipmentStoreDataContext(StringConnection);
        // GET: api/Shoe
        public IHttpActionResult Get()
        {
            try
            {
                Table<Shoe> shoes = shoesDB.Shoes;
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
                Shoe SingleShoe = shoesDB.Shoes.Single(item => item.Id == id);
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
        public IHttpActionResult Post([FromBody] Shoe shoe)
        {
            try
            {
                shoesDB.Shoes.InsertOnSubmit(shoe);
                shoesDB.SubmitChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //// PUT: api/Shoe/5
        public IHttpActionResult Put(int id, [FromBody] Shoe shoe)
        {
            try
            {
                Shoe SingleShoe = shoesDB.Shoes.Single(item => item.Id == id);
                if (SingleShoe != null)
                {
                    SingleShoe.shoeType = shoe.shoeType;
                    SingleShoe.company = shoe.company;
                    SingleShoe.model = shoe.model;
                    SingleShoe.price = shoe.price;
                    SingleShoe.amount = shoe.amount;
                    SingleShoe.isSale = shoe.isSale;
                    SingleShoe.LinkToImage = shoe.LinkToImage;
                    shoesDB.SubmitChanges();
                    return Ok("This item has been updated");
                }
                return NotFound();
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
                Shoe SingleShoe = shoesDB.Shoes.Single(item => item.Id == id);
                if (SingleShoe != null)
                {
                    shoesDB.Shoes.DeleteOnSubmit(SingleShoe);
                    shoesDB.SubmitChanges();
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
