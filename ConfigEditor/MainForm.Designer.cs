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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEditServer = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 525);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Öffnen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(89, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(153, 148);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(361, 23);
            this.txtServer.TabIndex = 3;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(153, 372);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(361, 23);
            this.txtClient.TabIndex = 4;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(153, 21);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(39, 15);
            this.lblServer.TabIndex = 5;
            this.lblServer.Text = "Server";
            // 
            // btnAddServer
            // 
            this.btnAddServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddServer.Location = new System.Drawing.Point(151, 206);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(75, 24);
            this.btnAddServer.TabIndex = 6;
            this.btnAddServer.Text = "Add";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Location = new System.Drawing.Point(153, 254);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(43, 15);
            this.lblClients.TabIndex = 7;
            this.lblClients.Text = "Clients";
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 15;
            this.lbClients.Location = new System.Drawing.Point(153, 272);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(361, 94);
            this.lbClients.TabIndex = 8;
            // 
            // lbServer
            // 
            this.lbServer.FormattingEnabled = true;
            this.lbServer.ItemHeight = 15;
            this.lbServer.Location = new System.Drawing.Point(153, 39);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(361, 94);
            this.lbServer.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Connection String";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 23);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "TSClient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Path";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(153, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 24);
            this.panel1.TabIndex = 20;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(53, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 19);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton1.Size = new System.Drawing.Size(42, 19);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(439, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 21;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(439, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 24;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(151, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 24);
            this.button4.TabIndex = 22;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Config Files|*.xml";
            // 
            // btnEditServer
            // 
            this.btnEditServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditServer.Location = new System.Drawing.Point(232, 206);
            this.btnEditServer.Name = "btnEditServer";
            this.btnEditServer.Size = new System.Drawing.Size(75, 24);
            this.btnEditServer.TabIndex = 25;
            this.btnEditServer.Text = "Edit";
            this.btnEditServer.UseVisualStyleBackColor = true;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditClient.Location = new System.Drawing.Point(232, 452);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(75, 24);
            this.btnEditClient.TabIndex = 26;
            this.btnEditClient.Text = "Edit";
            this.btnEditClient.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 560);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnEditServer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private Button btnEditServer;
        private Button btnEditClient;
    }
}