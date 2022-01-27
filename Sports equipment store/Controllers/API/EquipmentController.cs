using Sports_equipment_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//using System.Data.SqlClient;

namespace Sports_equipment_store.Controllers.API
{
    public class EquipmentController : Controller
    {
        SportsEquipmentStoreDataContext SportsEquipmentDB = new SportsEquipmentStoreDataContext();
        // GET: Equipment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllEquipment()
        {
            List<SportsEquipment> sportsEquipment = SportsEquipmentDB.SportsEquipments.ToList();
            if (sportsEquipment.Count > 0)
            {
                return View(sportsEquipment);
            }
            return View("empty");
        }

        public ActionResult ManagerClick()
        {
            try
            {

                List<SportsEquipment> sportsEquipment = SportsEquipmentDB.SportsEquipments.ToList();
                if (sportsEquipment.Count > 0)
                {
                    return View(sportsEquipment);
                }
                return View("empty");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        public ActionResult FootballEquipment()
        {
            try
            {

                List<SportsEquipment> sportsEquipment = SportsEquipmentDB.SportsEquipments.
                        Where(singleBeged => singleBeged.sportType.ToUpper() == "FOOTBALL").ToList();
                if (sportsEquipment.Count > 0)
                {
                    return View(sportsEquipment);
                }
                return View("empty");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

    }
}