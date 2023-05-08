
namespace _2DTransformation
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
            this.btn_scale = new System.Windows.Forms.Button();
            this.txt_scale_in = new System.Windows.Forms.TextBox();
            this.txt_rotate_in = new System.Windows.Forms.TextBox();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.txt_translate_x_in = new System.Windows.Forms.TextBox();
            this.btn_translate = new System.Windows.Forms.Button();
            this.txt_translate_y_in = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_scale
            // 
            this.btn_scale.Location = new System.Drawing.Point(880, 19);
            this.btn_scale.Name = "btn_scale";
            this.btn_scale.Size = new System.Drawing.Size(74, 21);
            this.btn_scale.TabIndex = 0;
            this.btn_scale.Text = "Scale";
            this.btn_scale.UseVisualStyleBackColor = true;
            this.btn_scale.Click += new System.EventHandler(this.btn_scale_Click);
            // 
            // txt_scale_in
            // 
            this.txt_scale_in.Location = new System.Drawing.Point(753, 19);
            this.txt_scale_in.Name = "txt_scale_in";
            this.txt_scale_in.Size = new System.Drawing.Size(121, 20);
            this.txt_scale_in.TabIndex = 3;
            // 
            // txt_rotate_in
            // 
            this.txt_rotate_in.Location = new System.Drawing.Point(753, 60);
            this.txt_rotate_in.Name = "txt_rotate_in";
            this.txt_rotate_in.Size = new System.Drawing.Size(121, 20);
            this.txt_rotate_in.TabIndex = 5;
            // 
            // btn_rotate
            // 
            this.btn_rotate.Location = new System.Drawing.Point(880, 60);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(74, 21);
            this.btn_rotate.TabIndex = 4;
            this.btn_rotate.Text = "Rotate";
            this.btn_rotate.UseVisualStyleBackColor = true;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // txt_translate_x_in
            // 
            this.txt_translate_x_in.Location = new System.Drawing.Point(753, 103);
            this.txt_translate_x_in.Name = "txt_translate_x_in";
            this.txt_translate_x_in.Size = new System.Drawing.Size(59, 20);
            this.txt_translate_x_in.TabIndex = 7;
            // 
            // btn_translate
            // 
            this.btn_translate.Location = new System.Drawing.Point(880, 103);
            this.btn_translate.Name = "btn_translate";
            this.btn_translate.Size = new System.Drawing.Size(74, 21);
            this.btn_translate.TabIndex = 6;
            this.btn_translate.Text = "Translate";
            this.btn_translate.UseVisualStyleBackColor = true;
            this.btn_translate.Click += new System.EventHandler(this.btn_translate_Click);
            // 
            // txt_translate_y_in
            // 
            this.txt_translate_y_in.Location = new System.Drawing.Point(815, 103);
            this.txt_translate_y_in.Name = "txt_translate_y_in";
            this.txt_translate_y_in.Size = new System.Drawing.Size(59, 20);
            this.txt_translate_y_in.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 581);
            this.Controls.Add(this.txt_translate_y_in);
            this.Controls.Add(this.txt_translate_x_in);
            this.Controls.Add(this.btn_translate);
            this.Controls.Add(this.txt_rotate_in);
            this.Controls.Add(this.btn_rotate);
            this.Controls.Add(this.txt_scale_in);
            this.Controls.Add(this.btn_scale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_scale;
        private System.Windows.Forms.TextBox txt_scale_in;
        private System.Windows.Forms.TextBox txt_rotate_in;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.TextBox txt_translate_x_in;
        private System.Windows.Forms.Button btn_translate;
        private System.Windows.Forms.TextBox txt_translate_y_in;
    }
}

