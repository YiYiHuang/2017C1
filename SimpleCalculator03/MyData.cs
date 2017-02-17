using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator03
{
    class MyData
    {
        private int _x;
        private int _y;

        public int X
        {
            // return_x指的是 將_x的值回傳給X
            // _x=value 今天給value一個值 將值指派給_x
            //set像是從外面改變裡面的(private)東西
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

    }
}
