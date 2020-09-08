namespace WindowsFormsApp1
{
    partial class Form3
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
            this.Task_1 = new System.Windows.Forms.Button();
            this.Task_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task_1
            // 
            this.Task_1.Location = new System.Drawing.Point(69, 155);
            this.Task_1.Name = "Task_1";
            this.Task_1.Size = new System.Drawing.Size(285, 109);
            this.Task_1.TabIndex = 0;
            this.Task_1.Text = "Task_1";
            this.Task_1.UseVisualStyleBackColor = true;
            this.Task_1.Click += new System.EventHandler(this.Task_1_click);
            // 
            // Task_2
            // 
            this.Task_2.Location = new System.Drawing.Point(466, 155);
            this.Task_2.Name = "Task_2";
            this.Task_2.Size = new System.Drawing.Size(285, 109);
            this.Task_2.TabIndex = 1;
            this.Task_2.Text = "Task_2";
            this.Task_2.UseVisualStyleBackColor = true;
            this.Task_2.Click += new System.EventHandler(this.Task_2_click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Task_2);
            this.Controls.Add(this.Task_1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Task_1;
        private System.Windows.Forms.Button Task_2;
    }
}