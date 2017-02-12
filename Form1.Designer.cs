namespace passwordgeneretor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.restrictionsF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.restrictionsT = new System.Windows.Forms.TextBox();
            this.generateButn = new System.Windows.Forms.Button();
            this.displayLBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Character Restrictions From";
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(182, 11);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 2;
            // 
            // restrictionsF
            // 
            this.restrictionsF.Location = new System.Drawing.Point(182, 40);
            this.restrictionsF.Name = "restrictionsF";
            this.restrictionsF.Size = new System.Drawing.Size(100, 20);
            this.restrictionsF.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Character Restrictions to";
            // 
            // restrictionsT
            // 
            this.restrictionsT.Location = new System.Drawing.Point(182, 71);
            this.restrictionsT.Name = "restrictionsT";
            this.restrictionsT.Size = new System.Drawing.Size(100, 20);
            this.restrictionsT.TabIndex = 5;
            // 
            // generateButn
            // 
            this.generateButn.Location = new System.Drawing.Point(258, 106);
            this.generateButn.Name = "generateButn";
            this.generateButn.Size = new System.Drawing.Size(75, 23);
            this.generateButn.TabIndex = 6;
            this.generateButn.Text = "Generate";
            this.generateButn.UseVisualStyleBackColor = true;
            this.generateButn.Click += new System.EventHandler(this.generateButn_Click);
            // 
            // displayLBox
            // 
            this.displayLBox.FormattingEnabled = true;
            this.displayLBox.Location = new System.Drawing.Point(42, 123);
            this.displayLBox.Name = "displayLBox";
            this.displayLBox.Size = new System.Drawing.Size(120, 95);
            this.displayLBox.TabIndex = 7;
            this.displayLBox.SelectedIndexChanged += new System.EventHandler(this.displayLBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.displayLBox);
            this.Controls.Add(this.generateButn);
            this.Controls.Add(this.restrictionsT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.restrictionsF);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox restrictionsF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox restrictionsT;
        private System.Windows.Forms.Button generateButn;
        private System.Windows.Forms.ListBox displayLBox;
    }
}

