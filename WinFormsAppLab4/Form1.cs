namespace WinFormsAppLab4
{
    public partial class Form1 : Form
    {
        Classroow classroow;
        public Form1()
        {
            InitializeComponent();
            classroow = new Classroow("OOP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_name = this.tbName.Text;
            string input_year = this.tbBirthYear.Text;
            int iYear = Int32.Parse(input_year);

            Person person = new Person(input_name, iYear);
            //show all person name
            this.texName.Text += person.getName() + "\r\n";
            //show all person age
            int currentAge = Int32.Parse(this.tbTotal.Text);
            int newtoalAge = currentAge + person.getAge();
            this.tbTotal.Text = newtoalAge.ToString();

        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}