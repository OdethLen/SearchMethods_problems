namespace Search_method_problems
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
            btnLinearSearch = new Button();
            txtNumbers = new TextBox();
            txtSearch = new TextBox();
            btnGenerate = new Button();
            dgvSearch = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            SuspendLayout();
            // 
            // btnLinearSearch
            // 
            btnLinearSearch.Font = new Font("Yu Gothic", 9F);
            btnLinearSearch.Location = new Point(36, 146);
            btnLinearSearch.Name = "btnLinearSearch";
            btnLinearSearch.Size = new Size(104, 23);
            btnLinearSearch.TabIndex = 0;
            btnLinearSearch.Text = "Linear Search ";
            btnLinearSearch.UseVisualStyleBackColor = true;
            btnLinearSearch.Click += btnLinearSearch_Click;
            // 
            // txtNumbers
            // 
            txtNumbers.Font = new Font("Yu Gothic", 9F);
            txtNumbers.Location = new Point(151, 107);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.ReadOnly = true;
            txtNumbers.Size = new Size(163, 27);
            txtNumbers.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Yu Gothic", 9F);
            txtSearch.Location = new Point(151, 147);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(163, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Yu Gothic", 9F);
            btnGenerate.Location = new Point(36, 106);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(104, 23);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate ";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // dgvSearch
            // 
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Location = new Point(360, 21);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.Size = new Size(252, 259);
            dgvSearch.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 327);
            Controls.Add(dgvSearch);
            Controls.Add(btnGenerate);
            Controls.Add(txtSearch);
            Controls.Add(txtNumbers);
            Controls.Add(btnLinearSearch);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLinearSearch;
        private TextBox txtNumbers;
        private TextBox txtSearch;
        private Button btnGenerate;
        private DataGridView dgvSearch;
    }
}
