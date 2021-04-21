
namespace App3
{
    partial class Form4
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
            this.tb_LocationB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Input = new System.Windows.Forms.Label();
            this.tb_LocationA = new System.Windows.Forms.TextBox();
            this.lb_Location = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.tb_LocationC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_LocationB
            // 
            this.tb_LocationB.Location = new System.Drawing.Point(463, 137);
            this.tb_LocationB.Name = "tb_LocationB";
            this.tb_LocationB.Size = new System.Drawing.Size(100, 20);
            this.tb_LocationB.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(241, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Insert location B (x, y)";
            // 
            // lb_Input
            // 
            this.lb_Input.AutoSize = true;
            this.lb_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_Input.Location = new System.Drawing.Point(336, 295);
            this.lb_Input.Name = "lb_Input";
            this.lb_Input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Input.Size = new System.Drawing.Size(0, 24);
            this.lb_Input.TabIndex = 22;
            this.lb_Input.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_LocationA
            // 
            this.tb_LocationA.Location = new System.Drawing.Point(463, 86);
            this.tb_LocationA.Name = "tb_LocationA";
            this.tb_LocationA.Size = new System.Drawing.Size(100, 20);
            this.tb_LocationA.TabIndex = 21;
            // 
            // lb_Location
            // 
            this.lb_Location.AutoSize = true;
            this.lb_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_Location.Location = new System.Drawing.Point(241, 80);
            this.lb_Location.Name = "lb_Location";
            this.lb_Location.Size = new System.Drawing.Size(222, 26);
            this.lb_Location.TabIndex = 20;
            this.lb_Location.Text = "Insert location A (x, y)";
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Create.Location = new System.Drawing.Point(320, 231);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(199, 34);
            this.btn_Create.TabIndex = 19;
            this.btn_Create.Text = "Create triangle";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // tb_LocationC
            // 
            this.tb_LocationC.Location = new System.Drawing.Point(463, 187);
            this.tb_LocationC.Name = "tb_LocationC";
            this.tb_LocationC.Size = new System.Drawing.Size(100, 20);
            this.tb_LocationC.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(241, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Insert location C (x, y)";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_LocationC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_LocationB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Input);
            this.Controls.Add(this.tb_LocationA);
            this.Controls.Add(this.lb_Location);
            this.Controls.Add(this.btn_Create);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_LocationB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Input;
        private System.Windows.Forms.TextBox tb_LocationA;
        private System.Windows.Forms.Label lb_Location;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox tb_LocationC;
        private System.Windows.Forms.Label label2;
    }
}