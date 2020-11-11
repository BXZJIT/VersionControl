﻿using GYAK8_BXZJIT.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYAK8_BXZJIT.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color ribbon, Color box)
        {
            BoxColor = new SolidBrush(box);
            RibbonColor = new SolidBrush(ribbon);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, Width / 5, Height / 5, Height/2 , Width);
            g.FillRectangle(RibbonColor, Width /5, Height / 5, Height, Width/2);
        }
    }
}