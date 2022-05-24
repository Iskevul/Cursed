using System;
using Core;
using Core.ADO;

namespace KursConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            int amount = Convert.ToInt32(Console.ReadLine());
            while ((line = Console.ReadLine()) != null && amount >= 0)
            {
                --amount;
                string[] command = line.Split();
                switch (command[0].ToUpper())
                {
                    //Childs------------------------------------------------------------------------------------------------------------
                    case "ALL_CHILDS":
                        foreach (Child child1 in DataAccess.GetChilds())  
                            Console.WriteLine($"Id: {child1.Id}, Name: {child1.Name}, Surname: {child1.Surname}, Patronymic: {child1.Patronymic}, " +
                                $"BirthDate: {child1.BirthDate}, GroupName: {DataAccess.GetGroup((int)child1.GroupId).Name}, " +
                                $"Gender: {DataAccess.GetGender((int)child1.GenderId).Name}");
                        break;

                    case "GET_CHILD":
                        Child child2 = DataAccess.GetChild(Convert.ToInt32(command[1]));
                        Console.WriteLine($"Id: {child2.Id}, Name: {child2.Name}, Surname: {child2.Surname}, Patronymic: {child2.Patronymic}" +
                                $"BirthDate: {child2.BirthDate}, GroupName: {DataAccess.GetGroup((int)child2.GroupId).Name}, " +
                                $"Gender: {DataAccess.GetGender((int)child2.GenderId).Name}");
                        break;

                    case "ADD_CHILD":
                        DataAccess.AddChild(command[1], command[2], command[3], command[4], command[5], command[6]);
                        break;

                    case "EDIT_CHILD":
                        DataAccess.EditChild(command[1], command[2], command[3], command[4], command[5], command[6], command[7]);
                        break;

                    case "REMOVE_CHILD":
                        DataAccess.RemoveChild(Convert.ToInt32(command[1]));
                        break;

                    //Employees---------------------------------------------------------------------------------------------------------

                    case "All_EMPLOYEES":
                        foreach (var emp1 in DataAccess.GetEmployees())
                            Console.WriteLine($"Id: {emp1.Id}, Name: {emp1.Name}, Surname: {emp1.Surname}, Patronymic: {emp1.Patronymic}" +
                                $"BirthDate: {emp1.BirthDate}, PositionName: {DataAccess.GetPosition((int)emp1.PositionId).Name}, " +
                                $"Gender: {DataAccess.GetGender((int)emp1.GenderId).Name}");
                        break;

                    case "GET_EMPLOYEE":
                        Employee emp2 = DataAccess.GetEmployee(Convert.ToInt32(command[1]));
                        Console.WriteLine($"Id: {emp2.Id}, Name: {emp2.Name}, Surname: {emp2.Surname}, Patronymic: {emp2.Patronymic}" +
                                $"BirthDate: {emp2.BirthDate}, PositionName: {DataAccess.GetPosition((int)emp2.PositionId).Name}, " +
                                $"Gender: {DataAccess.GetGender((int)emp2.GenderId).Name}");
                        break;

                    case "ADD_EMPLOYEE":
                        DataAccess.AddEmployee(command[1], command[2], command[3], command[4], command[5], command[6]);
                        break;

                    case "EDIT_EMPLOYEE":
                        DataAccess.EditEmployee(command[1], command[2], command[3], command[4], command[5], command[6], command[7]);
                        break;

                    case "REMOVE_EMPLOYEE":
                        DataAccess.RemoveEmployee(Convert.ToInt32(command[1]));
                        break;

                    //Groups------------------------------------------------------------------------------------------------------------

                    case "ALL_GROUPS":
                        foreach (var group1 in DataAccess.GetGroups())
                            Console.WriteLine($"Id: {group1.Id}, Name: {group1.Name}, " +
                                $"Specification: {DataAccess.GetSpecification((int)group1.SpecificationId).Name}, Amount: {group1.Amount}");
                        break;

                    case "GET_GROUP":
                        Group group2 = DataAccess.GetGroup(Convert.ToInt32(command[1]));
                        Console.WriteLine($"Id: {group2.Id}, Name: {group2.Name}, " +
                            $"Specification: {DataAccess.GetSpecification((int)group2.SpecificationId).Name}, Amount: {group2.Amount}");
                        break;

                    case "ADD_GROUP":
                        DataAccess.AddGroup(command[1], command[2], command[3]);
                        break;

                    case "EDIT_GROUP":
                        DataAccess.EditGroup(command[1], command[2], command[3], command[4]);
                        break;

                    case "REMOVE_GROUP":
                        DataAccess.RemoveGroup(Convert.ToInt32(command[1]));
                        break;

                    //Specifications-----------------------------------------------------------------------------------------------------

                    case "ALL_SPECIFICATIONS":
                        foreach (var specification1 in DataAccess.GetSpecifications())
                            Console.WriteLine($"Id: {specification1.Id}, Name: {specification1.Name}");
                        break;

                    case "GET_SPECIFICATION":
                        Specification specification2 = DataAccess.GetSpecification(Convert.ToInt32(command[1]));
                        Console.WriteLine($"Id: {specification2.Id}, Name: {specification2.Name}");
                        break;

                    case "ADD_SPECIFICATION":
                        DataAccess.AddSpecification(command[1]);
                        break;

                    case "EDIT_SPECIFICATION":
                        DataAccess.EditSpecification(command[1], command[2]);
                        break;

                    //Positions----------------------------------------------------------------------------------------------------------

                    case "ALL_POSITIONS":
                        foreach (var position1 in DataAccess.GetPositions())
                            Console.WriteLine($"Id: {position1.Id}, Name: {position1.Name}");
                        break;

                    case "GET_POSITION":
                        Position position2 = DataAccess.GetPosition(Convert.ToInt32(command[1]));
                        Console.WriteLine($"Id: {position2.Id}, Name: {position2.Name}");
                        break;

                    case "ADD_SPOSITION":
                        DataAccess.AddPosition(command[1]);
                        break;

                    case "EDIT_POSITION":
                        DataAccess.EditPosition(command[1], command[2]);
                        break;

                        //Добавить вывод вожатых групп
                }
            }
        }
    }
}
