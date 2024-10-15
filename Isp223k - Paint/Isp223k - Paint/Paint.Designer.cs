namespace Isp223k___Paint
{
    partial class Paint
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
            System.Windows.Forms.Button Pen;
            System.Windows.Forms.Button fiil_button;
            System.Windows.Forms.Button text;
            this.paint_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.color = new System.Windows.Forms.Button();
            this.lastik_button = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ellipse = new System.Windows.Forms.Button();
            this.trapezoid = new System.Windows.Forms.Button();
            this.polygon = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.curva = new System.Windows.Forms.Button();
            Pen = new System.Windows.Forms.Button();
            fiil_button = new System.Windows.Forms.Button();
            text = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pen
            // 
            Pen.BackColor = System.Drawing.SystemColors.ControlDark;
            Pen.Cursor = System.Windows.Forms.Cursors.Hand;
            Pen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Pen.FlatAppearance.BorderSize = 0;
            Pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Pen.ForeColor = System.Drawing.SystemColors.ControlText;
            Pen.Location = new System.Drawing.Point(3, 62);
            Pen.Name = "Pen";
            Pen.Size = new System.Drawing.Size(165, 53);
            Pen.TabIndex = 2;
            Pen.Text = "Pen";
            Pen.UseVisualStyleBackColor = false;
            Pen.Click += new System.EventHandler(this.Pen_Click);
            // 
            // fiil_button
            // 
            fiil_button.BackColor = System.Drawing.SystemColors.ControlDark;
            fiil_button.Cursor = System.Windows.Forms.Cursors.Hand;
            fiil_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            fiil_button.FlatAppearance.BorderSize = 0;
            fiil_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            fiil_button.ForeColor = System.Drawing.SystemColors.ControlText;
            fiil_button.Location = new System.Drawing.Point(3, 121);
            fiil_button.Name = "fiil_button";
            fiil_button.Size = new System.Drawing.Size(165, 53);
            fiil_button.TabIndex = 3;
            fiil_button.Text = "Filling";
            fiil_button.UseVisualStyleBackColor = false;
            fiil_button.Click += new System.EventHandler(this.fiil_button_Click);
            // 
            // text
            // 
            text.BackColor = System.Drawing.SystemColors.ControlDark;
            text.Cursor = System.Windows.Forms.Cursors.Hand;
            text.FlatAppearance.BorderColor = System.Drawing.Color.White;
            text.FlatAppearance.BorderSize = 0;
            text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            text.ForeColor = System.Drawing.SystemColors.ControlText;
            text.Location = new System.Drawing.Point(4, 180);
            text.Name = "text";
            text.Size = new System.Drawing.Size(165, 53);
            text.TabIndex = 4;
            text.Text = "Text";
            text.UseVisualStyleBackColor = false;
            text.Click += new System.EventHandler(this.text_Click);
            // 
            // paint_panel
            // 
            this.paint_panel.AllowDrop = true;
            this.paint_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paint_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paint_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paint_panel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.paint_panel.Location = new System.Drawing.Point(13, 13);
            this.paint_panel.Name = "paint_panel";
            this.paint_panel.Size = new System.Drawing.Size(1130, 769);
            this.paint_panel.TabIndex = 0;
            this.paint_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paint_panel_MouseDown);
            this.paint_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paint_panel_MouseMove);
            this.paint_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paint_panel_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(text);
            this.panel2.Controls.Add(fiil_button);
            this.panel2.Controls.Add(Pen);
            this.panel2.Controls.Add(this.color);
            this.panel2.Location = new System.Drawing.Point(1149, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 240);
            this.panel2.TabIndex = 1;
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.SystemColors.ControlDark;
            this.color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.color.FlatAppearance.BorderSize = 0;
            this.color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color.ForeColor = System.Drawing.SystemColors.ControlText;
            this.color.Location = new System.Drawing.Point(4, 3);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(165, 53);
            this.color.TabIndex = 0;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = false;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // lastik_button
            // 
            this.lastik_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lastik_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastik_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lastik_button.FlatAppearance.BorderSize = 0;
            this.lastik_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastik_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastik_button.Location = new System.Drawing.Point(3, 3);
            this.lastik_button.Name = "lastik_button";
            this.lastik_button.Size = new System.Drawing.Size(165, 53);
            this.lastik_button.TabIndex = 5;
            this.lastik_button.Text = "Lastik";
            this.lastik_button.UseVisualStyleBackColor = false;
            this.lastik_button.Click += new System.EventHandler(this.lastik_button_Click);
            // 
            // triangle
            // 
            this.triangle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.triangle.FlatAppearance.BorderSize = 0;
            this.triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.triangle.Location = new System.Drawing.Point(3, 3);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(165, 53);
            this.triangle.TabIndex = 4;
            this.triangle.Text = "Triangle";
            this.triangle.UseVisualStyleBackColor = false;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rectangle.FlatAppearance.BorderSize = 0;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rectangle.Location = new System.Drawing.Point(4, 62);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(165, 53);
            this.rectangle.TabIndex = 3;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Location = new System.Drawing.Point(4, 62);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(165, 53);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ellipse
            // 
            this.ellipse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ellipse.FlatAppearance.BorderSize = 0;
            this.ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ellipse.Location = new System.Drawing.Point(3, 121);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(165, 53);
            this.ellipse.TabIndex = 8;
            this.ellipse.Text = "Ellipse";
            this.ellipse.UseVisualStyleBackColor = false;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // trapezoid
            // 
            this.trapezoid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trapezoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trapezoid.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.trapezoid.FlatAppearance.BorderSize = 0;
            this.trapezoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trapezoid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trapezoid.Location = new System.Drawing.Point(3, 180);
            this.trapezoid.Name = "trapezoid";
            this.trapezoid.Size = new System.Drawing.Size(165, 53);
            this.trapezoid.TabIndex = 7;
            this.trapezoid.Text = "Trapezoid";
            this.trapezoid.UseVisualStyleBackColor = false;
            this.trapezoid.Click += new System.EventHandler(this.trapezoid_Click);
            // 
            // polygon
            // 
            this.polygon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.polygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.polygon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.polygon.FlatAppearance.BorderSize = 0;
            this.polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.polygon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.polygon.Location = new System.Drawing.Point(3, 239);
            this.polygon.Name = "polygon";
            this.polygon.Size = new System.Drawing.Size(165, 53);
            this.polygon.TabIndex = 6;
            this.polygon.Text = "Polygon";
            this.polygon.UseVisualStyleBackColor = false;
            this.polygon.Click += new System.EventHandler(this.polygon_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(18, 363);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Fill Brush Figure\'s";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.curva);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.triangle);
            this.panel1.Controls.Add(this.rectangle);
            this.panel1.Controls.Add(this.polygon);
            this.panel1.Controls.Add(this.ellipse);
            this.panel1.Controls.Add(this.trapezoid);
            this.panel1.Location = new System.Drawing.Point(1149, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 397);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lastik_button);
            this.panel3.Controls.Add(this.Reset);
            this.panel3.Location = new System.Drawing.Point(1149, 662);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 120);
            this.panel3.TabIndex = 3;
            // 
            // curva
            // 
            this.curva.BackColor = System.Drawing.SystemColors.ControlDark;
            this.curva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.curva.FlatAppearance.BorderSize = 0;
            this.curva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curva.ForeColor = System.Drawing.SystemColors.ControlText;
            this.curva.Location = new System.Drawing.Point(4, 298);
            this.curva.Name = "curva";
            this.curva.Size = new System.Drawing.Size(165, 53);
            this.curva.TabIndex = 10;
            this.curva.Text = "Curva";
            this.curva.UseVisualStyleBackColor = false;
            this.curva.Click += new System.EventHandler(this.curva_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1337, 794);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paint_panel);
            this.Name = "Paint";
            this.Text = "Paint";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paint_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button lastik_button;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button trapezoid;
        private System.Windows.Forms.Button polygon;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button curva;
    }
}