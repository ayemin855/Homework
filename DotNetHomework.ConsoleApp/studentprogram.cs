// // See https://aka.ms/new-console-template for more information
// using DotNet;
// using PWTAdoDotNetHomework.ConsoleApp;

// AppDbContext db = new AppDbContext();
// List<StudentsDto> students = db.Students.ToList();
// foreach (var lt in students)
// {
//     Console.WriteLine($"{lt.StudentId} {lt.StudentName} {lt.MobileNumber}");
// }

// StudentsDto student = new StudentsDto()
// {
//     StudentName = "Aye Min Tun",
//     FatherName = "U Tun",
//     DOB = new DateTime(1944, 1, 1),
//     Address = "Yangon",
//     MobileNumber = "0912345678",
// };
// db.Students.Add(student);
// db.SaveChanges();

// StudentsDto? editStudent = db.Students.Where(x => x.StudentId == 1).FirstOrDefault();
// if (editStudent is not null)
// {
//     editStudent.StudentName = "Aye Min Tun Edited";
//     db.SaveChanges();
// }

// StudentsDto? removeStudent = db.Students.Where(x => x.StudentId == 1).FirstOrDefault();
// if (removeStudent is not null)
// {
//     db.Students.Remove(removeStudent);
//     db.SaveChanges();
// }

// Console.ReadLine();