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
        public List<User> Users { get; set; } = new List<User>();
        public List<Role> Roles { get; set; } = new List<Role>();
        public List<Media> Medias { get; set; } = new List<Media>();

        public TestDataProvider()
        {
            loadUsers();
            loadRoles();
            loadMedias();
        }

        private void linkObjects()
        {

        }


        private void loadUsers()
        {
            //List<Role> roles = new List<Role>();
            //roles = this.getRoles();

            Users.Add(new User("oliverthebigdawg", "Oliver kempel", 22, "290703-5560", 1));
            Users.Add(new User("noaththepussyslayer", "Noah Bøttern", 22, "220704-2323", 1));
            Users.Add(new User("magnusthecatwisperer", "Magnus Mørup", 21, "210207-9986", 1));
        }

        private void loadRoles()
        {
            // Admin has all roles.
            Roles.Add(new Role("Admin", new List<Permissions> { Permissions.deleteMedia, Permissions.addMedia, Permissions.editMedia, Permissions.deleteMedia, Permissions.borrowMedia, Permissions.returnMedia }));

            // Employee and user does not have all permissions
            Roles.Add(new Role("Employee", new List<Permissions> { Permissions.deleteMedia, Permissions.addMedia, Permissions.editMedia, Permissions.deleteMedia, Permissions.borrowMedia, Permissions.returnMedia }));
            Roles.Add(new Role("User", new List<Permissions> { Permissions.borrowMedia, Permissions.returnMedia }));
        }

        private void loadMedias()
        {
            //medias.Add(new VideoGame() { Genre = "Action", ReleaseYear = 2029, SupportedPlatforms = new List<string>{"Windows"} });

        }
    }
}
