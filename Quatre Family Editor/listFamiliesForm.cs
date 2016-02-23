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
    public partial class listFamiliesForm : Form
    {
        Quatre quatre;
        Form parentform;
        Hashtable families;
        SortedDictionary<int, string> familylistitems = new SortedDictionary<int, string>();
        Family selectedfamily;

        public listFamiliesForm(Form parentForm, Quatre quatre)
        {
            this.parentform = parentForm;
            this.quatre = quatre;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadList();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listFamilies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            performSelect();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            performSelect();
        }

        private void performSelect()
        {
            if (listFamilies.SelectedItems.Count > 0)
            {
                this.selectedfamily = (Family)this.families[(int)listFamilies.SelectedItems[0].Tag];
                this.Close();
            }
        }

        public void loadList()
        {
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

        private void populateList(String filter)
        {
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            populateList(txtSearch.Text);
        }

        public Family SelectedFamily
        {
            get { return selectedfamily; }
        }

        private void listFamilies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (!txtSearch.Text.Equals("")) populateList(txtSearch.Text);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadList();
        }
    }
}
