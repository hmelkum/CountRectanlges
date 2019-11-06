namespace RectAligVisualization
{
    partial class MainW
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.secLbl = new System.Windows.Forms.Label();
            this.secTb = new System.Windows.Forms.TrackBar();
            this.restBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.yTb = new System.Windows.Forms.TextBox();
            this.xTb = new System.Windows.Forms.TextBox();
            this.rectNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coordLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.conBtn = new System.Windows.Forms.Button();
            this.refBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secTb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.secLbl);
            this.panel1.Controls.Add(this.secTb);
            this.panel1.Controls.Add(this.restBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.yTb);
            this.panel1.Controls.Add(this.xTb);
            this.panel1.Controls.Add(this.rectNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.coordLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.conBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.panel1.Location = new System.Drawing.Point(888, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 667);
            this.panel1.TabIndex = 0;
            // 
            // secLbl
            // 
            this.secLbl.AutoSize = true;
            this.secLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLbl.Location = new System.Drawing.Point(218, 599);
            this.secLbl.Name = "secLbl";
            this.secLbl.Size = new System.Drawing.Size(36, 39);
            this.secLbl.TabIndex = 11;
            this.secLbl.Text = "0";
            // 
            // secTb
            // 
            this.secTb.BackColor = System.Drawing.Color.SeaGreen;
            this.secTb.Location = new System.Drawing.Point(12, 599);
            this.secTb.Maximum = 500;
            this.secTb.Name = "secTb";
            this.secTb.Size = new System.Drawing.Size(200, 56);
            this.secTb.SmallChange = 2;
            this.secTb.TabIndex = 10;
            this.secTb.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.secTb.Scroll += new System.EventHandler(this.secTb_Scroll);
            // 
            // restBtn
            // 
            this.restBtn.Location = new System.Drawing.Point(249, 210);
            this.restBtn.Name = "restBtn";
            this.restBtn.Size = new System.Drawing.Size(51, 48);
            this.restBtn.TabIndex = 9;
            this.restBtn.Text = "R";
            this.restBtn.UseMnemonic = false;
            this.restBtn.UseVisualStyleBackColor = true;
            this.restBtn.Click += new System.EventHandler(this.restBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "new Point(   X   ,    Y)";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(84, 521);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(174, 64);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // yTb
            // 
            this.yTb.Location = new System.Drawing.Point(224, 427);
            this.yTb.Name = "yTb";
            this.yTb.Size = new System.Drawing.Size(76, 38);
            this.yTb.TabIndex = 6;
            // 
            // xTb
            // 
            this.xTb.Location = new System.Drawing.Point(137, 427);
            this.xTb.Name = "xTb";
            this.xTb.Size = new System.Drawing.Size(76, 38);
            this.xTb.TabIndex = 5;
            // 
            // rectNum
            // 
            this.rectNum.AutoSize = true;
            this.rectNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectNum.ForeColor = System.Drawing.Color.Blue;
            this.rectNum.Location = new System.Drawing.Point(19, 214);
            this.rectNum.Name = "rectNum";
            this.rectNum.Size = new System.Drawing.Size(26, 39);
            this.rectNum.TabIndex = 4;
            this.rectNum.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number odf Recctangles:";
            // 
            // coordLbl
            // 
            this.coordLbl.AutoSize = true;
            this.coordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordLbl.ForeColor = System.Drawing.Color.Red;
            this.coordLbl.Location = new System.Drawing.Point(18, 72);
            this.coordLbl.Name = "coordLbl";
            this.coordLbl.Size = new System.Drawing.Size(31, 48);
            this.coordLbl.TabIndex = 2;
            this.coordLbl.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point Coordinates:";
            // 
            // conBtn
            // 
            this.conBtn.Location = new System.Drawing.Point(26, 290);
            this.conBtn.Name = "conBtn";
            this.conBtn.Size = new System.Drawing.Size(274, 64);
            this.conBtn.TabIndex = 0;
            this.conBtn.Text = "Connect";
            this.conBtn.UseVisualStyleBackColor = true;
            this.conBtn.Click += new System.EventHandler(this.conBtn_Click);
            // 
            // refBtn
            // 
            this.refBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refBtn.Location = new System.Drawing.Point(803, 15);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(51, 48);
            this.refBtn.TabIndex = 10;
            this.refBtn.Text = "R";
            this.refBtn.UseMnemonic = false;
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // MainW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1232, 667);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.panel1);
            this.Name = "MainW";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secTb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button conBtn;
        private System.Windows.Forms.Label coordLbl;
        private System.Windows.Forms.Label rectNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox yTb;
        private System.Windows.Forms.TextBox xTb;
        private System.Windows.Forms.Button restBtn;
        private System.Windows.Forms.Button refBtn;
        private System.Windows.Forms.Label secLbl;
        private System.Windows.Forms.TrackBar secTb;
    }
}

