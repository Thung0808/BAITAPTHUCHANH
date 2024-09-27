namespace frmThongTinNguoiDung
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.checkTT = new System.Windows.Forms.CheckBox();
            this.checkPA = new System.Windows.Forms.CheckBox();
            this.checkDL = new System.Windows.Forms.CheckBox();
            this.btnXuatthongrtin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(241, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 22);
            this.txtName.TabIndex = 1;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(241, 202);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 2;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(315, 202);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 2;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(568, 119);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sở thích";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkTT
            // 
            this.checkTT.AutoSize = true;
            this.checkTT.Location = new System.Drawing.Point(497, 204);
            this.checkTT.Name = "checkTT";
            this.checkTT.Size = new System.Drawing.Size(88, 20);
            this.checkTT.TabIndex = 4;
            this.checkTT.Text = "Thể Thao";
            this.checkTT.UseVisualStyleBackColor = true;
            // 
            // checkPA
            // 
            this.checkPA.AutoSize = true;
            this.checkPA.Location = new System.Drawing.Point(591, 204);
            this.checkPA.Name = "checkPA";
            this.checkPA.Size = new System.Drawing.Size(84, 20);
            this.checkPA.TabIndex = 4;
            this.checkPA.Text = "Phim ảnh";
            this.checkPA.UseVisualStyleBackColor = true;
            // 
            // checkDL
            // 
            this.checkDL.AutoSize = true;
            this.checkDL.Location = new System.Drawing.Point(700, 204);
            this.checkDL.Name = "checkDL";
            this.checkDL.Size = new System.Drawing.Size(69, 20);
            this.checkDL.TabIndex = 4;
            this.checkDL.Text = "Du lịch";
            this.checkDL.UseVisualStyleBackColor = true;
            // 
            // btnXuatthongrtin
            // 
            this.btnXuatthongrtin.Location = new System.Drawing.Point(592, 288);
            this.btnXuatthongrtin.Name = "btnXuatthongrtin";
            this.btnXuatthongrtin.Size = new System.Drawing.Size(177, 33);
            this.btnXuatthongrtin.TabIndex = 5;
            this.btnXuatthongrtin.Text = "Xuất thông tin";
            this.btnXuatthongrtin.UseVisualStyleBackColor = true;
            this.btnXuatthongrtin.Click += new System.EventHandler(this.btnXuatthongrtin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXuatthongrtin);
            this.Controls.Add(this.checkDL);
            this.Controls.Add(this.checkPA);
            this.Controls.Add(this.checkTT);
            this.Controls.Add(this.date);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkTT;
        private System.Windows.Forms.CheckBox checkPA;
        private System.Windows.Forms.CheckBox checkDL;
        private System.Windows.Forms.Button btnXuatthongrtin;
    }
}

