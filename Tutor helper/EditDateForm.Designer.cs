namespace Tutor_helper
{
    partial class EditDateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDateForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.saveBo = new System.Windows.Forms.Button();
            this.backBo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Date";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(288, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveBo
            // 
            this.saveBo.Image = global::Tutor_helper.Properties.Resources.save40;
            this.saveBo.Location = new System.Drawing.Point(12, 207);
            this.saveBo.Name = "saveBo";
            this.saveBo.Size = new System.Drawing.Size(40, 40);
            this.saveBo.TabIndex = 13;
            this.saveBo.UseVisualStyleBackColor = true;
            this.saveBo.Click += new System.EventHandler(this.saveBo_Click);
            // 
            // backBo
            // 
            this.backBo.Image = global::Tutor_helper.Properties.Resources.exit20;
            this.backBo.Location = new System.Drawing.Point(288, 207);
            this.backBo.Name = "backBo";
            this.backBo.Size = new System.Drawing.Size(40, 40);
            this.backBo.TabIndex = 12;
            this.backBo.UseVisualStyleBackColor = true;
            this.backBo.Click += new System.EventHandler(this.backBo_Click);
            // 
            // EditDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(340, 259);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.saveBo);
            this.Controls.Add(this.backBo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDateForm";
            this.Text = "EditDateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveBo;
        private System.Windows.Forms.Button backBo;
    }
}