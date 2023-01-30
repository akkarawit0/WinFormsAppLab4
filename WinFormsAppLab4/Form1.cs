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
            string inputGpa = this.GPA.Text;
            int iYear = Int32.Parse(input_year);
            double iGpa = double.Parse(inputGpa);

            Person person = new Person(input_name, iYear,iGpa);

            //show all person name
            texName.Text += person.getName() + "\r\n";

            //show all person age
            int currentAge = Int32.Parse(this.tbTotal.Text);
            int newtoalAge = currentAge + person.getAge();
            this.tbTotal.Text = newtoalAge.ToString();

            this.classroow.addPerson2Class(person);
            this.texName.Text =
                  classroow.showAllPersoninClass();
            //ปีเกิด
           // tbBirthYear.Text =
             //   classroow.SumYear();
            //เฉลี่ยน
            GpaAvg.Text =
                classroow.avgMaxGPA();
            //เกรดสูง
            GpaMax.Text =
                classroow.MaxGPA();
            //เกรดต่ำ
            tbGpaNim.Text =
                classroow.MinGPA();
            //ชื่อเกรดสูง
            NameGMax.Text =
                classroow.GpamaxName();
            //ชื่อเกรดต่ำ
            NameGNim.Text =
                classroow.GpaminName();





        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void texName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}