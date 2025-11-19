namespace LibSys.Persistance
{
    using LibSys.Domain.Media;
    using LibSys.Domain.User;
    using LibSys.Persistance.Interfaces;

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Reflection.Metadata;
    using System.Text;
    using System.Threading.Tasks;

    public class FileDataProvider : IDataProvider
    {
        public string UsersFileName { get; set; } = "Users";
        public string RolesFileName { get; set; } = "Roles";
        public string MediasFileName { get; set; } = "Medias";
        public List<User> Users { get; set; } = new List<User>();
        public List<Role> Roles { get; set;} = new List<Role>();
        public List<Media> Medias { get; set; } = new List<Media>();

        private Dictionary<int, User> userCache = new Dictionary<int, User>();
        private Dictionary<int, Role> roleCache = new Dictionary<int, Role>();
        private Dictionary<int, Media> MediasCache = new Dictionary<int, Media>();

        public FileDataProvider()
        {
            InitFile("Users");
            InitFile("Roles");
            InitFile("Medias");

            LoadRoles();
            LoadUsers();

            // stitches the objects together
            stitchRelationships();

            //AddRole(new Role("Admin", new List<Permissions> { Permissions.deleteMedia, Permissions.addMedia, Permissions.editMedia, Permissions.deleteMedia, Permissions.borrowMedia, Permissions.returnMedia }));
            //AddRole(new Role("Employee", new List<Permissions> { Permissions.deleteMedia, Permissions.addMedia, Permissions.editMedia, Permissions.deleteMedia, Permissions.borrowMedia, Permissions.returnMedia }));


            //AddUser(new User("admin", "admin", 0, "000000-0000", 0));
            //AddUser(new User("oliver", "Oliver Kempel", 22, "121212-1212", 0));
            //AddUser(new User("test", "Oliver Kempel", 22, "121212-1212", 0));

            //RemoveRole(Roles.Find(x => x.Id == 1));

        }

        public void AddUser(User usr)
        {
            // Get the current max id, if there are no posts assign 0 as max id.
            int currentMaxId = Users.Count != 0 ? Users.Max(u => u.Id) + 1 : 0;
            usr.Id = currentMaxId;

            //resolve navigation property
            if (roleCache.TryGetValue(usr.RoleId, out Role? r))
            {
                usr.Role = r;
            }
            Users.Add(usr);
            userCache.Add(usr.Id, usr);
            resaveUsers();
        }

        public void RemoveUser(User usr)
        {
            Users.Remove(usr);
            userCache.Remove(usr.Id);
            resaveUsers();
        }

        public void AddRole(Role role)
        {
            // Get the current max id, if there are no posts assign 0 as max id.
            int currentMaxId = Roles.Count != 0 ? Roles.Max(r => r.Id) + 1 : 0;
            role.Id = currentMaxId;

            Roles.Add(role);
            roleCache.Add(role.Id, role);
            resaveRoles();
        }
        public void RemoveRole(Role role)
        {
            Roles.Remove(role);
            roleCache.Remove(role.Id);
            resaveRoles();
        }

        public void UpdateCSV()
        {
            resaveRoles();
        }

        private void stitchRelationships()
        {
            //Stitch role relationships
            foreach(User usr in Users)
            {
                // get reference to role object
                Role roleObj = roleCache[usr.RoleId];

                // set the navigation property
                usr.Role = roleObj;
            }
        }


        private void InitFile(string fileName)
        {
            if (!File.Exists($"{fileName}.csv"))
            {
                FileStream stream = File.Create($"{fileName}.csv");
                stream.Close();
            }
        }


        private void LoadRoles()
        {
            using (var reader = new StreamReader($"{this.RolesFileName}.csv"))
            {
                if (reader is null)
                {
                    return;
                }

                while(reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    if (!String.IsNullOrEmpty(line))
                    {
                        string[] values = line.Split(',');

                        string[] permissions = values[2].Split(";");

                        List<Permissions> perms = new List<Permissions>();

                        // Converts perm list
                        foreach (string str in permissions)
                        {
                            Permissions perm = Enum.Parse<Permissions>(str);
                            perms.Add(perm);
                        }

                        // Get the values from the csv
                        Role roleObj = new Role(values[1], perms);
                        roleObj.Id = Convert.ToInt32(values[0]);

                        // Add to users and to user cache for easy lookup.
                        Roles.Add(roleObj);
                        roleCache.Add(roleObj.Id, roleObj);
                    }
                }
            }
        }

        private void LoadUsers()
        {
            using(var reader = new StreamReader($"{this.UsersFileName}.csv"))
            {
                if(reader is null)
                {
                    return;
                }

                while(reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    if (!String.IsNullOrEmpty(line))
                    {
                        string[] values = line.Split(',');

                        // Get the values from the csv
                        User userObj = new User(values[1], values[2], Int32.Parse(values[3]), values[4], Int32.Parse(values[5]));
                        userObj.Id = Convert.ToInt32(values[0]);

                        // Add to users and to user cache for easy lookup.
                        Users.Add(userObj);
                        userCache.Add(userObj.Id, userObj);
                    }
                }
                
            }
        }

        private void resaveRoles()
        {
            using (var writer = new StreamWriter($"{this.RolesFileName}.csv"))
            {
                if (writer is null || Roles.Count == 0)
                {
                    return;
                }

                foreach (Role role in Roles)
                {
                    string permissionsStr = "";
                    for (int i = 0; i < role.Permissions.Count(); i++)
                    {
                        // Add the permission to the string
                        permissionsStr += role.Permissions[i];
                        // Only add delimiter when it is not the last element
                        if (i != role.Permissions.Count() - 1)
                        {
                            permissionsStr += ";";
                        }
                    }

                    writer.WriteLine($"{role.Id},{role.Name},{permissionsStr}");
                }
                
            }
        }

        private void resaveUsers()
        {
            using (var writer = new StreamWriter($"{this.UsersFileName}.csv"))
            {
                if (writer is null || Users.Count == 0)
                {
                    return;
                }

                foreach(User usr in Users)
                {
                    writer.WriteLine($"{usr.Id},{usr.Username},{usr.Name},{usr.Age},{usr.CPRNum},{usr.RoleId}");
                }

            }
        }

        public void UpdateRole(Role role)
        {

        }

    }
}
