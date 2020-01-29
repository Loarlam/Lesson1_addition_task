using System;
using System.Collections.Generic;
using System.Text;

namespace Addition_Task
{
    class Address
    {
        /*Поля можно не создавать, ибо свойства всё равно создают сокрытые поля*/
        public int Index { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
