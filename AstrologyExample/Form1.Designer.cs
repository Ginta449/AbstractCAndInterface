namespace AstrologyExample
{
    partial class StarSign
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.monthCalendarAstrology = new System.Windows.Forms.MonthCalendar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnter.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(122, 283);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(227, 61);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // monthCalendarAstrology
            // 
            this.monthCalendarAstrology.BackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendarAstrology.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarAstrology.Location = new System.Drawing.Point(122, 109);
            this.monthCalendarAstrology.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.monthCalendarAstrology.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.monthCalendarAstrology.Name = "monthCalendarAstrology";
            this.monthCalendarAstrology.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendarAstrology.TabIndex = 4;
            this.monthCalendarAstrology.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthCalendarAstrology.TrailingForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // StarSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::AstrologyExample.Properties.Resources.ast_jfif;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(472, 495);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.monthCalendarAstrology);
            this.Controls.Add(this.btnEnter);
            this.Name = "StarSign";
            this.Text = "FormStarSign";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.MonthCalendar monthCalendarAstrology;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

