using System;
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
    public partial class formFamily : Form
    {
        Form parentform;
        int familyid = 0;
        Boolean isnew = true;
        Family family;
        Quatre quatre;

        public formFamily(Form parentForm, Quatre quatre)
        {
            this.parentform = parentForm;
            this.quatre = quatre;
            family = new Family();
            isnew = true;
            family.ID = quatre.NextFamilyID;
            InitializeComponent();
        }

        public formFamily(Form parentForm, Quatre quatre, Individual husbandOrWife)
        {
            this.parentform = parentForm;
            this.quatre = quatre;
            family = new Family();
            isnew = true;
            family.ID = quatre.NextFamilyID;

            if (husbandOrWife.Sex.Equals(enums.Sex.Male))
            {
                family.Husband = husbandOrWife;
            }
            else
            {
                family.Wife = husbandOrWife;
            }

            InitializeComponent();
        }

        public formFamily(Form parentForm, Quatre quatre, int familyId)
        {
            this.parentform = parentForm;
            this.familyid = familyId;
            this.quatre = quatre;
            if(!familyId.Equals("")) isnew = false;
            loadFamily();
            InitializeComponent();
        }

        public formFamily(Form parentForm, Quatre quatre, Family family)
        {
            this.family = family;
            this.parentform = parentForm;
            this.familyid = family.ID;
            this.quatre = quatre;
            isnew = false;
            InitializeComponent();
        }

        private void loadFamily()
        {
            Hashtable families = quatre.Families;
            family = (Family)families[this.familyid];
        }

        private void formFamily_Load(object sender, EventArgs e)
        {
            txtID.Text = family.ID.ToString();
            if (!isnew) txtID.Enabled = false;

            txtDateMarried.Text = family.DateMarried;
            txtPlaceMarried.Text = family.PlaceMarried;
            txtDateDivorsed.Text = family.DateDivorsed;
            txtNotes.Text = family.Notes;

            if (family.Husband != null)
            {
                lblHusband.Tag = family.Husband.ID;
                lblHusband.Text = family.Husband.ID + " " + family.Husband.DisplayName;
            }
            else
            {
                lblHusband.Tag = 0;
            }

            if (family.Wife != null)
            {
                lblWife.Tag = family.Wife.ID;
                lblWife.Text = family.Wife.ID + " " + family.Wife.DisplayName;
            }
            else
            {
                lblWife.Tag = 0;
            }


            lstChildren.DisplayMember = "Text";
            lstChildren.ValueMember = "Tag";
            if (family.Children.Count > 0)
            {
                foreach (Individual child in family.Children)
                {
                    Label label = new Label();
                    label.Text = child.ID + " " + child.DisplayName;
                    label.Tag = child.ID;
                    lstChildren.Items.Add(label);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.family = null;
            this.Close();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                setFamilyDetailsFromFrom();

                if (quatre.Families.ContainsKey(family.ID))
                {
                    quatre.Families[family.ID] = family;
                }
                else
                {
                    quatre.Families.Add(family.ID, family);
                }
                quatre.SaveXML();

                if (family.ID > quatre.MaxFamilyID) quatre.MaxFamilyID = family.ID;

                this.Close();
            }
            catch (Exception ex)
            {
                Utilities.ShowError(this, "Unable to save family \n" + ex.Message);
            }

        }

        private void setFamilyDetailsFromFrom()
        {
            if ((int)lblHusband.Tag != 0)
            {
                family.Husband = (Individual)quatre.Individuals[(int)lblHusband.Tag];
                family.Husband.AddFamily(family.ID, family);
            }
            else
            {
                family.Husband = null;
            }

            if ((int)lblWife.Tag != 0)
            {
                family.Wife = (Individual)quatre.Individuals[(int)lblWife.Tag];
                family.Wife.AddFamily(family.ID, family);
            }
            else
            {
                family.Wife = null;
            }

            family.DateMarried = txtDateMarried.Text;
            family.PlaceMarried = txtPlaceMarried.Text;
            family.DateDivorsed = txtDateDivorsed.Text;

            family.ClearChildren();
            foreach (Label label in lstChildren.Items)
            {
                int childid = (int)label.Tag;
                Individual child = (Individual)quatre.Individuals[childid];
                child.FromFamily = family;
                family.addChild(child);
            }

        }


        private void buttonAddChild_Click(object sender, EventArgs e)
        {
            setFamilyDetailsFromFrom();

            listIndividualsForm form = new listIndividualsForm(quatre, this, true, enums.ListFilter.None, this.family);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            if (form.selectedIndividual != null)
            {
                Individual selectedindividual = form.selectedIndividual;
                Label label = new Label();
                label.Text = selectedindividual.ID + " " + selectedindividual.DisplayName;
                label.Tag = selectedindividual.ID;
                lstChildren.Items.Add(label);
            }
        }

        private void buttonRemoveChild_Click(object sender, EventArgs e)
        {
            if (this.lstChildren.SelectedIndex >= 0)
                this.lstChildren.Items.RemoveAt(this.lstChildren.SelectedIndex);

        }

        private void buttonRemoveHusband_Click(object sender, EventArgs e)
        {
            lblHusband.Tag = 0;
            lblHusband.Text = "Select a husband";
        }

        private void buttonRemoveWife_Click(object sender, EventArgs e)
        {
            lblWife.Tag = 0;
            lblWife.Text = "Select a wife";
        }

        private void buttonAddHusband_Click(object sender, EventArgs e)
        {
            listIndividualsForm form = new listIndividualsForm(quatre, this, true, enums.ListFilter.Male);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            if (form.selectedIndividual != null)
            {
                Individual selectedindividual = form.selectedIndividual;
                lblHusband.Tag = selectedindividual.ID;
                lblHusband.Text = selectedindividual.ID + " " + selectedindividual.DisplayName;
            }
        }

        private void buttonSelectWife_Click(object sender, EventArgs e)
        {
            listIndividualsForm form = new listIndividualsForm(quatre, this, true, enums.ListFilter.Female);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            if (form.selectedIndividual != null)
            {
                Individual selectedindividual = form.selectedIndividual;
                lblWife.Tag = selectedindividual.ID;
                lblWife.Text = selectedindividual.ID + " " + selectedindividual.DisplayName;
            }

        }

        public Family Family
        {
            get { return this.family; }
        }
    }
}
