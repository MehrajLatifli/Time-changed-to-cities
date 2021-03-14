
namespace Time_changetd_to_cities
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
            this.Bakubutton = new System.Windows.Forms.Button();
            this.Londonbutton = new System.Windows.Forms.Button();
            this.LabalImage = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bakubutton
            // 
            this.Bakubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bakubutton.Location = new System.Drawing.Point(12, 680);
            this.Bakubutton.Name = "Bakubutton";
            this.Bakubutton.Size = new System.Drawing.Size(524, 52);
            this.Bakubutton.TabIndex = 0;
            this.Bakubutton.Text = "Baku";
            this.Bakubutton.UseVisualStyleBackColor = true;
            this.Bakubutton.MouseHover += new System.EventHandler(this.Bakubutton_MouseHover);
            // 
            // Londonbutton
            // 
            this.Londonbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Londonbutton.Location = new System.Drawing.Point(546, 680);
            this.Londonbutton.Name = "Londonbutton";
            this.Londonbutton.Size = new System.Drawing.Size(524, 52);
            this.Londonbutton.TabIndex = 1;
            this.Londonbutton.Text = "London";
            this.Londonbutton.UseVisualStyleBackColor = true;
            this.Londonbutton.MouseHover += new System.EventHandler(this.Londonbutton_MouseHover);
            // 
            // LabalImage
            // 
            this.LabalImage.Image = global::Time_changetd_to_cities.Properties.Resources.B;
            this.LabalImage.Location = new System.Drawing.Point(12, 39);
            this.LabalImage.Name = "LabalImage";
            this.LabalImage.Size = new System.Drawing.Size(1058, 600);
            this.LabalImage.TabIndex = 2;
            this.LabalImage.Click += new System.EventHandler(this.LabalImage_Click);
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.BackColor = System.Drawing.Color.Transparent;
            this.Timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.Location = new System.Drawing.Point(7, 9);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(80, 29);
            this.Timelabel.TabIndex = 3;
            this.Timelabel.Text = "Time:";
            this.Timelabel.Click += new System.EventHandler(this.Timelabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.LabalImage);
            this.Controls.Add(this.Londonbutton);
            this.Controls.Add(this.Bakubutton);
            this.Name = "Form1";
            this.Text = "World Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bakubutton;
        private System.Windows.Forms.Button Londonbutton;
        private System.Windows.Forms.Label LabalImage;
        private System.Windows.Forms.Label Timelabel;
    }
}

