namespace Directory
{
    partial class AllThemes
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
            this.themeTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tagsTB = new System.Windows.Forms.TextBox();
            this.labelTag = new System.Windows.Forms.Label();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // themeTB
            // 
            this.themeTB.Location = new System.Drawing.Point(435, 41);
            this.themeTB.Name = "themeTB";
            this.themeTB.Size = new System.Drawing.Size(188, 20);
            this.themeTB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(629, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tagsTB
            // 
            this.tagsTB.Location = new System.Drawing.Point(435, 72);
            this.tagsTB.Name = "tagsTB";
            this.tagsTB.Size = new System.Drawing.Size(188, 20);
            this.tagsTB.TabIndex = 5;
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(400, 75);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(29, 13);
            this.labelTag.TabIndex = 6;
            this.labelTag.Text = "теги";
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.Location = new System.Drawing.Point(397, 128);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(327, 312);
            this.ThemeLabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Все темы:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(13, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 359);
            this.panel1.TabIndex = 9;
            // 
            // AllThemes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.tagsTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.themeTB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AllThemes";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox themeTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tagsTB;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}