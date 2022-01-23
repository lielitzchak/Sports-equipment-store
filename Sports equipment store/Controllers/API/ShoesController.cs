using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sports_equipment_store.Models;

namespace Sports_equipment_store.Controllers.API
{
    public class ShoesController : Controller
    {
        string stringConnection = "Data Source=LIEL-ITZCHAK;Initial Catalog=SportsEquipmentSoreDB;Integrated Security=True;Pooling=False";
        ShoesDataContextDataContext dataContext = new ShoesDataContextDataContext();
        // GET: Shoes
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult ShowShoes()
        {
            try
            {
                List<Shoe> Shoes = dataContext.Shoes.ToList();

                return View(Shoes);

            }
            catch (Exception ex)
            {
                return View(ex);
            }



        }

    }
}