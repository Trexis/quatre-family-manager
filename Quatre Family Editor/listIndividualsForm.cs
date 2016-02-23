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
    public partial class listIndividualsForm : Form
    {
        Quatre quatre;
        Form parentform;
        Hashtable individuals;
        SortedDictionary<int, string> individualslistitems = new SortedDictionary<int, string>();
        Individual selectedindividual;
        bool selectonly = true;
        enums.ListFilter filter = enums.ListFilter.None;
        bool familyadded = false;
        Family fromfamily;

        public listIndividualsForm(Quatre quatre, Form parentForm, bool selectOnly, enums.ListFilter filter)
        {
            this.quatre = quatre;
            this.parentform = parentForm;
            this.selectonly = selectOnly;
            this.filter = filter;

            InitializeComponent();

            if (!this.selectonly)
            {
                buttonSelect.Text = "Edit";
            }
        }

        public listIndividualsForm(Quatre quatre, Form parentForm, bool selectOnly, enums.ListFilter filter, Family fromFamily)
        {
            this.quatre = quatre;
            this.parentform = parentForm;
            this.selectonly = selectOnly;
            this.filter = filter;
            this.fromfamily = fromFamily;

            InitializeComponent();

            if (!this.selectonly)
            {
                buttonSelect.Text = "Edit";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listIndividualsForm_Load(object sender, EventArgs e)
        {
            loadList();
        }

        private void performSelect()
        {
            if (listIndividuals.SelectedItems.Count > 0)
            {
                this.selectedindividual = (Individual)this.individuals[(int)listIndividuals.SelectedItems[0].Tag];
                if (this.selectonly)
                {
                    this.Close();
                }
                else
                {
                    formIndividual form = new formIndividual(this, quatre, this.selectedindividual);
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog(this);
                    DrawDetails();
                }
            }
        }

        public void loadList()
        {
            this.individuals = quatre.Individuals;

            if (individuals.Count > 0)
            {
                individualslistitems = new SortedDictionary<int, string>();

                enums.Sex filtersex = enums.Sex.Unknown;
                if (this.filter.Equals(enums.ListFilter.Male)) filtersex = enums.Sex.Male;
                if (this.filter.Equals(enums.ListFilter.Female)) filtersex = enums.Sex.Female;

                foreach (Individual individual in individuals.Values)
                {
                    if (this.filter.Equals(enums.ListFilter.None))
                    {
                        String textline = individual.ID.ToString();
                        textline += " " + individual.DisplayName;
                        if (!individual.DOB.Equals("")) textline += " (" + individual.DOB + ")";
                        individualslistitems.Add(individual.ID, textline);
                    }
                    else if (individual.Sex.Equals(enums.Sex.Unknown) || individual.Sex.Equals(filtersex))
                    {
                        String textline = individual.ID.ToString();
                        textline += " " + individual.DisplayName;
                        if (!individual.DOB.Equals("")) textline += " (" + individual.DOB + ")";
                        individualslistitems.Add(individual.ID, textline);
                    }
                    
                }

                populateList("");
            }
        }

        private void populateList(String filter)
        {
            listIndividuals.Items.Clear();
            foreach (int key in individualslistitems.Keys)
            {
                String listtext = individualslistitems[key].ToString();
                if (filter.Equals("") || listtext.ToLower().Contains(filter.ToLower()))
                {
                    ListViewItem listviewitem = new ListViewItem(listtext, 0);
                    listviewitem.Tag = key;
                    listIndividuals.Items.Add(listviewitem);
                }
            }
        }

        private void listIndividuals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listIndividuals.SelectedItems.Count > 0)
            {
                this.selectedindividual = (Individual)this.individuals[(int)listIndividuals.SelectedItems[0].Tag];
                DrawDetails();
            }
        }

        private void DrawDetails() {
            if (this.selectedindividual != null)
            {
                lblName.Text = this.selectedindividual.Name;
                lblSurname.Text = this.selectedindividual.Surname;
                lblGivenName.Text = this.selectedindividual.Givenname;
                lblDateOfBirth.Text = this.selectedindividual.DOB;
                lblPlaceOfBirth.Text = this.selectedindividual.PlaceOfBirth;
                lblProfession.Text = this.selectedindividual.Profession;
                lblDateOfDeath.Text = this.selectedindividual.DOD;
                lblSex.Text = this.selectedindividual.Sex.ToString();

                if (this.selectedIndividual.FromFamily != null)
                {
                    lblFromFamily.Text = "(" + this.selectedIndividual.FromFamily.ID + ") " + this.selectedIndividual.FromFamily.DisplayName;
                }
                else
                {
                    lblFromFamily.Text = "";
                }

                panelFamilies.Controls.Clear();
                int previousheight = 0;
                if (this.selectedindividual.Families.Values.Count > 0)
                {
                    foreach (Family family in this.selectedindividual.Families.Values)
                    {
                        LinkLabel familylink = new LinkLabel();
                        familylink.Text = "(" + family.ID + ") " + family.DisplayName;
                        familylink.AutoSize = true;
                        familylink.Tag = family.ID;
                        familylink.Click += familylink_Click;
                        familylink.Top = previousheight;
                        panelFamilies.Controls.Add(familylink);
                        previousheight = familylink.Bottom;
                    }
                }

                panelDetails.Visible = true;
            }
        }

        void familylink_Click(object sender, EventArgs e)
        {
            int familyid = Convert.ToInt16(((LinkLabel)sender).Tag);
            formFamily form = new formFamily(this, quatre, familyid);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            DrawDetails();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            performSelect();
        }

        private void listIndividuals_DoubleClick(object sender, EventArgs e)
        {
            if (listIndividuals.SelectedItems.Count > 0)
            {
                this.selectedindividual = (Individual)this.individuals[(int)listIndividuals.SelectedItems[0].Tag];
                formIndividual form = new formIndividual(this, quatre, this.selectedindividual);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
                DrawDetails();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            populateList(txtSearch.Text);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(!txtSearch.Text.Equals("")) populateList(txtSearch.Text);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            formIndividual form = new formIndividual(this, this.quatre, this.fromfamily);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            if (form.Individual != null)
            {
                loadList();
                MessageBox.Show(this, "Successfully created new Individual", "Quatre Family Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                markIndividualSelected(form.Individual.ID);
            }
            else
            {
                populateList(txtSearch.Text);
            }
        }

        private void markIndividualSelected(int individualId)
        {
            foreach (ListViewItem listviewitem in listIndividuals.Items)
            {
                if (listviewitem.Tag.Equals(individualId))
                {
                    listviewitem.Selected = true;
                    listviewitem.Focused = true;
                    listviewitem.EnsureVisible();
                    listIndividuals.Select();
                }
                else
                {
                    listviewitem.Selected = false;
                    listviewitem.Focused = false;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedindividual!=null)
            {
                if (MessageBox.Show(this, "Are you sure you want to delete " + this.selectedindividual.DisplayName, "Delete Individual", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    quatre.Individuals.Remove(this.selectedindividual.ID);
                    quatre.SaveXML();
                    loadList();
                    panelDetails.Visible = false;

                    MessageBox.Show(this, "Successfully deleted individual");
                }
            }
        }

        public Individual selectedIndividual
        {
            get { return this.selectedindividual; }
        }

        private void buttonNewFamily_Click(object sender, EventArgs e)
        {
            if (this.selectedIndividual != null)
            {
                formFamily form = new formFamily(this, quatre, this.selectedIndividual);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
                DrawDetails();
                if (form.Family != null)
                {
                    this.familyadded = true;
                    MessageBox.Show(this, "Successfully created new Family", "Quatre Family Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public bool FamilyAdded
        {
            get { return this.familyadded; }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadList();
        }
    }
}
