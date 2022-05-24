using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ADO;
using System.Collections.ObjectModel;

namespace Core
{
    public static class DataAccess
    { 
        //CHILD--------------------------------------------------------------------------------------------------
        public static ObservableCollection<Child> GetChilds()
        {
            return new ObservableCollection<Child>(DbConnection.Connection.Child);
        }

        public static Child GetChild(int id)
        {
            return GetChilds().Where(x => x.Id == id).FirstOrDefault();
        }

        public static void AddChild(string name, string surname, string patronymic, string birthDate, string groupId, string genderId)
        {
            Child child = new Child();
            child.Name = name;
            child.Surname = surname;
            child.Patronymic = patronymic;
            child.BirthDate = Convert.ToDateTime(birthDate);
            child.GroupId = Convert.ToInt32(groupId);
            child.GenderId = Convert.ToInt32(genderId);
            DbConnection.Connection.Child.Add(child);
            DbConnection.Connection.SaveChanges();
        }

        public static void AddChild(Child child)
        {
            DbConnection.Connection.Child.Add(child);
            DbConnection.Connection.SaveChanges();
        }

        public static void EditChild(string id, string name, string surname, string patronymic, string birthDate, string groupId, string genderId)
        {
            Child child = GetChild(Convert.ToInt32(id));
            child.Name = name;
            child.Surname = surname;
            child.Patronymic = patronymic;
            child.BirthDate = Convert.ToDateTime(birthDate);
            child.GroupId = Convert.ToInt32(groupId);
            child.GenderId = Convert.ToInt32(genderId);
            DbConnection.Connection.SaveChanges();
        }

        public static void EditChild(string id, Child newChild)
        {
            Child child = GetChild(Convert.ToInt32(id));
            child = newChild;
            DbConnection.Connection.SaveChanges();
        }

        public static void RemoveChild(int id)
        {
            DbConnection.Connection.Child.Remove(GetChild(id));
            DbConnection.Connection.SaveChanges();
        }

        //EMPLOYEE------------------------------------------------------------------------------------------------

        public static ObservableCollection<Employee> GetEmployees()
        {
            return new ObservableCollection<Employee>(DbConnection.Connection.Employee);
        }

        public static Employee GetEmployee(int id)
        {
            return GetEmployees().Where(x => x.Id == id).FirstOrDefault();
        }

        public static void AddEmployee(string name, string surname, string patronymic, string birthDate, string positionId, string genderId)
        {
            Employee employee = new Employee();

            employee.Name = name;
            employee.Surname = surname;
            employee.Patronymic = patronymic;
            employee.BirthDate = Convert.ToDateTime(birthDate);
            employee.PositionId = Convert.ToInt32(positionId);
            employee.GenderId = Convert.ToInt32(genderId);

            DbConnection.Connection.Employee.Add(employee);
            DbConnection.Connection.SaveChanges();
        }

        public static void AddEmployee(Employee employee)
        {
            DbConnection.Connection.Employee.Add(employee);
            DbConnection.Connection.SaveChanges();
        }

        public static void EditEmployee(string id, string name, string surname, string patronymic, string birthDate, string positionId, string genderId)
        {
            Employee employee = GetEmployee(Convert.ToInt32(id));

            employee.Name = name;
            employee.Surname = surname;
            employee.Patronymic = patronymic;
            employee.BirthDate = Convert.ToDateTime(birthDate);
            employee.PositionId = Convert.ToInt32(positionId);
            employee.GenderId = Convert.ToInt32(genderId);

            DbConnection.Connection.SaveChanges();
        }
        
        public static void EditEmployee(string id, Employee newEmployee)
        {
            Employee employee = GetEmployee(Convert.ToInt32(id));
            employee = newEmployee;
            DbConnection.Connection.SaveChanges();
        }


        public static void RemoveEmployee(int id)
        {
            DbConnection.Connection.Employee.Remove(GetEmployee(id));
            DbConnection.Connection.SaveChanges();
        }

        //GROUP---------------------------------------------------------------------------------------------------

        public static ObservableCollection<Group> GetGroups()
        {
            return new ObservableCollection<Group>(DbConnection.Connection.Group);
        }

        public static Group GetGroup(int id)
        {
            return GetGroups().Where(x => x.Id == id).FirstOrDefault();
        }

        public static void AddGroup(string name, string specificationId, string amount)
        {
            Group group = new Group();
            group.Name = name;
            group.SpecificationId = Convert.ToInt32(specificationId);
            group.Amount = Convert.ToInt32(amount);
            DbConnection.Connection.Group.Add(group);
            DbConnection.Connection.SaveChanges();
        }

        public static void AddGroup(Group group)
        {
            DbConnection.Connection.Group.Add(group);
            DbConnection.Connection.SaveChanges();
        }

        public static void EditGroup(string id, string name, string specificationId, string amount)
        {
            Group group = GetGroup(Convert.ToInt32(id));
            group.Name = name;
            group.SpecificationId = Convert.ToInt32(specificationId);
            group.Amount = Convert.ToInt32(amount);
            DbConnection.Connection.SaveChanges();
        }

        public static void EditGroup(string id, Group newGroup)
        {
            Group group = GetGroup(Convert.ToInt32(id));
            group = newGroup;
            DbConnection.Connection.SaveChanges();
        }

        public static void RemoveGroup(int id)
        {
            DbConnection.Connection.Group.Remove(GetGroup(id));
            DbConnection.Connection.SaveChanges();
        }

        //Specification-------------------------------------------------------------------------------------------

        public static ObservableCollection<Specification> GetSpecifications()
        {
            return new ObservableCollection<Specification>(DbConnection.Connection.Specification);
        }

        public static Specification GetSpecification(int id)
        {
            return GetSpecifications().Where(x => x.Id == id).FirstOrDefault();
        }

        public static void AddSpecification(string name)
        {
            Specification specification = new Specification();
            specification.Name = name;
            DbConnection.Connection.Specification.Add(specification);
            DbConnection.Connection.SaveChanges();
        }

        public static void AddSpecification(Specification specification)
        {
            DbConnection.Connection.Specification.Add(specification);
            DbConnection.Connection.SaveChanges();
        }

        public static void EditSpecification(string id, string name)
        {
            Specification specification = GetSpecification(Convert.ToInt32(id));
            specification.Name = name;
            DbConnection.Connection.SaveChanges();
        }

        public static void EditSpecification(string id, Specification newSpecification)
        {
            Specification specification = GetSpecification(Convert.ToInt32(id));
            specification = newSpecification;
            DbConnection.Connection.SaveChanges();
        }

        public static void RemoveSpecification(int id)
        {
            DbConnection.Connection.Specification.Remove(GetSpecification(id));
            DbConnection.Connection.SaveChanges();
        }

        //Position------------------------------------------------------------------------------------------------

        public static ObservableCollection<Position> GetPositions()
        {
            return new ObservableCollection<Position>(DbConnection.Connection.Position);
        }

        public static Position GetPosition(int id)
        {
            return GetPositions().Where(x => x.Id == id).FirstOrDefault();
        }

        public static void AddPosition(string name)
        {
            Position position = new Position();
            position.Name = name;
            DbConnection.Connection.Position.Add(position);
            DbConnection.Connection.SaveChanges();
        }

        public static void AddPosition(Position position)
        {
            DbConnection.Connection.Position.Add(position);
            DbConnection.Connection.SaveChanges();
        }

        public static void EditPosition(string id, string name)
        {
            Position position = GetPosition(Convert.ToInt32(id));
            position.Name = name;
            DbConnection.Connection.SaveChanges();
        }

        public static void EditPosition(string id, Position newPosition)
        {
            Position position = GetPosition(Convert.ToInt32(id));
            position = newPosition;
            DbConnection.Connection.SaveChanges();
        }

        public static void RemovePosition(int id)
        {
            DbConnection.Connection.Position.Remove(GetPosition(id));
            DbConnection.Connection.SaveChanges();
        }

        //Gender--------------------------------------------------------------------------------------------------

        public static ObservableCollection<Gender> GetGenders()
        {
            return new ObservableCollection<Gender>(DbConnection.Connection.Gender);
        }

        public static Gender GetGender(int id)
        {
            return DbConnection.Connection.Gender.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
