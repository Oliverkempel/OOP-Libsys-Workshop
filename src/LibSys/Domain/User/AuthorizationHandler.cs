namespace LibSys.Domain.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class AuthorizationHandler
    {

        public static bool CheckAuth(User usr, Permissions perm)
        {   
            return usr.Role.Permissions.Contains(perm);
        }

    }
}
