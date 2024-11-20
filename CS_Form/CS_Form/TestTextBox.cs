using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    internal class TestTextBox : TextBox
    {
        ///<summary>
        ///コンストラクタ
        ///クラスを生成したときに呼び出される
        ///</summary>
        Form1 _form1;


        public TestTextBox(string str, int x, int y, int width, int hight)
        {
           _form1 = new Form1();

            //ボタン内に文字を表示させる
            Text = str;

            //ボタンの生成場所を指定
            Location = new Point(x, y);

            //ボタンの大きさを指定
            Size = new Size(width, hight);

        }

        public string TextReplacement(string str)
        {
            string temp = Text;

            Text = str;

            return temp;

        }


        /// <summary>
        /// ラベルの文字変更関数
        /// </summary>
        /// <param name="str"></param>
        public void TextUpdate(string str)
        {
            Text = str;
        }
    }
}
