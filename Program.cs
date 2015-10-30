using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;
using System.IO;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }

    class Book
    {
        public string bookName { get; set; }
        public string bookSubname { get; set; }
        public string writer { get; set; }
        public string subwriter { get; set; }
        public string translator { get; set; }
        public string publisher { get; set; }
        public string ISBN { get; set; }
        public string deweyNumber { get; set; }
        public string category { get; set; }
        public string edition { get; set; }
        public string total { get; set; }
        public string publishedYr { get; set; }
        public string left { get; set; }
        public bool canBorrow;

        public Book(String bookName, String bookSubname, String writer, String subwriter, String translator, string edition, string total,
            String publisher, string publishedYr, String ISBN, String deweyNumber, String category)
        {
            this.bookName = bookName;
            this.bookSubname = bookSubname;
            this.writer = writer;
            this.subwriter = subwriter;
            this.translator = translator;
            this.edition = edition;
            this.total = this.left = total;
            this.publisher = publisher;
            this.publishedYr = publishedYr;
            this.ISBN = ISBN;
            this.deweyNumber = deweyNumber;
            this.category = category;
            this.canBorrow = true;
        }

        public bool canborrow()
        {
            if (Convert.ToInt32(left) <= 0) return false;
            return true;
        }
    }

    class Borrower
    {
        public string name { get; set; }

        public Borrower(string name)
        {
            this.name = name;
        }
    }

    class DBCommand
    {
        public static string[,] searchBook(String bookName, String bookSubname, String writer, String translator, String publisher, String publishedYr, String category)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=libDB.sqlite;");
            SQLiteCommand cmd;
            string sql;
            try
            {
                conn.Open();
                int row = DBCommand.countRow();
                string[,] data = new String[row, 10];
                int i = 0;
                //SELECT
                sql = String.Format("SELECT * FROM bookData WHERE bookName LIKE \"%{0}%\" AND bookSubname LIKE \"%{1}%\" AND writer LIKE \"%{2}%\" AND translator LIKE \"%{3}%\" AND publisher LIKE \"%{4}%\" AND publishedYr LIKE \"%{5}%\" AND category LIKE \"%{6}%\";"
                                    , bookName, bookSubname, writer, translator, publisher, publishedYr, category);
                cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data[i, 0] += reader["bookName"];
                    data[i, 1] += reader["left"] + "/" + reader["total"];
                    data[i, 2] += reader["category"];
                    data[i, 3] += reader["writer"] + ", " + reader["subwriter"];
                    data[i, 4] += reader["translator"];
                    data[i, 5] += reader["publisher"];
                    data[i, 6] += reader["publishedYr"];
                    data[i, 7] += reader["edition"];
                    data[i, 8] += reader["ISBN"];
                    data[i, 9] += reader["deweyNumber"];
                    i++;
                }
                return data;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e);
                return new string[1, 10];
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        public static string[,] searchBrw(string bookName, string ISBN, string writer, string borrower)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=libDB.sqlite;");
            SQLiteCommand cmd;
            string sql;
            int row = 0, i = 0;
            try
            {
                conn.Open();
                row = DBCommand.countRowbrw();
                string[,] brwdata = new string[row, 6];
                sql = "SELECT * FROM borrowData";
                cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sql = $"SELECT * FROM bookData WHERE ROWID = \"{reader["bookID"]}\"";
                    cmd = new SQLiteCommand(sql, conn);
                    SQLiteDataReader r2 = cmd.ExecuteReader();
                    brwdata[i, 0] = r2["bookName"].ToString();
                    brwdata[i, 1] = reader["borrower"].ToString();
                    brwdata[i, 2] = "";
                    brwdata[i, 3] = DateTime.Now.ToString();
                    brwdata[i, 4] = r2["ISBN"].ToString();
                    brwdata[i, 5] = r2["writer"].ToString();
                    i++;
                }
                return brwdata;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e);
                return new string[1, 10];
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        public static void addBook(Book b)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=libDB.sqlite;");
            SQLiteCommand cmd;
            try
            {
                conn.Open();
                string sql = String.Format("SELECT * FROM bookData WHERE bookName = \"{0}\" AND ISBN LIKE \"%{1}%\";", b.bookName, b.ISBN);
                cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            int total = Int32.Parse(reader["total"].ToString());
                            int left = Int32.Parse(reader["left"].ToString());
                            string sql2 = String.Format("UPDATE bookData SET total = \"{0}\",left = \"{1}\" WHERE bookName = \"{2}\" AND ISBN LIKE \"%{3}%\";", total + b.total, left + b.total, b.bookName, b.ISBN);
                            cmd = new SQLiteCommand(sql2, conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("เพิ่มหนังสือเรียบร้อยแล้ว");
                        }
                        catch (SQLiteException e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
                else
                {
                    try
                    {
                        string sql3 = $"INSERT INTO bookData VALUES (\"{b.bookName}\", \"{b.bookSubname}\", \"{b.writer}\", \"{b.subwriter}\", \"{b.translator}\", \"{b.edition}\", " +
                            $"\"{b.total}\", \"{b.publisher}\", \"{b.publishedYr}\", \"{b.ISBN}\", \"{b.deweyNumber}\", \"{b.category}\", \"{b.total}\", \"true\")";
                        cmd = new SQLiteCommand(sql3, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("เพิ่มหนังสือเรียบร้อยแล้ว");
                    }
                    catch (SQLiteException e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        public static void delBook(Book b)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=libDB.sqlite;");
            SQLiteCommand cmd;
            string sql;
            try
            {
                conn.Open();
                sql = $"SELECT * FROM bookData WHERE bookName = \"{b.bookName}\" AND ISBN = \"{b.ISBN}\";";
                cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    sql = $"UPDATE bookData SET total = \"{Convert.ToInt32(reader["total"]) - Convert.ToInt32(b.total)}\", left = \"{Convert.ToInt32(reader["left"]) - Convert.ToInt32(b.total)}\" WHERE bookName = \"{b.bookName}\" AND ISBN = \"{b.ISBN}\";";
                    cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ลบหนังสือจำนวน " + b.total + " เล่ม\nเรียบร้อยแล้ว");
                    if (Convert.ToInt32(reader["total"]) <= 0)
                    {
                        try
                        {
                            sql = $"DELETE FROM bookData WHERE bookName = \"{b.bookName}\" AND ISBN = \"{b.ISBN}\";";
                            cmd = new SQLiteCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                        }
                        catch (SQLiteException e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        public static int countRow()
        {
            string sql = "SELECT COUNT(*) FROM bookData";
            int count = 0;

            using (SQLiteConnection conn = new SQLiteConnection("data source=libDB.sqlite;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    conn.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;
        }

        public static int countRowbrw()
        {
            string sql = "SELECT COUNT(*) FROM borrowData";
            int count = 0;

            using (SQLiteConnection conn = new SQLiteConnection("data source=libDB.sqlite;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    conn.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;
        }

        public static void brwBook(Book b, Borrower br)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=libDB.sqlite;");
            SQLiteCommand cmd;
            string sql;
            int rowID = 0;
            try
            {
                conn.Open();
                sql = $"SELECT ROWID FROM bookData WHERE bookName = \"{b.bookName}\" AND ISBN = \"{b.ISBN}\" AND writer LIKE \"%{b.writer}%\";";
                cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) rowID = Convert.ToInt32(reader["ROWID"]);

                sql = $"SELECT * FROM bookData WHERE bookName = \"{b.bookName}\" AND ISBN = \"{b.ISBN}\" AND writer LIKE \"%{b.writer}%\";";
                cmd = new SQLiteCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (Convert.ToInt32(reader["left"]) > 0)
                    {
                        try
                        {
                            sql = $"INSERT INTO borrowData VALUES (\"{br.name}\", \"{DateTime.Now}\", \"{rowID}\");";
                            cmd = new SQLiteCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            sql = $"UPDATE bookData SET left = \"{Convert.ToInt32(reader["left"]) - 1}\" WHERE bookName = \"{b.bookName}\" AND ISBN = \"{b.ISBN}\" AND writer LIKE \"%{b.writer}%\"";
                            cmd = new SQLiteCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("ยืมสำเร็จ");
                        }
                        catch (SQLiteException e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ยืมไม่สำเร็จ");
                    }
                }
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        public static void rtnBook(string bookName, string borrower)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=libDB.sqlite;");
            SQLiteCommand cmd;
            string sql;
            int rowID = 0;

            conn.Open();
            sql = $"SELECT ROWID FROM bookData WHERE bookName = \"{bookName}\";";
            cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    rowID = Convert.ToInt32(reader["ROWID"]);
                    try {
                        sql = $"UPDATE bookData SET left = left + 1 WHERE ROWID = \"{rowID}\";";
                        cmd = new SQLiteCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        sql = $"DELETE FROM borrowData WHERE borrower = \"{borrower}\" AND bookID = \"{rowID}\";";
                        cmd = new SQLiteCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("คืนสำเร็จ");
                        return;
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show("คืนไม่สำเร็จ");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("ไม่พบหนังสือ");
                return;
            }
        }
    }
}
