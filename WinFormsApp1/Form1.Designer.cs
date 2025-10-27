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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(541, 179);
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
            label1.Location = new Point(743, 40);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "نام";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(695, 97);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "نام خانوادگی";
            label2.Click += label2_Click;
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(470, 40);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(218, 23);
            textFirstName.TabIndex = 3;
            textFirstName.TextChanged += textFirstName_TextChanged;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(470, 97);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(218, 23);
            textLastName.TabIndex = 4;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(568, 139);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(32, 15);
            lblresult.TabIndex = 5;
            lblresult.Text = "-----";
            // 
            // labelAdd1
            // 
            labelAdd1.AutoSize = true;
            labelAdd1.Location = new Point(315, 51);
            labelAdd1.Name = "labelAdd1";
            labelAdd1.Size = new Size(46, 15);
            labelAdd1.TabIndex = 6;
            labelAdd1.Text = "عدد اول";
            // 
            // labelAdd2
            // 
            labelAdd2.AutoSize = true;
            labelAdd2.Location = new Point(313, 100);
            labelAdd2.Name = "labelAdd2";
            labelAdd2.Size = new Size(48, 15);
            labelAdd2.TabIndex = 7;
            labelAdd2.Text = "عدد دوم";
            // 
            // textBoxAdd1
            // 
            textBoxAdd1.Location = new Point(178, 43);
            textBoxAdd1.Name = "textBoxAdd1";
            textBoxAdd1.Size = new Size(100, 23);
            textBoxAdd1.TabIndex = 8;
            // 
            // textBoxAdd2
            // 
            textBoxAdd2.Location = new Point(178, 94);
            textBoxAdd2.Name = "textBoxAdd2";
            textBoxAdd2.Size = new Size(100, 23);
            textBoxAdd2.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(203, 169);
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
            resultcalu.Location = new Point(240, 139);
            resultcalu.Name = "resultcalu";
            resultcalu.Size = new Size(27, 15);
            resultcalu.TabIndex = 11;
            resultcalu.Text = "----";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
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
    }
}
