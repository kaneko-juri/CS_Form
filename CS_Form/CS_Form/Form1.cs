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

        TestTextBox _textBox;

        TestButton _testButton;

        public Form1()
        {
            //コンポーネントの初期化
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

           

           


            //ラベルの作成
            _TestLabel = new TestLabel("ラベルです", 10, 300, 100, 500);
            
            //ラベルの追加
            Controls.Add(_TestLabel);

            _textBox = new TestTextBox("テキストボックスです", 110, 400, 500, 200);
            Controls.Add(_textBox);

         

        }

        public void LabelTextUpdate(string str)
        {
            _TestLabel.TextUpdate(str);
        }

        public void TestTextBoxUpdate(string str)
        {
            _textBox.TextUpdate(str);
        }

        public void TestButtonUpdate(string str)
        {
            _testButton.TextUpdate(str);
        }

        public string ButtonLabelReplacement(string str)
        {
           string s = _textBox.TextReplacement(str);

            return s;
        }
      

    }
}
