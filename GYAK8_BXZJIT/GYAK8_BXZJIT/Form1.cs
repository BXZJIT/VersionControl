using GYAK8_BXZJIT.Abstractions;
using GYAK8_BXZJIT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYAK8_BXZJIT
{
    public partial class Form1 : Form
    {
        private Toy _nextToy;
        private List<Toy> _toys = new List<Toy>();
        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set { 
                _factory = value;
                DisplayNext();
            }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new CarFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                    maxPosition = toy.Left;
            }

            if (maxPosition > 1000)
            {
                var oldesToy = _toys[0];
                mainPanel.Controls.Remove(oldesToy);
                _toys.Remove(oldesToy);
            }
        }

        private void Car_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void ball_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }
        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);
        }
    }
}
