namespace Search_method_problems
{
    partial class Form4
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
            btnHash = new Button();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // btnHash
            // 
            btnHash.Font = new Font("Yu Gothic", 9F);
            btnHash.Location = new Point(105, 195);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(112, 23);
            btnHash.TabIndex = 7;
            btnHash.Text = "Hash ";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnHash_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Yu Gothic", 9F);
            btnGenerate.Location = new Point(105, 157);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(112, 23);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate ";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHash);
            Controls.Add(btnGenerate);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHash;
        private Button btnGenerate;
    }
}