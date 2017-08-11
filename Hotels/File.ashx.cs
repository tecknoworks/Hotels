using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotels
{
    /// <summary>
    /// Summary description for File
    /// </summary>
    public class File : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string id = context.Request.QueryString["id"];
            //save into the database 
            string fileName = "hotel1.jpg";
            context.Response.Clear();
            //context.Response.ContentType = "application/pdf";
            context.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
            context.Response.TransmitFile(HttpContext.Current.Server.MapPath("~/App_Data/hotel1.jpg"));
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}