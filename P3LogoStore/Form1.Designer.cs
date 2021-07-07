namespace P3LogoStore
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
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.gboxItemType = new System.Windows.Forms.GroupBox();
            this.rbtnUsb = new System.Windows.Forms.RadioButton();
            this.rbtnMug = new System.Windows.Forms.RadioButton();
            this.rbtnPen = new System.Windows.Forms.RadioButton();
            this.lblNumItems = new System.Windows.Forms.Label();
            this.txtNumItems = new System.Windows.Forms.TextBox();
            this.txtPrintedText = new System.Windows.Forms.TextBox();
            this.lblPrintedText = new System.Windows.Forms.Label();
            this.cboxLogo = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.lblNumColors = new System.Windows.Forms.Label();
            this.txtNumColors = new System.Windows.Forms.TextBox();
            this.gboxItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(25, 27);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(85, 13);
            this.lblOrderNum.TabIndex = 0;
            this.lblOrderNum.Text = "Order Number";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(135, 24);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(140, 20);
            this.txtOrderNum.TabIndex = 1;
            // 
            // gboxItemType
            // 
            this.gboxItemType.Controls.Add(this.rbtnPen);
            this.gboxItemType.Controls.Add(this.rbtnUsb);
            this.gboxItemType.Controls.Add(this.rbtnMug);
            this.gboxItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxItemType.Location = new System.Drawing.Point(135, 117);
            this.gboxItemType.Name = "gboxItemType";
            this.gboxItemType.Size = new System.Drawing.Size(140, 128);
            this.gboxItemType.TabIndex = 2;
            this.gboxItemType.TabStop = false;
            this.gboxItemType.Text = "Item Type";
            // 
            // rbtnUsb
            // 
            this.rbtnUsb.AutoSize = true;
            this.rbtnUsb.Location = new System.Drawing.Point(21, 19);
            this.rbtnUsb.Name = "rbtnUsb";
            this.rbtnUsb.Size = new System.Drawing.Size(50, 17);
            this.rbtnUsb.TabIndex = 3;
            this.rbtnUsb.TabStop = true;
            this.rbtnUsb.Text = "USB";
            this.rbtnUsb.UseVisualStyleBackColor = true;
            // 
            // rbtnMug
            // 
            this.rbtnMug.AutoSize = true;
            this.rbtnMug.Location = new System.Drawing.Point(21, 54);
            this.rbtnMug.Name = "rbtnMug";
            this.rbtnMug.Size = new System.Drawing.Size(49, 17);
            this.rbtnMug.TabIndex = 4;
            this.rbtnMug.TabStop = true;
            this.rbtnMug.Text = "Mug";
            this.rbtnMug.UseVisualStyleBackColor = true;
            // 
            // rbtnPen
            // 
            this.rbtnPen.AutoSize = true;
            this.rbtnPen.Location = new System.Drawing.Point(21, 89);
            this.rbtnPen.Name = "rbtnPen";
            this.rbtnPen.Size = new System.Drawing.Size(47, 17);
            this.rbtnPen.TabIndex = 5;
            this.rbtnPen.TabStop = true;
            this.rbtnPen.Text = "Pen";
            this.rbtnPen.UseVisualStyleBackColor = true;
            // 
            // lblNumItems
            // 
            this.lblNumItems.AutoSize = true;
            this.lblNumItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumItems.Location = new System.Drawing.Point(25, 66);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(99, 13);
            this.lblNumItems.TabIndex = 3;
            this.lblNumItems.Text = "Number of Items";
            // 
            // txtNumItems
            // 
            this.txtNumItems.Location = new System.Drawing.Point(135, 66);
            this.txtNumItems.Name = "txtNumItems";
            this.txtNumItems.Size = new System.Drawing.Size(140, 20);
            this.txtNumItems.TabIndex = 4;
            // 
            // txtPrintedText
            // 
            this.txtPrintedText.Location = new System.Drawing.Point(28, 293);
            this.txtPrintedText.Multiline = true;
            this.txtPrintedText.Name = "txtPrintedText";
            this.txtPrintedText.Size = new System.Drawing.Size(247, 57);
            this.txtPrintedText.TabIndex = 5;
            // 
            // lblPrintedText
            // 
            this.lblPrintedText.AutoSize = true;
            this.lblPrintedText.Location = new System.Drawing.Point(25, 277);
            this.lblPrintedText.Name = "lblPrintedText";
            this.lblPrintedText.Size = new System.Drawing.Size(113, 13);
            this.lblPrintedText.TabIndex = 6;
            this.lblPrintedText.Text = "Text to engrave/print: ";
            // 
            // cboxLogo
            // 
            this.cboxLogo.AutoSize = true;
            this.cboxLogo.Checked = true;
            this.cboxLogo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxLogo.Location = new System.Drawing.Point(219, 361);
            this.cboxLogo.Name = "cboxLogo";
            this.cboxLogo.Size = new System.Drawing.Size(56, 17);
            this.cboxLogo.TabIndex = 7;
            this.cboxLogo.Text = "Logo?";
            this.cboxLogo.UseVisualStyleBackColor = true;
            this.cboxLogo.CheckedChanged += new System.EventHandler(this.cboxLogo_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(28, 442);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(28, 484);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Size = new System.Drawing.Size(247, 54);
            this.txtSummary.TabIndex = 10;
            // 
            // lblNumColors
            // 
            this.lblNumColors.AutoSize = true;
            this.lblNumColors.Location = new System.Drawing.Point(25, 397);
            this.lblNumColors.Name = "lblNumColors";
            this.lblNumColors.Size = new System.Drawing.Size(93, 13);
            this.lblNumColors.TabIndex = 11;
            this.lblNumColors.Text = "Number of colors: ";
            // 
            // txtNumColors
            // 
            this.txtNumColors.Location = new System.Drawing.Point(175, 394);
            this.txtNumColors.Name = "txtNumColors";
            this.txtNumColors.Size = new System.Drawing.Size(100, 20);
            this.txtNumColors.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 592);
            this.Controls.Add(this.txtNumColors);
            this.Controls.Add(this.lblNumColors);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboxLogo);
            this.Controls.Add(this.lblPrintedText);
            this.Controls.Add(this.txtPrintedText);
            this.Controls.Add(this.txtNumItems);
            this.Controls.Add(this.lblNumItems);
            this.Controls.Add(this.gboxItemType);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.lblOrderNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxItemType.ResumeLayout(false);
            this.gboxItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.GroupBox gboxItemType;
        private System.Windows.Forms.RadioButton rbtnPen;
        private System.Windows.Forms.RadioButton rbtnUsb;
        private System.Windows.Forms.RadioButton rbtnMug;
        private System.Windows.Forms.Label lblNumItems;
        private System.Windows.Forms.TextBox txtNumItems;
        private System.Windows.Forms.TextBox txtPrintedText;
        private System.Windows.Forms.Label lblPrintedText;
        private System.Windows.Forms.CheckBox cboxLogo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label lblNumColors;
        private System.Windows.Forms.TextBox txtNumColors;
    }
}

