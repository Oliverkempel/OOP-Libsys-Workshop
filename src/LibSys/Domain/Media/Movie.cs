namespace LibSys.Domain.Media
{
    using LibSys.Domain.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Movie : Media, IOpenable
    { 
        public string Genre {get; set;}
        public int ReleaseYear {get; set;}
        public string Language {get; set;}
        public TimeSpan Duration {get; set;}
        public Movie(string title, string Genre, int ReleaseYear, string Language, TimeSpan Duration) : base(title)
        {
            this.Genre = Genre;
            this.ReleaseYear = ReleaseYear;
            this.Language = Language;
            this.Duration = Duration;
            
        }
        public string LocalFilePath { get; set; }
        public void Open()
        {
            
        }
        public override string getDesc()
        {
            return $"{this.Title} | Released: {this.ReleaseYear} | Lang: {this.Language} | Duration: {this.Duration.ToString()}";
        }
    }
}
