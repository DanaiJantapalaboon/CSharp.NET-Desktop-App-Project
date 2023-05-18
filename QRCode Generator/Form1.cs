using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCode_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateGridView();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private static string dbPath = @"data source = qrdb.db";

        private void updateGridView()
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection(dbPath);
                con.Open();

                string viewData = "SELECT * FROM QRlogs";
                SQLiteCommand cmd = new SQLiteCommand(viewData, con);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;  // Hide id column
            }
            catch
            {
                MessageBox.Show("ไม่สามารถดึงข้อมูลจากฐานข้อมูลได้ กรุณาตรวจสอบการเชื่อมต่อ", "Notice",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void executeQuery(string query)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection(dbPath);
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    inputQR.Clear();
                    txtNote.Clear();
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                //con.Close();
            }
        }

        private void saveData()
        {
            DateTime myDateTime = dateTimePicker1.Value;
            string sqlDate = myDateTime.ToString("yyyy-MM-dd");

            string save = "INSERT INTO QRlogs (date, Keyword, Link) " +
                          "VALUES ('" + sqlDate + "', '" + txtNote.Text + "', '" + inputQR.Text + "')";

            executeQuery(save);
            updateGridView();
        }

        private void generateQR_Click(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                QRBox.Image = qrCode.Draw(inputQR.Text, 50);

                if (inputQR.Text != "")
                {
                    saveData();
                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลลงในช่อง Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("ข้อมูล Input ต้องไม่เกิน 122 ตัวอักษร\n" +
                                "เป็นข้อจำกัดของตัวเฟรมเวิร์คจ้าา (QRCode Version 7)", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string resultText = "Sodsaisoft Free QRCode Generator - Version 1.02b\n\n" +
                                "QRCode Engine : Zen.Barcode.Rendering.Framework Version 3.1.10729.1\nDatabase : SQLite Version 3.12.2\nDeveloper : Danai Jantapalaboon\n---------------------------------------------------\nโปรแกรมแจกฟรี ห้ามจำหน่าย\n18 พฤษภาคม 2566\nwww.sodsaisoft.com";
            MessageBox.Show(resultText, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //โค้ด Save Image จาก pictureBox
        //link..https://stackoverflow.com/questions/21418238/c-save-image-on-picturebox-into-folder-on-my-computer
        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)   //Save Image จาก Menu FileSave
        {
            SaveImageCapture(QRBox.Image);
        }

        private void saveImage_Click(object sender, EventArgs e)    //Save Image จาก Button
        {
            SaveImageCapture(QRBox.Image);
        }

        private void SaveImageCapture(System.Drawing.Image image) //ส่วนทำงาน Save Image
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Image";
            s.DefaultExt = ".Jpg";
            s.Filter = "Image (.jpg)|*.jpg";

            s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            s.RestoreDirectory = true;
            if (s.ShowDialog() == DialogResult.OK)
            {
                string filename = s.FileName;
                using (System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                {
                    image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fstream.Close();
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputQR.Clear();
            txtNote.Clear();
        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value + string.Empty;
                txtNote.Text = dataGridView1.CurrentRow.Cells[2].Value + string.Empty;
                inputQR.Text = dataGridView1.CurrentRow.Cells[3].Value + string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string txtidSearch = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string delete = "DELETE FROM QRlogs WHERE id = '" + txtidSearch + "'";

                //DialogResult dialog = new DialogResult();
                DialogResult dialog = MessageBox.Show("คุณต้องการลบรายการบันทึกหรือไม่",
                                                      "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    executeQuery(delete);
                }

                updateGridView();

            }
            catch
            {
                MessageBox.Show("ไม่พบข้อมูลในตาราง", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //DialogResult dialog = new DialogResult();

            DialogResult dialog = MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(dbPath);
            con.Open();

            string viewData = "SELECT * FROM QRlogs";
            SQLiteCommand cmd = new SQLiteCommand(viewData, con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            string searchValue = textBoxSearch.Text;
            try
            {
                var re = from row in dataTable.AsEnumerable()
                         where row[2].ToString().Contains(searchValue)
                         select row;
                if (re.Count() == 0)
                {
                    //MessageBox.Show("ไม่พบข้อความที่ท่านค้นหา", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView1.DataSource = re.CopyToDataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
