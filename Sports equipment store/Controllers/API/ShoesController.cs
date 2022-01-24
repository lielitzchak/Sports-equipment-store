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
                List<Shoe> shoes = dataContext.Shoes.ToList();
                return View(shoes);

            }
            catch (Exception ex)
            {
                return View(ex);
            }



        }
        public ActionResult ManagerClick()
        {
            try
            {
                List<Shoe> shoes = dataContext.Shoes.ToList();
                return View(shoes);

            }
            catch (Exception ex)
            {
                return View(ex);
            }


        }
        public ActionResult OnlySale()
        {
            try
            {
                List<Shoe> shoes = new List<Shoe>();
                foreach (Shoe sho in dataContext.Shoes)
                {
                    if (sho.isSale == true)
                    {
                        shoes.Add(sho);
                    } 
                }
                return View(shoes);
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }
    }
}