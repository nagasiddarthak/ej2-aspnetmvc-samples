#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttChartController : Controller
    {
        // GET: Filtering
        public ActionResult Filtering()
        {
            ViewBag.DataSource = GanttData.FilteredData();
            List<Object> typedropData = new List<object>() {
                new { id = "Menu", type = "Menu" },
                new { id = "Excel", type = "Excel" }
            };
            ViewBag.typedropdata = typedropData;
            List<Object> modedropData = new List<object>() {
                new { id = "Parent", type = "Parent" },
                new { id = "Child", type = "Child" },
                 new { id = "Both", type = "Both" },
                  new { id = "None", type = "None" }
            };
            ViewBag.modedropData = modedropData;
            return View();
        }
    }
}