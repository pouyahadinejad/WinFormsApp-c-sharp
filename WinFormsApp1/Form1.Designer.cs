namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textFirstName = new TextBox();
            textLastName = new TextBox();
            lblresult = new Label();
            labelAdd1 = new Label();
            labelAdd2 = new Label();
            textBoxAdd1 = new TextBox();
            textBoxAdd2 = new TextBox();
            button2 = new Button();
            resultcalu = new Label();
            button3 = new Button();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button4 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            rdbMan = new RadioButton();
            rdbFameale = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(603, 330);
            button1.Name = "button1";
            button1.Size = new Size(91, 50);
            button1.TabIndex = 0;
            button1.Text = "ثبت نام";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(733, 12);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "نام";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(694, 59);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "نام خانوادگی";
            label2.Click += label2_Click;
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(470, 12);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(218, 23);
            textFirstName.TabIndex = 3;
            textFirstName.TextChanged += textFirstName_TextChanged;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(470, 51);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(218, 23);
            textLastName.TabIndex = 4;
            textLastName.TextChanged += textLastName_TextChanged;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(656, 300);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(32, 15);
            lblresult.TabIndex = 5;
            lblresult.Text = "-----";
            // 
            // labelAdd1
            // 
            labelAdd1.AutoSize = true;
            labelAdd1.Location = new Point(313, 12);
            labelAdd1.Name = "labelAdd1";
            labelAdd1.Size = new Size(46, 15);
            labelAdd1.TabIndex = 6;
            labelAdd1.Text = "عدد اول";
            // 
            // labelAdd2
            // 
            labelAdd2.AutoSize = true;
            labelAdd2.Location = new Point(313, 54);
            labelAdd2.Name = "labelAdd2";
            labelAdd2.Size = new Size(48, 15);
            labelAdd2.TabIndex = 7;
            labelAdd2.Text = "عدد دوم";
            // 
            // textBoxAdd1
            // 
            textBoxAdd1.Location = new Point(194, 9);
            textBoxAdd1.Name = "textBoxAdd1";
            textBoxAdd1.Size = new Size(100, 23);
            textBoxAdd1.TabIndex = 8;
            // 
            // textBoxAdd2
            // 
            textBoxAdd2.Location = new Point(194, 51);
            textBoxAdd2.Name = "textBoxAdd2";
            textBoxAdd2.Size = new Size(100, 23);
            textBoxAdd2.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(219, 135);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "خروجی جمع";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // resultcalu
            // 
            resultcalu.AutoSize = true;
            resultcalu.Location = new Point(267, 100);
            resultcalu.Name = "resultcalu";
            resultcalu.Size = new Size(27, 15);
            resultcalu.TabIndex = 11;
            resultcalu.Text = "----";
            // 
            // button3
            // 
            button3.Location = new Point(12, 9);
            button3.Name = "button3";
            button3.Size = new Size(157, 41);
            button3.TabIndex = 12;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 69);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 13;
            label3.Text = "---";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(606, 100);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "سابقه بیمه ؟";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(426, 333);
            button4.Name = "button4";
            button4.Size = new Size(171, 45);
            button4.TabIndex = 15;
            button4.Text = "بررسی";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "مشهد", "تهران", "شیراز", "قم", "تبریز", "اصفهان", "بوشهر", "خلیج فارس" });
            comboBox1.Location = new Point(567, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 16;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "برنامه نویس وب", "برنامه نویس بک", "برنامه نویس هوش" });
            listBox1.Location = new Point(568, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbFameale);
            groupBox1.Controls.Add(rdbMan);
            groupBox1.Location = new Point(490, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(72, 94);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "جنسیت";
            // 
            // rdbMan
            // 
            rdbMan.AutoSize = true;
            rdbMan.Location = new Point(20, 22);
            rdbMan.Name = "rdbMan";
            rdbMan.Size = new Size(42, 19);
            rdbMan.TabIndex = 0;
            rdbMan.TabStop = true;
            rdbMan.Text = "مرد";
            rdbMan.UseVisualStyleBackColor = true;
            // 
            // rdbFameale
            // 
            rdbFameale.AutoSize = true;
            rdbFameale.Location = new Point(24, 47);
            rdbFameale.Name = "rdbFameale";
            rdbFameale.Size = new Size(38, 19);
            rdbFameale.TabIndex = 1;
            rdbFameale.TabStop = true;
            rdbFameale.Text = "زن";
            rdbFameale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(999, 450);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(resultcalu);
            Controls.Add(button2);
            Controls.Add(textBoxAdd2);
            Controls.Add(textBoxAdd1);
            Controls.Add(labelAdd2);
            Controls.Add(labelAdd1);
            Controls.Add(lblresult);
            Controls.Add(textLastName);
            Controls.Add(textFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = " فایل من";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textFirstName;
        private TextBox textLastName;
        private Label lblresult;
        private Label labelAdd1;
        private Label labelAdd2;
        private TextBox textBoxAdd1;
        private TextBox textBoxAdd2;
        private Button button2;
        private Label resultcalu;
        private Button button3;
        private Label label3;
        private CheckBox checkBox1;
        private Button button4;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private RadioButton rdbFameale;
        private RadioButton rdbMan;
    }
}
