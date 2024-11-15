using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _TestLabel;

        public Form1()
        {

            InitializeComponent();

            string[] strs =
       {

            "あ",
            "か",
            "さ",
            "た",
            "な",
            "は",
            "ま",
            "や",
            "ら",
            "わ"

,        };

            int A;
            int B = 0;


            for (A = 0; A < 10; A++) 
            {
                TestButton testButtonA = new TestButton(this, strs[A], B, 0, 50, 50);
                Controls.Add(testButtonA);
                B = B + 50;
            }

            _TestLabel = new TestLabel("Label", 10, 300, 100, 500);
            Controls.Add(_TestLabel);

        

        }

        public void LabelTextUpdate(string str)
        {
            _TestLabel.TextUpdate(str);
        }
    }
}
