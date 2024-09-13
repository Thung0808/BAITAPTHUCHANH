using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { STT = 1, Ten = "Anh Hung", Tuoi = 20 },
                new Student { STT = 2, Ten = "Nguyen Dong Nhat", Tuoi = 15 },
                new Student { STT = 3, Ten = "Tieu Viet Huy", Tuoi = 18 },
                new Student { STT = 4, Ten = "Tran Trong Tin", Tuoi = 14 },
                new Student { STT = 5, Ten = "Nguyen Thanh Dat", Tuoi = 19 }
            };

            // a. In toàn bộ danh sách học sinh
            Console.WriteLine("Danh sach hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine("STT: " + student.STT + ", Ten: " + student.Ten + ", Tuoi: " + student.Tuoi);
            }

            // b. Tìm và in danh sách các học sinh có tuổi từ 15 đến 18
            Console.WriteLine("\nHoc sinh có so tuoi 15=>19:");
            var ageRangeStudents = students.Where(s => s.Tuoi >= 15 && s.Tuoi <= 18);
            foreach (var student in ageRangeStudents)
            {
                Console.WriteLine("STT: " + student.STT + ", Ten: " + student.Ten + ", Tuoi: " + student.Tuoi);
            }

            // c. Tìm và in học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
            var studentsWithA = students.Where(s => s.Ten.StartsWith("A"));
            foreach (var student in studentsWithA)
            {
                Console.WriteLine("STT: " + student.STT + ", Ten: " + student.Ten + ", Tuoi: " + student.Tuoi);
            }

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            int totalAge = students.Sum(s => s.Tuoi);
            Console.WriteLine("\nTong tuoi cua tat ca hoc sinh: " + totalAge);

            // e. Tìm và in học sinh có tuổi lớn nhất
            int maxAge = students.Max(s => s.Tuoi);
            var oldestStudent = students.First(s => s.Tuoi == maxAge);
            Console.WriteLine("\nHoc sinh co tuoi lon nhat: STT: " + oldestStudent.STT + ", Ten: " + oldestStudent.Ten + ", Tuoi: " + oldestStudent.Tuoi);

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách
            Console.WriteLine("\nDanh sach hoc sinh sap xep theo tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Tuoi);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("STT: " + student.STT + ", Ten: " + student.Ten + ", Tuoi: " + student.Tuoi);
            }
        }
    }

    class Student
    {
        public int STT { get; set; }   
        public string Ten { get; set; }
        public int Tuoi { get; set; }   
    }
}