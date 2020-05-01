using System;
using System.ComponentModel;
using PropertyChanged;

namespace ToDoList.Models
{
    [AddINotifyPropertyChangedInterface]
    [Serializable]
    public class Record
    {
        public string Title { get; set; }

        public Priority Priority { get; set; }

        public DateTime Date { get; } = DateTime.Now;

        public string Description { get; set; }

        public bool isCompleted { get; set; }

        public TypeValue Category { get; set; }
    }

    public enum TypeValue
    {
        [Description("Нет")]
        None,
        [Description("Величина")]
        Value,
        [Description("Ячейка")]
        Cell,
        [Description("Столбец")]
        Column,
        [Description("Формула")]
        Formula,
    }

    public enum Priority
    {
        [Description("High")]
        None,
        [Description("Average")]
        Value,
        [Description("Low")]
        Cell,
    }
}
