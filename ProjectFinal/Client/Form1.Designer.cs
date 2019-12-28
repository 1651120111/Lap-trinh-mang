namespace Client
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
            this.ketqua = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bao = new System.Windows.Forms.Button();
            this.keo = new System.Windows.Forms.Button();
            this.bua = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "=>";
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.Location = new System.Drawing.Point(542, 121);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(39, 42);
            this.ketqua.TabIndex = 7;
            this.ketqua.Text = "?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bao);
            this.groupBox1.Controls.Add(this.keo);
            this.groupBox1.Controls.Add(this.bua);
            this.groupBox1.Location = new System.Drawing.Point(72, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // bao
            // 
            this.bao.Image = global::Client.Properties.Resources._2;
            this.bao.Location = new System.Drawing.Point(493, 21);
            this.bao.Name = "bao";
            this.bao.Size = new System.Drawing.Size(94, 117);
            this.bao.TabIndex = 2;
            this.bao.UseVisualStyleBackColor = true;
            this.bao.Click += new System.EventHandler(this.bao_Click);
            // 
            // keo
            // 
            this.keo.Image = global::Client.Properties.Resources._0;
            this.keo.Location = new System.Drawing.Point(104, 21);
            this.keo.Name = "keo";
            this.keo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.keo.Size = new System.Drawing.Size(94, 117);
            this.keo.TabIndex = 1;
            this.keo.UseVisualStyleBackColor = true;
            this.keo.Click += new System.EventHandler(this.keo_Click);
            // 
            // bua
            // 
            this.bua.Image = global::Client.Properties.Resources._1;
            this.bua.Location = new System.Drawing.Point(293, 21);
            this.bua.Name = "bua";
            this.bua.Size = new System.Drawing.Size(94, 117);
            this.bua.TabIndex = 0;
            this.bua.UseVisualStyleBackColor = true;
            this.bua.Click += new System.EventHandler(this.bua_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Client.Properties.Resources._3;
            this.pictureBox2.Location = new System.Drawing.Point(318, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 129);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(318, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 129);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Oẳn Tù Tì";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bao;
        private System.Windows.Forms.Button keo;
        private System.Windows.Forms.Button bua;
    }
}

