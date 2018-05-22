﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWorkWithTran
{
    class Library
    {
        private string ConnectionString = "Server=(local);Database=Library_ru;Trusted_Connection=True;";

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
                command.CommandText = "SELECT Id, Name FROM Groups";
                SqlDataReader reader = command.ExecuteReader();
                List<Group> groups = new List<Group>();

                while (reader.Read())
                {
                    Group group = new Group();

                    group.Id = Convert.ToInt32(reader["Id"]);
                    group.Name = Convert.ToString(reader["Name"]);

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
                var result = MessageBox.Show("Delete?", "Caution!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlCommand command = _connection.CreateCommand();
                    command.CommandText = "DALETE FROM Students WHERE Id = @Id";

                    SqlParameter parameter = new SqlParameter("Id", Id);
                    command.Parameters.Add(parameter);

                    command.ExecuteNonQuery();

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

    }
}
