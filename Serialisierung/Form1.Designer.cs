namespace Serialisierung
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
            this.LbxFahrzeuge = new System.Windows.Forms.ListBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSaveXml = new System.Windows.Forms.Button();
            this.BtnLoadXml = new System.Windows.Forms.Button();
            this.LblMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbxFahrzeuge
            // 
            this.LbxFahrzeuge.FormattingEnabled = true;
            this.LbxFahrzeuge.Location = new System.Drawing.Point(12, 12);
            this.LbxFahrzeuge.Name = "LbxFahrzeuge";
            this.LbxFahrzeuge.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbxFahrzeuge.Size = new System.Drawing.Size(189, 186);
            this.LbxFahrzeuge.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(207, 12);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(97, 33);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "Neues FZ";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(207, 129);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(97, 33);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Lade FZ";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(207, 90);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(97, 33);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Speichere FZ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(207, 51);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(97, 33);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Lösche FZ";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSaveXml
            // 
            this.BtnSaveXml.Location = new System.Drawing.Point(207, 168);
            this.BtnSaveXml.Name = "BtnSaveXml";
            this.BtnSaveXml.Size = new System.Drawing.Size(97, 42);
            this.BtnSaveXml.TabIndex = 5;
            this.BtnSaveXml.Text = "Speichere FZ als XML";
            this.BtnSaveXml.UseVisualStyleBackColor = true;
            this.BtnSaveXml.Click += new System.EventHandler(this.BtnSaveXml_Click);
            // 
            // BtnLoadXml
            // 
            this.BtnLoadXml.Location = new System.Drawing.Point(207, 216);
            this.BtnLoadXml.Name = "BtnLoadXml";
            this.BtnLoadXml.Size = new System.Drawing.Size(97, 42);
            this.BtnLoadXml.TabIndex = 6;
            this.BtnLoadXml.Text = "Lade FZ aus XML";
            this.BtnLoadXml.UseVisualStyleBackColor = true;
            this.BtnLoadXml.Click += new System.EventHandler(this.BtnLoadXml_Click);
            // 
            // LblMain
            // 
            this.LblMain.AutoSize = true;
            this.LblMain.Location = new System.Drawing.Point(21, 216);
            this.LblMain.Name = "LblMain";
            this.LblMain.Size = new System.Drawing.Size(35, 13);
            this.LblMain.TabIndex = 7;
            this.LblMain.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 265);
            this.Controls.Add(this.LblMain);
            this.Controls.Add(this.BtnLoadXml);
            this.Controls.Add(this.BtnSaveXml);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.LbxFahrzeuge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbxFahrzeuge;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSaveXml;
        private System.Windows.Forms.Button BtnLoadXml;
        private System.Windows.Forms.Label LblMain;
    }
}

