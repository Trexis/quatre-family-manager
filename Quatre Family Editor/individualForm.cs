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
    public partial class formIndividual : Form
    {
        Form parentform;
        Quatre quatre;
        int individualid = 0;
        Boolean isnew = true;
        Individual individual;

        public formIndividual(Form parentForm, Quatre quatre)
        {
            this.quatre = quatre;
            this.parentform = parentForm;
            isnew = true;
            individual = new Individual();
            individual.ID = quatre.NextIndividualID;
            InitializeComponent();
        }

        public formIndividual(Form parentForm, Quatre quatre, Family fromFamily)
        {
            this.quatre = quatre;
            this.parentform = parentForm;
            isnew = true;
            individual = new Individual();
            individual.ID = quatre.NextIndividualID;
            individual.FromFamily = fromFamily;
            InitializeComponent();
        }

        public formIndividual(Form parentForm, Quatre quatre, int individualId)
        {
            this.quatre = quatre;
            this.parentform = parentForm;
            this.individualid = individualId;
            if (!individualid.Equals("")) isnew = false;
            loadIndividual();
            InitializeComponent();
        }

        public formIndividual(Form parentForm, Quatre quatre, Individual individual)
        {
            this.quatre = quatre;
            this.individual = individual;
            this.parentform = parentForm;
            this.individualid = individual.ID;
            isnew = false;
            InitializeComponent();
        }

        private void loadIndividual()
        {
            Hashtable individuals = quatre.Individuals;
            individual = (Individual)individuals[this.individualid];
        }

        private void formIndividual_Load(object sender, EventArgs e)
        {
            txtID.Text = individual.ID.ToString();
            if (!isnew) txtID.Enabled = false;
            
            txtName.Text = individual.Name;
            txtSurname.Text = individual.Surname;
            txtGivenName.Text = individual.Givenname;
            txtDOB.Text = individual.DOB;
            txtPlaceOfBirth.Text = individual.PlaceOfBirth;
            txtDOD.Text = individual.DOD;
            txtProfession.Text = individual.Profession;
            txtNotes.Text = individual.Notes;

            if (individual.Sex.Equals(enums.Sex.Male)) comboSex.SelectedIndex = 0;
            if (individual.Sex.Equals(enums.Sex.Female)) comboSex.SelectedIndex = 1;
            if (individual.Sex.Equals(enums.Sex.Unknown)) comboSex.SelectedIndex = 2;

            if (individual.FromFamily != null)
            {
                lblParentFamily.Tag = individual.FromFamily.ID;
                lblParentFamily.Text = individual.FromFamily.ID + " " + individual.FromFamily.DisplayName;
            }
            else
            {
                lblParentFamily.Tag = 0;
            }

            lstFamilies.DisplayMember = "Text";
            lstFamilies.ValueMember = "Tag";
            if (individual.Families.Count > 0)
            {
                foreach (Family family in individual.Families.Values)
                {
                    Label label = new Label();
                    label.Text = family.ID + " " + family.SpouseName(individual);
                    label.Tag = family.ID;
                    lstFamilies.Items.Add(label);
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.individual = null;
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonRemoveFamily_Click(object sender, EventArgs e)
        {
            if (this.lstFamilies.SelectedIndex >= 0)
                this.lstFamilies.Items.RemoveAt(this.lstFamilies.SelectedIndex);
        }

        private void lblParentFamily_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveParentFamily_Click(object sender, EventArgs e)
        {
            lblParentFamily.Tag = 0;
            lblParentFamily.Text = "Select a parent family";
        }

        private void buttonAddParentFamily_Click(object sender, EventArgs e)
        {
            listFamiliesForm form = new listFamiliesForm(this, quatre);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            if (form.SelectedFamily != null)
            {
                Family selectedfamily = form.SelectedFamily;
                lblParentFamily.Tag = selectedfamily.ID;
                lblParentFamily.Text = selectedfamily.ID + " " + selectedfamily.DisplayName;
            }
        }

        private void buttonAddFamily_Click(object sender, EventArgs e)
        {
            listFamiliesForm form = new listFamiliesForm(this, quatre);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            if (form.SelectedFamily != null)
            {
                Family selectedfamily = form.SelectedFamily;
                Label label = new Label();
                label.Text = selectedfamily.ID + " " + selectedfamily.SpouseName(this.individual);
                label.Tag = selectedfamily.ID;
                lstFamilies.Items.Add(label);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool continuesave = false;
                if ((comboSex.SelectedIndex == -1)||(comboSex.SelectedIndex == 2))
                {
                    if (MessageBox.Show(this, "You did not select the sex.  Do you want to continue without the selection?", "Quatre Save Individual", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        continuesave = true;
                    }
                    else
                    {
                        continuesave = false;
                    }
                }
                else
                {
                    continuesave = true;
                }

                if (continuesave)
                {
                    individual.Name = txtName.Text.Trim();
                    individual.Givenname = txtGivenName.Text.Trim();
                    individual.Surname = txtSurname.Text.Trim();
                    individual.DOB = txtDOB.Text.Trim();
                    individual.PlaceOfBirth = txtPlaceOfBirth.Text.Trim();
                    individual.DOD = txtDOD.Text.Trim();
                    individual.Profession = txtProfession.Text.Trim();
                    individual.Notes = txtNotes.Text.Trim();

                    if (comboSex.SelectedIndex == 0) individual.Sex = enums.Sex.Male;
                    if (comboSex.SelectedIndex == 1) individual.Sex = enums.Sex.Female;
                    if (comboSex.SelectedIndex == 2) individual.Sex = enums.Sex.Unknown;

                    if ((int)lblParentFamily.Tag != 0)
                    {
                        individual.FromFamily = (Family)quatre.Families[(int)lblParentFamily.Tag];
                    }
                    else
                    {
                        individual.FromFamily = null;
                    }

                    individual.ClearFamilies();
                    foreach (Label label in lstFamilies.Items)
                    {
                        int famid = (int)label.Tag;
                        individual.AddFamily(famid, (Family)quatre.Families[famid]);
                    }

                    if (quatre.Individuals.ContainsKey(individual.ID))
                    {
                        quatre.Individuals[individual.ID] = individual;
                    }
                    else
                    {
                        quatre.Individuals.Add(individual.ID, individual);
                    }
                    quatre.SaveXML();

                    if (individual.ID > quatre.MaxIndividualID) quatre.MaxIndividualID = individual.ID;

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowError(this, "Unable to save individual \n" + ex.Message);
            }
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            if (!txtName.Text.Equals(""))
            {
                if (txtGivenName.Text.Equals("") && txtSurname.Text.Equals(""))
                {
                    String[] splitted = txtName.Text.Split(Convert.ToChar(" "));
                    if (splitted.Length == 1)
                    {
                        txtGivenName.Text = splitted[0];
                    }
                    else
                    {
                        for (int i = 0; i < splitted.Length - 1; i++)
                        {
                            txtGivenName.Text += splitted[i] + " ";
                        }
                        txtSurname.Text = splitted[splitted.Length - 1];
                    }
                }
            }
        }
        public Individual Individual
        {
            get { return this.individual; }
        }
    }
}
