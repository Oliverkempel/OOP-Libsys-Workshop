namespace LibSys.Domain.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class User
    {
        private static int currentId = 0;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string CPRNum { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }

        public User(string username, string name, int age, string cprNum, int roleId )
        {
            Id = currentId + 1;
            Username = username;
            Name = name;
            Age = age;
            CPRNum = cprNum;
            RoleId = roleId;

            currentId = Id;
        }

    }
}
