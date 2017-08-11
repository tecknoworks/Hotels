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
            string name = context.Request.QueryString["name"];
            //save into the database 
            string fileName = name;
            context.Response.Clear();
            //context.Response.ContentType = "application/pdf";
            context.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
            context.Response.TransmitFile(HttpContext.Current.Server.MapPath("~/App_Data/"+ name ));
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