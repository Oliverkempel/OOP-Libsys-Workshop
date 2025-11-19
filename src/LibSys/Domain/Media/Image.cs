namespace LibSys.Domain.Media
{
    using LibSys.Domain.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Image : Media, IOpenable
    {
        public string Resolution {get; set;}
        public string FileFormat {get; set;}
        public int FileSize {get; set;}
        public DateOnly DateTaken {get; set;}
        
        public Image(string title) : base(title)
        {
        }
        public string LocalFilePath { get; set; }

        public void Open()
        {
            
        }
        
        public override string getDesc()
        {
            return "Hej";
        }
    }
}
