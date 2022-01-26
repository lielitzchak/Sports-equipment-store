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

            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.TypeGarment.ToUpper() == pantsType).ToList();
            ViewBag.AllPants = pantsList;
            return View();
        }

        public ActionResult ManagerClick()
        {
            List<Clothing> pantsTable = dataContext.Clothings.Where(item => item.TypeGarment.ToUpper() == pantsType).ToList();

            return View(pantsTable);


        }

        public ActionResult OnlyLongPants()
        {
            try
            {
                List<Clothing> longPants = dataContext.Clothings.
                        Where(singleBeged => singleBeged.TypeGarment.ToUpper() == pantsType).ToList();

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
        //public ActionResult OnlyShortsPants()
        //{
        //    List<clothing> onlyPantsShirts = dbCloting.clothings.Where(item => item.clothingType == "Pants" & item.isClothingShort == true).ToList();

        //    ViewBag.onlyShortPants = onlyPantsShirts;
        //    return View();

        //    //return Content("<script language='javascript' type='text/javascript'>alert('Sorry item not found, Going to all pants');</script>");
        //    //return RedirectToAction("ShowPantsall") ;


        //}

        //public ActionResult GetOnlyDryFitPants()

        //{
        //    List<clothing> onlyDryFitPants = dbCloting.clothings.Where(item => item.clothingType == "Pants" & item.isClothingDrifit == true).ToList();

        //    ViewBag.onlyDryFitPants = onlyDryFitPants;
        //    return View();

        //}

        //public ActionResult SortByPricePants()
        //{
        //    List<clothing> listOfShirts = dbCloting.clothings.Where(item => item.clothingType == "Pants").OrderBy(clothe => clothe.clothingPrice).ToList();

        //    ViewBag.sortByPrice = listOfShirts;
        //    return View();

        //return RedirectToAction("ShowPantsall");

        //}
    }
}