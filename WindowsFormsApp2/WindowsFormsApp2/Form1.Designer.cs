namespace WindowsFormsApp2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Stretch = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Show_the_drawing = new System.Windows.Forms.Button();
            this.Clear_the_drawing = new System.Windows.Forms.Button();
            this.Set_the_background_color = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Stretch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 318);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Stretch
            // 
            this.Stretch.AutoSize = true;
            this.Stretch.Location = new System.Drawing.Point(3, 327);
            this.Stretch.Name = "Stretch";
            this.Stretch.Size = new System.Drawing.Size(60, 17);
            this.Stretch.TabIndex = 1;
            this.Stretch.Text = "Stretch";
            this.Stretch.UseVisualStyleBackColor = true;
            this.Stretch.CheckedChanged += new System.EventHandler(this.Stretch_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.Show_the_drawing);
            this.flowLayoutPanel1.Controls.Add(this.Clear_the_drawing);
            this.flowLayoutPanel1.Controls.Add(this.Set_the_background_color);
            this.flowLayoutPanel1.Controls.Add(this.Close);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(90, 327);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 31);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Show_the_drawing
            // 
            this.Show_the_drawing.AutoSize = true;
            this.Show_the_drawing.Location = new System.Drawing.Point(386, 3);
            this.Show_the_drawing.Name = "Show_the_drawing";
            this.Show_the_drawing.Size = new System.Drawing.Size(102, 23);
            this.Show_the_drawing.TabIndex = 0;
            this.Show_the_drawing.Text = "Show the drawing";
            this.Show_the_drawing.UseVisualStyleBackColor = true;
            this.Show_the_drawing.Click += new System.EventHandler(this.Show_the_drawing_Click);
            // 
            // Clear_the_drawing
            // 
            this.Clear_the_drawing.AutoSize = true;
            this.Clear_the_drawing.Location = new System.Drawing.Point(281, 3);
            this.Clear_the_drawing.Name = "Clear_the_drawing";
            this.Clear_the_drawing.Size = new System.Drawing.Size(99, 23);
            this.Clear_the_drawing.TabIndex = 1;
            this.Clear_the_drawing.Text = "Clear the drawing";
            this.Clear_the_drawing.UseVisualStyleBackColor = true;
            this.Clear_the_drawing.Click += new System.EventHandler(this.Clear_the_drawing_Click);
            // 
            // Set_the_background_color
            // 
            this.Set_the_background_color.AutoSize = true;
            this.Set_the_background_color.Location = new System.Drawing.Point(138, 3);
            this.Set_the_background_color.Name = "Set_the_background_color";
            this.Set_the_background_color.Size = new System.Drawing.Size(137, 23);
            this.Set_the_background_color.TabIndex = 2;
            this.Set_the_background_color.Text = "Set the background color";
            this.Set_the_background_color.UseVisualStyleBackColor = true;
            this.Set_the_background_color.Click += new System.EventHandler(this.Set_the_background_color_Click);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Location = new System.Drawing.Point(57, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Выбор файла изображения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "PictureViewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Stretch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Show_the_drawing;
        private System.Windows.Forms.Button Clear_the_drawing;
        private System.Windows.Forms.Button Set_the_background_color;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

