using System;
using System.Collections;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bookDetail.Rows.Clear();
            string[,] book = new String[DBCommand.countRow(), 10];
            try {
                book = DBCommand.searchBook("", "", "", "", "", "", "");
                for (int i = 0; i < book.GetLength(0); i++)
                {
                    bookDetail.Rows.Add();
                    for (int j = 0; j < 10; j++)
                    {
                        bookDetail.Rows[i].Cells[j].Value = book[i, j];
                    }
                }

            } catch(FileLoadException e2) {
                Console.WriteLine(e2);
                bookDetail.Rows.Add();
                for (int j = 0; j < 10; j++)
                {
                    bookDetail.Rows[0].Cells[j].Value = "N/A";
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bookDetail.Rows.Clear();
            String[,] book = new String[DBCommand.countRow(),10];
            try {
                book = DBCommand.searchBook(nameField.Text, subNameField.Text, writerField.Text, translatorField.Text, publisherField.Text, publishedYrBox.Text, categoryBox.Text);
                for (int i = 0; i < book.GetLength(0); i++)
                {
                    bookDetail.Rows.Add();
                    for (int j = 0; j < 10; j++)
                    {
                        bookDetail.Rows[i].Cells[j].Value = book[i, j];
                    }
                }

            } catch(FileLoadException e2) {
                Console.WriteLine(e2);
                bookDetail.Rows.Add();
                for (int j = 0; j < 10; j++)
                {
                    bookDetail.Rows[0].Cells[j].Value = "N/A";
                }
            }
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using (AddDelBook adddelbook = new AddDelBook())
                adddelbook.ShowDialog();
            Show();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using (ReturnBook rtbook = new ReturnBook())
                rtbook.ShowDialog();
            Show();
        }

        private void borrowBtn_Click_1(object sender, EventArgs e)
        {
            Hide();
            using (BorrowBook brbook = new BorrowBook())
                brbook.ShowDialog();
            Show();
        }
    }
}
