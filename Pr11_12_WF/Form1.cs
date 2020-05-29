using System;
using System.Windows.Forms;

namespace Pr11_12_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Money cash = new Money();
		private void calculate_button_Click(object sender, EventArgs e)
		{
			try
			{
				cash.input(face_value_box, number_box);
				all_cash_box.Text = cash.TotalCash.ToString();
				if(cash.how_much(Convert.ToDouble(price_box.Text)) == 0)
				{
					MessageBox.Show($"Вам не хвататет {Math.Abs((double)cash.face_value_ * (double)cash.number_of_ - (Convert.ToDouble(price_box.Text)))}");
				}
				number_of_product_box.Text = cash.how_much(Convert.ToDouble(price_box.Text)).ToString();
				increment_box.Text = cash++.ToString();
				dekrement_box.Text = cash--.ToString();
				operator1_box.Text = (!cash).ToString();
				totoal_cash_box.Text = cash.number_of_.ToString();
				rezult_box.Text = (cash + Convert.ToInt32(scalar_box.Text)).ToString();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
	}
}
