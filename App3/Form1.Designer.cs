﻿
namespace App3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_Triangle = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Line
            // 
            this.btn_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Line.Location = new System.Drawing.Point(121, 216);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(96, 39);
            this.btn_Line.TabIndex = 1;
            this.btn_Line.Text = "Line";
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Rectangle.Location = new System.Drawing.Point(258, 216);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(134, 39);
            this.btn_Rectangle.TabIndex = 2;
            this.btn_Rectangle.Text = "Rectangle";
            this.btn_Rectangle.UseVisualStyleBackColor = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_Triangle
            // 
            this.btn_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Triangle.Location = new System.Drawing.Point(431, 216);
            this.btn_Triangle.Name = "btn_Triangle";
            this.btn_Triangle.Size = new System.Drawing.Size(122, 39);
            this.btn_Triangle.TabIndex = 3;
            this.btn_Triangle.Text = "Triangle";
            this.btn_Triangle.UseVisualStyleBackColor = true;
            this.btn_Triangle.Click += new System.EventHandler(this.btn_Triangle_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Circle.Location = new System.Drawing.Point(588, 216);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(96, 39);
            this.btn_Circle.TabIndex = 4;
            this.btn_Circle.Text = "Circle";
            this.btn_Circle.UseVisualStyleBackColor = true;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(302, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create figure";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Circle);
            this.Controls.Add(this.btn_Triangle);
            this.Controls.Add(this.btn_Rectangle);
            this.Controls.Add(this.btn_Line);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Triangle;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Label label1;
    }
}
