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
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.BulletChart
{
    public partial class BulletChartController : Controller
    {
        // GET: Dot
        public ActionResult Dot()
        {
            List<DotBulletData> bulletData1 = new List<DotBulletData>
            {
                new DotBulletData { value = 270, target = 250}     
            };
            ViewBag.dataSource = bulletData1;
            ViewBag.data = new String[] {"Rect", "Dot"};
            return View();
        }
        public class DotBulletData
        {           
            public double value;
            public double target;
        }
    }
}