namespace LibSys
{
    using LibSys.Domain.User;

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Library
    {
        public List<User> Users { get; set;} = new List<User>();
        public List<Role> Roles { get; set;} = new List<Role>();

        public User currentUser { get; set; }

        public Library()
        {
            initUsers();
            initRoles();
        }

        public void initUsers()
        {
            Users.Add(new User("oliverthebigdawg", "Oliver kempel", 22, "290703-5560", Roles.Find(x => x.Name == "Admin")));
            Users.Add(new User("noaththepussyslayer", "Noah Bøttern", 22, "220704-2323", Roles.Find(x => x.Name == "Admin")));
            Users.Add(new User("magnusthecatwisperer", "Magnus Mørup", 21, "210207-9986", Roles.Find(x => x.Name == "Admin")));
        }

        public void initRoles()
        {
            // Admin has all roles.
            Roles.Add(new Role("Admin", new List<Permissions> { Permissions.deleteMedia, Permissions.addMedia, Permissions.editMedia, Permissions.deleteMedia, Permissions.borrowMedia, Permissions.returnMedia }));
            
            // Employee and user does not have all permissions
            Roles.Add(new Role("Employee", new List<Permissions> { Permissions.deleteMedia, Permissions.addMedia, Permissions.editMedia, Permissions.deleteMedia, Permissions.borrowMedia, Permissions.returnMedia }));
            Roles.Add(new Role("User", new List<Permissions> { Permissions.borrowMedia, Permissions.returnMedia }));
        }

        public bool login(string username)
        {
            // try to find a user with specified username
            User? usr = Users.Find(_ => _.Username == username);

            // Check if user is found
            if(usr is not null)
            {
                // if user is found set current user to the found user.
                currentUser = usr;
                return true;
            }
            // if not found return false
            return false;
        }

        public bool logout()
        {
            // Only log out if current user exists
            if(currentUser != null)
            {
                // set current user to null when logged out
                currentUser = null;
                return true;
            }
            return false;
        }

    }
}
