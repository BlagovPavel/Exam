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
    public partial class Form2 : Form
    {
        public Model1 db { get; set; }
        public Сотрудники_НИИ cus { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (cus == null)
            {
                сотрудники_НИИBindingSource.AddNew();

                Text = " Добавление нового сотрудника ";
            }
            else
            {
                сотрудники_НИИBindingSource.Add(cus);
                кодTextBox.ReadOnly = true;
                Text = "Изменение данных сотрудника - " + cus.Код;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cus == null)
            {
                cus = (Сотрудники_НИИ)сотрудники_НИИBindingSource.List[0];
                db.Сотрудники_НИИ.Add(cus);
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void зарплата_в_мес_рубLabel_Click(object sender, EventArgs e)
        {
    
        }

        private void кодКатегорииLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
