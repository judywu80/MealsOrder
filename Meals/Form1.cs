using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n, sum, amt,tamt, j;
        string s1,s2, lst;
        string[] food = { "泡沫紅茶", "珍珠奶茶", "木瓜牛奶", "柳橙純汁", "漢堡Ａ餐", "麥克雞塊", "內用每人" };
        int[] price = { 30, 35, 40, 40, 100, 120, 10 };
        TextBox textBox; CheckBox checkBox;

        private void button1_Click(object sender, EventArgs e)
        {
            /* //基礎級C項
            sum = 0;
            if (checkBox1.Checked == true) sum = int.Parse(textBox1.Text) * 30;
            if (checkBox2.Checked == true) sum += int.Parse(textBox2.Text) * 35; 
            if (checkBox3.Checked == true) sum += int.Parse(textBox3.Text) * 40;
            if (checkBox4.Checked == true) sum += int.Parse(textBox4.Text) * 40;
            if (checkBox5.Checked == true) sum += int.Parse(textBox5.Text) * 100;
            if (checkBox6.Checked == true) sum += int.Parse(textBox6.Text) * 120;
            if (checkBox7.Checked == true) sum += int.Parse(textBox7.Text) * 10;
            label8.Text = sum.ToString();
            */
            listBox1.Items.Clear();  //不然會往下累計文字
            listBox1.Items.Add("");
            listBox1.Items.Add("餐飲清單".PadLeft(15,' ')); //單引號內要有空格否則有錯誤,因要用空格將字往右移
            listBox1.Items.Add("");

            tamt = 0;j = 0;
            int[] qty = new int[7];
            for (int i=0; i<7;i++)
            {
                s1="textBox"+(i+1).ToString();        //textBox名稱 (數量在tB)
                s2 = "checkBox" + (i + 1).ToString();  //checkBox名稱 (文字和單價在陣列,非cB)
                textBox = (TextBox)Controls.Find(s1, true)[0];   //用tB字串找到本tB物件
                checkBox = (CheckBox)Controls.Find(s2, true)[0];  //用cB字串找到本cB物件
                qty[i] = int.Parse(textBox.Text);  //數量字串轉數字

                if (checkBox.Checked)
                {
                    j++;
                    amt = price[i] * qty[i];
                    tamt+=amt;
                    lst = $" {j}.{food[i],4} {price[i],3} x {qty[i],3}= {amt,6:n0}"; //自行調整對齊字元數
                    listBox1.Items.Add(lst);  //加這行listBox才看的到lst陣列內容
                }
            }
            listBox1.Items.Add(" ".PadRight(29, '-'));  //只能放字元,故用單引號
            listBox1.Items.Add($" 總計: {tamt,22:n0}");
            listBox1.Items.Add("");
            listBox1.Items.Add(String.Format("{0,16}", " 謝謝惠顧！")); //字串前補空白,共16個
            label8.Text = $"小計${tamt,7:n0} 元";
        }
        private void textBox_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
        private void checkBox_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBox = (CheckBox)sender;
            s1=checkBox.Name;
            s2="textBox"+s1.Substring(s1.Length-1,1);
            textBox = (TextBox)Controls.Find(s2, true)[0];  

            if (checkBox.Checked)
            {
                if (int.TryParse(textBox.Text, out n) && n <= 0)
                    textBox.Text = "1";
            }
            if (checkBox.Checked == false)
            {
                textBox.Text = "0";
                if (s1.Substring(s1.Length - 1, 1) == "7")
                    rdBtn1.Checked=true;
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox = (TextBox)sender;
            s1 = textBox.Name;       //如選擇的textBox1, 偵到下一行才顯示s1值
            s2 = "checkBox" + s1.Substring(s1.Length - 1, 1);  //tB位置最後1個, 取1字元, 為cB名
            checkBox = (CheckBox)Controls.Find(s2, true)[0];  //用tB字串s2找物件cB,如選擇的checkbox=checkbox1 //checkbox {Text = "泡沫紅茶  [30元]" CheckState = Unchecked}
            
            if (int.TryParse(textBox.Text, out n) == true && n > 0 && (!textBox.Text.Contains(" ")))  //若無==true&&n>0負數可存在  //包含空格會歸0
            {
                checkBox.Checked = true;
            }
            else
            {  
                textBox.Text = "0";  //""會出現2個MesgBox,因不是正整數或0
                checkBox.Checked = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            rdBtn1.Checked = true;     //
            rdBtn2.Checked = false;
            label8.Text = "";          //
            listBox1.Items.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = "歡迎光臨！";
            textBox7.Visible = false;
            checkBox7.Visible = false;
            label7.Visible = false;
            rdBtn1.Checked = true;    //
        }
        private void rdBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn2.Checked)
            {
                textBox7.Visible = true;
                checkBox7.Visible = true;
                label7.Visible = true;
                textBox7.Text = "1";
                checkBox7.Checked = true;
            }
            else
            {
                textBox7.Visible = false;
                checkBox7.Visible = false;
                label7.Visible = false;
            }
        }
    }
}
