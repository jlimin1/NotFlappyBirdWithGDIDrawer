using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Drawing;
using GDIDrawer;

namespace NotFlappyBird
{
    internal class Bird
    {
        private PointF _position;
        private double _heading;
        private Color _color = Color.Yellow;

        public Bird (double heading, PointF position)
        {
            _heading = heading;
            _position = position;
        }

        public void Move()
        {

        }
    }
}
