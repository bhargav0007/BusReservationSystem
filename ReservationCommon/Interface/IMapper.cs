using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationCommon.Interface
{
    public interface IMapper<T1,T2>
    {
        T1 Map(T2 value);

        IEnumerable<T1> Maps(IEnumerable<T2> value);

        IEnumerable<T2> Maps(IEnumerable<T1> value);

        T2 Map(T1 value);

    }
}
