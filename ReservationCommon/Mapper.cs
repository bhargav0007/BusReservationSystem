using ReservationCommon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationCommon
{
    public abstract class Mapper<T1, T2> : IMapper<T1, T2>
    {
        public abstract T1 Map(T2 value);

        public IEnumerable<T1> Maps(IEnumerable<T2> values)
        {
            return values?.Select(Map);
        }
        public IEnumerable<T2> Maps(IEnumerable<T1> values) 
        {
            return values?.Select(Map);
        }
        public abstract T2 Map(T1 value);
    }
}
