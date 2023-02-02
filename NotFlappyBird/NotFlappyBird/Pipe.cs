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
    internal class Pipe
    {
        static CDrawer _canvas;

        static int windowRightEdge = 799;

        private static readonly int yGapHeight = 150;
        private static readonly int xPipeLength = 80;

        private Point topPipeAddress;
        private Point bottomPipeAddress;

        private int topPipeHeight;

        static Random random = new Random();

        private static readonly Color pipeColour = Color.DarkGreen;

        public void Generate()
        {
            topPipeHeight = random.Next(50, 500);

            topPipeAddress = new Point(windowRightEdge, 0);
            bottomPipeAddress = new Point(windowRightEdge, topPipeHeight + yGapHeight);


        }

        public void Move()
        {

        }
    }
}
