namespace Pr11_12_WF
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
			this.task_panel = new System.Windows.Forms.Panel();
			this.calculate_button = new System.Windows.Forms.Button();
			this.number_of_product_box = new System.Windows.Forms.TextBox();
			this.number_of_product = new System.Windows.Forms.Label();
			this.all_cash_box = new System.Windows.Forms.TextBox();
			this.all_cash_label = new System.Windows.Forms.Label();
			this.price_box = new System.Windows.Forms.TextBox();
			this.price_label = new System.Windows.Forms.Label();
			this.number_box = new System.Windows.Forms.TextBox();
			this.face_value_box = new System.Windows.Forms.TextBox();
			this.number_label = new System.Windows.Forms.Label();
			this.fase_value_label = new System.Windows.Forms.Label();
			this.increment_label = new System.Windows.Forms.Label();
			this.increment_box = new System.Windows.Forms.TextBox();
			this.dekrement_label = new System.Windows.Forms.Label();
			this.dekrement_box = new System.Windows.Forms.TextBox();
			this.operator1_label = new System.Windows.Forms.Label();
			this.operator1_box = new System.Windows.Forms.TextBox();
			this.operator2_label = new System.Windows.Forms.Label();
			this.scalar_box = new System.Windows.Forms.TextBox();
			this.totoal_cash_box = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rezult_box = new System.Windows.Forms.TextBox();
			this.task_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// task_panel
			// 
			this.task_panel.Controls.Add(this.rezult_box);
			this.task_panel.Controls.Add(this.label2);
			this.task_panel.Controls.Add(this.label1);
			this.task_panel.Controls.Add(this.totoal_cash_box);
			this.task_panel.Controls.Add(this.scalar_box);
			this.task_panel.Controls.Add(this.operator2_label);
			this.task_panel.Controls.Add(this.operator1_box);
			this.task_panel.Controls.Add(this.operator1_label);
			this.task_panel.Controls.Add(this.dekrement_box);
			this.task_panel.Controls.Add(this.dekrement_label);
			this.task_panel.Controls.Add(this.increment_box);
			this.task_panel.Controls.Add(this.increment_label);
			this.task_panel.Controls.Add(this.calculate_button);
			this.task_panel.Controls.Add(this.number_of_product_box);
			this.task_panel.Controls.Add(this.number_of_product);
			this.task_panel.Controls.Add(this.all_cash_box);
			this.task_panel.Controls.Add(this.all_cash_label);
			this.task_panel.Controls.Add(this.price_box);
			this.task_panel.Controls.Add(this.price_label);
			this.task_panel.Controls.Add(this.number_box);
			this.task_panel.Controls.Add(this.face_value_box);
			this.task_panel.Controls.Add(this.number_label);
			this.task_panel.Controls.Add(this.fase_value_label);
			this.task_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.task_panel.Location = new System.Drawing.Point(0, 0);
			this.task_panel.Name = "task_panel";
			this.task_panel.Size = new System.Drawing.Size(554, 310);
			this.task_panel.TabIndex = 0;
			// 
			// calculate_button
			// 
			this.calculate_button.Location = new System.Drawing.Point(432, 267);
			this.calculate_button.Name = "calculate_button";
			this.calculate_button.Size = new System.Drawing.Size(100, 31);
			this.calculate_button.TabIndex = 10;
			this.calculate_button.Text = "Рассчитать";
			this.calculate_button.UseVisualStyleBackColor = true;
			this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
			// 
			// number_of_product_box
			// 
			this.number_of_product_box.Location = new System.Drawing.Point(432, 79);
			this.number_of_product_box.Name = "number_of_product_box";
			this.number_of_product_box.ReadOnly = true;
			this.number_of_product_box.Size = new System.Drawing.Size(100, 22);
			this.number_of_product_box.TabIndex = 9;
			// 
			// number_of_product
			// 
			this.number_of_product.AutoSize = true;
			this.number_of_product.Location = new System.Drawing.Point(260, 79);
			this.number_of_product.Name = "number_of_product";
			this.number_of_product.Size = new System.Drawing.Size(166, 17);
			this.number_of_product.TabIndex = 8;
			this.number_of_product.Text = "Количество продуктов: ";
			// 
			// all_cash_box
			// 
			this.all_cash_box.Location = new System.Drawing.Point(363, 12);
			this.all_cash_box.Name = "all_cash_box";
			this.all_cash_box.ReadOnly = true;
			this.all_cash_box.Size = new System.Drawing.Size(100, 22);
			this.all_cash_box.TabIndex = 7;
			// 
			// all_cash_label
			// 
			this.all_cash_label.AutoSize = true;
			this.all_cash_label.Location = new System.Drawing.Point(263, 15);
			this.all_cash_label.Name = "all_cash_label";
			this.all_cash_label.Size = new System.Drawing.Size(94, 17);
			this.all_cash_label.TabIndex = 6;
			this.all_cash_label.Text = "Всего денег: ";
			// 
			// price_box
			// 
			this.price_box.Location = new System.Drawing.Point(363, 43);
			this.price_box.Name = "price_box";
			this.price_box.Size = new System.Drawing.Size(100, 22);
			this.price_box.TabIndex = 5;
			// 
			// price_label
			// 
			this.price_label.AutoSize = true;
			this.price_label.Location = new System.Drawing.Point(260, 45);
			this.price_label.Name = "price_label";
			this.price_label.Size = new System.Drawing.Size(97, 17);
			this.price_label.TabIndex = 4;
			this.price_label.Text = "Цена товара:";
			// 
			// number_box
			// 
			this.number_box.Location = new System.Drawing.Point(145, 43);
			this.number_box.Name = "number_box";
			this.number_box.Size = new System.Drawing.Size(100, 22);
			this.number_box.TabIndex = 3;
			// 
			// face_value_box
			// 
			this.face_value_box.Location = new System.Drawing.Point(145, 15);
			this.face_value_box.Name = "face_value_box";
			this.face_value_box.Size = new System.Drawing.Size(100, 22);
			this.face_value_box.TabIndex = 2;
			// 
			// number_label
			// 
			this.number_label.AutoSize = true;
			this.number_label.Location = new System.Drawing.Point(14, 45);
			this.number_label.Name = "number_label";
			this.number_label.Size = new System.Drawing.Size(138, 17);
			this.number_label.TabIndex = 1;
			this.number_label.Text = "Количество купюр: ";
			// 
			// fase_value_label
			// 
			this.fase_value_label.AutoSize = true;
			this.fase_value_label.Location = new System.Drawing.Point(14, 15);
			this.fase_value_label.Name = "fase_value_label";
			this.fase_value_label.Size = new System.Drawing.Size(125, 17);
			this.fase_value_label.TabIndex = 0;
			this.fase_value_label.Text = "Номинал купюры:";
			// 
			// increment_label
			// 
			this.increment_label.AutoSize = true;
			this.increment_label.Location = new System.Drawing.Point(14, 123);
			this.increment_label.Name = "increment_label";
			this.increment_label.Size = new System.Drawing.Size(85, 17);
			this.increment_label.TabIndex = 11;
			this.increment_label.Text = "Инкремент:";
			// 
			// increment_box
			// 
			this.increment_box.Location = new System.Drawing.Point(105, 123);
			this.increment_box.Name = "increment_box";
			this.increment_box.ReadOnly = true;
			this.increment_box.Size = new System.Drawing.Size(321, 22);
			this.increment_box.TabIndex = 12;
			// 
			// dekrement_label
			// 
			this.dekrement_label.AutoSize = true;
			this.dekrement_label.Location = new System.Drawing.Point(14, 161);
			this.dekrement_label.Name = "dekrement_label";
			this.dekrement_label.Size = new System.Drawing.Size(86, 17);
			this.dekrement_label.TabIndex = 13;
			this.dekrement_label.Text = "Декремент:";
			// 
			// dekrement_box
			// 
			this.dekrement_box.Location = new System.Drawing.Point(105, 161);
			this.dekrement_box.Name = "dekrement_box";
			this.dekrement_box.ReadOnly = true;
			this.dekrement_box.Size = new System.Drawing.Size(321, 22);
			this.dekrement_box.TabIndex = 14;
			// 
			// operator1_label
			// 
			this.operator1_label.AutoSize = true;
			this.operator1_label.Location = new System.Drawing.Point(14, 202);
			this.operator1_label.Name = "operator1_label";
			this.operator1_label.Size = new System.Drawing.Size(89, 17);
			this.operator1_label.TabIndex = 15;
			this.operator1_label.Text = "Оператор !: ";
			// 
			// operator1_box
			// 
			this.operator1_box.Location = new System.Drawing.Point(105, 202);
			this.operator1_box.Name = "operator1_box";
			this.operator1_box.ReadOnly = true;
			this.operator1_box.Size = new System.Drawing.Size(100, 22);
			this.operator1_box.TabIndex = 16;
			// 
			// operator2_label
			// 
			this.operator2_label.AutoSize = true;
			this.operator2_label.Location = new System.Drawing.Point(14, 243);
			this.operator2_label.Name = "operator2_label";
			this.operator2_label.Size = new System.Drawing.Size(90, 17);
			this.operator2_label.TabIndex = 17;
			this.operator2_label.Text = "Оператор +:";
			// 
			// scalar_box
			// 
			this.scalar_box.Location = new System.Drawing.Point(211, 243);
			this.scalar_box.Name = "scalar_box";
			this.scalar_box.Size = new System.Drawing.Size(78, 22);
			this.scalar_box.TabIndex = 18;
			// 
			// totoal_cash_box
			// 
			this.totoal_cash_box.Location = new System.Drawing.Point(105, 243);
			this.totoal_cash_box.Name = "totoal_cash_box";
			this.totoal_cash_box.ReadOnly = true;
			this.totoal_cash_box.Size = new System.Drawing.Size(77, 22);
			this.totoal_cash_box.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(189, 246);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 17);
			this.label1.TabIndex = 20;
			this.label1.Text = "+";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(295, 246);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "=";
			// 
			// rezult_box
			// 
			this.rezult_box.Location = new System.Drawing.Point(317, 243);
			this.rezult_box.Name = "rezult_box";
			this.rezult_box.ReadOnly = true;
			this.rezult_box.Size = new System.Drawing.Size(100, 22);
			this.rezult_box.TabIndex = 22;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 310);
			this.Controls.Add(this.task_panel);
			this.Name = "Form1";
			this.Text = "Практика 11-12";
			this.task_panel.ResumeLayout(false);
			this.task_panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel task_panel;
		private System.Windows.Forms.Label price_label;
		private System.Windows.Forms.TextBox number_box;
		private System.Windows.Forms.TextBox face_value_box;
		private System.Windows.Forms.Label number_label;
		private System.Windows.Forms.Label fase_value_label;
		private System.Windows.Forms.Button calculate_button;
		private System.Windows.Forms.TextBox number_of_product_box;
		private System.Windows.Forms.Label number_of_product;
		private System.Windows.Forms.TextBox all_cash_box;
		private System.Windows.Forms.Label all_cash_label;
		private System.Windows.Forms.TextBox price_box;
		private System.Windows.Forms.TextBox dekrement_box;
		private System.Windows.Forms.Label dekrement_label;
		private System.Windows.Forms.TextBox increment_box;
		private System.Windows.Forms.Label increment_label;
		private System.Windows.Forms.TextBox operator1_box;
		private System.Windows.Forms.Label operator1_label;
		private System.Windows.Forms.TextBox rezult_box;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox totoal_cash_box;
		private System.Windows.Forms.TextBox scalar_box;
		private System.Windows.Forms.Label operator2_label;
	}
}

