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
using Syncfusion.EJ2.Navigations;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.TreeView
{
    public partial class TreeViewController : Controller
    {
        TreeViewFieldsSettings iconFields = new TreeViewFieldsSettings();
      
        public ActionResult IconsandImages()
        {
            TreeviewImageIcons treeviewIcon = new TreeviewImageIcons();
            iconFields.DataSource = treeviewIcon.getTreeviewImageIconsModel();           
            iconFields.Id = "NodeId";
            iconFields.Text = "NodeText";
            iconFields.IconCss = "Icon";
            iconFields.Child = "NodeChild";
            iconFields.Expanded = "Expanded";
            ViewBag.iconFields = iconFields;
            return View();
       
        }
        
    }


}