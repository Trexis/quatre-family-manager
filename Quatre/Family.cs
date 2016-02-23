using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Quatre
{
    public class Family : IComparer
    {
        int id = 0;
        String datemarried = "";
        String placemarried = "";
        String datedivorsed = "";
        Individual husband = null;
        Individual wife = null;
        HashSet<Individual> children = new HashSet<Individual>();
        String notes = "";

        public Family()
        {
        }

        public string SpouseName(Individual primary)
        {
            if (this.Secondary != null)
            {
                return this.Secondary.DisplayName;
            }
            else
            {
                return "Unknown";
            }
        }


        public Individual Primary
        {
            get
            {
                if (this.husband != null)
                {
                    if (this.husband.FromFamily != null)
                    {
                        return this.husband;
                    }
                    else
                    {
                        if (this.wife.FromFamily != null)
                        {
                            return this.wife;
                        }
                        else
                        {
                            return this.husband;
                        }
                    }
                }
                else
                {
                    return this.wife;
                }
            }
        }

        public Individual Secondary
        {
            get
            {
                if (this.husband != null)
                {
                    if (this.husband.ID == this.Primary.ID)
                    {
                        return this.wife;
                    }
                    else
                    {
                        return this.husband;
                    }
                }
                else
                {
                    return this.wife;
                }
            }
        }

        public Boolean Ploral
        {
            get
            {
                Boolean ploral = false;
                if (this.husband != null)
                {
                    if (this.wife != null)
                    {
                        ploral = true;
                    }
                }
                return ploral;
            }
        }

        public Boolean PrimaryMale
        {
            get
            {
                bool primarymale = false;
                if (this.Primary != null)
                {
                    if (this.husband != null)
                    {
                        if (this.Primary.ID == this.husband.ID)
                        {
                            primarymale = true;
                        }
                    }
                }
                return primarymale;
            }
        }

        public string Details
        {
            get
            {
                Individual primary = this.Primary;
                Individual secondary = this.Secondary;
                String details = "";
                if (secondary != null)
                {
                    //                    Belia married Paul Kotze VAN ZYL born a farmer from farm Winstead, Groblershoop, on 11 April 1938, married on 23 December 1961.  He died on 16 October 2009  
                    details += primary.Givenname.Split(Convert.ToChar(" "))[0] + " married " + secondary.Givenname;
                    if (secondary.Profession != "") details += ", a " + secondary.Profession;

                    if (secondary.DOB != "") details += ", born on " + secondary.DOB;

                    if (this.DateMarried != "")
                    {
                        details += ", married on " + this.DateMarried + ".";
                    }

                    if (secondary.DOD != "")
                    {
                        if (secondary.Sex.Equals(enums.Sex.Male))
                        {
                            details += " He died on " + secondary.DOD;
                        }
                        else
                        {
                            details += " She died on " + secondary.DOD;
                        }
                    }
                    details += "\n";
                }
                else
                {
                    if (this.DateMarried != "")
                    {
                        details += "Married on " + this.DateMarried + ".";
                        details += "\n";
                    }
                }

                return details;
            }
        }

        public string DisplayName
        {
            get{
                return this.Primary.DisplayName;
            }
        }

        public string ToXML()
        {
            string xml = "";
            xml += "<family id=\"" + this.id + "\"";
            if (this.husband != null)
            {
                xml += " husbandid=\"" + this.husband.ID + "\"";
            }
            if (this.wife != null)
            {
                xml += " wifeid=\"" + this.wife.ID + "\"";
            }
            xml += ">";

            xml += "<datemarried>" + this.datemarried + "</datemarried>";
            xml += "<placemarried>" + this.placemarried + "</placemarried>";
            xml += "<datedivorsed>" + this.datedivorsed + "</datedivorsed>";
            xml += "<children>";
            foreach (Individual child in children)
            {
                xml += "<child id=\"" + child.ID + "\"/>";
            }
            xml += "</children>";
            xml += "<notes>" + this.notes + "</notes>";
            xml += "</family>";
            return xml;
        }

        int IComparer.Compare(object a, object b)
        {
            Family f1 = (Family)a;
            Family f2 = (Family)b;

            if (f1.id > f2.id)
                return 1;
            if (f1.id < f2.id)
                return -1;
            else
                return 0;
        }

        public void addChild(Individual child)
        {
            this.children.Add(child);
        }
        public void ClearChildren()
        {
            this.children = new HashSet<Individual>();
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public Individual Husband
        {
            get { return this.husband; }
            set { this.husband = value; }
        }

        public Individual Wife
        {
            get { return this.wife; }
            set { this.wife = value; }
        }

        public HashSet<Individual> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public String DateMarried
        {
            get { return this.datemarried; }
            set { this.datemarried = value; }
        }

        public String DateDivorsed
        {
            get { return this.datedivorsed; }
            set { this.datedivorsed = value; }
        }
        public String PlaceMarried
        {
            get { return this.placemarried; }
            set { this.placemarried = value; }
        }
        public String Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
    }
}
