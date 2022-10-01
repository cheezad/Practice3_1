using System;

namespace Practice3_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnRisk = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnAddDel = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelLink = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(24, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(65, 12);
            this.Title.TabIndex = 0;
            this.Title.Text = "密碼管理員";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(24, 59);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(53, 12);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "搜尋序列";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(24, 139);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(53, 12);
            this.labelRes.TabIndex = 2;
            this.labelRes.Text = "搜尋結果";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(83, 54);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(480, 22);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRisk
            // 
            this.btnRisk.Location = new System.Drawing.Point(22, 91);
            this.btnRisk.Name = "btnRisk";
            this.btnRisk.Size = new System.Drawing.Size(691, 29);
            this.btnRisk.TabIndex = 4;
            this.btnRisk.Text = "風險帳號";
            this.btnRisk.UseVisualStyleBackColor = true;
            this.btnRisk.Click += new System.EventHandler(this.btnRisk_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(602, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 22);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelResult.Location = new System.Drawing.Point(24, 161);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(684, 271);
            this.labelResult.TabIndex = 6;
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // btnAddDel
            // 
            this.btnAddDel.Location = new System.Drawing.Point(546, 127);
            this.btnAddDel.Name = "btnAddDel";
            this.btnAddDel.Size = new System.Drawing.Size(152, 24);
            this.btnAddDel.TabIndex = 7;
            this.btnAddDel.Text = "新增或刪除";
            this.btnAddDel.UseVisualStyleBackColor = true;
            this.btnAddDel.Click += new System.EventHandler(this.btnAddDel_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStatus.Location = new System.Drawing.Point(208, 224);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(288, 26);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "我是狀態列";
            this.labelStatus.Visible = false;
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(208, 273);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(29, 12);
            this.labelLink.TabIndex = 9;
            this.labelLink.Text = "連結";
            this.labelLink.Visible = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(208, 305);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(41, 12);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "使用者";
            this.labelUser.Visible = false;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(208, 336);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(29, 12);
            this.labelPass.TabIndex = 11;
            this.labelPass.Text = "密碼";
            this.labelPass.Visible = false;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(258, 270);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(235, 22);
            this.txtLink.TabIndex = 12;
            this.txtLink.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(258, 302);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(236, 22);
            this.txtUser.TabIndex = 13;
            this.txtUser.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(258, 333);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(237, 22);
            this.txtPass.TabIndex = 14;
            this.txtPass.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(363, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(436, 376);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(57, 22);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "刪除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnAddDel);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRisk);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void labelResult_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnRisk;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnAddDel;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
    }
}

