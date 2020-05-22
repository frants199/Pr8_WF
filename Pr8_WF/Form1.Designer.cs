namespace Pr8_WF
{
	partial class Pr8
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
			this.task1 = new System.Windows.Forms.GroupBox();
			this.text_label = new System.Windows.Forms.Label();
			this.text_box = new System.Windows.Forms.RichTextBox();
			this.result_label = new System.Windows.Forms.Label();
			this.result_box = new System.Windows.Forms.RichTextBox();
			this.numbers_box = new System.Windows.Forms.ComboBox();
			this.numbers_label = new System.Windows.Forms.Label();
			this.execute_button = new System.Windows.Forms.Button();
			this.task1.SuspendLayout();
			this.SuspendLayout();
			// 
			// task1
			// 
			this.task1.Controls.Add(this.execute_button);
			this.task1.Controls.Add(this.numbers_label);
			this.task1.Controls.Add(this.numbers_box);
			this.task1.Controls.Add(this.result_box);
			this.task1.Controls.Add(this.result_label);
			this.task1.Controls.Add(this.text_box);
			this.task1.Controls.Add(this.text_label);
			this.task1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.task1.Location = new System.Drawing.Point(0, 0);
			this.task1.Name = "task1";
			this.task1.Size = new System.Drawing.Size(324, 270);
			this.task1.TabIndex = 0;
			this.task1.TabStop = false;
			this.task1.Text = "Задание 1";
			// 
			// text_label
			// 
			this.text_label.AutoSize = true;
			this.text_label.Location = new System.Drawing.Point(12, 57);
			this.text_label.Name = "text_label";
			this.text_label.Size = new System.Drawing.Size(50, 17);
			this.text_label.TabIndex = 0;
			this.text_label.Text = "Текст:";
			// 
			// text_box
			// 
			this.text_box.Location = new System.Drawing.Point(68, 57);
			this.text_box.Name = "text_box";
			this.text_box.Size = new System.Drawing.Size(244, 73);
			this.text_box.TabIndex = 1;
			this.text_box.Text = "";
			// 
			// result_label
			// 
			this.result_label.AutoSize = true;
			this.result_label.Location = new System.Drawing.Point(12, 147);
			this.result_label.Name = "result_label";
			this.result_label.Size = new System.Drawing.Size(80, 17);
			this.result_label.TabIndex = 2;
			this.result_label.Text = "Результат:";
			// 
			// result_box
			// 
			this.result_box.Location = new System.Drawing.Point(98, 144);
			this.result_box.Name = "result_box";
			this.result_box.Size = new System.Drawing.Size(214, 80);
			this.result_box.TabIndex = 3;
			this.result_box.Text = "";
			// 
			// numbers_box
			// 
			this.numbers_box.FormattingEnabled = true;
			this.numbers_box.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
			this.numbers_box.Location = new System.Drawing.Point(76, 27);
			this.numbers_box.Name = "numbers_box";
			this.numbers_box.Size = new System.Drawing.Size(53, 24);
			this.numbers_box.TabIndex = 4;
			// 
			// numbers_label
			// 
			this.numbers_label.AutoSize = true;
			this.numbers_label.Location = new System.Drawing.Point(12, 27);
			this.numbers_label.Name = "numbers_label";
			this.numbers_label.Size = new System.Drawing.Size(58, 17);
			this.numbers_label.TabIndex = 5;
			this.numbers_label.Text = "Цифра:";
			// 
			// execute_button
			// 
			this.execute_button.Location = new System.Drawing.Point(12, 235);
			this.execute_button.Name = "execute_button";
			this.execute_button.Size = new System.Drawing.Size(300, 23);
			this.execute_button.TabIndex = 6;
			this.execute_button.Text = "Выполнить";
			this.execute_button.UseVisualStyleBackColor = true;
			this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
			// 
			// Pr8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 270);
			this.Controls.Add(this.task1);
			this.Name = "Pr8";
			this.Text = "Практика 8";
			this.task1.ResumeLayout(false);
			this.task1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox task1;
		private System.Windows.Forms.RichTextBox result_box;
		private System.Windows.Forms.Label result_label;
		private System.Windows.Forms.RichTextBox text_box;
		private System.Windows.Forms.Label text_label;
		private System.Windows.Forms.Label numbers_label;
		private System.Windows.Forms.ComboBox numbers_box;
		private System.Windows.Forms.Button execute_button;
	}
}

