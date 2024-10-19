namespace _03_Eventos
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
            btnVideoEncode = new Button();
            SuspendLayout();
            // 
            // btnVideoEncode
            // 
            btnVideoEncode.Location = new Point(38, 86);
            btnVideoEncode.Name = "btnVideoEncode";
            btnVideoEncode.Size = new Size(253, 94);
            btnVideoEncode.TabIndex = 0;
            btnVideoEncode.Text = "Video Encode";
            btnVideoEncode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 226);
            Controls.Add(btnVideoEncode);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVideoEncode;
    }
}
