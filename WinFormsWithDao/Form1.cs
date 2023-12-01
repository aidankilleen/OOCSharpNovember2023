using MemberDao;

namespace WinFormsWithDao
{
    public partial class Form1 : Form
    {
        MemberDao.MemberDao dao = new MemberDao.MemberDao();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var members = dao.GetMembers();
            foreach(Member member in members)
            {
                lbMembers.Items.Add(member.Name);
            }
        }
    }
}