using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSHS
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "An", Age = 17 },
            new Student { Id = 2, Name = "Bình", Age = 19 },
            new Student { Id = 3, Name = "Anh", Age = 16 },
            new Student { Id = 4, Name = "Cường", Age = 20 },
            new Student { Id = 5, Name = "Ánh", Age = 15 }
        };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sách học sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }

            // b. Tìm và in ra các học sinh có tuổi từ 15 đến 18
            var age15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            Console.WriteLine("\nHọc sinh có tuổi từ 15 đến 18:");
            foreach (var student in age15to18)
            {
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }

            // c. Tìm và in ra các học sinh có tên bắt đầu bằng chữ "A"
            var nameStartsWithA = students.Where(s => s.Name.StartsWith("A"));
            Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ 'A':");
            foreach (var student in nameStartsWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }

            // d. Tính tổng tuổi của tất cả học sinh
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {totalAge}");

            // e. Tìm và in ra học sinh có tuổi nhỏ nhất
            var youngest = students.OrderBy(s => s.Age).First();
            Console.WriteLine($"\nHọc sinh có tuổi nhỏ nhất: ID: {youngest.Id}, Tên: {youngest.Name}, Tuổi: {youngest.Age}");

            // f. Sắp xếp danh sách theo tuổi tăng dần
            var sortedByAge = students.OrderBy(s => s.Age);
            Console.WriteLine("\nDanh sách học sinh sau khi sắp xếp theo tuổi:");
            foreach (var student in sortedByAge)
            {
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }
        }
    }
}
