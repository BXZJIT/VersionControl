using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersionControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = VersionControlResource.LastName; 
            label2.Text = VersionControlResource.FirstName; 
            button1.Text = VersionControlResource.Add; 
        }
    }
}
