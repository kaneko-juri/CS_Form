using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CS_Form
{
    internal class TestButton : Button
    {
        /// <summary>
        /// ボタンをクリックした際にラベルを変更したいため、
        /// Form1への参照を補完しておく
        /// </summary>
        Form1 _form1;


        ///<summary>
        ///コンストラクタ
        ///クラスを生成したときに呼び出される
        ///</summary>

        public TestButton(Form1 form1, string id, int x, int y, int width, int hight)
        {
            _form1 = form1;
            

            //ClickイベントにOnclick関数を登録
            //ボタンをクリックした時に登録した関数を実行します
            Click += OnClick;

            //ボタン内に文字を表示させる
            Text = id;  

            //ボタンの生成場所を指定
            Location = new Point(x,y);

            //ボタンの大きさを指定
            Size = new Size(width, hight);

        }

        /// <summary>
        /// ボタンをクリックした際に記述をする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="s"></param>

        public void OnClick(object sender, EventArgs s)
        {
        
            _form1.LabelTextUpdate(Text);

            _form1.TestTextBoxUpdate(Text);

            _form1.TestButtonUpdate(Text);

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
