
namespace App3
{
    partial class Form5
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
            this.lb_Input = new System.Windows.Forms.Label();
            this.tb_Location = new System.Windows.Forms.TextBox();
            this.lb_Location = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.tb_Radius = new System.Windows.Forms.TextBox();
            this.lb_Radius = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Input
            // 
            this.lb_Input.AutoSize = true;
            this.lb_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_Input.Location = new System.Drawing.Point(337, 309);
            this.lb_Input.Name = "lb_Input";
            this.lb_Input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Input.Size = new System.Drawing.Size(0, 24);
            this.lb_Input.TabIndex = 16;
            this.lb_Input.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_Location
            // 
            this.tb_Location.Location = new System.Drawing.Point(462, 171);
            this.tb_Location.Name = "tb_Location";
            this.tb_Location.Size = new System.Drawing.Size(100, 20);
            this.tb_Location.TabIndex = 15;
            // 
            // lb_Location
            // 
            this.lb_Location.AutoSize = true;
            this.lb_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_Location.Location = new System.Drawing.Point(240, 165);
            this.lb_Location.Name = "lb_Location";
            this.lb_Location.Size = new System.Drawing.Size(201, 26);
            this.lb_Location.TabIndex = 14;
            this.lb_Location.Text = "Insert location (x, y)";
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Create.Location = new System.Drawing.Point(321, 245);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(199, 34);
            this.btn_Create.TabIndex = 13;
            this.btn_Create.Text = "Create circle";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // tb_Radius
            // 
            this.tb_Radius.Location = new System.Drawing.Point(462, 123);
            this.tb_Radius.Name = "tb_Radius";
            this.tb_Radius.Size = new System.Drawing.Size(100, 20);
            this.tb_Radius.TabIndex = 12;
            // 
            // lb_Radius
            // 
            this.lb_Radius.AutoSize = true;
            this.lb_Radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_Radius.Location = new System.Drawing.Point(238, 118);
            this.lb_Radius.Name = "lb_Radius";
            this.lb_Radius.Size = new System.Drawing.Size(188, 26);
            this.lb_Radius.TabIndex = 11;
            this.lb_Radius.Text = "Insert circle radius";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Input);
            this.Controls.Add(this.tb_Location);
            this.Controls.Add(this.lb_Location);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.tb_Radius);
            this.Controls.Add(this.lb_Radius);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Input;
        private System.Windows.Forms.TextBox tb_Location;
        private System.Windows.Forms.Label lb_Location;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox tb_Radius;
        private System.Windows.Forms.Label lb_Radius;
    }
}