namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbt1 = new System.Windows.Forms.Button();
            this.cbt2 = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.pnlstats = new System.Windows.Forms.Panel();
            this.barhp = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblmana = new System.Windows.Forms.Label();
            this.lblhp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlenemy = new System.Windows.Forms.Panel();
            this.lblenemyname = new System.Windows.Forms.Label();
            this.lblenemyhp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtproceed = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.picturebx = new System.Windows.Forms.PictureBox();
            this.barmana = new System.Windows.Forms.ProgressBar();
            this.barenemyhp = new System.Windows.Forms.ProgressBar();
            this.pnlstats.SuspendLayout();
            this.pnlenemy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebx)).BeginInit();
            this.SuspendLayout();
            // 
            // cbt1
            // 
            this.cbt1.BackColor = System.Drawing.SystemColors.Control;
            this.cbt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbt1.Location = new System.Drawing.Point(12, 478);
            this.cbt1.Name = "cbt1";
            this.cbt1.Size = new System.Drawing.Size(207, 119);
            this.cbt1.TabIndex = 0;
            this.cbt1.Text = "OK";
            this.cbt1.UseVisualStyleBackColor = false;
            this.cbt1.Click += new System.EventHandler(this.cbt1_Click);
            // 
            // cbt2
            // 
            this.cbt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbt2.Location = new System.Drawing.Point(460, 478);
            this.cbt2.Name = "cbt2";
            this.cbt2.Size = new System.Drawing.Size(207, 119);
            this.cbt2.TabIndex = 1;
            this.cbt2.UseVisualStyleBackColor = true;
            this.cbt2.Visible = false;
            this.cbt2.Click += new System.EventHandler(this.cbt2_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(213, 71);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(247, 30);
            this.txtname.TabIndex = 3;
            // 
            // pnlstats
            // 
            this.pnlstats.BackColor = System.Drawing.Color.Transparent;
            this.pnlstats.Controls.Add(this.barmana);
            this.pnlstats.Controls.Add(this.barhp);
            this.pnlstats.Controls.Add(this.label2);
            this.pnlstats.Controls.Add(this.lblname);
            this.pnlstats.Controls.Add(this.lblmana);
            this.pnlstats.Controls.Add(this.lblhp);
            this.pnlstats.Controls.Add(this.label1);
            this.pnlstats.Location = new System.Drawing.Point(225, 435);
            this.pnlstats.Name = "pnlstats";
            this.pnlstats.Size = new System.Drawing.Size(235, 161);
            this.pnlstats.TabIndex = 4;
            this.pnlstats.Visible = false;
            // 
            // barhp
            // 
            this.barhp.ForeColor = System.Drawing.Color.Red;
            this.barhp.Location = new System.Drawing.Point(2, 77);
            this.barhp.Name = "barhp";
            this.barhp.Size = new System.Drawing.Size(227, 23);
            this.barhp.TabIndex = 8;
            this.barhp.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "MANA:";
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(3, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(226, 27);
            this.lblname.TabIndex = 6;
            this.lblname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblmana
            // 
            this.lblmana.AutoSize = true;
            this.lblmana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmana.ForeColor = System.Drawing.Color.White;
            this.lblmana.Location = new System.Drawing.Point(115, 103);
            this.lblmana.Name = "lblmana";
            this.lblmana.Size = new System.Drawing.Size(45, 25);
            this.lblmana.TabIndex = 4;
            this.lblmana.Text = "100";
            // 
            // lblhp
            // 
            this.lblhp.AutoSize = true;
            this.lblhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhp.ForeColor = System.Drawing.Color.White;
            this.lblhp.Location = new System.Drawing.Point(115, 43);
            this.lblhp.Name = "lblhp";
            this.lblhp.Size = new System.Drawing.Size(45, 25);
            this.lblhp.TabIndex = 1;
            this.lblhp.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP:";
            // 
            // pnlenemy
            // 
            this.pnlenemy.BackColor = System.Drawing.Color.Transparent;
            this.pnlenemy.Controls.Add(this.barenemyhp);
            this.pnlenemy.Controls.Add(this.lblenemyname);
            this.pnlenemy.Controls.Add(this.lblenemyhp);
            this.pnlenemy.Controls.Add(this.label4);
            this.pnlenemy.Location = new System.Drawing.Point(189, 277);
            this.pnlenemy.Name = "pnlenemy";
            this.pnlenemy.Size = new System.Drawing.Size(302, 118);
            this.pnlenemy.TabIndex = 5;
            this.pnlenemy.Visible = false;
            // 
            // lblenemyname
            // 
            this.lblenemyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenemyname.ForeColor = System.Drawing.Color.White;
            this.lblenemyname.Location = new System.Drawing.Point(3, 23);
            this.lblenemyname.Name = "lblenemyname";
            this.lblenemyname.Size = new System.Drawing.Size(296, 36);
            this.lblenemyname.TabIndex = 7;
            this.lblenemyname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblenemyhp
            // 
            this.lblenemyhp.AutoSize = true;
            this.lblenemyhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenemyhp.ForeColor = System.Drawing.Color.White;
            this.lblenemyhp.Location = new System.Drawing.Point(149, 59);
            this.lblenemyhp.Name = "lblenemyhp";
            this.lblenemyhp.Size = new System.Drawing.Size(0, 25);
            this.lblenemyhp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "HP:";
            // 
            // cbtproceed
            // 
            this.cbtproceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtproceed.Location = new System.Drawing.Point(266, 396);
            this.cbtproceed.Name = "cbtproceed";
            this.cbtproceed.Size = new System.Drawing.Size(145, 29);
            this.cbtproceed.TabIndex = 6;
            this.cbtproceed.Text = "Proceed";
            this.cbtproceed.UseVisualStyleBackColor = true;
            this.cbtproceed.Visible = false;
            this.cbtproceed.Click += new System.EventHandler(this.cbtproceed_Click);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(68, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(531, 273);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Type your name here";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picturebx
            // 
            this.picturebx.Location = new System.Drawing.Point(0, 0);
            this.picturebx.Name = "picturebx";
            this.picturebx.Size = new System.Drawing.Size(684, 626);
            this.picturebx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebx.TabIndex = 7;
            this.picturebx.TabStop = false;
            // 
            // barmana
            // 
            this.barmana.ForeColor = System.Drawing.Color.Blue;
            this.barmana.Location = new System.Drawing.Point(3, 131);
            this.barmana.Name = "barmana";
            this.barmana.Size = new System.Drawing.Size(227, 23);
            this.barmana.TabIndex = 9;
            this.barmana.Value = 100;
            // 
            // barenemyhp
            // 
            this.barenemyhp.ForeColor = System.Drawing.Color.Red;
            this.barenemyhp.Location = new System.Drawing.Point(38, 90);
            this.barenemyhp.Name = "barenemyhp";
            this.barenemyhp.Size = new System.Drawing.Size(227, 23);
            this.barenemyhp.TabIndex = 10;
            this.barenemyhp.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 621);
            this.Controls.Add(this.pnlenemy);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cbtproceed);
            this.Controls.Add(this.pnlstats);
            this.Controls.Add(this.cbt2);
            this.Controls.Add(this.cbt1);
            this.Controls.Add(this.picturebx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Adventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlstats.ResumeLayout(false);
            this.pnlstats.PerformLayout();
            this.pnlenemy.ResumeLayout(false);
            this.pnlenemy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cbt1;
        private System.Windows.Forms.Button cbt2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Panel pnlstats;
        private System.Windows.Forms.Label lblhp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmana;
        private System.Windows.Forms.Panel pnlenemy;
        private System.Windows.Forms.Label lblenemyhp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button cbtproceed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblenemyname;
        private System.Windows.Forms.PictureBox picturebx;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ProgressBar barhp;
        private System.Windows.Forms.ProgressBar barmana;
        private System.Windows.Forms.ProgressBar barenemyhp;
    }
}

