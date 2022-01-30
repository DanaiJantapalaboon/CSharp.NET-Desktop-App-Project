using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
        }

        MySqlConnection connect = new MySqlConnection("host = localhost; user = root; password = 1234; database = qrcodegen");
        MySqlCommand command;

        private void updateGridView()
        {
            try
            {
                string viewData = "SELECT * FROM qrcodegen.tblqrgen";
                MySqlDataAdapter adapter = new MySqlDataAdapter(viewData, connect);

                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
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
                connect.Open();
                command = new MySqlCommand(query, connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    inputQR.Clear();
                    txtNote.Clear();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connect.Close();
            }
        }

        private void saveData()
        {
            DateTime myDateTime = dateTimePicker1.Value;
            string sqlDate = myDateTime.ToString("yyyy-MM-dd");

            string save = "INSERT INTO qrcodegen.tblqrgen (date, Note, Link) " +
                          "VALUES ('" + sqlDate + "', '" + txtNote.Text + "', '" + inputQR.Text + "')";

            executeQuery(save);
            updateGridView();
        }

        private void saveHistory_Click(object sender, EventArgs e)
        {
            saveData();
        }
        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void generateQR_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            QRBox.Image = qrCode.Draw(inputQR.Text, 50);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string resultText = "C# using Zen.Barcode.Rendering.Framework -Version 3.1.10729.1\nUI Designed & Programming by Danai J.";
            MessageBox.Show(resultText, "About QR Code Generator v1.01");
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you want to exit?", "QR Code Generator", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputQR.Clear();
            txtNote.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = txtidSearch.Text;
            dataGridView1.ClearSelection();

            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dataGridView1.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            txtidSearch.Clear();
                            break;
                        }
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + txtidSearch.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtidSearch.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNote.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            inputQR.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM qrcodegen.tblqrgen WHERE id = '"+ txtidSearch.Text +"'";
            executeQuery(delete);
            updateGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateGridView();
        }
    }
}