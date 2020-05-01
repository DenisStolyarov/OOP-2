using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ToDoList.Models
{
    public class RecordServise
    {
        private static string fileName = "Records.json";

        public static IEnumerable<Record> ReadRecords()
        {
            return HasFile()
                ? GetRecords()
                : GetEmptyCollection();
        }

        public static void WriteRecords(IEnumerable<Record> records)
        {
            var textJson = JsonSerializer.Serialize(records);
            File.WriteAllText(fileName, textJson);
        }

        private static IEnumerable<Record> GetRecords()
        {
            var textJSON = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<IEnumerable<Record>>(textJSON);
        }

        private static IEnumerable<Record> GetEmptyCollection()
        {
            return Array.Empty<Record>();
        }

        private static bool HasFile()
        {
            return File.Exists(fileName);
        }
    }
}
