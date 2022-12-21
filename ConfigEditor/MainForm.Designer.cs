namespace ConfigEditor
{
    partial class MainForm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.lblClients = new System.Windows.Forms.Label();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.lbServer = new System.Windows.Forms.ListBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnRemoveServer = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(67, 214);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Öffnen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(66, 149);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(120, 23);
            this.txtServer.TabIndex = 3;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(292, 149);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(120, 23);
            this.txtClient.TabIndex = 4;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(66, 22);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(39, 15);
            this.lblServer.TabIndex = 5;
            this.lblServer.Text = "Server";
            // 
            // btnAddServer
            // 
            this.btnAddServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddServer.Location = new System.Drawing.Point(192, 148);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(31, 24);
            this.btnAddServer.TabIndex = 6;
            this.btnAddServer.Text = "+";
            this.btnAddServer.UseVisualStyleBackColor = true;
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Location = new System.Drawing.Point(292, 22);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(43, 15);
            this.lblClients.TabIndex = 7;
            this.lblClients.Text = "Clients";
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 15;
            this.lbClients.Location = new System.Drawing.Point(292, 40);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(120, 94);
            this.lbClients.TabIndex = 8;
            // 
            // lbServer
            // 
            this.lbServer.FormattingEnabled = true;
            this.lbServer.ItemHeight = 15;
            this.lbServer.Location = new System.Drawing.Point(66, 40);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(120, 94);
            this.lbServer.TabIndex = 9;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddClient.Location = new System.Drawing.Point(418, 149);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(31, 24);
            this.btnAddClient.TabIndex = 10;
            this.btnAddClient.Text = "+";
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // btnRemoveServer
            // 
            this.btnRemoveServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveServer.Location = new System.Drawing.Point(229, 147);
            this.btnRemoveServer.Name = "btnRemoveServer";
            this.btnRemoveServer.Size = new System.Drawing.Size(31, 24);
            this.btnRemoveServer.TabIndex = 11;
            this.btnRemoveServer.Text = "-";
            this.btnRemoveServer.UseVisualStyleBackColor = true;
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveClient.Location = new System.Drawing.Point(455, 149);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(31, 24);
            this.btnRemoveClient.TabIndex = 12;
            this.btnRemoveClient.Text = "-";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 257);
            this.Controls.Add(this.btnRemoveClient);
            this.Controls.Add(this.btnRemoveServer);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.btnAddServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Name = "MainForm";
            this.Text = "Config-Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnOpen;
        private Button btnSave;
        private TextBox txtServer;
        private TextBox txtClient;
        private Label lblServer;
        private Button btnAddServer;
        private Label lblClients;
        private ListBox lbClients;
        private ListBox lbServer;
        private Button btnAddClient;
        private Button btnRemoveServer;
        private Button btnRemoveClient;
    }
}