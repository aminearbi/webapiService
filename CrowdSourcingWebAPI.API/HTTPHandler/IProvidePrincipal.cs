using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace CrowdSourcingWebAPI.API
{
    public interface IProvidePrincipal
    {
        IPrincipal CreatePrincipal(string username, string password);
    }
}