namespace LibSys.Persistance.Interfaces
{
    using LibSys.Domain.Media;
    using LibSys.Domain.User;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDataProvider
    {
        public List<User> Users { get; set; }
        public List<Role> Roles { get; set; }
        public List<Media> Medias { get; set; }
        //public List<User> getUsers();
        //public List<Role> getRoles();
        //public List<Media> getMedias();
    }
}
