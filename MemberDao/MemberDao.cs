using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberDao
{
    public class MemberDao
    {
        SqliteConnection conn;
        string connectionString = @"Data Source=C:\work\training\cso\db\oocsharp.db;";

        public MemberDao()
        {
            conn = new SqliteConnection(connectionString);
            conn.Open();
        }
        // return all member objects from the db
        public List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();
            string sql = "SELECT * FROM members";
            SqliteCommand cmd = new SqliteCommand(sql, conn);
            var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int id = rdr.GetInt32(0);
                string name = rdr.GetString(1);
                string email = rdr.GetString(2);
                bool active = rdr.GetBoolean(3);
                Member member = new Member { 
                    Id=id, 
                    Name = name, 
                    Email=email, 
                    Active=active
                };
                members.Add(member);
            }
            rdr.Close();
            return members;
        }
        public Member GetMember(int id)
        {
            Member member = null;

            string sql = $"SELECT * FROM members WHERE id = { id }";

            SqliteCommand cmd = new SqliteCommand(sql, conn);

            var rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                string name = rdr.GetString(1);
                string email = rdr.GetString(2);
                bool active = rdr.GetBoolean(3);
                member = new Member { 
                    Id = id, 
                    Name = name, 
                    Email = email, 
                    Active = active 
                };
            } else
            {
                throw new MemberDaoException($"Member {id} not found");
            }
            return member;
        }

        public void DeleteMember(int id)
        {
            string sql = $"DELETE FROM members WHERE id = { id }";
            SqliteCommand cmd = new SqliteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
 
        public Member UpdateMember(Member member)
        {
            //string sql = $@"UPDATE members SET name = '{ member.Name }', email='{ member.Email }', active = { (member.Active ? 1 : 0) } WHERE id= { member.Id }";
            string sql = "UPDATE members SET name=@Name, email=@Email, active=@Active WHERE id=@Id";


            SqliteCommand cmd = new SqliteCommand(sql, conn);

            cmd.Parameters.Add(new SqliteParameter("@Name", member.Name));
            cmd.Parameters.Add(new SqliteParameter("@Email", member.Email));
            cmd.Parameters.Add(new SqliteParameter("@Active", member.Active));
            cmd.Parameters.Add(new SqliteParameter("@Id", member.Id));

            cmd.ExecuteNonQuery();
            return member;
        }
        
        public Member AddMember(Member member)
        {
            // string sql = $@"INSERT INTO members (name, email, active) VALUES('{ member.Name }', '{ member.Email }',{ (member.Active ? 1 : 0) })";
            // ','',0);  --
            // ','',0); drop table members; --


            string sql = $@"INSERT INTO members (name, email, active) VALUES(@Name,@Email,@Active)";

            SqliteCommand cmd = new SqliteCommand(sql, conn);

            cmd.Parameters.Add(new SqliteParameter("@Name", member.Name != null ? member.Name : ""));
            cmd.Parameters.Add(new SqliteParameter("@Email", member.Email != null ? member.Email : ""));
            cmd.Parameters.Add(new SqliteParameter("@Active", member.Active ? 1 : 0));

            cmd.ExecuteNonQuery();

            // Get the newly created id
            sql = "SELECT last_insert_rowid();";
            cmd = new SqliteCommand(sql, conn);

            Int64 id = (Int64)cmd.ExecuteScalar();

            member.Id = Convert.ToInt32(id);
            Console.WriteLine($"New id:{ id }");
            return member;
        }

        public void Close()
        {
            conn.Close();
        }
    }
}
