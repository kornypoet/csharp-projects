using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    class CustomerList<T>
    {
        private List<T> list = new List<T>();

        public event ChangeHandler Changed;
        public delegate void ChangeHandler();
        
        public T this[int i]
        {
            get { return list[i]; }
        }
        public int Count
        {
            get { return list.Count; }
        }
        public void Add(T item)
        {
            list.Add(item);
            Changed();
        }
        public T GetAt(int index)
        {
            return list[index];
        }
        public void Remove(T item)
        {
            list.Remove(item);
            Changed();
        }
        public void Save()
        {
            FileStream fs = new FileStream("CustomerInfo.dat", 
                FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            foreach (T item in list)
            {
                bFormatter.Serialize(fs, item);
            }
            fs.Close();   
        }
        public void Load()
        {
            if (!File.Exists("CustomerInfo.dat"))
                return;
            FileStream fs = new FileStream("CustomerInfo.dat", 
                FileMode.Open, FileAccess.Read);
            BinaryFormatter bFormatter = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                T item = (T)bFormatter.Deserialize(fs);                
                list.Add(item);                                           
            }
            fs.Close();
        }
    }
}
