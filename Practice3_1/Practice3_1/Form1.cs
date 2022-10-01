using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice3_1
{
    public partial class Form1 : Form
    {
        class Account
            {
                public string link, user, pass;
                public Account (string _link, string _user, string _pass)
                {
                    link = _link;
                    user = _user;
                    pass = _pass;
                }
            }
        private List<Account> accounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e) // search button (done)
        {
            labelResult.Text = "";
            string searchtxt = textSearch.Lines[0];
            int count = 0;
            for (int i = 0; i < accounts.Count; i++)
            {
                string currlink = accounts.ElementAt(i).link;
                if (currlink.Contains(searchtxt))
                {
                    labelResult.Text += "連結:" + currlink + "\n";
                    labelResult.Text += "使用者:" + accounts.ElementAt(i).user + "\n";
                    labelResult.Text += "密碼:" + accounts.ElementAt(i).pass + "\n";
                    labelResult.Text += "==============================================" + "\n";
                    count++;
                }
            }
            if(count == 0)
            {
                for (int i = 0; i < accounts.Count; i++)
                {
                    labelResult.Text += "連結:" + accounts.ElementAt(i).link + "\n";
                    labelResult.Text += "使用者:" + accounts.ElementAt(i).user + "\n";
                    labelResult.Text += "密碼:" + accounts.ElementAt(i).pass + "\n";
                    labelResult.Text += "==============================================" + "\n";                    
                }
            }
        }

        private void btnAddDel_Click(object sender, EventArgs e) // switch scene (done)
        {
            if(labelResult.Visible == true)
            {
                labelSearch.Visible = false;
                textSearch.Visible = false;
                textSearch.Text = "";
                btnSearch.Enabled = false;
                btnRisk.Enabled = false;
                // end here 
                labelRes.Visible = false;
                labelResult.Visible = false;
                labelResult.Text = "";
                labelStatus.Visible = true;
                labelLink.Visible = true;
                txtLink.Visible = true;
                labelUser.Visible = true;
                txtUser.Visible = true;
                labelPass.Visible = true;
                txtPass.Visible = true;
                btnAdd.Visible = true;
                btnDel.Visible = true;
                btnAddDel.Text = "回主畫面";
            }
            else
            {
                labelSearch.Visible = true;
                textSearch.Visible = true;
                textSearch.Text = "";
                btnSearch.Enabled = true;
                btnRisk.Enabled = true;
                labelRes.Visible = true;
                labelResult.Visible = true;
                labelResult.Text = "";
                labelStatus.Visible = false;
                labelLink.Visible = false;
                txtLink.Visible = false;
                labelUser.Visible = false;
                txtUser.Visible = false;
                labelPass.Visible = false;
                txtPass.Visible = false;
                btnAdd.Visible = false;
                btnDel.Visible = false;
                btnAddDel.Text = "新增或刪除";
                txtLink.Clear();
                txtUser.Clear();
                txtPass.Clear();
                labelStatus.Text = "我是狀態列";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) // add user (done)
        {
            string link = txtLink.Lines[0];
            string user = txtUser.Lines[0];
            string pass = txtPass.Lines[0];
            for(int i = 0; i < accounts.Count; i++)
            {
                if(accounts.ElementAt(i).link == link && accounts.ElementAt(i).user == user)
                {
                    labelStatus.Text = "帳號已存在";
                    return;
                }
            }
            accounts.Add(new Account(link, user, pass));
            labelStatus.Text = "新增完成";
            txtLink.Clear();
            txtUser.Clear();
            txtPass.Clear();
            return;
        }

        private void btnDel_Click(object sender, EventArgs e)  // delete user (done)
        {
            string link = txtLink.Lines[0];
            string user = txtUser.Lines[0];
            string pass = txtPass.Lines[0];
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts.ElementAt(i).link == link && accounts.ElementAt(i).user == user && accounts.ElementAt(i).pass == pass)
                {
                    accounts.RemoveAt(i);
                    labelStatus.Text = "刪除完成";
                    txtLink.Clear();
                    txtUser.Clear();
                    txtPass.Clear();
                    return;
                }
            }
            labelStatus.Text = "帳號不存在或密碼錯誤";
        }

        private void btnRisk_Click(object sender, EventArgs e) // print out risk account
        {
            int checklast = 0;
            labelResult.Text = "";
            List<Account> risk = new List<Account>();
            int[] checker = new int[accounts.Count];
            for (int i = 0; i < accounts.Count; i++) checker[i] = 0;
            for(int i = 0; i < accounts.Count - 1; i++)
            {
                for(int j = 0; j < accounts.Count ; j++)
                {
                    if (i != j && accounts.ElementAt(i).pass.Equals(accounts.ElementAt(j).pass)){
                        if(checker[i] == 0)
                        {
                            risk.Add(new Account(accounts.ElementAt(i).link, accounts.ElementAt(i).user, accounts.ElementAt(i).pass));
                            checker[i] = 1;
                        }
                        if (j == accounts.Count - 1) checklast++;
                    }
                }
            }
            if(checklast != 0)
            {
                risk.Add(new Account(accounts.ElementAt(accounts.Count - 1).link, accounts.ElementAt(accounts.Count - 1).user, accounts.ElementAt(accounts.Count - 1).pass));
            }
            for (int i = 0; i < risk.Count; i++)
            {
                labelResult.Text += "連結:" + risk.ElementAt(i).link + "\n";
                labelResult.Text += "使用者:" + risk.ElementAt(i).user + "\n";
                labelResult.Text += "密碼:" + risk.ElementAt(i).pass + "\n";
                labelResult.Text += "==============================================" + "\n";
            }
        }
    }
}
