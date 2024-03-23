namespace Day12_Threading
{
    public partial class ThreadingTask : Form
    {
        public ThreadingTask()
        {
            InitializeComponent();
        }

        private async void btnOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Please enter a valid URL in the text box.");
                    return;
                }

                HttpClient client = new HttpClient();
                byte[] fileBytes = await client.GetByteArrayAsync(textBox1.Text);

                if (fileBytes != null && fileBytes.Length > 0)
                {
                    await File.WriteAllBytesAsync("D:\\C#-ITI\\Labs\\Day12\\Day12-Threading\\Download\\file.rar", fileBytes);
                    MessageBox.Show("Downloaded");
                }
                else
                {
                    MessageBox.Show("Failed to download file. The response is empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private async void btnTwo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Please enter a valid URL in the text box.");
                    return;
                }

                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(textBox1.Text);

                if (response.IsSuccessStatusCode)
                {
                    richTextBoxOne.Text = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("New Information Ready");
                }
                else
                {
                    MessageBox.Show($"Failed to retrieve data. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }
    }
}
