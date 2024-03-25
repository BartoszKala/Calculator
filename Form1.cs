using System.Globalization;

namespace kalkulator
{
	public partial class Kalkulator : Form
	{

		Decimal result = 0;
		string operation = string.Empty;
		string first, second;
		bool enterValue = false;


        public Kalkulator()
		{
			InitializeComponent();
		}

		private void number_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;

			if ((text.Text == "") && (button.Text == "."))
			{
				text.Text = "0.";
			}


			if (text.Text == "0" && button.Text != ".")
			{
				text.Text = text.Text.Trim('0');
			}

			if (button.Text == ".")
			{
				if (!text.Text.Contains("."))
				{
					text.Text = text.Text + button.Text;
				}
			}
			else
			{
				text.Text = text.Text + button.Text;
			}
		}

		private void operation_Click(object sender, EventArgs e)
		{
			try
			{

				if (text.Text != "")
				{

                    //if (result != 0)
                    //{
                    //                   equals.PerformClick();
                    //}
                    //else
                    //{
                    //                   result = Decimal.Parse(text.Text);
                    //}

                    equals.PerformClick();

                    result = Decimal.Parse(text.Text);

                    Button button = (Button)sender;
					operation = button.Text;
					enterValue = true;

					if (text.Text != "")
					{
						text2.Text = first = $"{result}{operation}";
						text.Text = string.Empty;
					}
				}
			}
			catch (FormatException ex)
			{
                CA.PerformClick();
                MessageBox.Show("Invalid number format", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (OverflowException ex)
			{
                CA.PerformClick();
                MessageBox.Show("Value is out of range", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
                CA.PerformClick();
                MessageBox.Show($"Unexpected error: {ex.Message}", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

        }

		private void equals_Click(object sender, EventArgs e)
		{
			try { 
			if (text.Text != "") { 
			second = text.Text;
			//text.Text=Decimal.Parse(text.Text).ToString();
			text2.Text = $"{text2.Text}{text.Text}=";

			if (text.Text != string.Empty)
					{ 
					if (text.Text == "")
					{
						text2.Text = string.Empty;
					}
					switch (operation)
					{
						case "+":
							text.Text = (result + Decimal.Parse(text.Text, CultureInfo.InvariantCulture)).ToString();
							break;
						case "-":
							text.Text = (result - Decimal.Parse(text.Text, CultureInfo.InvariantCulture)).ToString();
							break;
						case "*":
							text.Text = (result * Decimal.Parse(text.Text, CultureInfo.InvariantCulture)).ToString();
							break;
						case "/":
						if (Decimal.Parse(second) == 0)
						{
							CA.PerformClick();
							MessageBox.Show("You can not devide by zero!", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
						}
						else
						{
								text.Text = (result / Decimal.Parse(text.Text, CultureInfo.InvariantCulture)).ToString();
							}
							break;
						default:
							text2.Text = $"{text.Text}";
							break;
					}

				if (second != string.Empty)
				{
					result = Decimal.Parse(text.Text, CultureInfo.InvariantCulture);  
					operation = string.Empty;
				}
	
			}
			}
            }
            catch (FormatException ex)
            {
                CA.PerformClick();
                MessageBox.Show("Invalid number format", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                CA.PerformClick();
                MessageBox.Show("Value is out of range", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                CA.PerformClick();
                MessageBox.Show($"Unexpected error: {ex.Message}", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

		private void advanced_operation_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			operation = button.Text;

			try { 
			if (text.Text.Length > 0 && text.Text!="-")
			{
				switch (operation)
				{
					case "√":
						if (Decimal.Parse(text.Text, CultureInfo.InvariantCulture) < 0)
						{
							CA.PerformClick();
							MessageBox.Show("There is not square root of a negative number!", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

						}
						else
						{
							text2.Text = $"√({Decimal.Parse(text.Text)})";
							text.Text = Convert.ToString(Math.Sqrt(Double.Parse(text.Text, CultureInfo.InvariantCulture)));
						}
						break;
					case "^2":
						text2.Text = $"{Decimal.Parse(text.Text)}^2";
						text.Text = Convert.ToString(Decimal.Parse(text.Text) * Decimal.Parse(text.Text, CultureInfo.InvariantCulture));
						break;
					case "1/x":
						if (Decimal.Parse(text.Text, CultureInfo.InvariantCulture) != 0)
						{

							text2.Text = $"1/{Decimal.Parse(text.Text)}";
							text.Text = Convert.ToString(1 / Decimal.Parse(text.Text, CultureInfo.InvariantCulture));
						}
						else
						{    
							CA.PerformClick();

							MessageBox.Show("There is not inverse of zero!", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
						}
						break;
					default:
                        text2.Text = $"{text.Text}";
                        break;


				}
			}
            }
            catch (FormatException ex)
            {
                CA.PerformClick();
                MessageBox.Show("Invalid number format", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                CA.PerformClick();
                MessageBox.Show("Value is out of range", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                CA.PerformClick();
                MessageBox.Show($"Unexpected error: {ex.Message}", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void CA_Click(object sender, EventArgs e)
		{
			text.Text = string.Empty;
			text2.Text = string.Empty;
			first =string.Empty;
			second=string.Empty;
			operation= string.Empty;
			result = 0;
        }

		private void C_Click(object sender, EventArgs e)
		{
			text.Text = string.Empty;
		}

		private void opposite_Click(object sender, EventArgs e)
		{
			if (text.Text.Length > 0 && text.Text != "-")
			{
				if (Decimal.Parse(text.Text) != 0)
				{
					if (text.Text.Contains("-"))
					{
						text.Text = text.Text.Remove(0, 1);
					}
					else
					{
						text.Text = "-" + text.Text;
					}
				}
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			try { 
			if (text.Text.Length > 0)
			{
				text.Text = text.Text.Remove(text.Text.Length - 1, 1);

					if (text.Text == "-")
					{
						text.Text = string.Empty;
					}
			}
			 }
            catch (FormatException ex)
            {
                CA.PerformClick();
                MessageBox.Show("Invalid number format", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                CA.PerformClick();
                MessageBox.Show("Value is out of range", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                CA.PerformClick();
                MessageBox.Show($"Unexpected error: {ex.Message}", "WARING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

		}

	
	}
}
