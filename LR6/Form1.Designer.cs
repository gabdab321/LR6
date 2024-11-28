namespace LR6
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
            btnToSet = new Button();
            btnToArray = new Button();
            txtArrayInput = new TextBox();
            txtSetOutput = new TextBox();
            txtSetInput = new TextBox();
            txtArrayOutput = new TextBox();
            SuspendLayout();

            this.txtArrayInput.Location = new System.Drawing.Point(20, 20);
            this.txtArrayInput.Size = new System.Drawing.Size(260, 20);
            this.txtArrayInput.PlaceholderText = "Enter array (e.g., 1, 2, 3)";

            // ToSet Button
            this.btnToSet.Location = new System.Drawing.Point(20, 50);
            this.btnToSet.Size = new System.Drawing.Size(100, 30);
            this.btnToSet.Text = "To Set";
            this.btnToSet.Click += new System.EventHandler(this.btnToSet_Click);

            // Set Output
            this.txtSetOutput.Location = new System.Drawing.Point(20, 90);
            this.txtSetOutput.Size = new System.Drawing.Size(260, 20);
            this.txtSetOutput.ReadOnly = true;

            // Set Input
            this.txtSetInput.Location = new System.Drawing.Point(20, 130);
            this.txtSetInput.Size = new System.Drawing.Size(260, 20);
            this.txtSetInput.PlaceholderText = "Enter set (e.g., 1, 2, 3)";

            // ToArray Button
            this.btnToArray.Location = new System.Drawing.Point(20, 160);
            this.btnToArray.Size = new System.Drawing.Size(100, 30);
            this.btnToArray.Text = "To Array";
            this.btnToArray.Click += new System.EventHandler(this.btnToArray_Click);

            // Array Output
            this.txtArrayOutput.Location = new System.Drawing.Point(20, 200);
            this.txtArrayOutput.Size = new System.Drawing.Size(260, 20);
            this.txtArrayOutput.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnToSet);
            Controls.Add(txtArrayInput);
            Controls.Add(txtSetOutput);
            Controls.Add(txtSetInput);
            Controls.Add(btnToArray);
            Controls.Add(txtArrayOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnToSet;
        private TextBox txtArrayInput;
        private TextBox txtSetOutput;
        private TextBox txtSetInput;
        private Button btnToArray;
        private TextBox txtArrayOutput;
    }
}
