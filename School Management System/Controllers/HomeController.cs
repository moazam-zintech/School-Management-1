using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using School_Management_System.Data;
using School_Management_System.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace School_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }




        //Teacher CRUD

        public IActionResult Teacher()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Teacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return RedirectToAction("TeacherData");
        }
        public async Task<IActionResult> TeacherData()
        {
            var teacher = await _context.Teachers.ToListAsync();

            return View(teacher);
        }
        public IActionResult EditTeacher(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        [HttpPost]
        public IActionResult EditTeacher(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Teachers.Update(teacher);
                _context.SaveChanges();
                return RedirectToAction("TeacherData");
            }
            return View(teacher);
        }


        public IActionResult DeleteTeacher(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
            return RedirectToAction("TeacherData");
        }
        //Teacher CRUD end



        //Student CRUD
        public IActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Student(Student Std)
        {
            _context.Students.Add(Std);
            _context.SaveChanges();
            return RedirectToAction("StudentData");
        }

        public IActionResult EditStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult EditStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return RedirectToAction("StudentData");
            }
            return View(student);
        }

        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("StudentData");
        }
        public async Task<IActionResult> StudentData()
        {
            var students = await _context.Students.ToListAsync();
            return View(students);
        }
        //Student CRUD end



        //Subject CRUD
        public async Task<IActionResult> SubjectData()
        {
            var subjects = await _context.Subjects.ToListAsync();

            return View(subjects);
        }

        public IActionResult Subject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Subject(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();

            return RedirectToAction("SubjectData");
        }

        public IActionResult EditSubject(int id)
        {
            var subject = _context.Subjects.Find(id);
            if (subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }

        [HttpPost]
        public IActionResult EditSubject(Subject subject)
        {
            if (ModelState.IsValid)
            {
                _context.Subjects.Update(subject);
                _context.SaveChanges();
                return RedirectToAction("SubjectData");
            }
            return View(subject);
        }

        public IActionResult DeleteSubject(int id)
        {
            var subject = _context.Subjects.Find(id);
            if (subject == null)
            {
                return NotFound();
            }

            _context.Subjects.Remove(subject);
            _context.SaveChanges();
            return RedirectToAction("SubjectData");
        }
        //Subject CRUD end

        //Grade CRUD
        public IActionResult Grades()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Grades(Grade grade)
        {
            _context.Grades.Add(grade);
            _context.SaveChanges();
            return RedirectToAction("GradeData");
        }

        public async Task<IActionResult> GradeData()
        {
            var grades = await _context.Grades.ToListAsync();

            return View(grades);
        }

        public IActionResult EditGrade(int id)
        {
            var grade = _context.Grades.Find(id);
            if (grade == null)
            {
                return NotFound();
            }
            return View(grade);
        }

        [HttpPost]
        public IActionResult EditGrade(Grade grade)
        {
            if (ModelState.IsValid)
            {
                _context.Grades.Update(grade);
                _context.SaveChanges();
                return RedirectToAction("GradeData");
            }
            return View(grade);
        }

        public IActionResult DeleteGrade(int id)
        {
            var grade = _context.Grades.Find(id);
            if (grade == null)
            {
                return NotFound();
            }

            _context.Grades.Remove(grade);
            _context.SaveChanges();
            return RedirectToAction("GradeData");
        }
        //Grade CRUD end


        //Term CRUD 
        public async Task<IActionResult> TermData()
        {
            var terms = await _context.Terms.ToListAsync();

            return View(terms);
        }

        public IActionResult Term()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Term(Term term)
        {
            _context.Terms.Add(term);
            _context.SaveChanges();
            return RedirectToAction("TermData");
        }

        public IActionResult EditTerm(int id)
        {
            var term = _context.Terms.Find(id);
            if (term == null)
            {
                return NotFound();
            }
            return View(term);
        }

        [HttpPost]
        public IActionResult EditTerm(Term term)
        {
            if (ModelState.IsValid)
            {
                _context.Terms.Update(term);
                _context.SaveChanges();
                return RedirectToAction("TermData");
            }
            return View(term);
        }

        public IActionResult DeleteTerm(int id)
        {
            var term = _context.Terms.Find(id);
            if (term == null)
            {
                return NotFound();
            }

            _context.Terms.Remove(term);
            _context.SaveChanges();
            return RedirectToAction("TermData");
        }

        //Term CRUD end

        //Class CRUD
        public async Task<IActionResult> ClassData()
        {
            var classes = await _context.Classes.ToListAsync();

            return View(classes);
        }


        public IActionResult Class()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Class(Class cls)
        {
            _context.Classes.Add(cls);
            _context.SaveChanges();
            return RedirectToAction("ClassData");
        }

        public IActionResult EditClass(int id)
        {
            var cls = _context.Classes.Find(id);
            if (cls == null)
            {
                return NotFound();
            }
            return View(cls);
        }

        [HttpPost]
        public IActionResult EditClass(Class cls)
        {
            if (ModelState.IsValid)
            {
                _context.Classes.Update(cls);
                _context.SaveChanges();
                return RedirectToAction("ClassData");
            }
            return View(cls);
        }

        public IActionResult DeleteClass(int id)
        {
            var cls = _context.Classes.Find(id);
            if (cls == null)
            {
                return NotFound();
            }

            _context.Classes.Remove(cls);
            _context.SaveChanges();
            return RedirectToAction("ClassData");
        }
        //Class CRUD end

    }
}
