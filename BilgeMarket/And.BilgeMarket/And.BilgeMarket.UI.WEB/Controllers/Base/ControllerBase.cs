using And.BilgeMarket.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace And.BilgeMarket.UI.WEB
{
    public class AndControllerBase : Controller
    {
        public bool IsLogin { get;private set; }
        public int LoginUserID { get;private set; }
        public User LoginUserEntity { get; private set; }
        protected override void Initialize(RequestContext requestContext)
        {
            if (requestContext.HttpContext.Session["LoginUserID"] !=null )
            {

                IsLogin = true;
                LoginUserID = (int)requestContext.HttpContext.Session["LoginUserID"];
                LoginUserEntity=(Core.Model.Entity.User)requestContext.HttpContext.Session["LoginUser"];
    }
            base.Initialize(requestContext);
        }
    }
}