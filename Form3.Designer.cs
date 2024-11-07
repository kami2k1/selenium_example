namespace Kami
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idnv = new TextBox();
            sl = new TextBox();
            dilay = new TextBox();
            oke = new Button();
            label4 = new Label();
            Tukhoa = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Id NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 58);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 1;
            label2.Text = "SL ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 106);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "dilay";
            // 
            // idnv
            // 
            idnv.Location = new Point(114, 23);
            idnv.Name = "idnv";
            idnv.Size = new Size(100, 23);
            idnv.TabIndex = 3;
            // 
            // sl
            // 
            sl.Location = new Point(114, 58);
            sl.Name = "sl";
            sl.Size = new Size(100, 23);
            sl.TabIndex = 4;
            // 
            // dilay
            // 
            dilay.Location = new Point(114, 98);
            dilay.Name = "dilay";
            dilay.Size = new Size(100, 23);
            dilay.TabIndex = 5;
            // 
            // oke
            // 
            oke.Location = new Point(139, 185);
            oke.Name = "oke";
            oke.Size = new Size(75, 23);
            oke.TabIndex = 6;
            oke.Text = "oke";
            oke.UseVisualStyleBackColor = true;
            oke.Click += oke_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 143);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Từ Khoá";
            // 
            // Tukhoa
            // 
            Tukhoa.Location = new Point(114, 143);
            Tukhoa.Name = "Tukhoa";
            Tukhoa.Size = new Size(100, 23);
            Tukhoa.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 241);
            Controls.Add(Tukhoa);
            Controls.Add(label4);
            Controls.Add(oke);
            Controls.Add(dilay);
            Controls.Add(sl);
            Controls.Add(idnv);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "SET NV FB ";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idnv;
        private TextBox sl;
        private TextBox dilay;
        private Button oke;
        private Label label4;
        private TextBox Tukhoa;
    }
}