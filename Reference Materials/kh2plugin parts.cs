        uint rox2 = 0;
        private void roxas2_CheckedChanged(object sender, EventArgs e)
        {

            string roxcode = "0 027F6A88 0323";

           if (roxas1.Checked)
            {
                rox2 = NCInterface.ConstCodeAdd(roxcode, true);
            }
           else
           {
               NCInterface.ConstCodeRemove(rox2);
           }
        }
	
	
	
	
	
	private void Test()
{
    ComboboxItem tent = new ComboboxItem();
    tent.Text = "Item text1";
    tent.Value = 12;

    comboBox1.Items.Add(tent);

    comboBox1.SelectedIndex = 0;

    MessageBox.Show((comboBox1.SelectedItem as ComboboxItem).Value.ToString());
}