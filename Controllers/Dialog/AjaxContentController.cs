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
using Syncfusion.EJ2.Popups;

namespace EJ2MVCSampleBrowser.Controllers.Dialog
{
    public partial class DialogController : Controller
    {
        // GET: AjaxContent
        public ActionResult AjaxContent()
        {
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new AjaxButtonModel() { content = "More Details", isPrimary = true } });
            ViewBag.AjaxButton = buttons;
            return View();
        }
    }
    public class AjaxButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}