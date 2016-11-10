using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTask
{
    public class PhonesComparer : IEqualityComparer<Person>
        {
            public bool Equals(Person x, Person y)
            {
                if (x.Phone == y.Phone)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public int GetHashCode(Person obj)
            {
                return obj.Phone.GetHashCode();
            }
        }
    }
