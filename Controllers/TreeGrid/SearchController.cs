#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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

namespace EJ2MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        public ActionResult Search()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewBag.datasource = treeData;

            List<Object> dropData = new List<object>() {
                new { id = "Parent", mode = "Parent" },
                new { id = "Child", mode = "Child" },
                new { id = "Both", mode = "Both" },
                new { id = "None", mode = "None" }
            };
            ViewBag.dropdata = dropData;
            return View();
        }
    }
}