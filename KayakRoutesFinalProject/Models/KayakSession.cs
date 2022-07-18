using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace KayakRoutesFinalProject.Models
{
    public class KayakSession
    {
        private const string RouteKey = "myroutes";
        private const string CountKey = "mycounts";

        private ISession session { get; set; }
        public KayakSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyRoutes(List<Route> route)
        {
            session.SetObject(RouteKey, route);
            session.SetInt32(CountKey, route.Count);
        }
        public List<Route> GetMyRoutes() => session.GetObject<List<Route>>(RouteKey) ?? new List<Route>();

        public int GetMyRoutesCount() => session.GetInt32(CountKey) ?? 0;

        public void RemoveMyRoutes()
        {
            session.Remove(RouteKey);
            session.Remove(CountKey);
        }

    }
}
