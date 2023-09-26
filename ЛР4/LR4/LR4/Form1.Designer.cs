namespace LR4
{
    partial class MainForm
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
            this.ExitBut = new System.Windows.Forms.Label();
            this.CoorSys = new System.Windows.Forms.Panel();
            this.CoorSys1 = new System.Windows.Forms.Panel();
            this.CoorSys2 = new System.Windows.Forms.Panel();
            this.CoorSys4 = new System.Windows.Forms.Panel();
            this.CoorSys3 = new System.Windows.Forms.Panel();
            this.XPoint = new System.Windows.Forms.TextBox();
            this.YPoint = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartBut = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Point)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBut
            // 
            this.ExitBut.AutoSize = true;
            this.ExitBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(27)))));
            this.ExitBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(220)))));
            this.ExitBut.Location = new System.Drawing.Point(767, 9);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(21, 20);
            this.ExitBut.TabIndex = 0;
            this.ExitBut.Text = "X";
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            this.ExitBut.MouseEnter += new System.EventHandler(this.ExitBut_MouseEnter);
            this.ExitBut.MouseLeave += new System.EventHandler(this.ExitBut_MouseLeave);
            // 
            // CoorSys
            // 
            this.CoorSys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoorSys.Location = new System.Drawing.Point(440, 75);
            this.CoorSys.Name = "CoorSys";
            this.CoorSys.Size = new System.Drawing.Size(300, 300);
            this.CoorSys.TabIndex = 1;
            // 
            // CoorSys1
            // 
            this.CoorSys1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoorSys1.Location = new System.Drawing.Point(590, 75);
            this.CoorSys1.Name = "CoorSys1";
            this.CoorSys1.Size = new System.Drawing.Size(150, 150);
            this.CoorSys1.TabIndex = 2;
            // 
            // CoorSys2
            // 
            this.CoorSys2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoorSys2.Location = new System.Drawing.Point(440, 75);
            this.CoorSys2.Name = "CoorSys2";
            this.CoorSys2.Size = new System.Drawing.Size(150, 150);
            this.CoorSys2.TabIndex = 3;
            // 
            // CoorSys4
            // 
            this.CoorSys4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoorSys4.Location = new System.Drawing.Point(590, 225);
            this.CoorSys4.Name = "CoorSys4";
            this.CoorSys4.Size = new System.Drawing.Size(150, 150);
            this.CoorSys4.TabIndex = 4;
            // 
            // CoorSys3
            // 
            this.CoorSys3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoorSys3.Location = new System.Drawing.Point(440, 225);
            this.CoorSys3.Name = "CoorSys3";
            this.CoorSys3.Size = new System.Drawing.Size(150, 150);
            this.CoorSys3.TabIndex = 5;
            // 
            // XPoint
            // 
            this.XPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(220)))));
            this.XPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XPoint.Font = new System.Drawing.Font("Book Antiqua", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XPoint.Location = new System.Drawing.Point(100, 100);
            this.XPoint.Multiline = true;
            this.XPoint.Name = "XPoint";
            this.XPoint.Size = new System.Drawing.Size(200, 50);
            this.XPoint.TabIndex = 6;
            this.XPoint.MouseEnter += new System.EventHandler(this.XPoint_MouseEnter);
            this.XPoint.MouseLeave += new System.EventHandler(this.XPoint_MouseLeave);
            // 
            // YPoint
            // 
            this.YPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(220)))));
            this.YPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YPoint.Font = new System.Drawing.Font("Book Antiqua", 22F);
            this.YPoint.Location = new System.Drawing.Point(100, 200);
            this.YPoint.Multiline = true;
            this.YPoint.Name = "YPoint";
            this.YPoint.Size = new System.Drawing.Size(200, 50);
            this.YPoint.TabIndex = 7;
            this.YPoint.MouseEnter += new System.EventHandler(this.YPoint_MouseEnter);
            this.YPoint.MouseLeave += new System.EventHandler(this.YPoint_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(63)))), ((int)(((byte)(55)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(75, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 200);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(63)))), ((int)(((byte)(55)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(415, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 350);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(162, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "150";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(324, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "150";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(158, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "-150";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(-3, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "-150";
            // 
            // StartBut
            // 
            this.StartBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(63)))), ((int)(((byte)(55)))));
            this.StartBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(63)))), ((int)(((byte)(55)))));
            this.StartBut.FlatAppearance.BorderSize = 3;
            this.StartBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(125)))), ((int)(((byte)(110)))));
            this.StartBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(94)))), ((int)(((byte)(82)))));
            this.StartBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBut.Font = new System.Drawing.Font("Book Antiqua", 22F);
            this.StartBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(220)))));
            this.StartBut.Location = new System.Drawing.Point(125, 350);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(150, 50);
            this.StartBut.TabIndex = 10;
            this.StartBut.Text = "Start";
            this.StartBut.UseVisualStyleBackColor = false;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.Color.Black;
            this.Point.Location = new System.Drawing.Point(588, 223);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(4, 4);
            this.Point.TabIndex = 11;
            this.Point.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.StartBut);
            this.Controls.Add(this.YPoint);
            this.Controls.Add(this.XPoint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CoorSys4);
            this.Controls.Add(this.CoorSys3);
            this.Controls.Add(this.CoorSys2);
            this.Controls.Add(this.CoorSys1);
            this.Controls.Add(this.CoorSys);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Point)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitBut;
        private System.Windows.Forms.Panel CoorSys;
        private System.Windows.Forms.Panel CoorSys1;
        private System.Windows.Forms.Panel CoorSys2;
        private System.Windows.Forms.Panel CoorSys4;
        private System.Windows.Forms.Panel CoorSys3;
        private System.Windows.Forms.TextBox XPoint;
        private System.Windows.Forms.TextBox YPoint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.PictureBox Point;
    }
}

