using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;

namespace Quatre
{
    public class Quatre
    {
        Hashtable individuals = new Hashtable();
        Hashtable families = new Hashtable();
        XmlDocument xmldocument = new XmlDocument();
        String xmlfilename = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("Quatre.dll", "quatre.xml");
        int maxfamilyid = 0;
        int maxindividualid = 0;


        public Quatre()
        {
        }

        public void LoadXML() {
            if (System.IO.File.Exists(this.xmlfilename))
            {
                xmldocument.Load(this.xmlfilename);
            }
            else
            {
                //This will create the initial xml structure
                SaveXML();
            }

            LoadXML(xmldocument);
        }

        public void LoadXML(XmlDocument xmlDocument)
        {
            maxfamilyid = 0;
            maxindividualid = 0;

            XmlNodeList individualnodes = xmlDocument.SelectNodes("//quatre/individuals/individual");
            foreach (XmlNode node in individualnodes)
            {
                Individual individual = new Individual();
                individual.ID = Convert.ToInt16(node.Attributes["id"].Value);
                if (individual.ID > maxindividualid) maxindividualid = individual.ID;

                if(node.Attributes["fromfamilyid"]!=null){
                    individual.FromFamily = getFamily(Convert.ToInt16(node.Attributes["fromfamilyid"].Value));
                }
                individual.Name = node.SelectSingleNode("name").InnerText;
                individual.Givenname = node.SelectSingleNode("givenname").InnerText;
                individual.Surname = node.SelectSingleNode("surname").InnerText;
                individual.DOB = node.SelectSingleNode("dob").InnerText;
                individual.PlaceOfBirth = node.SelectSingleNode("placeofbirth").InnerText;
                individual.DOD = node.SelectSingleNode("dod").InnerText;
                individual.Profession = node.SelectSingleNode("profession").InnerText;
                individual.Notes = node.SelectSingleNode("notes").InnerText;
                string sex = node.SelectSingleNode("sex").InnerText;
                if (sex.Equals("M")) individual.Sex = enums.Sex.Male;
                if (sex.Equals("F")) individual.Sex = enums.Sex.Female;
                XmlNodeList subfamilynodes = node.SelectNodes("families/family");
                foreach (XmlNode subfamilynode in subfamilynodes)
                {
                    Family subfamily = getFamily(Convert.ToInt16(subfamilynode.Attributes["id"].Value));
                    individual.AddFamily(subfamily.ID, subfamily);
                }
                individuals.Add(individual.ID, individual);
            }

            XmlNodeList familynodes = xmlDocument.SelectNodes("//quatre/families/family");
            foreach (XmlNode node in familynodes)
            {
                int famid = Convert.ToInt16(node.Attributes["id"].Value);
                Family family = getFamily(famid);
                if (famid > maxfamilyid) maxfamilyid = famid;

                if (node.Attributes["husbandid"] != null)
                {
                    int husbandid = Convert.ToInt16(node.Attributes["husbandid"].Value);
                    family.Husband = (Individual)individuals[husbandid];
                }

                if (node.Attributes["wifeid"] != null)
                {
                    int wifeid = Convert.ToInt16(node.Attributes["wifeid"].Value);
                    family.Wife = (Individual)individuals[wifeid];
                }
                
                family.DateMarried = node.SelectSingleNode("datemarried").InnerText;
                family.PlaceMarried = node.SelectSingleNode("placemarried").InnerText;
                family.DateDivorsed = node.SelectSingleNode("datedivorsed").InnerText;
                family.Notes = node.SelectSingleNode("notes").InnerText;

                XmlNodeList childrennodes = node.SelectNodes("children/child");
                foreach (XmlNode childnode in childrennodes)
                {
                    int childid = Convert.ToInt16(childnode.Attributes["id"].Value);
                    Individual child = (Individual)individuals[childid];
                    family.addChild(child);
                }
            }

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


        public void SaveXML()
        {
            SaveXML(this.xmlfilename);
        }

        public void SaveXML(String fileName)
        {
            xmldocument.LoadXml(createXML());
            xmldocument.Save(fileName);
        }

        public void SaveXML(System.IO.Stream stream)
        {
            xmldocument.LoadXml(createXML());
            xmldocument.Save(stream);
        }

        private string createXML()
        {
            String xml = "<quatre>";
            if (families.Values.Count > 0)
            {
                xml += "<families>";
                foreach (Family family in families.Values)
                {
                    xml += family.ToXML();
                }
                xml += "</families>";
            }
            if (individuals.Values.Count > 0)
            {
                xml += "<individuals>";
                foreach (Individual individual in individuals.Values)
                {
                    xml += individual.ToXML();
                }
                xml += "</individuals>";
            }
            xml += "</quatre>";
            return xml;
        }

        public Hashtable Individuals
        {
            get { return this.individuals; }
            set { this.individuals = value; }
        }

        public Hashtable Families
        {
            get { return this.families; }
            set { this.families = value; }
        }

        public int NextIndividualID
        {
            get { return this.maxindividualid + 1; }
        }
        public int NextFamilyID
        {
            get { return this.maxfamilyid + 1; }
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
