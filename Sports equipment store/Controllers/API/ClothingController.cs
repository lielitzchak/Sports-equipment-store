using Sports_equipment_store.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sports_equipment_store.Controllers.API
{
    public class ClothingController : Controller
    {
        // GET: Clothing
        string stringConnection = "Data Source=LIEL-ITZCHAK;Initial Catalog=SportsEquipmentSoreDB;Integrated Security=True;Pooling=False";
        ShoesDataContextDataContext dataContext = new ShoesDataContextDataContext();
        // GET: Shoes
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult ShowClothing()
        {
            try
            {
                List<Clothing> clothing = dataContext.Clothings.ToList();
                if (clothing != null)
                {
                    return View(clothing);

                }
                return View("no data");

            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }
        public ActionResult ManagerClickClothing()
        {
            try
            {
                List<Clothing> clothing = dataContext.Clothings.ToList();
                return View(clothing);

            }
            catch (Exception ex)
            {
                return View(ex);
            }


        }
        public ActionResult OnlyLongShirt()
        {
            try
            {
                string shirt = "Shirt".ToUpper();
                List<Clothing> clothing = new List<Clothing>();
                foreach (Clothing singleBeged in dataContext.Clothings)
                {
                    if (singleBeged.TypeGarment.ToUpper() == shirt)
                    {
                        if (singleBeged.IsShort == false)
                        {
                            clothing.Add(singleBeged);
                        }
                    }
                }
                if (clothing == null)
                {
                    return View("not found");
                }
                return View(clothing);
            }
            catch (SqlException ex)
            {
                return View(ex);
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }
        public ActionResult OnlyShortShirts()
        {
            try
            {
                string shirt = "Shirt".ToUpper();
                List<Clothing> clothing = new List<Clothing>();
                foreach (Clothing singleBeged in dataContext.Clothings)
                {
                    if (singleBeged.TypeGarment.ToUpper() == shirt)
                    {
                        if (singleBeged.IsShort == true)
                        {
                            clothing.Add(singleBeged);
                        }
                    }
                }
                if (clothing == null)
                {
                    return View("not found");
                }
                return View(clothing);
            }
            catch (SqlException ex)
            {
                return View(ex);
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }
        public ActionResult OnlyDriftShirts()
        {
            try
            {
                string shirt = "Shirt".ToUpper();
                List<Clothing> clothing = new List<Clothing>();
                foreach (Clothing singleBeged in dataContext.Clothings)
                {
                    if (singleBeged.TypeGarment.ToUpper() == shirt)
                    {
                        if (singleBeged.IsDreyfit == true)
                        {
                            clothing.Add(singleBeged);
                        }
                    }
                }
                if (clothing == null)
                {
                    return View("not found");
                }
                return View(clothing);
            }
            catch (SqlException ex)
            {
                return View(ex);
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }
    }
}