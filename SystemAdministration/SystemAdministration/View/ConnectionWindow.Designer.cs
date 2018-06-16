namespace SystemAdministration.View
{
    partial class ConnectionWindow
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
            this.buttonConnectionTest = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInitialCatalog = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConnectionTest
            // 
            this.buttonConnectionTest.Location = new System.Drawing.Point(60, 194);
            this.buttonConnectionTest.Name = "buttonConnectionTest";
            this.buttonConnectionTest.Size = new System.Drawing.Size(113, 23);
            this.buttonConnectionTest.TabIndex = 0;
            this.buttonConnectionTest.Text = "Connection Test";
            this.buttonConnectionTest.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(199, 194);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(313, 194);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Initial Catalog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server";
            // 
            // textBoxInitialCatalog
            // 
            this.textBoxInitialCatalog.Location = new System.Drawing.Point(60, 66);
            this.textBoxInitialCatalog.Name = "textBoxInitialCatalog";
            this.textBoxInitialCatalog.Size = new System.Drawing.Size(328, 20);
            this.textBoxInitialCatalog.TabIndex = 5;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(60, 140);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(328, 20);
            this.textBoxServer.TabIndex = 6;
            // 
            // ConnectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 229);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.textBoxInitialCatalog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonConnectionTest);
            this.Name = "ConnectionWindow";
            this.Text = "Connection Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnectionTest;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInitialCatalog;
        private System.Windows.Forms.TextBox textBoxServer;
    }
}