
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
            this.board = new System.Windows.Forms.Panel();
            this.penPanel = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.lbWidth = new System.Windows.Forms.ListBox();
            this.penPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Line
            // 
            this.btn_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Line.Location = new System.Drawing.Point(12, 12);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(96, 39);
            this.btn_Line.TabIndex = 2;
            this.btn_Line.Text = "Line";
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Rectangle.Location = new System.Drawing.Point(114, 12);
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
            this.btn_Triangle.Location = new System.Drawing.Point(254, 12);
            this.btn_Triangle.Name = "btn_Triangle";
            this.btn_Triangle.Size = new System.Drawing.Size(122, 39);
            this.btn_Triangle.TabIndex = 2;
            this.btn_Triangle.Text = "Triangle";
            this.btn_Triangle.UseVisualStyleBackColor = true;
            this.btn_Triangle.Click += new System.EventHandler(this.btn_Triangle_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Circle.Location = new System.Drawing.Point(382, 12);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(96, 39);
            this.btn_Circle.TabIndex = 2;
            this.btn_Circle.Text = "Circle";
            this.btn_Circle.UseVisualStyleBackColor = true;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.board.Location = new System.Drawing.Point(0, 0);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(867, 497);
            this.board.TabIndex = 5;
            // 
            // penPanel
            // 
            this.penPanel.BackColor = System.Drawing.SystemColors.Control;
            this.penPanel.Controls.Add(this.lbWidth);
            this.penPanel.Controls.Add(this.btnColor);
            this.penPanel.Controls.Add(this.btn_Circle);
            this.penPanel.Controls.Add(this.btn_Line);
            this.penPanel.Controls.Add(this.btn_Rectangle);
            this.penPanel.Controls.Add(this.btn_Triangle);
            this.penPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.penPanel.Location = new System.Drawing.Point(0, 0);
            this.penPanel.Name = "penPanel";
            this.penPanel.Size = new System.Drawing.Size(867, 61);
            this.penPanel.TabIndex = 3;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnColor.Location = new System.Drawing.Point(537, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(48, 39);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lbWidth
            // 
            this.lbWidth.FormattingEnabled = true;
            this.lbWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lbWidth.Location = new System.Drawing.Point(640, 19);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(101, 30);
            this.lbWidth.TabIndex = 4;
            this.lbWidth.SelectedIndexChanged += new System.EventHandler(this.lbWidth_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 497);
            this.Controls.Add(this.penPanel);
            this.Controls.Add(this.board);
            this.Name = "Form1";
            this.Text = "Form1";
            this.penPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Triangle;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Panel penPanel;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.ListBox lbWidth;
    }
}

