namespace LibSys.Domain.Media
{
    using LibSys.Domain.Interfaces;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class App : Media, IExecutable
    {

        public string Publisher {get; set;}
        public int Version { get; set; } 
        public string LocalFilePath { get; set; }
        public List<string> SupportedPlatforms { get; set; }
        public int FileSize { get; set; }

        public App(string title, string publisher, int version, int fileSize, List<string> supportedPlatforms) : base(title)
        {
            Publisher = publisher;
            Version = version;
            FileSize = fileSize;
            SupportedPlatforms = supportedPlatforms;
        }

        public override string getDesc()
        {
            return $"App: {Title} Version: {Version} SupportedPlatforms: {SupportedPlatforms.ToString()} FileSize: {FileSize}";
        }

        public void Execute()
        {
            
        }
    }
}
