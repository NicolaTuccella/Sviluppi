using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseManager
{

    class F1Team
    {
        public string TeamName { get; set; }
        public Pilot[] Pilots { get; set; }
        public int Wins { get; set; }

        public override string ToString()
        {
            return string.Format("Team {0}, Wins: {1}", TeamName, Wins);

        }
    };

    class Pilot
    {
        public F1Team Team { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IDCountry { get; set; }
        public int Points { get; set; }
    };

    class Country
    {
        public int IDCountry { get; set; }
        public string Name { get; set; }
        public static List<Country> All = new List<Country>
        {
           new Country(){IDCountry=1,Name="Spagna"},
           new Country(){IDCountry=2,Name="Brasile"},
           new Country(){IDCountry=3,Name="Germania"},
           new Country(){IDCountry=4,Name="Australia"},
           new Country(){IDCountry=5,Name="Regno Unito"},
           new Country(){IDCountry=6,Name="Messico"},
           new Country(){IDCountry=7,Name="Finlandia"},
           new Country(){IDCountry=8,Name="Svizzera"},
           new Country(){IDCountry=9,Name="Italia"},
           new Country(){IDCountry=10,Name="USA"}

        };
    }

}

