using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using Quatre;

namespace Quatre
{
    class GEDReader
    {
        Hashtable individuals = new Hashtable();
        Hashtable families = new Hashtable();
        int maxfamilyid = 0;
        int maxindividualid = 0;

        public GEDReader(String filePath)
        {
            StreamReader file = new StreamReader(filePath);
            Boolean donereading = false;

            int linecount = 0;

            String line = file.ReadLine();
            linecount++;

            while(!donereading){

                if (line != null)
                {
                    if (line.EndsWith("INDI"))
                    {
                        Individual indi = new Individual();
                        indi.ID = Convert.ToInt16(line.Substring(2, line.Length - 7).Replace("@", "").Replace("I", ""));
                        if (indi.ID > maxindividualid) maxindividualid = indi.ID;
                        String indiline = "";
                        while (!indiline.Trim().Equals("1 CHAN"))
                        {
                            indiline = file.ReadLine();
                            linecount++;

                            if (indiline.StartsWith("1 NAME")) indi.Name = indiline.Substring(7);
                            if (indiline.StartsWith("2 SURN")) indi.Surname = indiline.Substring(7);
                            if (indiline.StartsWith("2 GIVN")) indi.Givenname = indiline.Substring(7);
                            if (indiline.StartsWith("1 SEX")){
                                if(indiline.Substring(6).Trim().Equals("F")) indi.Sex = enums.Sex.Female;
                                if(indiline.Substring(6).Trim().Equals("M")) indi.Sex = enums.Sex.Male;
                            }
                            if (indiline.StartsWith("2 DATE")) indi.DOB = indiline.Substring(7);
                            if (indiline.StartsWith("1 FAMS"))
                            {
                                Family fam = getFamily(ConvertToID(indiline.Substring(7)));
                                indi.AddFamily(fam.ID, fam);
                            }
                            if (indiline.StartsWith("1 FAMC"))
                            {
                                Family fromfam = getFamily(ConvertToID(indiline.Substring(7)));
                                indi.FromFamily = fromfam;
                            }
                        }

                        individuals.Add(indi.ID, indi);

                        file.ReadLine(); //read date
                        linecount++;
                        file.ReadLine(); //read time
                        linecount++;
                        
                        line = file.ReadLine();
                        linecount++;
                        
                    }
                    else if (line.Trim().EndsWith("FAM"))
                    {
                        int famid = ConvertToID(line.Substring(2, line.Length - 5));
                        if (famid > maxfamilyid) maxfamilyid = famid;

                        Family fam = getFamily(famid);
                        String famline = "";

                        while (famline!=null && !famline.Trim().EndsWith("FAM"))
                        {
                        //1 DIV 
                            if (famline.StartsWith("1 HUSB")) fam.Husband = (Individual)individuals[ConvertToID(famline.Substring(7))];
                            if (famline.StartsWith("1 WIFE")) fam.Wife = (Individual)individuals[ConvertToID(famline.Substring(7))];
                            if (famline.StartsWith("1 CHIL")) fam.addChild((Individual)individuals[ConvertToID(famline.Substring(7))]);

                            if (famline.EndsWith("1 DIV"))
                            {
                                famline = file.ReadLine();
                                linecount++;
                                if (famline.StartsWith("2 DATE")) fam.DateDivorsed = famline.Substring(7);
                            }

                            if (famline.StartsWith("1 MARR"))
                            {
                                famline = file.ReadLine();
                                linecount++;
                                if (famline.StartsWith("2 DATE")) fam.DateMarried = famline.Substring(7);
                                if (famline.StartsWith("2 PLAC")) fam.PlaceMarried = famline.Substring(7);
                            }

                            famline = file.ReadLine();
                            linecount++;
                        }

                        line = famline;


                    }
                    else if (line.EndsWith("0 TRLR"))
                    {
                        donereading = true;
                    }
                    else
                    {
                        line = file.ReadLine();
                        linecount++;
                    }
                }
                else
                {
                    donereading = true;
                }
                
            }

            file.Close();

        }

        private int ConvertToID(String id)
        {
            return Convert.ToInt16(id.Trim().Replace("@", "").Replace("F", "").Replace("I",""));
        }

        private Family getFamily(int familyId)
        {
            if (families.ContainsKey(familyId))
            {
                return (Family)families[familyId];
            }
            else
            {
                Family family = new Family();
                family.ID = familyId;
                families.Add(familyId, family);
                return family;
            }
        }

        public Hashtable Families
        {
            get { return families; }
        }
        public Hashtable Individuals
        {
            get { return individuals; }
        }

        public int MaxIndividualID
        {
            get { return this.maxindividualid; }
            set { this.maxindividualid = value; }
        }
        public int MaxFamilyID
        {
            get { return this.maxfamilyid; }
            set { this.maxfamilyid = value; }
        }
    }
}
