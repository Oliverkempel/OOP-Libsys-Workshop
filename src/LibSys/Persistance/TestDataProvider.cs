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
            this.loadData();

            this.stitchRelationships();
        }




        private void stitchRelationships()
        {

        }


        private void loadData()
        {
            //// Admin has all roles.
            //Roles.Add(new Role("Admin", new List<Permissions> { Permissions.deleteMedia, Permissions.addMedia, Permissions.editMedia, Permissions.deleteMedia, Permissions.borrowMedia, Permissions.returnMedia }));

            //// Employee and user does not have all permissions
            //Roles.Add(new Role("Employee", new List<Permissions> { Permissions.deleteMedia, Permissions.addMedia, Permissions.editMedia, Permissions.deleteMedia, Permissions.borrowMedia, Permissions.returnMedia }));
            //Roles.Add(new Role("User", new List<Permissions> { Permissions.borrowMedia, Permissions.returnMedia }));

            //// Add users
            //Users.Add(new User("oliverthebigdawg", "Oliver kempel", 22, "290703-5560", 1));
            //Users.Add(new User("noaththepussyslayer", "Noah Bøttern", 22, "220704-2323", 1));
            //Users.Add(new User("magnusthecatwisperer", "Magnus Mørup", 21, "210207-9986", 1));

            //Medias.Add(new App("Angry birds") { Publisher = "Rovi", Version = 12, FileSize = 13000, SupportedPlatforms = new List<string> { "Android", "iOS"}, LocalFilePath = "www.gogogogog.com" });
            //Medias.Add(new Movie("Jhon wick", "Action", 2012, "English", new TimeSpan(1, 12, 34)));
        }
    }
}
