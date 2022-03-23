using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using RealLifeTamagochi.Model;

namespace RealLifeTamagochi.View
{
    public class TaskDB
    {
        readonly SQLiteConnection db;
        public TaskDB(string connectionString)
        {
            db = new SQLiteConnection(connectionString);
            db.CreateTable<Task>();
        }
        public IEnumerable<Task> GetTask()
        {
            return db.Table<Task>().ToList();
        } 
        public Task GetTask(int id)
        {
            return db.Table<Task>()
                            .Where(i => i.ID == id)
                            .FirstOrDefault();
        }
        public int SaveTask(Task task)
        {
            if(task.ID != 0)
            {
                return db.Update(task);
            }
            else
            {
                return db.Insert(task);
            }
        }
        public int DeleteTask(int id)
        {
            return db.Delete<Task>(id);
        }
    }
}
