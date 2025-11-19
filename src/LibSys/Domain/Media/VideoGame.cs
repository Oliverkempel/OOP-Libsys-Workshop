namespace LibSys.Domain.Media
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    public class VideoGame : Media
    {
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public List<string> SupportedPlatforms { get; set; }
         

        public VideoGame(string title, string genre) : base(title)
        {
            Genre = genre;
            SupportedPlatforms = new List<string>();
        }

        public override string getDesc()
        {
            return $"{this.Title} | Genre: {this.Genre} | Released: {this.ReleaseYear}";
        }
    }
}
