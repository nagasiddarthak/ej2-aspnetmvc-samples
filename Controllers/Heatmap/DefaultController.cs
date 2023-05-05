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


namespace EJ2MVCSampleBrowser.Controllers.Heatmap
{
    public partial class HeatmapController : Controller
    {
        // GET: Default
        public ActionResult Default()
        {
            ViewBag.textStyle = new
            {
                size= "15px",
                fontWeight= "500",
                fontStyle= "Normal",
                fontFamily= "Segoe UI"
            };
            string[] xlabels = new string[12] { "Nancy", "Andrew", "Janet", "Margaret", "Steven", "Michael", "Robert", "Laura", "Anne", "Paul", "Karin", "Mario" };
            ViewBag.xLabels = xlabels;
            string[] yLabels = new string[6] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            ViewBag.yLabels = yLabels;
            ViewBag.dataSource = GetDataSource();
            return View();
        }
        private int[,] GetDataSource()
        {
            int[,] data = new int[12,6];
            Random random = new Random();
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                  
                    data[x, y] = random.Next(0, 100);
                }
            }
            return data;
        }

    }
}