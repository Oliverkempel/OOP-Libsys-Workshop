namespace LibSys.Domain.Media
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class App : Media, IExecutable 
    {
        public override int Title {get; set;}
        public string Publisher {get; set;}
        public int Vesion { get; set; } 
        public string LocalFilePath { get; set; }
        public List<string> SupportedPlatforms { get; set; }
        public int FileSize { get; set; }

        public override string getDesc()
        {
            return $"App: {Title} Version: {Version} SupportedPlatforms: {SupportedPlatforms} FileSize: {FileSize}";
        }

        public void Execute()
        {
            
        }
    }
}
