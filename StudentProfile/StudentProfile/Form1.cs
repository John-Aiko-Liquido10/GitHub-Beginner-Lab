namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text.Trim();

            if (ID == "123")
            {
                lblName.Text = "John Doe";
                lblSection.Text = "BT-1101";
                lblCourse.Text = "Information Technology";
                lblYear.Text = "1st Year";
            }
            else if (ID == "122")
            {
                lblName.Text = "Jane Doe";
                lblSection.Text = "COE-2001";
                lblCourse.Text = "Computer Engineering";
                lblYear.Text = "2nd Year";
            }
            else if (ID == "121")
            {
                lblName.Text = "Mark Doe";
                lblSection.Text = "HM-3101";
                lblCourse.Text = "Hotel Management";
                lblYear.Text = "3rd Year";
            }
            else
            {
                lblName.Text = "Student Not Found";
                lblSection.Text = "Student Not Found";
                lblCourse.Text = "Student Not Found";
                lblYear.Text = "Student Not Found";
            }
        }
    }
}
