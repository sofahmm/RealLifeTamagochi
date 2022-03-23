using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RealLifeTamagochi.Model
{
    [Table("Tasks")]
    public class Task
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reward { get; set; }
        public string Date { get; set; }
    }
}
