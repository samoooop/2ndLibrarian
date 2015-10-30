using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ReturnBook.ActiveForm.Hide();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            borrowDetail.Rows.Clear();
            string[,] book = new String[DBCommand.countRowbrw(), 10];
            try
            {
                book = DBCommand.searchBrw("", "", "", "");
                for (int i = 0; i < book.GetLength(0); i++)
                {
                    borrowDetail.Rows.Add();
                    for (int j = 0; j < 6; j++)
                    {
                        borrowDetail.Rows[i].Cells[j].Value = book[i, j];
                    }
                }

            }
            catch (FileLoadException e2)
            {
                Console.WriteLine(e2);
                borrowDetail.Rows.Add();
                for (int j = 0; j < 10; j++)
                {
                    borrowDetail.Rows[0].Cells[j].Value = "N/A";
                }
            }
        }

        private void refshBtn_Click(object sender, EventArgs e)
        {
            borrowDetail.Rows.Clear();
            string[,] book = new String[DBCommand.countRowbrw(), 10];
            try
            {
                book = DBCommand.searchBrw("", "", "", "");
                for (int i = 0; i < book.GetLength(0); i++)
                {
                    borrowDetail.Rows.Add();
                    for (int j = 0; j < 6; j++)
                    {
                        borrowDetail.Rows[i].Cells[j].Value = book[i, j];
                    }
                }

            }
            catch (FileLoadException e2)
            {
                Console.WriteLine(e2);
                borrowDetail.Rows.Add();
                for (int j = 0; j < 10; j++)
                {
                    borrowDetail.Rows[0].Cells[j].Value = "N/A";
                }
            }
        }
    }
}
