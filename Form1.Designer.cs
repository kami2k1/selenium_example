namespace Kami
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            kami = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            textBox3 = new TextBox();
            linkLabel2 = new LinkLabel();
            textBox4 = new TextBox();
            linkLabel3 = new LinkLabel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(274, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(290, 192);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 2;
            button1.Text = "Sart ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // kami
            // 
            kami.Icon = (Icon)resources.GetObject("kami.Icon");
            kami.Text = "Kami Cloud";
            kami.Visible = true;
            kami.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 221);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(683, 194);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ActiveBorder;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(208, 150);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(54, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "PRO FILe";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.Location = new Point(274, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = SystemColors.ActiveBorder;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(208, 110);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(43, 15);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Endfile";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Window;
            textBox4.Location = new Point(274, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = SystemColors.ActiveBorder;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(208, 53);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(43, 15);
            linkLabel3.TabIndex = 8;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Sartfile";
            // 
            // button2
            // 
            button2.Location = new Point(581, 53);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "SetProfile FB";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(581, 110);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "RunFb";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(581, 163);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "run id ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(798, 522);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(linkLabel3);
            Controls.Add(textBox4);
            Controls.Add(linkLabel2);
            Controls.Add(textBox3);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Kami APP";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private Button button1;
        private ToolTip toolTip1;
        private NotifyIcon kami;
        private System.Windows.Forms.Timer timer1;
        public TextBox textBox2;
        private LinkLabel linkLabel1;
        private TextBox textBox3;
        private LinkLabel linkLabel2;
        private TextBox textBox4;
        private LinkLabel linkLabel3;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
