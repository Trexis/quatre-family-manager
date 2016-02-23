using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quatre
{
    public class Individual
    {
        /*
            0 @I466@ INDI
            1 NAME Albertus Barend /Tredoux/
            2 SURN Tredoux
            2 GIVN Albertus Barend
            1 SEX M
            1 BIRT
            2 DATE 19 Apr 1940
            1 _UID 0E5A9B7F5F28D611971BEB9FA9B0F92FAD1B
            1 FAMS @F105@
            1 FAMS @F333@
            1 FAMC @F236@
            1 CHAN
            2 DATE 19 Apr 2004
            3 TIME 22:58:35
         */

        private int id = 0;
        private string name = "";
        private string surname = "";
        private string givenname = "";
        private enums.Sex sex = enums.Sex.Unknown;
        private string dob = "";
        private string placeofbirth = "";
        private string dod = "";
        private string profession = "";
        private Hashtable families = new Hashtable();
        private Family fromfamily;
        private string notes = "";
        private int generation = 1;

        public Individual()
        {
        }

        public string ToXML()
        {
            string xml = "";
            xml += "<individual id=\"" + this.id + "\"";
            if (fromfamily != null) xml += " fromfamilyid=\"" + this.fromfamily.ID + "\"";
            xml += ">";
            xml += "<name>" + this.name + "</name>";
            xml += "<surname>" + this.surname + "</surname>";
            xml += "<givenname>" + this.givenname + "</givenname>";
            xml += "<dob>" + this.dob + "</dob>";
            xml += "<placeofbirth>" + this.placeofbirth + "</placeofbirth>";
            xml += "<dod>" + this.dod + "</dod>";
            xml += "<profession>" + this.profession + "</profession>";
            if (this.sex.Equals(enums.Sex.Male)) xml += "<sex>M</sex>";
            if (this.sex.Equals(enums.Sex.Female)) xml += "<sex>F</sex>";
            if (this.sex.Equals(enums.Sex.Unknown)) xml += "<sex></sex>";
            if (this.families.Count > 0)
            {
                xml += "<families>";
                foreach (Family family in this.families.Values)
                {
                    xml += "<family id=\"" + family.ID + "\"/>";
                }
                xml += "</families>";
            }
            xml += "<notes>" + this.notes + "</notes>";
            xml += "</individual>";
            return xml;
        }

        public void AddFamily(int familyId, Family family)
        {
            if (this.families.ContainsKey(familyId))
            {
                this.families[familyId] = family;
            }
            else
            {
                this.families.Add(familyId, family);
            }
        }
        public void ClearFamilies()
        {
            this.families = new Hashtable();
        }

        public String DisplayName
        {
            get 
            {
                if(this.givenname.Equals("")){
                    return this.name + " " + this.surname; 
                } else {
                    return this.givenname + " " + this.surname; 
                }
            }
        }

        public String Details
        {
            get
            {
                String details = "";
                if (this.PlaceOfBirth != "" || this.DOB != "")
                {
                    details += "Born";
                    if (this.PlaceOfBirth != "") details += " in " + this.PlaceOfBirth;
                    if (this.DOB != "") details += " on " + this.DOB;
                    details += ".  ";
                }
                return details;
            }
        }
        
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }
        public string Givenname
        {
            get { return this.givenname; }
            set { this.givenname = value; }
        }
        public enums.Sex Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }
        public String DOB
        {
            get { return this.dob; }
            set { this.dob = value; }
        }
        public string PlaceOfBirth
        {
            get { return this.placeofbirth; }
            set { this.placeofbirth = value; }
        }
        public String DOD
        {
            get { return this.dod; }
            set { this.dod = value; }
        }
        public String Profession
        {
            get { return this.profession; }
            set { this.profession = value; }
        }
        public String Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
        public Family FromFamily
        {
            get { return this.fromfamily; }
            set { this.fromfamily = value; }
        }
        public Hashtable Families
        {
            get { return this.families; }
        }
        public int Generation
        {
            get { return this.generation; }
            set { this.generation = value; }
        }
    }
}
