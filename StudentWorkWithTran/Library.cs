using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace StudentWorkWithTran
{
    public class Library
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Library_ru"].ConnectionString;

        private SqlConnection _connection;
        //--------------------------------------------------------------------
        public bool OpenConnection()
        {
            try
            {
                _connection = new SqlConnection(ConnectionString);
                _connection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        //--------------------------------------------------------------------
        public void CloseConnection()
        {
            if (_connection != null)
                _connection.Close();
        }
        //--------------------------------------------------------------------
        public List<Student> GetStudents(int groupId)
        {
            try
            {
                SqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM Students WHERE Id_Group = @groupId";

                SqlParameter parameter = new SqlParameter("groupId", groupId);
                command.Parameters.Add(parameter);

                SqlDataReader reader = command.ExecuteReader();
                List<Student> students = new List<Student>();

                while (reader.Read())
                {
                    Student student = new Student();

                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.FirstName = Convert.ToString(reader["FirstName"]);
                    student.LastName = Convert.ToString(reader["LastName"]);
                    student.Term = Convert.ToInt32(reader["Term"]);
                    student.Id_Group = Convert.ToInt32(reader["Id_Group"]);

                    students.Add(student);
                }

                reader.Close();
                return students;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        //--------------------------------------------------------------------
        public List<Group> GetGroups()
        {
            try
            {
                SqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM Groups";
                SqlDataReader reader = command.ExecuteReader();
                List<Group> groups = new List<Group>();

                while (reader.Read())
                {
                    Group group = new Group();

                    group.Id = Convert.ToInt32(reader["Id"]);
                    group.Name = Convert.ToString(reader["Name"]);
                    group.Id_Faculty = Convert.ToInt32(reader["Id_Faculty"]);

                    groups.Add(group);
                }

                reader.Close();
                return groups;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        //--------------------------------------------------------------------
        public List<Faculties> GetFaculties()
        {
            try
            {
                SqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM Faculties";
                SqlDataReader reader = command.ExecuteReader();
                List<Faculties> faculties = new List<Faculties>();

                while (reader.Read())
                {
                    Faculties facultie = new Faculties();

                    facultie.Id = Convert.ToInt32(reader["Id"]);
                    facultie.Name = Convert.ToString(reader["Name"]);

                    faculties.Add(facultie);
                }

                reader.Close();
                return faculties;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        //--------------------------------------------------------------------
        public bool UpdateStudent(string FirstName, string LastName, int Term, int Id_Group, int Id)
        {
            try
            {
                SqlCommand command = _connection.CreateCommand();
                command.CommandText = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, Term = @Term, Id_Group = @Id_Group WHERE Id = @Id";

                command.Parameters.AddWithValue("FirstName", FirstName);
                command.Parameters.AddWithValue("LastName", LastName);
                command.Parameters.AddWithValue("Term", Term);
                command.Parameters.AddWithValue("Id_Group", Id_Group);
                command.Parameters.AddWithValue("Id", Id);

                command.ExecuteNonQuery();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        //--------------------------------------------------------------------
        public bool DeleteStudent(int Id)
        {
            try
            {
                var result = MessageBox.Show("When deleting a student, the records from the student card are deleted, you agree?", "Caution!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlTransaction transaction = _connection.BeginTransaction();

                    SqlCommand command = _connection.CreateCommand();
                    command.Transaction = transaction;

                    SqlParameter parameter = new SqlParameter("Id", Id);

                    command.CommandText = "DELETE FROM S_Cards WHERE Id_Student = @Id";
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();

                    command.CommandText = "DELETE FROM Students WHERE Id = @Id";
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }

                return false;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        //--------------------------------------------------------------------
        public bool AddStudentGroup(string FirstName, string LastName, int Term, int Id_Group = -1, string GroupName = "", int Id_Faculties = 0)
        {
            try
            {
                SqlTransaction transaction = _connection.BeginTransaction();

                SqlCommand command = _connection.CreateCommand();
                command.Transaction = transaction;

                if (Id_Group == -1)
                {
                    command.CommandText = "SELECT MAX(Id) + 1 FROM Groups";

                    int maxIndexGroup = Convert.ToInt32(command.ExecuteScalar());

                    Id_Group = maxIndexGroup;

                    command.CommandText = "INSERT INTO Groups (Id, [Name], Id_Faculty) VALUES (@Id, @GroupName, @Id_Faculties)";
                    command.Parameters.AddWithValue("Id", Id_Group);
                    command.Parameters.AddWithValue("GroupName", GroupName);
                    command.Parameters.AddWithValue("Id_Faculties", Id_Faculties);

                    command.ExecuteNonQuery();
                }

                command.CommandText = "SELECT MAX(Id) + 1 FROM Students";

                int maxIndexStud = Convert.ToInt32(command.ExecuteScalar());

                command.CommandText = "INSERT INTO Students (Id, FirstName, LastName, Term, Id_Group) VALUES (@Id, @FirstName, @LastName, @Term, @Id_Group)";

                command.Parameters.AddWithValue("Id", maxIndexStud);
                command.Parameters.AddWithValue("FirstName", FirstName);
                command.Parameters.AddWithValue("LastName", LastName);
                command.Parameters.AddWithValue("Term", Term);
                command.Parameters.AddWithValue("Id_Group", Id_Group);

                command.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        //--------------------------------------------------------------------
        public bool AddGroup(string GroupName, int Id_Faculties)
        {
            try
            {
                SqlCommand command = new SqlCommand();

                command.CommandText = "INSERT INTO Groups (Id, Name, Id_Group) VALUES (@Id, @GroupName, @Id_Faculties)";
                command.Parameters.AddWithValue("Id", GetNewGroupId());
                command.Parameters.AddWithValue("GroupName", GroupName);
                command.Parameters.AddWithValue("Id_Faculties", Id_Faculties);

                command.ExecuteNonQuery();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        //--------------------------------------------------------------------
        public int GetNewGroupId()
        {
            try
            {
                SqlTransaction transaction = _connection.BeginTransaction();

                SqlCommand command = _connection.CreateCommand();
                command.Transaction = transaction;

                command.CommandText = "SELECT MAX(Id) + 1 FROM Groups";

                transaction.Commit();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException)
            {
                return -1;
            }
        }
        //--------------------------------------------------------------------
        public int GetNewStudId()
        {
            try
            {
                SqlTransaction transaction = _connection.BeginTransaction();

                SqlCommand command = _connection.CreateCommand();
                command.Transaction = transaction;

                command.CommandText = "SELECT MAX(Id) + 1 FROM Student";

                transaction.Commit();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException)
            {
                return -1;
            }
        }
        //--------------------------------------------------------------------
    }
}
