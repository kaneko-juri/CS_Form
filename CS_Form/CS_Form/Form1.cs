using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int A;
            int B = 0;


            for (A = 0; A < 10; A++) 
            {
                TestButton testButtonA = new TestButton(A, B, 0, 50, 50);
                Controls.Add(testButtonA);
                B = B + 50;
            }
           
           

        ;

        }
    }
}
