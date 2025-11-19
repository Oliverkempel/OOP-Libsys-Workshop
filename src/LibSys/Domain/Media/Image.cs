namespace LibSys.Domain.Media
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Image : Media, IOpenable
    {
        public string LocalFilePath { get; set; }
        public void Open();
    }
}
