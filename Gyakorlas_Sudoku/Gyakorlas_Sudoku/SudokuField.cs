using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyakorlas_Sudoku
{
    class SudokuField : Button
    {
        public SudokuField()
        {
            this.Height = 30;
            this.Width = 30;
            this.BackColor = Color.White;
            Value = 0;
            MouseDown += SudokuField_MouseDown;
        }
        private void SudokuField_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Active) return;
            if (e.Button == MouseButtons.Left) { Value++; }
            if (e.Button == MouseButtons.Right) { Value--; }
        }


        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                if (value < 0) { _value = 9; }
                else if (value > 9) { _value = 0;}
                else { _value = value; }

                if (value==0) {this.Text = ""; }
                else {this.Text = value.ToString();}
            }
        }
        private bool _active;

        public bool Active
        {
            get { return _active; }
            set 
            { _active = value;
            if(_active)
                    Font = new Font(FontFamily.GenericSansSerif, 12);
                else
                    Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            }
        }


    }
}
