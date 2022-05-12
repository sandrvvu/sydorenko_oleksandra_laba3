using System;
using System.Collections.Generic;
using System.Text;

namespace laba3_program3
{
    class Month
    {
        public enum Type
        {
             January,
             February,
             March,
             April,
             May,
             June,
             July,
             August,
             September,
             October,
             November,
             December
        }
        public Type month_type;
        public int days;

        public Month(Type month_type, int days)
        {
            this.month_type = month_type;
            this.days = days;
        }
    }
}
