namespace DayCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnShowTime = new Button();
            lbDate = new Label();
            tbDays = new TextBox();
            btnUtc = new Button();
            SuspendLayout();
            // 
            // btnShowTime
            // 
            btnShowTime.Location = new Point(52, 167);
            btnShowTime.Name = "btnShowTime";
            btnShowTime.Size = new Size(75, 59);
            btnShowTime.TabIndex = 1;
            btnShowTime.Text = "显示日期";
            btnShowTime.UseVisualStyleBackColor = true;
            btnShowTime.Click += button1_Click;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.BackColor = SystemColors.ActiveCaption;
            lbDate.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDate.Location = new Point(12, 82);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(59, 22);
            lbDate.TabIndex = 2;
            lbDate.Text = "label1";
            lbDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbDays
            // 
            tbDays.Location = new Point(12, 29);
            tbDays.Name = "tbDays";
            tbDays.Size = new Size(321, 23);
            tbDays.TabIndex = 3;
            // 
            // btnUtc
            // 
            btnUtc.Location = new Point(216, 167);
            btnUtc.Name = "btnUtc";
            btnUtc.Size = new Size(75, 59);
            btnUtc.TabIndex = 4;
            btnUtc.Text = "UTC转换";
            btnUtc.UseVisualStyleBackColor = true;
            btnUtc.Click += btnUtc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 295);
            Controls.Add(btnUtc);
            Controls.Add(tbDays);
            Controls.Add(lbDate);
            Controls.Add(btnShowTime);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnShowTime;
        private Label lbDate;
        private TextBox tbDays;
        private Button btnUtc;
    }
}
