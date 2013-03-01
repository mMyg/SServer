namespace SClient
{
    partial class SClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.launchbutton = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.selecthost = new System.Windows.Forms.TextBox();
            this.portinfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selecttype = new System.Windows.Forms.TextBox();
            this.selectclass = new System.Windows.Forms.TextBox();
            this.selectside = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // launchbutton
            // 
            this.launchbutton.Location = new System.Drawing.Point(12, 145);
            this.launchbutton.Name = "launchbutton";
            this.launchbutton.Size = new System.Drawing.Size(268, 57);
            this.launchbutton.TabIndex = 0;
            this.launchbutton.Text = "Launch";
            this.launchbutton.UseVisualStyleBackColor = true;
            this.launchbutton.Click += new System.EventHandler(this.launchbutton_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(47, 12);
            this.namebox.MaxLength = 11;
            this.namebox.Name = "namebox";
            this.namebox.ReadOnly = true;
            this.namebox.Size = new System.Drawing.Size(233, 20);
            this.namebox.TabIndex = 4;
            this.namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selecthost
            // 
            this.selecthost.Location = new System.Drawing.Point(47, 119);
            this.selecthost.Name = "selecthost";
            this.selecthost.Size = new System.Drawing.Size(109, 20);
            this.selecthost.TabIndex = 5;
            this.selecthost.TextChanged += new System.EventHandler(this.hostinfo_TextChanged);
            // 
            // portinfo
            // 
            this.portinfo.Location = new System.Drawing.Point(211, 119);
            this.portinfo.Name = "portinfo";
            this.portinfo.Size = new System.Drawing.Size(69, 20);
            this.portinfo.TabIndex = 6;
            this.portinfo.TextChanged += new System.EventHandler(this.portinfo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Side";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type";
            // 
            // selecttype
            // 
            this.selecttype.Location = new System.Drawing.Point(47, 92);
            this.selecttype.Name = "selecttype";
            this.selecttype.Size = new System.Drawing.Size(109, 20);
            this.selecttype.TabIndex = 14;
            this.selecttype.TextChanged += new System.EventHandler(this.selecttype_TextChanged);
            // 
            // selectclass
            // 
            this.selectclass.Location = new System.Drawing.Point(47, 65);
            this.selectclass.Name = "selectclass";
            this.selectclass.Size = new System.Drawing.Size(109, 20);
            this.selectclass.TabIndex = 15;
            this.selectclass.TextChanged += new System.EventHandler(this.selectclass_TextChanged);
            // 
            // selectside
            // 
            this.selectside.Location = new System.Drawing.Point(47, 38);
            this.selectside.Name = "selectside";
            this.selectside.Size = new System.Drawing.Size(109, 20);
            this.selectside.TabIndex = 16;
            this.selectside.TextChanged += new System.EventHandler(this.selectside_TextChanged);
            // 
            // SClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 213);
            this.Controls.Add(this.selectside);
            this.Controls.Add(this.selectclass);
            this.Controls.Add(this.selecttype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portinfo);
            this.Controls.Add(this.selecthost);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.launchbutton);
            this.Name = "SClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sole Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SClient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchbutton;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox selecthost;
        private System.Windows.Forms.TextBox portinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox selecttype;
        private System.Windows.Forms.TextBox selectclass;
        private System.Windows.Forms.TextBox selectside;
    }
}

