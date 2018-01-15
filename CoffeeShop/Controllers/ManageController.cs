using System;
using System.IO;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class ManageController : Controller
    {        //
        // GET: /Manage/Index
        public async Task<ActionResult> Index(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
                : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
                : message == ManageMessageId.SetTwoFactorSuccess ? "Your two-factor authentication provider has been set."
                : message == ManageMessageId.Error ? "An error has occurred."
                : message == ManageMessageId.AddPhoneSuccess ? "Your phone number was added."
                : message == ManageMessageId.RemovePhoneSuccess ? "Your phone number was removed."
                : "";
            
            return View("dashboard");
        }

        public ActionResult Modules()
        {
            return View();
        }

        public ActionResult Chucdanhnguoidung()
        {
            return View();
        }

        public ActionResult Grantpermisstion()
        {
            return View();
        }

        public ActionResult Adminmanage()
        {
            ViewBag.Title = "Quản trị viên";
            return View();
        }

        public ActionResult Usermanage()
        {
            ViewBag.Title = "Quản lý người dùng";
            return View("Adminmanage");
        }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult Articles()
        {
            return View();
        }

        public ActionResult Editarticle()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult Editproduct()
        {
            return View();
        }

        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult Orderview()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Uploadimage(int? pid)
        {
            bool isSavedSuccessfully = true;
            string FileName = "";
            string fName = "";
            try
            {
                foreach (string fileName in Request.Files)
                {
                    HttpPostedFileBase file = Request.Files[fileName];
                    //Save file content goes here
                    fName = file.FileName;
                    if (file != null && file.ContentLength > 0)
                    {
                        var originalDirectory = new DirectoryInfo(string.Format("{0}ImagesUpload", Server.MapPath(@"\")));
                        string pathString = Path.Combine(originalDirectory.ToString(), "ImagesProduct");
                        var fileName1 = Path.GetFileName(file.FileName);
                        bool isExists = Directory.Exists(pathString);
                        if (!isExists) Directory.CreateDirectory(pathString);
                        var path = string.Format("{0}\\{1}", pathString, file.FileName);
                        file.SaveAs(path);
                    }

                }
            }
            catch (Exception ex)
            {
                isSavedSuccessfully = false;
            }

            if (isSavedSuccessfully)
            {
                return Json(new { success = true, Message = fName });
            }
            else
            {
                return Json(new { success = false, Message = "Error in saving file" });
            }
        }

        //
        // GET: /Manage/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }
        
        #region Helpers
        
        public enum ManageMessageId
        {
            AddPhoneSuccess,
            ChangePasswordSuccess,
            SetTwoFactorSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            RemovePhoneSuccess,
            Error
        }

        #endregion
    }
}