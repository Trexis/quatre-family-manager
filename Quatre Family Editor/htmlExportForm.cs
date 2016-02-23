using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Quatre
{
    public partial class htmlExportForm : Form
    {
        Form parentform;
        Quatre quatre;

        public htmlExportForm(Form parentForm, Quatre quatre)
        {
            this.parentform = parentForm;
            this.quatre = quatre;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtExportFolderLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void htmlExportForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            string directorypath = txtExportFolderLocation.Text;
            if(directorypath.Equals("")){
                directorypath = Application.ExecutablePath.Replace("Quatre Family Editor.EXE","exports");
                txtExportFolderLocation.Text = directorypath;
            }
            if (!Directory.Exists(directorypath))
            {
                Directory.CreateDirectory(directorypath);
            }

            //update quatre individuals with generation numbers.
            Hashtable individuals = quatre.Individuals;
            if (individuals.Values.Count > 0) {
                foreach (Individual individual in individuals.Values)
                {
                    individual.Generation = countParents(individual, 1);
                }
            }


            if (radioComplete.Checked)
            {
                exportIndex(directorypath);
                exportGenerations(directorypath);
            } 
            else if (radioGenerations.Checked)
            {
                exportGenerations(directorypath);
            } 
            else if (radioIndex.Checked)
            {
                exportIndex(directorypath);
            }

            MessageBox.Show(this, "Export successfull", "Quatre Family Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void exportIndex(String filePath)
        {
            StreamWriter sw = File.CreateText(filePath + @"\index.html");

            Hashtable individuals = quatre.Individuals;
            if (individuals.Values.Count > 0)
            {
                SortedDictionary<string, string> individualsbyname = new SortedDictionary<string, string>();
                SortedDictionary<string, string> individualsbysurname = new SortedDictionary<string, string>();
                foreach (Individual individual in individuals.Values)
                {
                    individualsbyname.Add(individual.DisplayName + individual.ID, individual.ID.ToString());
                    individualsbysurname.Add(individual.Surname + individual.ID, individual.ID.ToString());
                }

                sw.WriteLine("<table>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<td><b>Individuals by Name</b></td>");
                sw.WriteLine("<td><b>Individuals by Surname</b></td>");
                sw.WriteLine("</tr>");

                sw.WriteLine("<tr>");
                sw.WriteLine("<td>");
                foreach (string value in individualsbyname.Values)
                {
                    int id = Convert.ToInt16(value);
                    Individual individual = (Individual)individuals[id];
                    int generation = individual.Generation;
                    if (individual.Families.Values.Count == 0) generation--;
                    string aurl = "/genealogy/" + getGenerationString(generation) + "-generation/#I" + individual.ID.ToString();
                    string text = individual.DisplayName;
                    if (!individual.DOB.Equals("")) text += " (" + individual.DOB + ")";
                    sw.WriteLine("<a href=\"" + aurl + "\">" + text + "</a><br/>");
                }
                sw.WriteLine("</td>");

                sw.WriteLine("<td>");
                foreach (string value in individualsbysurname.Values)
                {
                    int id = Convert.ToInt16(value);
                    Individual individual = (Individual)individuals[id];
                    int generation = individual.Generation;
                    if (individual.Families.Values.Count == 0) generation--;
                    string aurl = "/genealogy/" + getGenerationString(generation) + "-generation/#I" + individual.ID.ToString();
                    string text = individual.Surname.ToUpper() + ", " + individual.Givenname;
                    if (!individual.DOB.Equals("")) text += " (" + individual.DOB + ")";
                    sw.WriteLine("<a href=\"" + aurl + "\">" + text + "</a><br/>");
                }
                sw.WriteLine("</td>");
                sw.WriteLine("</tr>");
                sw.WriteLine("</table>");
            }
            sw.Close();
        }

        private void exportGenerations(String filePath)
        {
            Hashtable generations = groupFamiliesByGenerations();

            HashSet<int> familiesbuilt = new HashSet<int>();

            foreach (int key in generations.Keys)
            {
                StreamWriter sw = File.CreateText(filePath + @"\" + key.ToString() + "_generation.html");

                HashSet<Family> generationfamilies = (HashSet<Family>)generations[key];
                foreach (Family family in generationfamilies)
                {
                    if (!familiesbuilt.Contains(family.ID))
                    {
                        Individual primary = family.Primary;
                        sw.WriteLine("<div id=\"I" + primary.ID + "\">");
                        sw.WriteLine("   " + family.ID + ". <b>" + primary.Givenname + " " + primary.Surname.ToUpper() + "</b>");
                        if (family.Primary.FromFamily != null)
                        {
                            sw.WriteLine("      (" + buildFromFamily(primary.FromFamily, new HashSet<int>()) + ")");
                        }
                        sw.WriteLine("  <div>" + primary.Details + "</div>");
                        if (primary.Families.Count > 0)
                        {
                            foreach (Family subfamily in primary.Families.Values)
                            {
                                sw.WriteLine("  <div id=\"F" + subfamily.ID + "\">");
                                sw.WriteLine("      <div>" + subfamily.Details.Replace("\n\n", "") + "</div>");
                                if (!family.Notes.Equals(""))
                                {
                                    sw.WriteLine("      <div>" + subfamily.Notes + "</div>");
                                }
                                sw.WriteLine("      <div>" + buildChildren(subfamily) + "</div>");
                                sw.WriteLine("  </div>");
                                if (!familiesbuilt.Contains(subfamily.ID)) familiesbuilt.Add(subfamily.ID);
                            }
                        }

                        sw.WriteLine("</div><br/><br/>");

                        if (!familiesbuilt.Contains(family.ID)) familiesbuilt.Add(family.ID);
                    }
                }
                sw.Close();
            }

        }

        private String buildChildren(Family family)
        {
            Boolean ploral = family.Ploral;
            Boolean primaryMale = family.PrimaryMale;

            String response = "";

            if (family.Children.Count > 0)
            {

                response += "<ol type=\"i\">";

                if (ploral)
                {
                    response += "They had the following children";
                }
                else
                {
                    if (primaryMale)
                    {
                        response += "He had the following children";
                    }
                    else
                    {
                        response += "She had the following children";
                    }
                }

                int childcounter = 1;
                foreach (Individual child in family.Children)
                {
                    response += "<li type=\"i\" id=\"I" + child.ID + "\">";
                    //response += "<label style=\"width:30px\">(" + Utilities.ToRoman(childcounter) + ")</label>";

                    if (child.Sex.Equals(enums.Sex.Male)) response += " (M) ";
                    if (child.Sex.Equals(enums.Sex.Female)) response += " (F) ";
                    if (child.Sex.Equals(enums.Sex.Unknown)) response += " (X) ";

                    String linktext = child.DisplayName;

                    if (child.Families.Count > 0)
                    {
                        if (!child.Families.Count.Equals(1))
                        {
                            String anchorhref = "/genealogy/" + getGenerationString(child.Generation) + "-generation/#I" + child.ID.ToString();
                            response += "<a href=\"" + anchorhref + "\">" + linktext + "</a>";
                            if (!child.DOB.Equals(""))
                            {
                                response += " born on " + child.DOB;
                            }
                        }
                        foreach (Family childfamily in child.Families.Values)
                        {
                            if (child.Families.Count.Equals(1))
                            {
                                String anchorhref = "/genealogy/" + getGenerationString(child.Generation) + "-generation/#F" + childfamily.ID.ToString();
                                response += "<a href=\"" + anchorhref + "\">" + linktext + "</a>";
                            }
                            else
                            {
                                response += "<div>";
                                response += " married ";

                                Individual spouse;
                                if (childfamily.Husband != null)
                                {
                                    if (childfamily.Husband.ID.Equals(child.ID))
                                    {
                                        spouse = childfamily.Wife;
                                    }
                                    else
                                    {
                                        spouse = childfamily.Husband;
                                    }
                                }
                                else
                                {
                                    if (childfamily.Wife.ID == child.ID)
                                    {
                                        spouse = new Individual();
                                        spouse.Name = "Unknown";
                                        spouse.Givenname = "Unknown";
                                    }
                                    else
                                    {
                                        spouse = childfamily.Wife;
                                    }
                                }

                                if (spouse != null)
                                {
                                    String anchorhref = "/genealogy/" + getGenerationString(child.Generation) + "-generation/#F" + childfamily.ID.ToString();
                                    response += "<a href=\"" + anchorhref + "\">" + spouse.DisplayName + "</a>";

                                    if (!spouse.DOB.Equals(""))
                                    {
                                        response += ", born on " + spouse.DOB;
                                    }
                                }

                                if (childfamily.DateDivorsed.Equals(""))
                                {
                                    if (!childfamily.DateMarried.Equals(""))
                                    {
                                        response += ", married on " + childfamily.DateMarried;
                                    }
                                }
                                else
                                {
                                    response += ", the marriage ended in divorce on " + childfamily.DateDivorsed;
                                }

                                response += "</div>";
                            }
                        }
                    }
                    else
                    {
                        response += linktext;
                    }

                    childcounter++;
                    response += "</li>";
                }
                response += "</ol>";
            }
            return response;
        }


        private String buildFromFamily(Family family, HashSet<int> fromfamiliesbuilt)
        {
            String response = "";
            if (!fromfamiliesbuilt.Contains(family.ID))
            {
                Individual primary = family.Primary;
                Individual secondary = family.Secondary;

                String anchorhref = "/genealogy/" + getGenerationString(primary.Generation) + "-generation/#I" + primary.ID.ToString();

                response = "<a href=\"" + anchorhref + "\">" + primary.Givenname + " " + primary.Surname.ToUpper() + "</a>";

                fromfamiliesbuilt.Add(family.ID);

                if (primary.FromFamily != null)
                {
                    String subresponse = buildFromFamily(primary.FromFamily, fromfamiliesbuilt);
                    if (!response.Equals("")) response += ",";
                    response += subresponse;
                }
            }
            return response;
        }

        private Hashtable groupFamiliesByGenerations() { 
            Hashtable generations = new Hashtable();

            Hashtable families = quatre.Families;
            if (families.Values.Count > 0)
            {
                foreach (Family family in families.Values)
                {
                    int generationno = family.Primary.Generation;

                    if (!generations.ContainsKey(generationno))
                    {
                        generations.Add(generationno, new HashSet<Family>());
                    }
                    HashSet<Family> generationfamilies = (HashSet<Family>)generations[generationno];
                    generationfamilies.Add(family);
                }
            }
            return generations;
        }

        private int countParents(Individual child, int counter) {
            int total = counter;
            if (child.FromFamily != null)
            {
                total = countParents(child.FromFamily.Primary, total+1);
            }
            return total;
        }

        private string getGenerationString(int generationNumber)
        {
            switch (generationNumber)
            {
                case 1: return "First";
                case 2: return "Second";
                case 3: return "Third";
                case 4: return "Forth";
                case 5: return "Fifth";
                case 6: return "Sixth";
                case 7: return "Seventh";
                case 8: return "Eighth";
                case 9: return "Ninth";
                case 10: return "Tenth";
                default: return generationNumber.ToString();
            }
        }
    }
}
