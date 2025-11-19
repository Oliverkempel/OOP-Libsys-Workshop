namespace LibSys.Domain.Media
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Media
    {
    public string Title { get; set; } 

    public Media(string title)
        {
            this.Title = title;
        }

        public abstract string GetDesc();

    }
}
