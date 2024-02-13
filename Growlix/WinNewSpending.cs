using Entities;
using Growlix.DGVModels;
using Microsoft.VisualBasic;
using NHibernate;
using NHibernate.Util;
using System.Collections.Generic;
//Safe this:: Enum.GetValues(typeof(SpendingCategoriesEnum))
namespace Growlix
{
    public partial class WinNewSpending : Form
    {
        private List<Spending> SpendingsToAdd;
        private ISessionFactory sf;
        public WinNewSpending(ISessionFactory _sf)
        {
            sf = _sf;
            SpendingsToAdd = new List<Spending>();
            InitializeComponent();
            cbSpendingCategory.DataSource = Enum.GetValues(typeof(SpendingCategoriesEnum));
        }

        private void btSaveAndBack_Click(object sender, EventArgs e)
        {
            tbName.Text = cbSpendingCategory.SelectedValue.ToString();
            tbPcsPrice.Text = ((int)cbSpendingCategory.SelectedValue).ToString();

        }

        private void cbDateToday_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.Enabled = !cbDateToday.Checked;
        }

        private void WhileEditing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                try
                {
                    var combobox = (DataGridViewComboBoxColumn)dgvSpendingsToAdd.Columns["ColCategory"];
                    combobox.DisplayMember = "Name";
                    combobox.ValueMember = "ID";
                    combobox.DataSource = GetSpendingCategoriesForDGV();
                    dgvSpendingsToAdd.DataSource = GetSpendingsForDGV();
                    dgvSpendingsToAdd.Refresh();

                }
                catch (Exception ex)
                {
                }

            }
        }
        private List<SpendingModel> GetSpendingsForDGV()
        {
            ISession session = sf.OpenSession();
            var ret =  session.Query<Spending>().Select(x => new SpendingModel(x)).ToList();
            session.Close();
            return ret;
        }
        private List<SpendingCategory> GetSpendingCategoriesForDGV()
        {
            ISession session = sf.OpenSession();
            var ret = session.Query<SpendingCategory>().ToList();
            session.Close();
            return ret;
        }
    }
}
