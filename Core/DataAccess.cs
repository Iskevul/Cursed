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
        public static ObservableCollection<Child> GetChilds()
        {
            return new ObservableCollection<Child>(DbConnection.Connection.Child);
        }

        public static void AddChild(Child child)
        {
            DbConnection.Connection.Child.Add(child);
        }

        public static void RemoveChild(Child child)
        {
            DbConnection.Connection.Child.Remove(child);
        }
    }
}
