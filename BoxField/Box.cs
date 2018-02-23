﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxField
{
    class Box
    {
        public int x, y, size;

        public Box(int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
        }

        public void Move(int speed)
        {
            y += speed;
        }
    }
}
