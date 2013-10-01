using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadband.Data
{
    public interface IDataProvider
    {
        int OpenDb();
        int CloseDb();
    }
}
