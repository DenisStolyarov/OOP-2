using PropertyChanged;
using System.Collections.ObjectModel;
using ToDoList.Models;
using ToDoList.Models.Commands;

namespace ToDoList.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class RecordViewModel
    {
        public ObservableCollection <Record> Records { get; set; }

        public Record SelectedRecord { get; set; }

        public RecordCommand Add => new RecordCommand(AddRecord);
        public RecordCommand Delete => new RecordCommand(DeleteRecord, isNotEmpty);
        public RecordCommand Copy => new RecordCommand(CopyRecord, isNotEmpty);
        public RecordCommand Save => new RecordCommand(SaveRecords, isNotEmpty);

        public RecordViewModel()
        {
            this.Records = new ObservableCollection<Record>(RecordServise.ReadRecords());
        }

        private void SaveRecords(object parameter)
        {
            RecordServise.WriteRecords(this.Records);
        }

        private void AddRecord(object parameter)
        {
            var record = new Record
            {
                Title = "New Record",
                Priority = 0,
                Description = string.Empty,
                Category = TypeValue.Formula,
                isCompleted = false,
            };

            this.Records.Insert(0, record);
            this.SelectedRecord = record;
        }

        private void DeleteRecord(object parameter)
        {
            if (parameter is Record record) this.Records.Remove(record);
        }

        private void CopyRecord(object parameter)
        {
            if (parameter is Record record)
            {
                var recordCopy = new Record
                {
                    Title = record.Title,
                    Priority = record.Priority,
                    Description = record.Description,
                    Category = record.Category,
                    isCompleted = false,
                };

                this.Records.Insert(0, recordCopy);
                this.SelectedRecord = recordCopy;
            }
        }

        private bool isNotEmpty(object parameter)
        {
            return this.Records.Count != 0;
        }
    }
}
