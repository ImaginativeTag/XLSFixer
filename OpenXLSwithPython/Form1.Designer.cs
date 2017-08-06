namespace XLSFixer
{
    partial class OpenXLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenXLS));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.chkFreeze = new System.Windows.Forms.CheckBox();
            this.chkResize = new System.Windows.Forms.CheckBox();
            this.btnOpenCSharp = new System.Windows.Forms.Button();
            this.chkOpen = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(22, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Drag and Drop .xls files here";
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox1_DragOver);
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Checked = true;
            this.chkFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilter.Location = new System.Drawing.Point(17, 16);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(48, 17);
            this.chkFilter.TabIndex = 2;
            this.chkFilter.Text = "Filter";
            this.chkFilter.UseVisualStyleBackColor = true;
            // 
            // chkFreeze
            // 
            this.chkFreeze.AutoSize = true;
            this.chkFreeze.Checked = true;
            this.chkFreeze.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFreeze.Location = new System.Drawing.Point(71, 16);
            this.chkFreeze.Name = "chkFreeze";
            this.chkFreeze.Size = new System.Drawing.Size(80, 17);
            this.chkFreeze.TabIndex = 3;
            this.chkFreeze.Text = "Freeze Top";
            this.chkFreeze.UseVisualStyleBackColor = true;
            // 
            // chkResize
            // 
            this.chkResize.AutoSize = true;
            this.chkResize.Checked = true;
            this.chkResize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResize.Location = new System.Drawing.Point(157, 16);
            this.chkResize.Name = "chkResize";
            this.chkResize.Size = new System.Drawing.Size(58, 17);
            this.chkResize.TabIndex = 4;
            this.chkResize.Text = "Resize";
            this.chkResize.UseVisualStyleBackColor = true;
            // 
            // btnOpenCSharp
            // 
            this.btnOpenCSharp.Location = new System.Drawing.Point(17, 67);
            this.btnOpenCSharp.Name = "btnOpenCSharp";
            this.btnOpenCSharp.Size = new System.Drawing.Size(91, 20);
            this.btnOpenCSharp.TabIndex = 5;
            this.btnOpenCSharp.Text = "Run";
            this.btnOpenCSharp.UseVisualStyleBackColor = true;
            this.btnOpenCSharp.Visible = false;
            this.btnOpenCSharp.Click += new System.EventHandler(this.btnOpenCSharp_Click);
            // 
            // chkOpen
            // 
            this.chkOpen.AutoSize = true;
            this.chkOpen.Checked = true;
            this.chkOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpen.Location = new System.Drawing.Point(212, 16);
            this.chkOpen.Name = "chkOpen";
            this.chkOpen.Size = new System.Drawing.Size(52, 17);
            this.chkOpen.TabIndex = 6;
            this.chkOpen.Text = "Open";
            this.chkOpen.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(181, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 20);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 8;
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTick.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTick.Location = new System.Drawing.Point(2, 43);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(55, 16);
            this.lblTick.TabIndex = 9;
            this.lblTick.Text = "lblTick";
            this.lblTick.Visible = false;
            // 
            // OpenXLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 73);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkOpen);
            this.Controls.Add(this.btnOpenCSharp);
            this.Controls.Add(this.chkResize);
            this.Controls.Add(this.chkFreeze);
            this.Controls.Add(this.chkFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenXLS";
            this.Text = "XLS Fixer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.CheckBox chkFreeze;
        private System.Windows.Forms.CheckBox chkResize;
        private System.Windows.Forms.Button btnOpenCSharp;
        private System.Windows.Forms.CheckBox chkOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTick;
    }
}

