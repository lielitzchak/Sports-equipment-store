using Sports_equipment_store.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sports_equipment_store.Controllers.API
{
    public class PantsController : Controller
    {
        public static string pantsType = "pants".ToUpper();
        ShoesDataContextDataContext dataContext = new ShoesDataContextDataContext();
        // GET: Pants
        public ActionResult ShowAllPants()
        {
            try
            {
                List<Clothing> pantsList = dataContext.Clothings.Where(item => item.TypeGarment.ToUpper() == pantsType).ToList();
                ViewBag.AllPants = pantsList;
                return View();
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        public ActionResult ManagerClick()
        {
            try
            {
                List<Clothing> pantsTable = dataContext.Clothings.Where(item => item.TypeGarment.ToUpper() == pantsType).ToList();

                return View(pantsTable);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }


        }

        public ActionResult OnlyLongPants()
        {
            try
            {
                List<Clothing> longPants = dataContext.Clothings.
                        Where(singleBeged => singleBeged.TypeGarment.ToUpper() == pantsType && singleBeged.IsShort == false).ToList();

                return View(longPants);
            }
            catch (SqlException ex)
            {
                return View(ex.Message);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
        public ActionResult OnlyShorts()
        {
            try
            {
                List<Clothing> pantsShort = dataContext.Clothings.Where(item => item.TypeGarment.ToUpper() == pantsType & item.IsShort == true).ToList();
                if (pantsShort != null)
                {
                    return View(pantsShort);
                }
                return View("empty");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        public ActionResult GetOnlyDryFitPants()

        {
            try
            {
                List<Clothing> onlyDryFitPants = dataContext.Clothings.Where(item => item.TypeGarment.ToUpper() == pantsType & item.IsDreyfit == true).ToList();
                if (onlyDryFitPants != null)
                {
                    return View(onlyDryFitPants);
                }
                return View("empty");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
        public ActionResult SortPriceLowHigh()
        {
            try
            {
                List<Clothing> listOfShirts = dataContext.Clothings.Where(item => item.TypeGarment.ToUpper() == pantsType).OrderBy(clothe => clothe.Price).ToList();
                if (listOfShirts != null)
                {
                    return View(listOfShirts);
                }
                return View();
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }
    }
}