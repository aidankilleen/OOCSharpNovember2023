using Microsoft.Data.Sqlite;
using MemberDao;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        List<Member> members;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            string connectionString = @"Data Source=C:\work\training\cso\db\oocsharp.db;";

            SqliteConnection conn = new SqliteConnection(connectionString);

            conn.Open();

            conn.Close();

            */

            MemberDao.MemberDao dao = new MemberDao.MemberDao();


            members = dao.GetMembers();

            foreach(Member member in members)
            {
                listBox1.Items.Add(member.Name);
            }

            dao.Close();


        }
    }
}