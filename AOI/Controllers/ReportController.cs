using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AOI.Controllers
{
    /*
     *  This controller is based on the MvcMusicStore application in place of StoreController
     *  This controller will support three scenarios:
     *  - (in place of music genre) The index page lists all Work Order numbers  - showing false-true defect result summary, full scan time
     *  - (in place of albums for a genre) Clicking a Work Order leads to a browse page that lists all Serial Numbers much the way the spreadsheet reports is now
     *  - (in place of clicking an album) Clicking a Serial Number enables the Inspection Update entry for the PCB
     *  
     *  Convention change summary:
     *  MvcMusicStore = AOI
     *  Store = Report
     *  Genre = WorkOrder
     *  Album = SerialNum
     */
    public class ReportController : Controller
    {
        //
        // GET: /Report/

        public ActionResult Index()
        {
            return View();
        }

    }
}
