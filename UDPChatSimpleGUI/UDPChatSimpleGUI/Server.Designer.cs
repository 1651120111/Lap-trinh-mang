namespace UDPChatSimpleGUI
{
    partial class Server
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
            this.butGui = new System.Windows.Forms.Button();
            this.txtThongdiep = new System.Windows.Forms.TextBox();
            this.txtNoidungChat = new System.Windows.Forms.TextBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.butKhoitao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numServerPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // butGui
            // 
            this.butGui.Location = new System.Drawing.Point(624, 364);
            this.butGui.Name = "butGui";
            this.butGui.Size = new System.Drawing.Size(118, 38);
            this.butGui.TabIndex = 19;
            this.butGui.Text = "Gui";
            this.butGui.UseVisualStyleBackColor = true;
            this.butGui.Click += new System.EventHandler(this.butGui_Click);
            // 
            // txtThongdiep
            // 
            this.txtThongdiep.Location = new System.Drawing.Point(33, 372);
            this.txtThongdiep.Name = "txtThongdiep";
            this.txtThongdiep.Size = new System.Drawing.Size(569, 22);
            this.txtThongdiep.TabIndex = 18;
            // 
            // txtNoidungChat
            // 
            this.txtNoidungChat.Location = new System.Drawing.Point(33, 129);
            this.txtNoidungChat.Multiline = true;
            this.txtNoidungChat.Name = "txtNoidungChat";
            this.txtNoidungChat.Size = new System.Drawing.Size(728, 228);
            this.txtNoidungChat.TabIndex = 17;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTrangThai.Location = new System.Drawing.Point(33, 91);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(723, 35);
            this.lbTrangThai.TabIndex = 16;
            this.lbTrangThai.Text = "Chua ket noi";
            this.lbTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butKhoitao
            // 
            this.butKhoitao.Location = new System.Drawing.Point(472, 37);
            this.butKhoitao.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.butKhoitao.Name = "butKhoitao";
            this.butKhoitao.Size = new System.Drawing.Size(190, 37);
            this.butKhoitao.TabIndex = 15;
            this.butKhoitao.Text = "Khoi tao server";
            this.butKhoitao.UseVisualStyleBackColor = true;
            this.butKhoitao.Click += new System.EventHandler(this.butKhoitao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Server chay tren Port";
            // 
            // numServerPort
            // 
            this.numServerPort.Location = new System.Drawing.Point(243, 44);
            this.numServerPort.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.numServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numServerPort.Name = "numServerPort";
            this.numServerPort.Size = new System.Drawing.Size(181, 22);
            this.numServerPort.TabIndex = 13;
            this.numServerPort.Value = new decimal(new int[] {
            12345,
            0,
            0,
            0});
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 438);
            this.Controls.Add(this.butGui);
            this.Controls.Add(this.txtThongdiep);
            this.Controls.Add(this.txtNoidungChat);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.butKhoitao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numServerPort);
            this.Name = "Server";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butGui;
        private System.Windows.Forms.TextBox txtThongdiep;
        private System.Windows.Forms.TextBox txtNoidungChat;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Button butKhoitao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numServerPort;
    }
}