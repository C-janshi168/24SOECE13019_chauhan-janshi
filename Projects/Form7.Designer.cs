namespace Projects
{
    partial class Form7
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
            RED_BTN = new RadioButton();
            GREEN_BTN = new RadioButton();
            BLUE_BTN = new RadioButton();
            CYAN_BTN = new RadioButton();
            PINK_BTN = new RadioButton();
            BLACK_BTN = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // RED_BTN
            // 
            RED_BTN.AutoSize = true;
            RED_BTN.Location = new Point(34, 26);
            RED_BTN.Name = "RED_BTN";
            RED_BTN.Size = new Size(59, 24);
            RED_BTN.TabIndex = 0;
            RED_BTN.TabStop = true;
            RED_BTN.Text = "RED";
            RED_BTN.UseVisualStyleBackColor = true;
            RED_BTN.CheckedChanged += RED_BTN_CheckedChanged;
            // 
            // GREEN_BTN
            // 
            GREEN_BTN.AutoSize = true;
            GREEN_BTN.Location = new Point(202, 26);
            GREEN_BTN.Name = "GREEN_BTN";
            GREEN_BTN.Size = new Size(79, 24);
            GREEN_BTN.TabIndex = 1;
            GREEN_BTN.TabStop = true;
            GREEN_BTN.Text = "GREEN";
            GREEN_BTN.UseVisualStyleBackColor = true;
            GREEN_BTN.CheckedChanged += GREEN_BTN_CheckedChanged;
            // 
            // BLUE_BTN
            // 
            BLUE_BTN.AutoSize = true;
            BLUE_BTN.Location = new Point(375, 26);
            BLUE_BTN.Name = "BLUE_BTN";
            BLUE_BTN.Size = new Size(67, 24);
            BLUE_BTN.TabIndex = 2;
            BLUE_BTN.TabStop = true;
            BLUE_BTN.Text = "BLUE";
            BLUE_BTN.UseVisualStyleBackColor = true;
            BLUE_BTN.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // CYAN_BTN
            // 
            CYAN_BTN.AutoSize = true;
            CYAN_BTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CYAN_BTN.Location = new Point(0, 38);
            CYAN_BTN.Name = "CYAN_BTN";
            CYAN_BTN.Size = new Size(70, 24);
            CYAN_BTN.TabIndex = 5;
            CYAN_BTN.TabStop = true;
            CYAN_BTN.Text = "CYAN";
            CYAN_BTN.UseVisualStyleBackColor = true;
            CYAN_BTN.CheckedChanged += CYAN_BTN_CheckedChanged;
            // 
            // PINK_BTN
            // 
            PINK_BTN.AutoSize = true;
            PINK_BTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PINK_BTN.Location = new Point(162, 38);
            PINK_BTN.Name = "PINK_BTN";
            PINK_BTN.Size = new Size(66, 24);
            PINK_BTN.TabIndex = 4;
            PINK_BTN.TabStop = true;
            PINK_BTN.Text = "PINK";
            PINK_BTN.UseVisualStyleBackColor = true;
            PINK_BTN.CheckedChanged += PINK_BTN_CheckedChanged;
            // 
            // BLACK_BTN
            // 
            BLACK_BTN.AutoSize = true;
            BLACK_BTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BLACK_BTN.Location = new Point(335, 38);
            BLACK_BTN.Name = "BLACK_BTN";
            BLACK_BTN.Size = new Size(78, 24);
            BLACK_BTN.TabIndex = 3;
            BLACK_BTN.TabStop = true;
            BLACK_BTN.Text = "BLACK";
            BLACK_BTN.UseVisualStyleBackColor = true;
            BLACK_BTN.CheckedChanged += BLACK_BTN_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BLUE_BTN);
            groupBox1.Controls.Add(RED_BTN);
            groupBox1.Controls.Add(GREEN_BTN);
            groupBox1.Location = new Point(164, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 94);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "FORE COLOUR";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CYAN_BTN);
            groupBox2.Controls.Add(PINK_BTN);
            groupBox2.Controls.Add(BLACK_BTN);
            groupBox2.Location = new Point(151, 354);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 90);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "BACK COLOUR";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 513);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form7";
            Text = "fore color";
            Load += Form7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton RED_BTN;
        private RadioButton GREEN_BTN;
        private RadioButton BLUE_BTN;
        private RadioButton CYAN_BTN;
        private RadioButton PINK_BTN;
        private RadioButton BLACK_BTN;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}