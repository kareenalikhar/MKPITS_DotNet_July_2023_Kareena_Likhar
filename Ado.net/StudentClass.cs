using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace student_class_sqlcon
{
    internal class StudentClass
    {
        string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";

        //create a method to insert into student table

        public string InsertStudent(int rno,string studname,string gender,string hobby,string city,string dob)
        {
            using(SqlConnection con=new SqlConnection(strcon))
            {
                con.Open();
                string str = "insert into students values(@rno,@studname,@gender,@hobby,@city,@dob)";

                using(SqlCommand command=new SqlCommand(str,con))
                {
                    command.Parameters.AddWithValue("@rno", rno);
                    command.Parameters.AddWithValue("@studname", studname);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@hobby", hobby);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.ExecuteNonQuery();

                    con.Close();
                    return "Record inserted successfully";
                }
            }
        }

        public string UpdateStudent(int rno,string studname,string gender,string hobby,string city,string dob)
        {
            using(SqlConnection con=new SqlConnection(strcon))
            {
                con.Open();
                string str = "update students set studname=@studname,gender=@gender,hobby=@hobby,city=@city,dob=@dob where rno=@rno";

                using(SqlCommand command=new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@studname", studname);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@hobby", hobby);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.Parameters.AddWithValue("@rno", rno);
                    command.ExecuteNonQuery();

                    con.Close();
                    return "Record updated successfully";
                }
                
            }
            
        }

        public string DeleteStudent(int rno,string studname,string gender,string hobby,string city,string dob)
        {
            using(SqlConnection con=new SqlConnection(strcon))
            {
                con.Open() ;
                string str = "delete from students where rno=@rno or studname=@studname";

                using(SqlCommand command=new SqlCommand(str,con))
                {
                    command.Parameters.AddWithValue("@rno", rno);
                    command.Parameters.AddWithValue("@studname", studname);

                    command.ExecuteNonQuery();
                    con.Close();
                    return "Record deleted successfully";
                }
            }
        }

        public List<student> SearchStudent(int rno)
        {
            using(SqlConnection con=new SqlConnection(strcon))
            {
                con.Open();
                string str = "select * from students where rno=@rno";
                using( SqlCommand command=new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@rno", rno);
                    SqlDataReader dr= command.ExecuteReader();
                    List<student> li = new List<student>();
                    while(dr.Read())
                    {
                        li.Add(new student(Convert.ToInt32(dr["rno"].ToString()), dr["studname"].ToString(), dr["gender"].ToString(), dr["hobby"].ToString(), dr["city"].ToString(), dr["dob"].ToString()));
                    }
                    return li;
                }
            }
        }
    }
}
