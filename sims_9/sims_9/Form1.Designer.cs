namespace sims_9
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labeln = new System.Windows.Forms.Label();
            this.col_money = new System.Windows.Forms.NumericUpDown();
            this.label_color = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_red = new System.Windows.Forms.Button();
            this.button_yellow = new System.Windows.Forms.Button();
            this.button_green = new System.Windows.Forms.Button();
            this.labelrate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.col_money)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelrate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labeln);
            this.panel1.Controls.Add(this.col_money);
            this.panel1.Controls.Add(this.label_color);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_red);
            this.panel1.Controls.Add(this.button_yellow);
            this.panel1.Controls.Add(this.button_green);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 261);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "You are loosed!";
            this.label2.Visible = false;
            // 
            // labeln
            // 
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(17, 82);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(36, 13);
            this.labeln.TabIndex = 6;
            this.labeln.Text = "Rate: ";
            // 
            // col_money
            // 
            this.col_money.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.col_money.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.col_money.Location = new System.Drawing.Point(72, 80);
            this.col_money.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.col_money.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.col_money.Name = "col_money";
            this.col_money.Size = new System.Drawing.Size(200, 20);
            this.col_money.TabIndex = 5;
            this.col_money.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label_color
            // 
            this.label_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_color.ForeColor = System.Drawing.Color.Yellow;
            this.label_color.Location = new System.Drawing.Point(0, 198);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(284, 31);
            this.label_color.TabIndex = 4;
            this.label_color.Text = "Yellow";
            this.label_color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Money: 50";
            // 
            // button_red
            // 
            this.button_red.BackColor = System.Drawing.Color.Red;
            this.button_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_red.Location = new System.Drawing.Point(203, 123);
            this.button_red.Name = "button_red";
            this.button_red.Size = new System.Drawing.Size(69, 56);
            this.button_red.TabIndex = 2;
            this.button_red.Text = "Red";
            this.button_red.UseVisualStyleBackColor = false;
            this.button_red.Click += new System.EventHandler(this.button_red_Click);
            // 
            // button_yellow
            // 
            this.button_yellow.BackColor = System.Drawing.Color.Yellow;
            this.button_yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_yellow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_yellow.Location = new System.Drawing.Point(111, 123);
            this.button_yellow.Name = "button_yellow";
            this.button_yellow.Size = new System.Drawing.Size(69, 56);
            this.button_yellow.TabIndex = 1;
            this.button_yellow.Text = "Yellow";
            this.button_yellow.UseVisualStyleBackColor = false;
            this.button_yellow.Click += new System.EventHandler(this.button_yellow_Click);
            // 
            // button_green
            // 
            this.button_green.BackColor = System.Drawing.Color.Green;
            this.button_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_green.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_green.Location = new System.Drawing.Point(12, 123);
            this.button_green.Name = "button_green";
            this.button_green.Size = new System.Drawing.Size(69, 56);
            this.button_green.TabIndex = 0;
            this.button_green.Text = "Green";
            this.button_green.UseVisualStyleBackColor = false;
            this.button_green.Click += new System.EventHandler(this.button_green_Click);
            // 
            // labelrate
            // 
            this.labelrate.ForeColor = System.Drawing.Color.Maroon;
            this.labelrate.Location = new System.Drawing.Point(0, 103);
            this.labelrate.Name = "labelrate";
            this.labelrate.Size = new System.Drawing.Size(284, 23);
            this.labelrate.TabIndex = 8;
            this.labelrate.Text = "The rate is too high";
            this.labelrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelrate.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.col_money)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_red;
        private System.Windows.Forms.Button button_yellow;
        private System.Windows.Forms.Button button_green;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.NumericUpDown col_money;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelrate;
    }
}

