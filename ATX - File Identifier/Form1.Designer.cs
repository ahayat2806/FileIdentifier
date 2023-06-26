
namespace ATX___File_Identifier
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadFile1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.fileName1 = new System.Windows.Forms.Label();
            this.uploadFile2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.fileName2 = new System.Windows.Forms.Label();
            this.checkButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATX#6009 - File Identifier";
            // 
            // uploadFile1
            // 
            this.uploadFile1.BackColor = System.Drawing.Color.Transparent;
            this.uploadFile1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadFile1.BackgroundImage")));
            this.uploadFile1.ButtonText = "Original File";
            this.uploadFile1.ButtonTextMarginLeft = 0;
            this.uploadFile1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.uploadFile1.DisabledFillColor = System.Drawing.Color.Gray;
            this.uploadFile1.DisabledForecolor = System.Drawing.Color.White;
            this.uploadFile1.ForeColor = System.Drawing.Color.White;
            this.uploadFile1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.uploadFile1.IconPadding = 10;
            this.uploadFile1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.uploadFile1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.uploadFile1.IdleBorderRadius = 1;
            this.uploadFile1.IdleBorderThickness = 0;
            this.uploadFile1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.uploadFile1.IdleIconLeftImage = null;
            this.uploadFile1.IdleIconRightImage = null;
            this.uploadFile1.Location = new System.Drawing.Point(12, 44);
            this.uploadFile1.Name = "uploadFile1";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties7.BorderRadius = 1;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.uploadFile1.onHoverState = stateProperties7;
            this.uploadFile1.Size = new System.Drawing.Size(210, 45);
            this.uploadFile1.TabIndex = 2;
            this.uploadFile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadFile1.Click += new System.EventHandler(this.uploadFile1_Click);
            // 
            // fileName1
            // 
            this.fileName1.AutoSize = true;
            this.fileName1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName1.ForeColor = System.Drawing.Color.White;
            this.fileName1.Location = new System.Drawing.Point(228, 57);
            this.fileName1.Name = "fileName1";
            this.fileName1.Size = new System.Drawing.Size(139, 32);
            this.fileName1.TabIndex = 3;
            this.fileName1.Text = "(No file set)";
            this.fileName1.Click += new System.EventHandler(this.fileName1_Click);
            // 
            // uploadFile2
            // 
            this.uploadFile2.BackColor = System.Drawing.Color.Transparent;
            this.uploadFile2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadFile2.BackgroundImage")));
            this.uploadFile2.ButtonText = "Comparison File";
            this.uploadFile2.ButtonTextMarginLeft = 0;
            this.uploadFile2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.uploadFile2.DisabledFillColor = System.Drawing.Color.Gray;
            this.uploadFile2.DisabledForecolor = System.Drawing.Color.White;
            this.uploadFile2.ForeColor = System.Drawing.Color.White;
            this.uploadFile2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.uploadFile2.IconPadding = 10;
            this.uploadFile2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.uploadFile2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.uploadFile2.IdleBorderRadius = 1;
            this.uploadFile2.IdleBorderThickness = 0;
            this.uploadFile2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.uploadFile2.IdleIconLeftImage = null;
            this.uploadFile2.IdleIconRightImage = null;
            this.uploadFile2.Location = new System.Drawing.Point(12, 95);
            this.uploadFile2.Name = "uploadFile2";
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.BorderRadius = 1;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.uploadFile2.onHoverState = stateProperties8;
            this.uploadFile2.Size = new System.Drawing.Size(210, 45);
            this.uploadFile2.TabIndex = 4;
            this.uploadFile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadFile2.Click += new System.EventHandler(this.uploadFile2_Click);
            // 
            // fileName2
            // 
            this.fileName2.AutoSize = true;
            this.fileName2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName2.ForeColor = System.Drawing.Color.White;
            this.fileName2.Location = new System.Drawing.Point(228, 108);
            this.fileName2.Name = "fileName2";
            this.fileName2.Size = new System.Drawing.Size(139, 32);
            this.fileName2.TabIndex = 5;
            this.fileName2.Text = "(No file set)";
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.Transparent;
            this.checkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkButton.BackgroundImage")));
            this.checkButton.ButtonText = "Check files";
            this.checkButton.ButtonTextMarginLeft = 0;
            this.checkButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.checkButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.checkButton.DisabledForecolor = System.Drawing.Color.White;
            this.checkButton.ForeColor = System.Drawing.Color.White;
            this.checkButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.checkButton.IconPadding = 10;
            this.checkButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.checkButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.checkButton.IdleBorderRadius = 1;
            this.checkButton.IdleBorderThickness = 0;
            this.checkButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.checkButton.IdleIconLeftImage = null;
            this.checkButton.IdleIconRightImage = null;
            this.checkButton.Location = new System.Drawing.Point(12, 146);
            this.checkButton.Name = "checkButton";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties9.BorderRadius = 1;
            stateProperties9.BorderThickness = 1;
            stateProperties9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties9.IconLeftImage = null;
            stateProperties9.IconRightImage = null;
            this.checkButton.onHoverState = stateProperties9;
            this.checkButton.Size = new System.Drawing.Size(349, 45);
            this.checkButton.TabIndex = 6;
            this.checkButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Original File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(958, 203);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.fileName2);
            this.Controls.Add(this.uploadFile2);
            this.Controls.Add(this.fileName1);
            this.Controls.Add(this.uploadFile1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "ATX - File Identifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton uploadFile1;
        private System.Windows.Forms.Label fileName1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton uploadFile2;
        private System.Windows.Forms.Label fileName2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton checkButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

