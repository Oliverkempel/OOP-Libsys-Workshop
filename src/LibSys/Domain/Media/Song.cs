using LibSys.Domain.Interfaces;

namespace LibSys.Domain.Media
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Song : Media, IOpenable
    {
        public string Singer { get; set; }
        public string Genre { get; set; }
        public string FileType {get; set;}
        public string LocalFilePath { get; set; }
        public TimeSpan Duration { get; set; }
        public string Language { get; set; }
        
        public Song(string title, string Singer, string Genre, string FileType, TimeSpan Duration, string Language) : base(title)
            {
            this.Singer = Singer;
            this.Genre = Genre;
            this.FileType = FileType;
            this.Duration = Duration;
            this.Language = Language;
            }

        public override string getDesc()
        {
            return $" {Title} | Song by: {Singer}| Genre: {Genre} | FileType: {FileType} | LocalFilePath: {LocalFilePath}";
        }

        public void Open()
        {
                throw new NotImplementedException();
        }
    }
}
