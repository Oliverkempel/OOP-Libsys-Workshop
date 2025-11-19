namespace LibSys.Domain.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBorrowable
    {
        BorrwStatus Status { get; set; }

        DateOnly ReturnDate {  get; set; }

        bool Borrw();

        bool Return();
    }
}
