using Business.Models;
using System.Diagnostics;
using System.Text.Json;
using System.IO;

namespace Business.Services
{
    public class FileService
    {
        private readonly string _directoryPath;
        private readonly string _filePath;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public FileService(string directoryPath = "Data", string fileName = "list.json")
        {
            _directoryPath = directoryPath;
            _filePath = Path.Combine(_directoryPath, fileName);
            _jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };
        }

        public void SaveListToFile(List<User> list)
        {
            try
            {
                if (!Directory.Exists(_directoryPath))
                {
                    Directory.CreateDirectory(_directoryPath);
                }

                var json = JsonSerializer.Serialize(list, _jsonSerializerOptions);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public List<User> LoadListFromFile()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    return new List<User>();
                }

                var json = File.ReadAllText(_filePath);
                var list = JsonSerializer.Deserialize<List<User>>(json, _jsonSerializerOptions);
                return list ?? new List<User>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new List<User>();
            }
        }
    }
}
