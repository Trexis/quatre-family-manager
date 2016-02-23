﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Quatre
{
    public partial class formGEDReader : Form
    {

        Form parentform;
        Hashtable families;
        Hashtable individuals;
        int maxfamilyid = 0;
        int maxindividualid = 0;

        public formGEDReader(Form parentForm)
        {
            this.parentform = parentForm;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoadGEDFile(String filename)
        {
            GEDReader gedreader = new GEDReader(filename);

            families = gedreader.Families;
            individuals = gedreader.Individuals;
            maxfamilyid = gedreader.MaxFamilyID;
            maxindividualid = gedreader.MaxIndividualID;

            /*
             * 459. Belia Johanna Jacoba (Lokkie) TREDOUX (Stephanus Petrus Johannes (Fanie) , Albertus Barend (Barry) , Frans Jacobus , Francois Pieter , Jacques Gideon , Claude-Francois) 
born in Velddrif on 12 August 1938, was a teacher in Grobershoop.
Belia married Paul Kotze VAN ZYL born a farmer from farm Winstead, Groblershoop, on 11 April 1938, married on 23 December 1961.  He died on 16 October 2009  
They had the following children
+	866	F	i	Anneli VAN ZYL born 05 October 1962
				married (1) Ben DE SWARDT, the marriage ended in divorce
				married (2) Abraham Johannes (Jaco) COETZEE, born on 24 November 1975, married on 30 March 2002
867	M	ii	Pieter Johannes Christiaan VAN ZYL born on 24 January 1965
+	868	M	iii	Stephanus Petrus Johannes VAN ZYL born on 18 July 1968
				married Anna Maria (Anria) DE WET born in Kakamas on 26 March 1970

             */

            String webtext = "";
            foreach (Family family in families.Values)
            {
                webtext += family.ID + ". ";

                if (family.Husband != null && family.Wife != null)
                {

                    Individual primary = null;
                    Individual secondary = null;

                    if (family.Husband != null)
                    {
                        primary = family.Husband;
                        if (family.Wife != null)
                        {
                            secondary = family.Wife;
                        }
                    }
                    else
                    {
                        primary = family.Wife;
                    }

                    webtext += "<b>";
                    webtext += primary.Givenname;
                    webtext += " " + primary.Surname;
                    webtext += "</b>";

                    if (primary.PlaceOfBirth != "" || primary.DOB != "")
                    {
                        webtext += " born";
                        if (primary.PlaceOfBirth != "") webtext += " in" + primary.PlaceOfBirth;
                        if (primary.DOB != "") webtext += " on" + primary.DOB;
                    }

                    webtext += "<br/>";

                    if (family.DateMarried != "")
                    {
                        if (secondary != null)
                        {
                            //                    Belia married Paul Kotze VAN ZYL born a farmer from farm Winstead, Groblershoop, on 11 April 1938, married on 23 December 1961.  He died on 16 October 2009  
                            webtext += primary.Givenname + " married " + secondary.Givenname;
                            if (secondary.DOB != "") webtext += " born on " + secondary.DOB;

                            webtext += ", married on " + family.DateMarried + ".";

                            if (secondary.DOD != "")
                            {
                                if (secondary.Sex.Equals(enums.Sex.Male))
                                {
                                    webtext += " He died on " + secondary.DOD;
                                }
                                else
                                {
                                    webtext += " She died on " + secondary.DOD;
                                }
                            }
                            webtext += "<br/>";
                        }
                        else
                        {
                            webtext += "Married on " + family.DateMarried + ".";
                            webtext += "<br/>";
                        }
                    }
                }

                /*
                They had the following children
                +	866	F	i	Anneli VAN ZYL born 05 October 1962
    				married (1) Ben DE SWARDT, the marriage ended in divorce
	    			married (2) Abraham Johannes (Jaco) COETZEE, born on 24 November 1975, married on 30 March 2002
                 */
                if (family.Children.Count > 0)
                {
                    webtext += "They had the following children";
                    webtext += "<br/>";
                    foreach (Individual child in family.Children)
                    {
                        webtext += "+ " + child.ID + " " + child.Givenname;
                        webtext += "<br/>";
                    }
                }

            }

            webtext = "<html><head></head><body>" + webtext + "</body></html>";

            textBox2.Text += webtext;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Note that if you create or update any data from this point onwards, until restart, that this newly imported data will persist", "Quatre Family Editor", MessageBoxButtons.OK, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                mainForm mainform = (mainForm)parentform;
                Quatre quatre = new Quatre();
                quatre.Individuals = individuals;
                quatre.Families = families;
                quatre.MaxIndividualID = maxindividualid;
                quatre.MaxFamilyID = maxfamilyid;
                mainform.loadQuatre(quatre);
                mainform.loadList();
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Quatre quatre = new Quatre();
            quatre.Families = this.families;
            quatre.Individuals = this.individuals;
            quatre.SaveXML();
            MessageBox.Show(this, "Saved successfully", "Quatre Family Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "GED|*.ged";
            filedialog.Title = "GED Data File";
            if (filedialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (filedialog.FileName != "")
                {
                    LoadGEDFile(filedialog.FileName);
                }
            }

        }
    }
}
