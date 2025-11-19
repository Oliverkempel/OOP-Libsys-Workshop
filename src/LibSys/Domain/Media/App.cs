namespace LibSys.Domain.Media
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class App
    {
        public override int Title {get; set;}
        public int Vesion { get; set; }
        public List<string> SupportedPlatforms { get; set; }
        public int FileSize { get; set; }

        public override getDesc()
        {
            Console.WriteLine($"App: {Title} Version: {Version} SupportedPlatforms: {SupportedPlatforms} FileSize: {FileSize}");
        }
    }
}
