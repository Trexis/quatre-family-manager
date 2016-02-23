using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using Quatre;

namespace Quatre.GED
{
    class GEDReader
    {
        Hashtable individuals = new Hashtable();
        Hashtable families = new Hashtable();

        public GEDReader(String filePath)
        {
            StreamReader file = new StreamReader(filePath);
            Boolean donereading = false;


            String line = file.ReadLine();

            while(!donereading){

                if (line != null)
                {
                    if (line.EndsWith("INDI"))
                    {
                        Individual indi = new Individual();
                        indi.ID = line.Substring(2, line.Length - 7);
                        String indiline = "";
                        while (!indiline.Trim().Equals("1 CHAN"))
                        {
                            indiline = file.ReadLine();
                            if (indiline.StartsWith("1 NAME"))  indi.Name = indiline.Substring(7);
                            if (indiline.StartsWith("2 SURN")) indi.Surname = indiline.Substring(7);
                            if (indiline.StartsWith("2 GIVN")) indi.Givenname = indiline.Substring(7);
                            if (indiline.StartsWith("1 SEX")){
                                if(indiline.Substring(6).Trim().Equals("F")) indi.Sex = enums.Sex.Female;
                                if(indiline.Substring(6).Trim().Equals("M")) indi.Sex = enums.Sex.Male;
                            }
                            if (indiline.StartsWith("2 DATE")) indi.DOB = indiline.Substring(7);
                        }

                        individuals.Add(indi.ID, indi);

                        file.ReadLine(); //read date
                        file.ReadLine(); //read time
                        
                        line = file.ReadLine();
                        
                    }
                    else if (line.EndsWith("FAM"))
                    {
                        Family fam = new Family();
                        fam.ID = line.Substring(2, line.Length - 5);
                        String famline = "";

                        while (famline!=null && !famline.Trim().EndsWith("FAM"))
                        {
                        //1 DIV 
                            if (famline.StartsWith("1 HUSB")) fam.Husband = (Individual)individuals[famline.Substring(7)];
                            if (famline.StartsWith("1 WIFE")) fam.Wife = (Individual)individuals[famline.Substring(7)];
                            if (famline.StartsWith("1 CHIL")) fam.addChild((Individual)individuals[famline.Substring(7)]);

                            if (famline.EndsWith("1 DIV"))
                            {
                                famline = file.ReadLine();
                                if (famline.StartsWith("2 DATE")) fam.DateDivorsed = famline.Substring(7);
                            }

                            if (famline.StartsWith("1 MARR"))
                            {
                                famline = file.ReadLine();
                                if (famline.StartsWith("2 DATE")) fam.DateMarried = famline.Substring(7);
                                if (famline.StartsWith("2 PLAC")) fam.PlaceMarried = famline.Substring(7);
                            }

                            famline = file.ReadLine();
                        }

                        families.Add(fam.ID, fam);

                        line = famline;


                    }
                    else if (line.EndsWith("0 TRLR"))
                    {
                        donereading = true;
                    }
                    else
                    {
                        line = file.ReadLine();
                    }
                }
                else
                {
                    donereading = true;
                }
                
            }

            file.Close();

        }

        public Hashtable Families
        {
            get { return families; }
        }
        public Hashtable Individuals
        {
            get { return individuals; }
        }

    }
}
