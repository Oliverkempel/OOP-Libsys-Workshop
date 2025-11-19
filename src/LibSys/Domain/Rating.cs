namespace LibSys.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rating
    {
        public int Stars { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Rating(int stars, string title, string description) 
        {
            this.Stars = stars;
            this.Title = title;
            this.Description = description;
        }
    }
}
