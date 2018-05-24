using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;

namespace StudentWorkWithTran
{
    public class Library
    {
        private string _connectionString;
        private DbConnection _connection;
        private DbProviderFactory _factory;
        //--------------------------------------------------------------------
        public Library(string ConnectionStringName)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[ConnectionStringName];

            _connectionString = settings.ConnectionString;

            _factory = DbProviderFactories.GetFactory(settings.ProviderName);
        }
        //--------------------------------------------------------------------
        public bool OpenConnection()
        {
            try
            {
                _connection = _factory.CreateConnection();
                _connection.ConnectionString = _connectionString;
                _connection.Open();
                return true;
            }
            catch (DbException)
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
                DbCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM Students WHERE Id_Group = @groupId";
                
                DbParameter parameter = _factory.CreateParameter();
                parameter.ParameterName = "groupId";
                parameter.Value = groupId;
                command.Parameters.Add(parameter);

                DbDataReader reader = command.ExecuteReader();
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
            catch (DbException)
            {
                return null;
            }
        }
        //--------------------------------------------------------------------
        public List<Group> GetGroups()
        {
            try
            {
                DbCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM Groups";
                DbDataReader reader = command.ExecuteReader();
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
            catch (DbException)
            {
                return null;
            }
        }
        //--------------------------------------------------------------------
        public List<Faculties> GetFaculties()
        {
            try
            {
                DbCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM Faculties";
                DbDataReader reader = command.ExecuteReader();
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
            catch (DbException)
            {
                return null;
            }
        }
        //--------------------------------------------------------------------
        public bool UpdateStudent(string FirstName, string LastName, int Term, int Id_Group, int Id)
        {
            try
            {
                DbCommand command = _connection.CreateCommand();
                command.CommandText = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, Term = @Term, Id_Group = @Id_Group WHERE Id = @Id";

                DbParameter parameterFirstName = _factory.CreateParameter();
                parameterFirstName.ParameterName = "FirstName";
                parameterFirstName.Value = FirstName;
                command.Parameters.Add(parameterFirstName);

                DbParameter parameterLastName = _factory.CreateParameter();
                parameterLastName.ParameterName = "LastName";
                parameterLastName.Value = LastName;
                command.Parameters.Add(parameterLastName);

                DbParameter parameterTerm = _factory.CreateParameter();
                parameterTerm.ParameterName = "Term";
                parameterTerm.Value = Term;
                command.Parameters.Add(parameterTerm);

                DbParameter parameterId_Group = _factory.CreateParameter();
                parameterId_Group.ParameterName = "Id_Group";
                parameterId_Group.Value = Id_Group;
                command.Parameters.Add(parameterId_Group);

                DbParameter parameterId = _factory.CreateParameter();
                parameterId.ParameterName = "Id";
                parameterId.Value = Id;
                command.Parameters.Add(parameterId);

                command.ExecuteNonQuery();

                return true;
            }
            catch (DbException)
            {
                return false;
            }
        }
        //--------------------------------------------------------------------
        public bool DeleteStudent(int Id)
        {
            DbTransaction transaction = _connection.BeginTransaction();

            try
            {
                var result = MessageBox.Show("When deleting a student, the records from the student card are deleted, you agree?", "Caution!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    DbCommand command = _connection.CreateCommand();
                    command.Transaction = transaction;

                    DbParameter parameter = _factory.CreateParameter();
                    parameter.ParameterName = "Id";
                    parameter.Value = Id;
                    command.Parameters.Add(parameter);

                    command.CommandText = "DELETE FROM S_Cards WHERE Id_Student = @Id";
                    command.ExecuteNonQuery();

                    command.CommandText = "DELETE FROM Students WHERE Id = @Id";
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }

                return false;
            }
            catch (DbException)
            {
                transaction.Rollback();
                return false;
            }
        }
        //--------------------------------------------------------------------
        public bool AddStudentGroup(string FirstName, string LastName, int Term, int Id_Group = -1, string GroupName = "", int Id_Faculties = 0)
        {
            DbTransaction transaction = _connection.BeginTransaction();

            try
            {
                DbCommand command = _connection.CreateCommand();
                command.Transaction = transaction;


                if (Id_Group == -1)
                {
                    command.CommandText = "SELECT MAX(Id) + 1 FROM Groups";

                    int maxIndexGroup = Convert.ToInt32(command.ExecuteScalar());

                    Id_Group = maxIndexGroup;

                    command.CommandText = "INSERT INTO Groups (Id, [Name], Id_Faculty) VALUES (@Id, @GroupName, @Id_Faculties)";

                    DbParameter parameterIdGroup = _factory.CreateParameter();
                    parameterIdGroup.ParameterName = "Id";
                    parameterIdGroup.Value = Id_Group;
                    command.Parameters.Add(parameterIdGroup);

                    DbParameter parameterGroupName = _factory.CreateParameter();
                    parameterGroupName.ParameterName = "GroupName";
                    parameterGroupName.Value = GroupName;
                    command.Parameters.Add(parameterGroupName);

                    DbParameter parameterId_Faculties = _factory.CreateParameter();
                    parameterId_Faculties.ParameterName = "Id_Faculties";
                    parameterId_Faculties.Value = Id_Faculties;
                    command.Parameters.Add(parameterId_Faculties);

                    command.ExecuteNonQuery();
                }

                command.CommandText = "SELECT MAX(Id) + 1 FROM Students";

                int maxIndexStud = Convert.ToInt32(command.ExecuteScalar());

                command.CommandText = "INSERT INTO Students (Id, FirstName, LastName, Term, Id_Group) VALUES (@Id, @FirstName, @LastName, @Term, @Id_Group)";
                
                DbParameter parameterIdStud = _factory.CreateParameter();
                parameterIdStud.ParameterName = "Id";
                parameterIdStud.Value = maxIndexStud;
                command.Parameters.Add(parameterIdStud);

                DbParameter parameterFirstName = _factory.CreateParameter();
                parameterFirstName.ParameterName = "FirstName";
                parameterFirstName.Value = FirstName;
                command.Parameters.Add(parameterFirstName);

                DbParameter parameterLastName = _factory.CreateParameter();
                parameterLastName.ParameterName = "LastName";
                parameterLastName.Value = LastName;
                command.Parameters.Add(parameterLastName);

                DbParameter parameterTerm = _factory.CreateParameter();
                parameterTerm.ParameterName = "Term";
                parameterTerm.Value = Term;
                command.Parameters.Add(parameterTerm);

                DbParameter parameterId_Group = _factory.CreateParameter();
                parameterId_Group.ParameterName = "Id_Group";
                parameterId_Group.Value = Id_Group;
                command.Parameters.Add(parameterId_Group);

                command.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch (DbException)
            {
                transaction.Rollback();
                return false;
            }
        }
        //--------------------------------------------------------------------
        public bool AddGroup(string GroupName, int Id_Faculties)
        {
            try
            {
                DbCommand command = _connection.CreateCommand();

                command.CommandText = "INSERT INTO Groups (Id, Name, Id_Group) VALUES (@Id, @GroupName, @Id_Faculties)";

                DbParameter parameterId = _factory.CreateParameter();
                parameterId.ParameterName = "Id";
                parameterId.Value = GetNewGroupId();
                command.Parameters.Add(parameterId);

                DbParameter parameterGroupName = _factory.CreateParameter();
                parameterGroupName.ParameterName = "GroupName";
                parameterGroupName.Value = GroupName;
                command.Parameters.Add(parameterGroupName);

                DbParameter parameterId_Faculties = _factory.CreateParameter();
                parameterId_Faculties.ParameterName = "Id_Faculties";
                parameterId_Faculties.Value = Id_Faculties;
                command.Parameters.Add(parameterId_Faculties);
                
                command.ExecuteNonQuery();

                return true;
            }
            catch (DbException)
            {
                return false;
            }
        }
        //--------------------------------------------------------------------
        public int GetNewGroupId()
        {
            DbTransaction transaction = _connection.BeginTransaction();

            try
            {
                DbCommand command = _connection.CreateCommand();
                command.Transaction = transaction;

                command.CommandText = "SELECT MAX(Id) + 1 FROM Groups";

                transaction.Commit();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (DbException)
            {
                transaction.Rollback();
                return -1;
            }
        }
        //--------------------------------------------------------------------
        public int GetNewStudId()
        {
            DbTransaction transaction = _connection.BeginTransaction();

            try
            {
                DbCommand command = _connection.CreateCommand();
                command.Transaction = transaction;

                command.CommandText = "SELECT MAX(Id) + 1 FROM Student";

                transaction.Commit();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (DbException)
            {
                transaction.Rollback();
                return -1;
            }
        }
        //--------------------------------------------------------------------
    }
}
