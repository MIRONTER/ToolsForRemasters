namespace ToolsForRemasters
{
    partial class FormToolsForRemasters
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.NumericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownMultiplier = new System.Windows.Forms.NumericUpDown();
            this.ButtonStartRepair = new System.Windows.Forms.Button();
            this.ButtonFindTemp = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMultiplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Limit of files in group:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Multiplier:";
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Location = new System.Drawing.Point(12, 25);
            this.TextBoxPath.Multiline = true;
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.Size = new System.Drawing.Size(246, 60);
            this.TextBoxPath.TabIndex = 3;
            // 
            // NumericUpDownLimit
            // 
            this.NumericUpDownLimit.Location = new System.Drawing.Point(12, 104);
            this.NumericUpDownLimit.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericUpDownLimit.Name = "NumericUpDownLimit";
            this.NumericUpDownLimit.Size = new System.Drawing.Size(246, 20);
            this.NumericUpDownLimit.TabIndex = 4;
            this.NumericUpDownLimit.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NumericUpDownMultiplier
            // 
            this.NumericUpDownMultiplier.Location = new System.Drawing.Point(12, 143);
            this.NumericUpDownMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownMultiplier.Name = "NumericUpDownMultiplier";
            this.NumericUpDownMultiplier.Size = new System.Drawing.Size(246, 20);
            this.NumericUpDownMultiplier.TabIndex = 5;
            this.NumericUpDownMultiplier.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ButtonStartRepair
            // 
            this.ButtonStartRepair.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStartRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStartRepair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStartRepair.ForeColor = System.Drawing.Color.Black;
            this.ButtonStartRepair.Location = new System.Drawing.Point(12, 171);
            this.ButtonStartRepair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonStartRepair.Name = "ButtonStartRepair";
            this.ButtonStartRepair.Size = new System.Drawing.Size(119, 61);
            this.ButtonStartRepair.TabIndex = 21;
            this.ButtonStartRepair.Text = "Start Repair";
            this.ButtonStartRepair.UseVisualStyleBackColor = false;
            this.ButtonStartRepair.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonFindTemp
            // 
            this.ButtonFindTemp.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFindTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFindTemp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFindTemp.ForeColor = System.Drawing.Color.Black;
            this.ButtonFindTemp.Location = new System.Drawing.Point(139, 171);
            this.ButtonFindTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonFindTemp.Name = "ButtonFindTemp";
            this.ButtonFindTemp.Size = new System.Drawing.Size(119, 61);
            this.ButtonFindTemp.TabIndex = 22;
            this.ButtonFindTemp.Text = "Find Temp";
            this.ButtonFindTemp.UseVisualStyleBackColor = false;
            this.ButtonFindTemp.Click += new System.EventHandler(this.ButtonFindTemp_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 240);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(246, 23);
            this.ProgressBar.TabIndex = 23;
            // 
            // FormToolsForRemasters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 274);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ButtonFindTemp);
            this.Controls.Add(this.ButtonStartRepair);
            this.Controls.Add(this.NumericUpDownMultiplier);
            this.Controls.Add(this.NumericUpDownLimit);
            this.Controls.Add(this.TextBoxPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormToolsForRemasters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolsForRemasters";
            this.Load += new System.EventHandler(this.FormToolsForRemasters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMultiplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.NumericUpDown NumericUpDownLimit;
        private System.Windows.Forms.NumericUpDown NumericUpDownMultiplier;
        public System.Windows.Forms.Button ButtonStartRepair;
        public System.Windows.Forms.Button ButtonFindTemp;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

