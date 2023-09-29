namespace OOP2_L2_Timer2
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
            customControlTimer21 = new CustomControlTimer2();
            SuspendLayout();
            // 
            // customControlTimer21
            // 
            customControlTimer21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            customControlTimer21.Location = new Point(0, 0);
            customControlTimer21.Name = "customControlTimer21";
            customControlTimer21.Size = new Size(285, 102);
            customControlTimer21.TabIndex = 0;
            customControlTimer21.Text = "customControlTimer21";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 103);
            Controls.Add(customControlTimer21);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CustomControlTimer2 customControlTimer21;
    }
}