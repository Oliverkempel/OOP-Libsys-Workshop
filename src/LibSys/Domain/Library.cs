namespace LibSys
{
    using LibSys.Domain.Media;
    using LibSys.Domain.User;
    using LibSys.Persistance;
    using LibSys.Persistance.Interfaces;

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Library
    {
        private FileDataProvider _data { get; set; }
        public List<Media> Medias { get; set;} = new List<Media>();

        public User? currentUser { get; set; }

        public Library(FileDataProvider dataProvider)
        {
            // Dependency inject the dataprovider
            _data = dataProvider;

            // Start by loading users and roles from persistant storage
            //Users = _data.getUsers();
            //Roles = _data.getRoles();
            //Medias = _data.getMedias();

            _data.Roles.Find(x => x.Name == "Admin").Permissions.Add(Permissions.getAllMedia);
            _data.UpdateCSV();

        }

        public bool login(string username)
        {
            // try to find a user with specified username
            User? usr = _data.Users.Find(_ => _.Username == username);

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

        public List<Media>? getAllMedia()
        {
           if( !AuthorizationHandler.CheckAuth(currentUser, Permissions.getAllMedia))
            {
                throw new Exception("User does not have access.");
            }

            return _data.Medias;
        }

    }
}
