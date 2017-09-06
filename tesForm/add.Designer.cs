namespace tesForm
{
    partial class add
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.namaTxt = new System.Windows.Forms.TextBox();
            this.hpTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.alamat1Txt = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.plusAlamat = new System.Windows.Forms.Button();
            this.alamatPanel = new System.Windows.Forms.Panel();
            this.alamatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Hp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alamat";
            // 
            // namaTxt
            // 
            this.namaTxt.Location = new System.Drawing.Point(86, 65);
            this.namaTxt.MaxLength = 50;
            this.namaTxt.Name = "namaTxt";
            this.namaTxt.Size = new System.Drawing.Size(225, 20);
            this.namaTxt.TabIndex = 5;
            // 
            // hpTxt
            // 
            this.hpTxt.Location = new System.Drawing.Point(86, 104);
            this.hpTxt.Name = "hpTxt";
            this.hpTxt.Size = new System.Drawing.Size(225, 20);
            this.hpTxt.TabIndex = 6;
            this.hpTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hpTxt_KeyPress);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(86, 148);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(225, 20);
            this.emailTxt.TabIndex = 7;
            // 
            // alamat1Txt
            // 
            this.alamat1Txt.Location = new System.Drawing.Point(0, 12);
            this.alamat1Txt.Name = "alamat1Txt";
            this.alamat1Txt.Size = new System.Drawing.Size(190, 20);
            this.alamat1Txt.TabIndex = 8;
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.Location = new System.Drawing.Point(155, 233);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 9;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.Location = new System.Drawing.Point(236, 233);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // plusAlamat
            // 
            this.plusAlamat.Location = new System.Drawing.Point(193, 10);
            this.plusAlamat.Name = "plusAlamat";
            this.plusAlamat.Size = new System.Drawing.Size(29, 23);
            this.plusAlamat.TabIndex = 11;
            this.plusAlamat.Text = "+";
            this.plusAlamat.UseVisualStyleBackColor = true;
            this.plusAlamat.Click += new System.EventHandler(this.plusAlamat_Click);
            // 
            // alamatPanel
            // 
            this.alamatPanel.Controls.Add(this.alamat1Txt);
            this.alamatPanel.Controls.Add(this.plusAlamat);
            this.alamatPanel.Location = new System.Drawing.Point(86, 179);
            this.alamatPanel.Name = "alamatPanel";
            this.alamatPanel.Size = new System.Drawing.Size(225, 48);
            this.alamatPanel.TabIndex = 12;
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 268);
            this.Controls.Add(this.alamatPanel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.hpTxt);
            this.Controls.Add(this.namaTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add";
            this.Text = "add";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_FormClosed);
            this.alamatPanel.ResumeLayout(false);
            this.alamatPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox namaTxt;
        private System.Windows.Forms.TextBox hpTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox alamat1Txt;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button plusAlamat;
        private System.Windows.Forms.Panel alamatPanel;
    }
}