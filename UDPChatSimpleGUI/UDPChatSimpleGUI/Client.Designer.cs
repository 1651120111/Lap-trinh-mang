namespace UDPChatSimpleGUI
{
    partial class Client
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
            this.butKetnoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numServerPort = new System.Windows.Forms.NumericUpDown();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // butGui
            // 
            this.butGui.Location = new System.Drawing.Point(627, 369);
            this.butGui.Name = "butGui";
            this.butGui.Size = new System.Drawing.Size(118, 38);
            this.butGui.TabIndex = 17;
            this.butGui.Text = "Gui";
            this.butGui.UseVisualStyleBackColor = true;
            // 
            // txtThongdiep
            // 
            this.txtThongdiep.Location = new System.Drawing.Point(36, 377);
            this.txtThongdiep.Name = "txtThongdiep";
            this.txtThongdiep.Size = new System.Drawing.Size(569, 22);
            this.txtThongdiep.TabIndex = 16;
            // 
            // txtNoidungChat
            // 
            this.txtNoidungChat.Location = new System.Drawing.Point(36, 134);
            this.txtNoidungChat.Multiline = true;
            this.txtNoidungChat.Name = "txtNoidungChat";
            this.txtNoidungChat.Size = new System.Drawing.Size(728, 228);
            this.txtNoidungChat.TabIndex = 15;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTrangThai.Location = new System.Drawing.Point(36, 96);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(729, 35);
            this.lbTrangThai.TabIndex = 14;
            this.lbTrangThai.Text = "Chua ket noi";
            this.lbTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butKetnoi
            // 
            this.butKetnoi.Location = new System.Drawing.Point(627, 43);
            this.butKetnoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butKetnoi.Name = "butKetnoi";
            this.butKetnoi.Size = new System.Drawing.Size(99, 32);
            this.butKetnoi.TabIndex = 13;
            this.butKetnoi.Text = "Ket noi";
            this.butKetnoi.UseVisualStyleBackColor = true;
            this.butKetnoi.Click += new System.EventHandler(this.butKetnoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server IP";
            // 
            // numServerPort
            // 
            this.numServerPort.Location = new System.Drawing.Point(459, 45);
            this.numServerPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numServerPort.Name = "numServerPort";
            this.numServerPort.Size = new System.Drawing.Size(122, 22);
            this.numServerPort.TabIndex = 10;
            this.numServerPort.Value = new decimal(new int[] {
            12345,
            0,
            0,
            0});
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(177, 45);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(204, 22);
            this.txtServerIP.TabIndex = 9;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butGui);
            this.Controls.Add(this.txtThongdiep);
            this.Controls.Add(this.txtNoidungChat);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.butKetnoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numServerPort);
            this.Controls.Add(this.txtServerIP);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butGui;
        private System.Windows.Forms.TextBox txtThongdiep;
        private System.Windows.Forms.TextBox txtNoidungChat;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Button butKetnoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
    }
}