﻿namespace System.Web.Mvc {
    using System;
    using System.Web.Routing;

    public class AjaxHelper {

        public AjaxHelper(ViewContext viewContext, IViewDataContainer viewDataContainer)
            : this(viewContext, viewDataContainer, RouteTable.Routes) {
        }

        public AjaxHelper(ViewContext viewContext, IViewDataContainer viewDataContainer, RouteCollection routeCollection) {
            if (viewContext == null) {
                throw new ArgumentNullException("viewContext");
            }
            if (viewDataContainer == null) {
                throw new ArgumentNullException("viewDataContainer");
            }
            if (routeCollection == null) {
                throw new ArgumentNullException("routeCollection");
            }
            ViewContext = viewContext;
            ViewDataContainer = viewDataContainer;
            RouteCollection = routeCollection;
        }

        public RouteCollection RouteCollection {
            get;
            private set;
        }

        public ViewContext ViewContext {
            get;
            private set;
        }

        public ViewDataDictionary ViewData {
            get {
                return ViewDataContainer.ViewData;
            }
        }

        public IViewDataContainer ViewDataContainer {
            get;
            private set;
        }
    }
}
