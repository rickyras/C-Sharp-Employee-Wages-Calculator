//A2 Ritchie Perera

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2RitchiePerera
{

    public partial class Form1 : Form
    {
        List<Employee> empList = new List<Employee>();

        public Form1()
        {
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            empList = new List<Employee>();


        }

        private void nameEmptxt_TextChanged(object sender, EventArgs e)
        {


        }

        private void houryWagTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void hoursWorkedTxt_TextChanged(object sender, EventArgs e)
        {

        }


        private void calcBtn_Click(object sender, EventArgs e)
        {

            string name = nameEmptxt.Text.Trim();
            decimal hrs = Convert.ToDecimal(hoursWorkedTxt.Text);
            decimal wage = Convert.ToDecimal(houryWagTxt.Text);
            // Add items to the list

            bool man = mgrChk.Checked;
            Employee newEmp = new Employee(name, hrs, wage, man);

            bool isFound = empBox.Items.Contains(name);

            bool isWage = wage > 0;
            bool ishrs = hrs > 0 && hrs < 80;

            bool isName = name.Length > 0;

           

            //fill fields
            decimal tax = 0.15M;

            bool isChecked = mgrChk.Checked;

            decimal oTime = (hrs - 40);
            decimal owage = (.5M * wage * oTime);
            decimal perf = .2M;

            try
            {
                if (!isFound && isWage && ishrs && isName)
                ////// Fill the listbox with the items from the List<>
                {
                    empList.Add(newEmp);
                    string sname = nameEmptxt.Text.Trim();

                    empBox.Items.Add(name);
                    //  empBox.Items.Add(name);
                    if (hrs < 41 && !isChecked)
                    {
                        grossEtxt.Text = "$" + Math.Round((wage * hrs), 2);

                        lessfwtTx.Text = "$" + Math.Round(tax * (wage * hrs), 2);

                        netEarnTxt.Text = "$" + Math.Round(((wage * hrs) - (tax * (wage * hrs))), 2);
                    }

                    if (hrs > 40 && !isChecked)
                    {
                        grossEtxt.Text = "$" + Math.Round(((wage * hrs) + owage), 2);

                        lessfwtTx.Text = "$" + Math.Round(((tax * (wage * hrs)) + (tax * owage)), 2);

                        netEarnTxt.Text = "$" + Math.Round((((wage * hrs) + owage) - ((tax * (wage * hrs)) + (tax * owage))), 2);
                    }

                    if (isChecked)
                    {
                        grossEtxt.Text = "$" + Math.Round((((wage * hrs) * perf) + (wage * hrs)), 2);

                        lessfwtTx.Text = "$" + Math.Round((tax * (wage * hrs) * perf) + (tax * (wage * hrs)), 2);

                        netEarnTxt.Text = "$" + Math.Round((((wage * hrs) * perf + (wage * hrs)) - ((tax * (wage * hrs) * perf) + (tax * (wage * hrs)))), 2);
                    }

                }

            }
            catch (Exception eu)
            {
                if (isFound)
                {
                    MessageBox.Show(eu.ToString());
                }
                ///  calcBtn.Enabled = false;
                if (!isWage)
                {
                    MessageBox.Show(eu.ToString());
                }
                if (!ishrs)
                {
                    MessageBox.Show(eu.ToString());
                }
                if (!isName)
                {
                    MessageBox.Show(eu.ToString());
                }

            }

            finally
            {
                if (isFound) {
                    MessageBox.Show("Employee Name must be unique");
                }

                if (!isWage)
                {
                    MessageBox.Show("Wage Must be a positive number");
                }

                if (!ishrs)
                {
                    MessageBox.Show("Hours Must be higher than 0 and cannot exceed 80");
                }

                if (!isName)
                {
                    MessageBox.Show("Name field cannot be empty");
                }
            }

        }

        private void mgrChk_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            nameEmptxt.Text = null;
            hoursWorkedTxt.Text = null;
            houryWagTxt.Text = null;
            mgrChk.Checked = false;
            grossEtxt.Text = null;
            netEarnTxt.Text = null;
            lessfwtTx.Text = null;
        }


        private void empBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  nameEmptxt.Text = empBox.SelectedIndex.ToString();
            int index = empBox.SelectedIndex;

            Employee emp = empList[index];

            decimal tax = 0.15M;

            decimal hrs = emp.getHours();

            decimal wage = emp.getWage();

            bool man = emp.getMan();

            bool isChecked = mgrChk.Checked;

            decimal oTime = (hrs - 40);
            decimal owage = (.5M * wage * oTime);
            decimal perf = .2M;

            if (hrs < 41 && !man)
            {
                nameEmptxt.Text = emp.getName();

                hoursWorkedTxt.Text = Convert.ToString(emp.getHours());

                houryWagTxt.Text = Convert.ToString(emp.getWage());
                mgrChk.Checked = false;

                grossEtxt.Text = "$" + Math.Round((wage * hrs), 2);

                lessfwtTx.Text = "$" + Math.Round(tax * (wage * hrs), 2);

                netEarnTxt.Text = "$" + Math.Round(((wage * hrs) - (tax * (wage * hrs))), 2);
            }

            if (hrs > 40 && !man)
            {
               

                nameEmptxt.Text = emp.getName();

                hoursWorkedTxt.Text = Convert.ToString(emp.getHours());

                houryWagTxt.Text = Convert.ToString(emp.getWage());

                mgrChk.Checked = false;

                grossEtxt.Text = "$" + Math.Round(((wage * hrs)+owage), 2);

                lessfwtTx.Text = "$" + Math.Round(((tax * (wage * hrs))+ (tax * owage)),2);

                netEarnTxt.Text = "$" + Math.Round((((wage * hrs)+owage) - ((tax * (wage * hrs))+(tax*owage))), 2);


            }

           


            if (man)
            {
                nameEmptxt.Text = emp.getName();

                hoursWorkedTxt.Text = Convert.ToString(emp.getHours());

                houryWagTxt.Text = Convert.ToString(emp.getWage());

                mgrChk.Checked = true;
               

                grossEtxt.Text = "$" + Math.Round(((((wage * hrs)*perf)+ (wage * hrs))), 2);

                lessfwtTx.Text = "$" + Math.Round((tax * (wage * hrs) *perf)+( tax * (wage * hrs)), 2);

                netEarnTxt.Text = "$" + Math.Round((((wage * hrs)*perf + (wage * hrs)) - ((tax * (wage * hrs) * perf)+(tax * (wage * hrs)))), 2);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // check if 'No' is clicked
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }

}


