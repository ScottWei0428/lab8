namespace lab8
{
    partial class Form1
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
            BtnGenerate = new Button();
            tbxInput = new TextBox();
            listBoxResult = new ListBox();
            SuspendLayout();
            // 
            // BtnGenerate
            // 
            BtnGenerate.Location = new Point(251, 12);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(148, 51);
            BtnGenerate.TabIndex = 0;
            BtnGenerate.Text = "&Generate";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // tbxInput
            // 
            tbxInput.Location = new Point(35, 22);
            tbxInput.Multiline = true;
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(193, 41);
            tbxInput.TabIndex = 1;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 24;
            listBoxResult.Location = new Point(35, 108);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.ScrollAlwaysVisible = true;
            listBoxResult.Size = new Size(386, 316);
            listBoxResult.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResult);
            Controls.Add(tbxInput);
            Controls.Add(BtnGenerate);
            Name = "Form1";
            Text = "Multi-Threading Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGenerate;
        private TextBox tbxInput;
        private ListBox listBoxResult;
    }
}
