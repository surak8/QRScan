//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace NSQRScan {
    
    public partial class QRScanForm : System.Windows.Forms.Form {
        #region fields
        /// <summary>
        /// Required designer variable.
        /// </summary>
        IContainer components = null;
        MenuStrip ms1;
        ToolStripMenuItem tsmiFile;
        ToolStripMenuItem tsmiFileExit;
        #endregion
        #region Windows Form Designer generated code
        /// <summary>Required method for Designer support</summary>
        void InitializeComponent() {
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.tbModelNumber = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pbData = new System.Windows.Forms.PictureBox();
            this.myView1 = new NSQRScan.MyView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLoadModels = new System.Windows.Forms.Button();
            this.ms1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).BeginInit();
            this.SuspendLayout();
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(284, 24);
            this.ms1.TabIndex = 0;
            this.ms1.Text = "ms1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiFileExit
            // 
            this.tsmiFileExit.Name = "tsmiFileExit";
            this.tsmiFileExit.Size = new System.Drawing.Size(92, 22);
            this.tsmiFileExit.Text = "Exit";
            this.tsmiFileExit.Click += new System.EventHandler(this.exitClick);
            // 
            // tbInput
            // 
            this.tbInput.AcceptsReturn = true;
            this.tbInput.Location = new System.Drawing.Point(12, 27);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(247, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.Enter += new System.EventHandler(this.tbInput_Enter);
            this.tbInput.Validated += new System.EventHandler(this.tbInput_Validated);
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Location = new System.Drawing.Point(95, 158);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(164, 20);
            this.tbSerialNumber.TabIndex = 2;
            // 
            // tbModelNumber
            // 
            this.tbModelNumber.Location = new System.Drawing.Point(95, 178);
            this.tbModelNumber.Name = "tbModelNumber";
            this.tbModelNumber.Size = new System.Drawing.Size(164, 20);
            this.tbModelNumber.TabIndex = 3;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(95, 198);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(164, 20);
            this.tbDate.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 158);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(77, 20);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pbData
            // 
            this.pbData.Location = new System.Drawing.Point(12, 67);
            this.pbData.Name = "pbData";
            this.pbData.Size = new System.Drawing.Size(72, 72);
            this.pbData.TabIndex = 6;
            this.pbData.TabStop = false;
            this.pbData.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbData_DragDrop);
            this.pbData.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbData_DragEnter);
            this.pbData.DragOver += new System.Windows.Forms.DragEventHandler(this.pbData_DragOver);
            this.pbData.DragLeave += new System.EventHandler(this.pbData_DragLeave);
            // 
            // myView1
            // 
            this.myView1.AllowDrop = true;
            this.myView1.image = null;
            this.myView1.Location = new System.Drawing.Point(109, 67);
            this.myView1.Name = "myView1";
            this.myView1.Size = new System.Drawing.Size(72, 72);
            this.myView1.TabIndex = 7;
            this.myView1.Text = "myView1";
            this.myView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.myView1_DragDrop);
            this.myView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.myView1_DragEnter);
            this.myView1.DragOver += new System.Windows.Forms.DragEventHandler(this.myView1_DragOver);
            this.myView1.DragLeave += new System.EventHandler(this.myView1_DragLeave);
            this.myView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myView1_MouseMove);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 178);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(77, 20);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print...";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLoadModels
            // 
            this.btnLoadModels.Location = new System.Drawing.Point(12, 198);
            this.btnLoadModels.Name = "btnLoadModels";
            this.btnLoadModels.Size = new System.Drawing.Size(77, 20);
            this.btnLoadModels.TabIndex = 9;
            this.btnLoadModels.Text = "Load models";
            this.btnLoadModels.UseVisualStyleBackColor = true;
            this.btnLoadModels.Click += new System.EventHandler(this.btnLoadModels_Click);
            // 
            // QRScanForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnLoadModels);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.myView1);
            this.Controls.Add(this.pbData);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbModelNumber);
            this.Controls.Add(this.tbSerialNumber);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.ms1);
            this.MainMenuStrip = this.ms1;
            this.Name = "QRScanForm";
            this.Load += new System.EventHandler(this.formLoad);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if ((components != null)) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private TextBox tbInput;
        private TextBox tbSerialNumber;
        private TextBox tbModelNumber;
        private TextBox tbDate;
        private Button btnGenerate;
        private PictureBox pbData;
        private MyView myView1;
        private Button btnPrint;
        private Button btnLoadModels;
    }
}