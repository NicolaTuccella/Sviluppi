using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CourseManager
{


    public partial class frmLinq : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();


        class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public List<int> Scores;
        }

        class Teacher
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public string City { get; set; }
        }

        public frmLinq()
        {
            // AllocConsole();

            InitializeComponent();
            // Use a lambda expression to define an event handler.  
            this.Click += (s, e) => { MessageBox.Show(((MouseEventArgs)e).Location.ToString()); };
        }

        private void btLink1_Click(object sender, EventArgs e)
        {
            this.logBox.Items.Clear();

            this.logBox.Items.Insert(0, "Hello World");
            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // The call to Count forces iteration of the source
            int highScoreCount = scores.Where(n => n > 80).Count();

            this.logBox.Items.Insert(0, string.Format("{0} scores are greater than 80", highScoreCount));

            // Outputs: 4 scores are greater than 80         
        }

        private void frmLinq_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.logBox.Items.Clear();

            // Create the first data source.
            List<Student> students = new List<Student>()
        {
            new Student {First="Svetlana",
                Last="Omelchenko",
                ID=111,
                Street="123 Main Street",
                City="Seattle",
                Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire",
                Last="O’Donnell",
                ID=112,
                Street="124 Main Street",
                City="Redmond",
                Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven",
                Last="Mortensen",
                ID=113,
                Street="125 Main Street",
                City="Lake City",
                Scores= new List<int> {88, 94, 65, 91}},
        };

            // Create the second data source.
            List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher {First="Ann", Last="Beebe", ID=945, City = "Seattle"},
            new Teacher {First="Alex", Last="Robinson", ID=956, City = "Redmond"},
            new Teacher {First="Michiyo", Last="Sato", ID=972, City = "Tacoma"},
            new Teacher {First="Nicola", Last="Tuccella", ID=972, City = "Torino"},
            new Teacher {First="Rocco", Last="Tuccella", ID=972, City = "Torino"},
              new Teacher {First="Tizio", Last="Caio", ID=972, City = "Terni"},
            };

            // Create the query.
            var peopleInCity = ((from student in students
                                 where student.City == this.textBoxFilter.Text
                                 select student.Last)
                               .Concat(from teacher in teachers
                                       where teacher.City == this.textBoxFilter.Text
                                       select teacher.Last)
                                );

            var peopleAndTeacher = ((from student in students
                                     select new { student.Last, student.First, student.City })
                                    .Concat(from teacher in teachers
                                            select new { teacher.Last, teacher.First, teacher.City })
                                     );


            // Execute the query.
            var people = (from student in students
                          select new { student.Last, student.First, student.City });
            this.logBox.Items.Add("-- Tutti gli studenti:");
            people.ToList().ForEach(s => this.logBox.Items.Add(s));


            if (this.textBoxFilter.Text != "")
            {
                this.logBox.Items.Add("-- Tutti gli studenti e professori con filtro:" + textBoxFilter.Text);
                peopleAndTeacher = peopleAndTeacher.Where(w => w.City.StartsWith(textBoxFilter.Text));


                peopleAndTeacher.Select(r => r.First + ',' + r.Last).ToList().ForEach(s => this.logBox.Items.Add(s));
            }


            //            .Concat(from teacher in teachers
            //                    where teacher.City == this.textBoxFilter.Text
            //                    select teacher.Last);

            //peopleInCity.Select(.Where(w => w.)

            //            var o = Ordini
            //.Where(w => w.Id == 1)
            //.Select(s => new { s.Data, s.Id });


            //            from p in db.products
            //if p.price > 0
            //select new
            //{
            //    Owner = from q in db.Users
            //            select q.Name
            //}
            //else
            //select new
            //{
            //    Owner = from r in db.ExternalUsers
            //            select r.Name
            //}



            this.logBox.Items.Add("-- The following students and teachers live in " + this.textBoxFilter.Text + ":");
            // Execute the query.
            foreach (var person in peopleInCity)
            {

                this.logBox.Items.Add(person);
            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }


}
