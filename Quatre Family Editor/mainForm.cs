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
    public partial class mainForm : Form
    {
        Hashtable families;
        HashSet<int> fromfamiliesbuilt = new HashSet<int>();
        SortedDictionary<int,string> familylistitems = new SortedDictionary<int,string>();
        Quatre quatre = new Quatre();

        public mainForm()
        {
            InitializeComponent();
        }

        private void loadGEDButton_Click(object sender, EventArgs e)
        {
            formGEDReader form = new formGEDReader(this);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            quatre.LoadXML();
            loadList();
        }

        public void loadQuatre(Quatre quatre)
        {
            this.quatre = quatre;
        }

        public void loadList(){
            this.families = quatre.Families;

            if (families.Count > 0)
            {
                familylistitems = new SortedDictionary<int, string>();

                foreach (Family family in families.Values)
                {
                    String textline = family.ID.ToString();
                    textline += " " + family.DisplayName;
                    familylistitems.Add(family.ID, textline);
                }

                populateList("");
            }
        }

        private void populateList(String filter){
            listFamilies.Items.Clear();
            foreach (int key in familylistitems.Keys)
            {
                String listtext = familylistitems[key].ToString();
                if (filter.Equals("") || listtext.ToLower().Contains(filter.ToLower()))
                {
                    ListViewItem listviewitem = new ListViewItem(listtext, 0);
                    listviewitem.Tag = key;
                    listFamilies.Items.Add(listviewitem);
                }
            }
        }

        private void listFamilies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFamilies.SelectedItems.Count > 0)
            {
                drawFamily((int)listFamilies.SelectedItems[0].Tag);
            }
        }

        private void drawFamily(int familyId)
        {
            Family family = (Family)families[familyId];

            Individual primary = family.Primary;
            Individual secondary = family.Secondary;

            linkNameSurname.Text = primary.Givenname + " " + primary.Surname.ToUpper();
            linkNameSurname.Visible = true;
            linkNameSurname.Tag = primary.ID;


            panelFamilies.Controls.Clear();
            this.fromfamiliesbuilt = new HashSet<int>();
            if (primary.FromFamily != null)
            {
                buildFromFamily(primary.FromFamily, null);
            }
            else
            {
                lblDetails.Top = linkNameSurname.Bottom + 5;
                panelChildren.Top = lblDetails.Bottom;
            }

            buildDetails(family);

            buildChildren(family);
        }


        private void buildChildren(Family family)
        {
            panelChildren.Top = lblDetails.Bottom + 10;
            panelChildList.Controls.Clear();

            Boolean ploral = family.Ploral;
            Boolean primaryMale = family.PrimaryMale;

            if (family.Children.Count > 0)
            {

                if (ploral)
                {
                    lblChildren.Text = "They had the following children";
                }
                else
                {
                    if (primaryMale)
                    {
                        lblChildren.Text = "He had the following children";
                    }
                    else
                    {
                        lblChildren.Text = "She had the following children";
                    }
                }

                int heightcounter = 0;
                int childcounter = 1;
                foreach (Individual child in family.Children)
                {
                    Label labelcounter = new Label();
                    labelcounter.Text = "(" + Utilities.ToRoman(childcounter) + ")";
                    labelcounter.Top = heightcounter;
                    labelcounter.AutoSize = true;
                    labelcounter.Width = 35;
                    panelChildList.Controls.Add(labelcounter);

                    Label labelsex = new Label();
                    if (child.Sex.Equals(enums.Sex.Male)) labelsex.Text = "M";
                    if (child.Sex.Equals(enums.Sex.Female)) labelsex.Text = "F";
                    if (child.Sex.Equals(enums.Sex.Unknown)) labelsex.Text = "";
                    labelsex.Top = heightcounter;
                    labelsex.Left = 35;
                    labelsex.AutoSize = true;
                    labelsex.Width = 10;
                    panelChildList.Controls.Add(labelsex);

                    String linktext = "(" + child.ID + ") " + child.DisplayName;

                    if (child.Families.Count > 0)
                    {
                        if (!child.Families.Count.Equals(1))
                        {
                            Label childlink = new Label();
                            childlink.Left = labelsex.Right;
                            childlink.Text = linktext;
                            childlink.AutoSize = true;
                            childlink.Top = heightcounter;
                            panelChildList.Controls.Add(childlink);

                            if (!child.DOB.Equals(""))
                            {
                                Label bornlabel = new Label();
                                bornlabel.Text = "born on " + child.DOB;
                                bornlabel.Top = heightcounter;
                                bornlabel.Left = childlink.Right;
                                bornlabel.AutoSize = true;
                                panelChildList.Controls.Add(bornlabel);
                            }


                            heightcounter += 15;
                        }
                        foreach (Family childfamily in child.Families.Values)
                        {
                            if (child.Families.Count.Equals(1))
                            {
                                LinkLabel childlink = new LinkLabel();
                                childlink.Left = labelsex.Right;
                                childlink.Text = linktext;
                                childlink.AutoSize = true;
                                childlink.Top = heightcounter;
                                childlink.Tag = childfamily.ID;
                                childlink.Click += linklabel_Click;
                                panelChildList.Controls.Add(childlink);
                                heightcounter += 15;
                            }
                            else
                            {
                                Label label1 = new Label();
                                label1.Left = 53;
                                label1.Top = heightcounter;
                                label1.Text = "married ";
                                label1.Width = 45;
                                label1.AutoSize = true;

                                Individual spouse;
                                if (childfamily.Husband.ID.Equals(child.ID))
                                {
                                    spouse = childfamily.Wife;
                                }
                                else
                                {
                                    spouse = childfamily.Husband;
                                }
                                LinkLabel childlink = new LinkLabel();
                                childlink.Text = spouse.DisplayName;
                                childlink.AutoSize = true;
                                childlink.Top = heightcounter;
                                childlink.Left = label1.Right;
                                childlink.Tag = childfamily.ID;
                                childlink.Click += linklabel_Click;
                                panelChildList.Controls.Add(childlink);

                                Label label2 = new Label();
                                label2.Left = childlink.Right;
                                label2.Top = heightcounter;

                                if (!spouse.DOB.Equals(""))
                                {
                                    label2.Text = ", born on " + spouse.DOB;
                                }

                                if (childfamily.DateDivorsed.Equals(""))
                                {
                                    if (!childfamily.DateMarried.Equals(""))
                                    {
                                        label2.Text += ", married on " + childfamily.DateMarried;
                                    }
                                }
                                else
                                {
                                    label2.Text = ", the marriage ended in divorce on " + childfamily.DateDivorsed;
                                }
                                label2.AutoSize = true;

                                panelChildList.Controls.Add(label1);
                                panelChildList.Controls.Add(childlink);
                                panelChildList.Controls.Add(label2);

                                heightcounter += 15;
                            }
                        }

                    }
                    else
                    {
                        Label childlink = new Label();
                        childlink.Left = labelsex.Right;
                        childlink.Text = linktext;
                        childlink.AutoSize = true;
                        childlink.Top = heightcounter;
                        panelChildList.Controls.Add(childlink);
                        heightcounter += 15;
                    }

                    childcounter++;
                }
                panelChildren.Height = heightcounter + 20;
                panelChildren.Visible = true;
            }
            else
            {
                panelChildren.Visible = false;
            }
        }

        private void buildDetails(Family family)
        {
            lblDetails.Text = family.Primary.Details + "\n\n" + family.Details;
            lblDetails.MaximumSize = new System.Drawing.Size(groupBox1.Width-5, lblDetails.MaximumSize.Height);
            lblDetails.Visible = true;
        }

        private void buildFromFamily(Family family, LinkLabel previousLinkLabel)
        {
            if (!fromfamiliesbuilt.Contains(family.ID))
            {
                Individual primary = family.Primary;
                Individual secondary = family.Secondary;

                LinkLabel linklabel = new LinkLabel();
                linklabel.Text = primary.Givenname + " " + primary.Surname.ToUpper();
                linklabel.AutoSize = true;
                linklabel.Tag = family.ID;
                linklabel.Click += linklabel_Click;

                if (previousLinkLabel!=null)
                {
                    if ((linklabel.Width + previousLinkLabel.Right) >= panelFamilies.Width)
                    {
                        linklabel.Left = 0;
                        linklabel.Top = previousLinkLabel.Top + 15;
                    }
                    else
                    {
                        linklabel.Top = previousLinkLabel.Top;
                        linklabel.Left = previousLinkLabel.Right;
                    }
                    panelFamilies.Height = linklabel.Bottom + 5;
                    lblDetails.Top = panelFamilies.Bottom;
                    panelChildren.Top = lblDetails.Bottom;
                }
                panelFamilies.Controls.Add(linklabel);

                this.fromfamiliesbuilt.Add(family.ID);

                if (primary.FromFamily != null)
                {
                    buildFromFamily(primary.FromFamily, linklabel);
                }

            }

        }

        void linklabel_Click(object sender, EventArgs e)
        {
            if(!txtSearch.Text.Equals("")) populateList("");
            LinkLabel linklabel = (LinkLabel)sender;
            markFamilySelected((int)linklabel.Tag);

        }

        private void linkNameSurname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formIndividual form = new formIndividual(this, quatre, (int)linkNameSurname.Tag);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            if (listFamilies.SelectedItems.Count > 0)
            {
                drawFamily((int)listFamilies.SelectedItems[0].Tag);
            }

        }

        private void listFamilies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            formIndividual form = new formIndividual(this, quatre, (int)linkNameSurname.Tag);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            if (listFamilies.SelectedItems.Count > 0)
            {
                drawFamily((int)listFamilies.SelectedItems[0].Tag);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            populateList(txtSearch.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Xml File|*.xml";
            saveFileDialog1.Title = "Backup Data File";
            saveFileDialog1.FileName = "quatre " + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xml";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    System.IO.Stream stream = saveFileDialog1.OpenFile();
                    quatre.SaveXML(stream);
                    stream.Close();
                    MessageBox.Show(this, "Backup successfull", "Quatre Family Editor");
                }
            }
        }

        private void newIndividualButton_Click(object sender, EventArgs e)
        {
            formIndividual form = new formIndividual(this, quatre);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (!txtSearch.Text.Equals("")) populateList(txtSearch.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            listIndividualsForm form = new listIndividualsForm(quatre, this, false, enums.ListFilter.None);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            if (form.FamilyAdded)
            {
                loadList();
            }
            else
            {
                populateList(txtSearch.Text);
            }
        }

        private void newFamilyButton_Click(object sender, EventArgs e)
        {
            formFamily form = new formFamily(this, quatre);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            loadList();
        }


        private void markFamilySelected(int familyId)
        {
            foreach (ListViewItem listviewitem in listFamilies.Items)
            {
                if (listviewitem.Tag.Equals(familyId))
                {
                    listviewitem.Selected = true;
                    listviewitem.Focused = true;
                    listviewitem.EnsureVisible();
                    listFamilies.Select();
                }
                else
                {
                    listviewitem.Selected = false;
                    listviewitem.Focused = false;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listFamilies.SelectedItems.Count > 0)
            {
                int familyid = (int)listFamilies.SelectedItems[0].Tag;
                formFamily form = new formFamily(this, quatre, familyid);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
                drawFamily(familyid);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listFamilies.SelectedItems.Count > 0)
            {
                int familyid = (int)listFamilies.SelectedItems[0].Tag;
                Family selectedfamily = (Family)this.quatre.Families[familyid];
                if (MessageBox.Show(this, "Are you sure you want to delete " + selectedfamily.DisplayName, "Delete Family", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (selectedfamily.Husband != null) selectedfamily.Husband.Families.Remove(familyid);
                    if (selectedfamily.Wife != null) selectedfamily.Wife.Families.Remove(familyid);
                    foreach (Individual child in selectedfamily.Children)
                    {
                        child.FromFamily = null;
                    }

                    quatre.Families.Remove(familyid);
                    quatre.SaveXML();
                    panelChildren.Visible = false;
                    panelFamilies.Visible = false;
                    linkNameSurname.Visible = false;
                    lblDetails.Visible = false;
                    loadList();
                    MessageBox.Show(this, "Successfully deleted family");
                }
            }

        }

        private void btnDelete_Resize(object sender, EventArgs e)
        {
            if (listFamilies.SelectedItems.Count > 0)
            {
                drawFamily((int)listFamilies.SelectedItems[0].Tag);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            htmlExportForm form = new htmlExportForm(this, quatre);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadList();
        }
    }
}
