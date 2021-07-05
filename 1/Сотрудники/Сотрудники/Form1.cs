using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сотрудники
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            должностиBindingSource.DataSource = db.Должности.ToList();
           категорииBindingSource.DataSource = db.Категории.ToList();
           сотрудники_НИИBindingSource.DataSource = db.Сотрудники_НИИ.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.db = db;
            frm.cus = null;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                сотрудники_НИИBindingSource.DataSource = null;
                сотрудники_НИИBindingSource.DataSource = db.Сотрудники_НИИ.ToList();
            }
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Сотрудники_НИИ cus = (Сотрудники_НИИ)сотрудники_НИИBindingSource.Current;
            Form2 frm = new Form2();
            frm.db = db;
            frm.cus = cus;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                сотрудники_НИИBindingSource.DataSource = null;
                сотрудники_НИИBindingSource.DataSource = db.Сотрудники_НИИ.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Сотрудники_НИИ cus = (Сотрудники_НИИ)сотрудники_НИИBindingSource.Current;
            DialogResult dr = MessageBox.Show(" Удалить " +
            cus.Код + "?", " Удаление ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Сотрудники_НИИ.Remove(cus);
                try
                {
                    db.SaveChanges();
                    сотрудники_НИИBindingSource.DataSource = db.Сотрудники_НИИ.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }

        private void сотрудники_НИИDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void сотрудники_НИИDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void должностиBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void категорииBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void сотрудники_НИИDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

