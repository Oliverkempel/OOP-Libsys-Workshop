namespace LibSys.Domain.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Role
    {
        private static int currentId = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Permissions> Permissions { get; set; } = new List<Permissions>();

        public Role(string name, List<Permissions>? permissions = null)
        {
            // set permissions
            if(permissions is not null)
            {
                Permissions = permissions;
            }

            Name = name;

            Id = currentId++;
            currentId = Id;

        }

    }
}
