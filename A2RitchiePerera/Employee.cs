using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2RitchiePerera
{
 
    class Employee
    {
        public string Name = "";
        public decimal Hours = 0;
        public decimal Wage = 0;
        public bool man = false;



        public Employee (){
            }

        public Employee(string name, decimal hrs, decimal wage, bool m)
        {

            Name = name;
            Hours = hrs;
            Wage = wage;
            man = m;
            //  Salary = salary;
        }
      

        // public decimal Salary { get; private set; }
        public string getName() { return Name; }
        public decimal getHours() { return Hours; }
        public decimal getWage() { return Wage; }
        public bool getMan() { return man; }


        ///////////////////////////////////////////////////////////////////////////
        // setters
        ///////////////////////////////////////////////////////////////////////////
        public void setId(string name) { this.Name = name; }


        public void setName(string name) {

            if (name.Length > 0) {

                this.Name = name;
            }

             }

        public void sethrs(decimal hrs) {


                this.Hours = hrs; }

        public void setWage(decimal wage) { this.Wage = wage; }

        public void setMan(bool m) { this.man = m; }


        public override string ToString()
        {
            return $" {Name}";
        }
    }
}
