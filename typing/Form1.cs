using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace typing
{
    public partial class Form1 : Form
    {

        List<string> japanese = new List<string>();
        List<string> romaji = new List<string>();
        int i = 0;
        int Qcount = 0;
        int Tcount = 0;
        string s2 ="";
        Stopwatch sw = new Stopwatch();  

        public Form1()
        {
            InitializeComponent();
            sw.Start();
            japanese.Add("「ずっと俺のそばにいろよ」");
            japanese.Add("「手・・・つなごうか」");
            japanese.Add("「俺のことだけ見てろ」");
            japanese.Add("「おやすみ、子猫ちゃん」");
            japanese.Add("「今夜また夢で逢おう」");
            japanese.Add("");
            romaji.Add("ZUTTOORENOSOBANIIROYO");
            romaji.Add("TETUNAGOUKA");
            romaji.Add("ORENOKOTODAKEMITERO");
            romaji.Add("OYASUMIKONEKOCHAN");
            romaji.Add("KONNYAMATAYUMEDEAOU");
            romaji.Add("");
            label1.Text = japanese[i];
            label2.Text = romaji[i];      
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            s2 += e.KeyCode.ToString();
            typing.Text = s2;
            Tcount++;
            Qcount++;
            string s1 = romaji[i].Substring(0, Qcount);

            if (s2 == s1)
            {
                label3.Text = "ok";
            }
            else
            {
                label3.Text = "MISS";
                Qcount--;
                Tcount--;

                s1 = romaji[i].Substring(0, Qcount);
                s2 = s2.Substring(0, Tcount);
            }

            int last= romaji[i].Length;

            if (last == Qcount)
            {
                i++;
                label1.Text = japanese[i];
                label2.Text = romaji[i];
                Qcount = 0;
                Tcount = 0;
                s1 = "";
                s2 = "";
            }

            if (i == 5)
            {
                sw.Stop();
                MessageBox.Show("女の子を口説くのに\r\n\r\n" + sw.Elapsed.ToString()+ "\r\n\r\nかかりました");
            }
          
        }


    }
}
