using NorthwindModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace T264297 {
    public class NorthwindModel {
        public IEnumerable<Category> Categories()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            NorthwindEntities context = new NorthwindEntities(new Uri("https://services.odata.org/V3/Northwind/Northwind.svc"));
            IEnumerable<Category> categories = context.Categories.Execute();
            return categories;
        }
    }
}
