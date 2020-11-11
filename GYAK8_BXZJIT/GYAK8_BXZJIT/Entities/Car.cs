using GYAK8_BXZJIT.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYAK8_BXZJIT.Entities
{
    class Car : Abstractions.Toy
    {
        protected override void DrawImage(Graphics g)
        {
           Image imageFile = Image.FromFile("car.png");
           g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
    }
}
