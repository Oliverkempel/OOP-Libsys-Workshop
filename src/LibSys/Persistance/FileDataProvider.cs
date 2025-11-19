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

    public class FileDataProvider : IDataProvider
    {
        public List<User> getUsers()
        {
            throw new NotImplementedException();
        }

        public List<Role> getRoles()
        {
            throw new NotImplementedException();
        }

        public List<Media> getMedias()
        {
            throw new NotImplementedException();
        }

        public List<User> Users { get; set; }
        public List<Role> Roles { get; set; }
        public List<Media> Medias { get; set; }
    }
}
