using System;
using System.Collections.Generic;
using System.Linq;

namespace hw15
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> CourseIds { get; set; }
    }
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, Name = "Alice", Age = 20, CourseIds = new List<int> { 1, 2, 3 } },
                new Student { StudentId = 2, Name = "Bob", Age = 22, CourseIds = new List<int> { 2, 3, 4 } },
                new Student { StudentId = 3, Name = "Charlie", Age = 21, CourseIds = new List<int> { 1, 3, 5 } },
                // Добавьте еще студентов при необходимости
                new Student { StudentId = 4, Name = "Leo", Age = 23, CourseIds = new List<int> {} },
                new Student { StudentId = 5, Name = "Mark", Age = 20, CourseIds = new List<int> {3, 4, 5} },
                new Student { StudentId = 6, Name = "Brian", Age = 26, CourseIds = new List<int> {1, 2, 3} }
            };

            List<Course> courses = new List<Course>
            {
                new Course { CourseId = 1, CourseName = "Math" },
                new Course { CourseId = 2, CourseName = "Physics" },
                new Course { CourseId = 3, CourseName = "Computer Science" },
                new Course { CourseId = 4, CourseName = "Biology" },
                new Course { CourseId = 5, CourseName = "Chemistry" },
                new Course { CourseId = 6, CourseName = "English" },
                // Добавьте еще курсы при необходимости
            };

            //•	Вывести имена студентов, которые старше 21 года.
            //var query = students.Where(s => s.Age > 21);
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Id: {item.StudentId}, name: {item.Name}, age: {item.Age}");
            //}

            //•	Найти средний возраст студентов по каждому курсу.
            //var query = courses.Select(c => new
            //{
            //    courseName = c.CourseName,
            //    avg = students.Where(s => s.CourseIds.Contains(c.CourseId)).Any() ? students.Where(s => s.CourseIds.Contains(c.CourseId)).Average(s => s.Age) : 0
            //});
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.courseName + " avg age: " + item.avg);
            //}

            //•	Вывести названия курсов, на которых учится более двух студентов.
            //var query = courses.Where(c => students.Count(s => s.CourseIds.Contains(c.CourseId)) >= 2);
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.CourseName);
            //}

            //•	Найти студента с наибольшим возрастом.
            //var query = students.FirstOrDefault(s => s.Age == students.Max(a => a.Age));
            //Console.WriteLine($"{query.Name} the oldest student, age: {query.Age}");

            //•	Вывести имена студентов, у которых нет курсов.
            //var query = students.Where(s => s.CourseIds.Count == 0);
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //•	Найти суммарный возраст студентов на каждом курсе.
            //var query = courses.Select(c => new
            //{
            //    courseName = c.CourseName,
            //    sum = students.Where(s => s.CourseIds.Contains(c.CourseId)).Sum(s => s.Age)
            //});
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.courseName + " summary age: " + item.sum);
            //}

            //•	Вывести имена студентов, у которых есть общие курсы.
            //var query = courses.Select(c => new
            //{
            //    CourseName = c.CourseName,
            //    studentsName = students.Where(s => s.CourseIds.Contains(c.CourseId)).Select(s => s.Name).ToList(),
            //});
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Course name: {item.CourseName}");
            //    foreach (var name in item.studentsName)
            //    {
            //        Console.WriteLine("\t" + name);
            //    }
            //}

            //•	Найти средний возраст студентов, у которых есть общие курсы.
            //var query = courses.Select(c => new
            //{
            //    CourseName = c.CourseName,
            //    studentsName = students.Where(s => s.CourseIds.Contains(c.CourseId)).Select(s => s.Name),
            //    avgAge = students.Where(s => s.CourseIds.Contains(c.CourseId)).Any() ? students.Where(s => s.CourseIds.Contains(c.CourseId)).Average(s => s.Age) : 0,
            //});
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Course name: {item.CourseName}");
            //    Console.WriteLine($"Average age = {item.avgAge}");
            //    foreach (var name in item.studentsName)
            //    {
            //        Console.WriteLine("\t" + name);
            //    }
            //    Console.WriteLine();
            //}

            //•	Вывести имена студентов, у которых средний возраст на курсе больше 20 лет.
            //var query = courses.GroupBy(c => new
            //{
            //    courseName = c.CourseName,
            //    avg = students.Where(s => s.CourseIds.Contains(c.CourseId)).Any() ? students.Where(s => s.CourseIds.Contains(c.CourseId)).Average(s => s.Age) : 0
            //}).Where(g => g.Key.avg > 20).Select(g => new
            //{
            //    g.Key.courseName,
            //    g.Key.avg
            //});
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Course name: {item.courseName}, avg age: {item.avg}");
            //}

            //•	Найти курс с наибольшим числом студентов.
            //var query = courses.GroupBy(c => new
            //{
            //    course = c,
            //    StudentMax = students.Count(s => s.CourseIds.Contains(c.CourseId))
            //}
            //).Select(g => new
            //{
            //    g.Key.course,
            //    g.Key.StudentMax
            //}).OrderByDescending(c => c.StudentMax).FirstOrDefault();
            //Console.WriteLine($"The maximum students count on course {query.course.CourseName}, {query.StudentMax} people");

            //•	Вывести имена студентов, у которых возраст на курсе максимален.
            //var query = courses.GroupBy(c => new
            //{
            //    course = c.CourseName,
            //    OldestStudent = students.Where(s => 
            //    s.CourseIds.Contains(c.CourseId)).Any() ? students.Where(s => s.CourseIds.Contains(c.CourseId)).Max(s => s.Age) : 0
            //}).Select(g => new
            //{
            //    g.Key.course,
            //    g.Key.OldestStudent
            //});
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Course: {item.course}, oldest student: {item.OldestStudent}");
            //}

            //•	Найти курсы, на которых учится хотя бы один студент старше 25 лет.
            //var query = courses.Where(c => students.Any(s => s.CourseIds.Contains(c.CourseId) && s.Age > 25));
            //Console.WriteLine($"Courses where students are older then 25:");
            //foreach (var item in query)
            //{
            //    Console.WriteLine("\t" + item.CourseName);
            //}

            //•	Вывести имена студентов, у которых возраст на курсе отличается не более чем на 1 год.
            //var query = courses.GroupBy(c => new
            //{
            //    CourseName = c.CourseName,
            //    students = students.Where(s => s.CourseIds.Contains(c.CourseId)).ToList()
            //}).Select(g => new
            //{
            //    g.Key.CourseName,
            //    g.Key.students
            //})
            //.Where(c =>
            //{
            //    var ages = c.students.Select(s => s.Age).ToList();
            //    return ages.Any() && (ages.Max() - ages.Min()) <= 1;
            //});
            //foreach (var course in query)
            //{
            //    Console.WriteLine($"Course name: {course.CourseName}");
            //    Console.WriteLine("Students with age difference of 1 year or less:");
            //    foreach (var studentName in course.students)
            //    {
            //        Console.WriteLine("\t" + studentName.Name);
            //    }
            //};




            //•	Найти курсы, на которых нет студентов.
            //var query = courses.Where(c => !students.Any(s => s.CourseIds.Contains(c.CourseId)));
            //Console.WriteLine("Courses with 0 students:");
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"\t{item.CourseName}");
            //}

            //•	Вывести имена студентов, у которых есть курсы и которые не учатся на курсах "Math" и "Physics".
            //var excludedCourseIds = courses.Where(c => c.CourseName == "Math" || c.CourseName == "Physics").Select(c => c.CourseId).ToList();
            //var query = students.Where(s => s.CourseIds.Any()).Where(s => !s.CourseIds.Intersect(excludedCourseIds).Any());
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //•	Найти студентов, у которых есть курсы и которые учатся хотя бы на одном курсе в каждой категории (Math, Physics, Computer Science).
            //var requiredCourseIds = courses.Where(c => c.CourseName == "Math" || c.CourseName == "Physics" || c.CourseName == "Computer Science").Select(c => new { c.CourseId, c.CourseName }).ToList();
            //var query = students.Where(s => requiredCourseIds.Any(r => r.CourseName == "Math" && s.CourseIds.Contains(r.CourseId)) ||
            //    requiredCourseIds.Any(r => r.CourseName == "Physics" && s.CourseIds.Contains(r.CourseId)) ||
            //    requiredCourseIds.Any(r => r.CourseName == "Computer Science" && s.CourseIds.Contains(r.CourseId)));

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //•	Вывести имена студентов, у которых есть курсы, и у каждого курса есть хотя бы один другой курс с тем же количеством студентов.
            //•	Найти студентов, у которых есть хотя бы один курс, и у всех их курсов есть другие курсы с тем же количеством студентов.
            //var courseStudentCounts = courses.Select(c => new
            //{
            //    CourseId = c.CourseId,
            //    StudentCount = students.Count(s => s.CourseIds.Contains(c.CourseId))
            //}).ToList();

            //var coursesWithSameCount = courseStudentCounts
            //    .Where(c => courseStudentCounts.Any(other => other.CourseId != c.CourseId && other.StudentCount == c.StudentCount))
            //    .Select(c => c.CourseId).ToList();

            //var query = students
            //    .Where(s => s.CourseIds.Any(cid => coursesWithSameCount.Contains(cid)))
            //    .Select(s => s.Name);

            //Console.WriteLine("Students enrolled in courses where another course has the same number of students:");
            //foreach (var studentName in query)
            //{
            //    Console.WriteLine(studentName);
            //}

            //•	Вывести имена студентов, у которых есть хотя бы один курс, и у всех их курсов средний возраст студентов больше 18 лет.
            //var courseAvgAge = courses.GroupBy(c => c.CourseId).Select(g => new
            //{
            //    CourseId = g.Key,
            //    AvgAge = students.Where(s => s.CourseIds.Contains(g.Key)).Average(s => s.Age)
            //});
            //var query = students.Where(s => s.CourseIds.Any()).Where(s => s.CourseIds.All(cid =>
            //        courseAvgAge.First(c => c.CourseId == cid).AvgAge > 18)).Select(s => s.Name);

            //Console.WriteLine("Students where the average age of students in all their courses is greater than 18:");
            //foreach (var studentName in query)
            //{
            //    Console.WriteLine(studentName);
            //}

            //•	Найти студентов, у которых возраст на всех курсах выше среднего возраста студентов в целом.
            //var overallAvgAge = students.Average(s => s.Age);
            //var courseAvgAge = courses.GroupBy(c => c.CourseId).Select(g => new
            //{
            //    CourseId = g.Key,
            //    AvgAge = students.Where(s => s.CourseIds.Contains(g.Key)).Average(s => s.Age)
            //});
            //var query = students.Where(s => s.CourseIds.Any()).Where(s => s.CourseIds.Average(cid => courseAvgAge.First(c => c.CourseId == cid).AvgAge) > overallAvgAge);
            //foreach (var studentName in query)
            //{
            //    Console.WriteLine(studentName.Name);
            //}
        }
    }
}
