namespace LibSys.Domain.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IExecutable
    {
        public string LocalFilePath { get; set;}
        public void Execute();
    }
}
