namespace DesignTest
{
    partial class DesignTest
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
            this.KeyWordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KeyWordTextBox
            // 
            this.KeyWordTextBox.Location = new System.Drawing.Point(103, 99);
            this.KeyWordTextBox.Name = "KeyWordTextBox";
            this.KeyWordTextBox.Size = new System.Drawing.Size(116, 23);
            this.KeyWordTextBox.TabIndex = 0;
            this.KeyWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyWordTextBox.TextChanged += new System.EventHandler(this.KeyWordTextBox_TextChanged);
            // 
            // ConfirmationLabel
            // 
            this.ConfirmationLabel.AutoSize = true;
            this.ConfirmationLabel.Location = new System.Drawing.Point(122, 125);
            this.ConfirmationLabel.Name = "ConfirmationLabel";
            this.ConfirmationLabel.Size = new System.Drawing.Size(81, 15);
            this.ConfirmationLabel.TabIndex = 2;
            this.ConfirmationLabel.Text = "Not Key Word";
            // 
            // DesignTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 301);
            this.Controls.Add(this.ConfirmationLabel);
            this.Controls.Add(this.KeyWordTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DesignTest";
            this.Text = "Design Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KeyWordTextBox;
        private System.Windows.Forms.Label ConfirmationLabel;
    }
}

