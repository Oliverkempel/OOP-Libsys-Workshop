namespace LibSys.Persistance
{
    using LibSys.Domain.Media;
    using LibSys.Domain.User;
    using LibSys.Persistance.Interfaces;

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class TestDataProvider : IDataProvider
    {
        public List<User> getUsers()
        {
            List<User> Users = new List<User>();
            Users.Add(new User("oliverthebigdawg", "Oliver kempel", 22, "290703-5560", 1));
            Users.Add(new User("noaththepussyslayer", "Noah Bøttern", 22, "220704-2323", 1));
            Users.Add(new User("magnusthecatwisperer", "Magnus Mørup", 21, "210207-9986", 1));
            return Users;
        }

        public List<Role> getRoles()
        {
            List<Role> Roles = new List<Role>();
            // Admin has all roles.
            Roles.Add(new Role("Admin", new List<Permissions> { Permissions.deleteMedia, Permissions.addMedia, Permissions.editMedia, Permissions.deleteMedia, Permissions.borrowMedia, Permissions.returnMedia }));

            // Employee and user does not have all permissions
            Roles.Add(new Role("Employee", new List<Permissions> { Permissions.deleteMedia, Permissions.addMedia, Permissions.editMedia, Permissions.deleteMedia, Permissions.borrowMedia, Permissions.returnMedia }));
            Roles.Add(new Role("User", new List<Permissions> { Permissions.borrowMedia, Permissions.returnMedia }));
            return Roles;
        }

        public List<Media> getMedias()
        {
            List<Media> medias = new List<Media>();
            medias.Add(new Movie("Svampebob the movie", "Hype", 2005, "Danish", new TimeSpan(1, 20, 34)));
            medias.Add(new App("Excel", "Microsoft", 19, 12000, new List<string> { "Android", "iOS", "Windows", "MacOS" }));
            medias.Add(new Movie("Spiderman", "Action", 2009, "English", new TimeSpan(2, 34, 12)));
            medias.Add(new App("Angry birds", "Rovi", 12, 3600, new List<string> { "Android", "iOS", "Linux"}));

            return medias;
        }
    }
}
