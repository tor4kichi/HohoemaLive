using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HohoemaLive.Interfaces
{
    public interface ITitleUpdatablePage
    {
        IObservable<string> GetTitleObservable();
    }
}
