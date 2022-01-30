using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;
using ClosedXML.Excel;

namespace cleanroomBooking
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            FromRegister f2 = new FromRegister();
            f2.Show();
        }

        private void menuAddAccount_Click(object sender, EventArgs e)
        {
            FromRegister f2 = new FromRegister();
            f2.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delData();
        }

        private void menuDelData_Click(object sender, EventArgs e)
        {
            delData();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult msgExit = MessageBox.Show("ต้องการออกจากโปรแกรมใช่หรือไม่",
                                                   "Notice",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (msgExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            exportExcel();
        }

        private void menuExportExcel_Click(object sender, EventArgs e)
        {
            exportExcel();
        }


        MySqlConnection connection = new MySqlConnection("host = localhost; user = root; password = 1234; database = cleanroom");
        MySqlCommand command;

        public void updateGridView()
        {
            try
            {
                //openConnection();
                string viewData = "SELECT * FROM cleanroom.tblbooking";
                MySqlDataAdapter adapter = new MySqlDataAdapter(viewData, connection);

                DataTable table = new DataTable();
                adapter.Fill(table);
                gridBooking.DataSource = table;


                //closeConnection();
                string viewDataCbb = "SELECT * FROM cleanroom.tblusername";
                MySqlDataAdapter adapterCbb = new MySqlDataAdapter(viewDataCbb, connection);

                DataTable tableCbb = new DataTable();
                adapterCbb.Fill(tableCbb);
                cbbNAME.DisplayMember = "UserName";
                cbbNAME.DataSource = tableCbb;
            }

            catch (Exception)
            {
                MessageBox.Show("ไม่สามารถดึงข้อมูลจากฐานข้อมูลได้ กรุณาตรวจสอบการเชื่อมต่อ",
                                "Notice",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }

        public void executeQuery(string query)
        {
            try
            {
                connection.Open();

                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    txtPURPOSE.Clear();
                }
                else
                {
                    MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ กรุณาตรวจสอบอีกครั้ง",
                                    "Notice",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ห้องไม่ว่างหรือบันทึกวันซ้ำ กรุณาเลือกวันใหม่",
                                "Notice",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }

            finally
            {
                connection.Close();
            }

        }

        private void saveData()
        {

            DateTime myDateTime = selectedDateTime.Value;
            string sqlDate = myDateTime.ToString("yyyy-MM-dd");

            if (cbbROOM.Text == "Lab A")
            {
                string save = "INSERT INTO cleanroom.tblbooking (Name, Room, LabA, Purpose) " +
                              "VALUES ('" + cbbNAME.Text + "','" + cbbROOM.Text + "', '" + sqlDate + "', '" + txtPURPOSE.Text + "')";

                MySqlDataAdapter adapter = new MySqlDataAdapter(save, connection);

                DialogResult msgResult = MessageBox.Show("คุณต้องการบันทึกข้อมูลใช่หรือไม่",
                                                         "Notice",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (msgResult == DialogResult.Yes)
                {
                    executeQuery(save);
                    updateGridView();
                }
            }

            else if (cbbROOM.Text == "Lab B")
            {
                string save = "INSERT INTO cleanroom.tblbooking (Name, Room, LabB, Purpose) " +
                              "VALUES ('" + cbbNAME.Text + "', '" + cbbROOM.Text + "', '" + sqlDate + "', '" + txtPURPOSE.Text + "')";

                MySqlDataAdapter adapter = new MySqlDataAdapter(save, connection);

                DialogResult msgResult = MessageBox.Show("คุณต้องการบันทึกข้อมูลใช่หรือไม่",
                                         "Notice",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

                if (msgResult == DialogResult.Yes)
                {
                    executeQuery(save);
                    updateGridView();
                }
            }

            else if (cbbROOM.Text == "Lab C")
            {
                string save = "INSERT INTO cleanroom.tblbooking (Name, Room, LabC, Purpose) " +
                              "VALUES ('" + cbbNAME.Text + "', '" + cbbROOM.Text + "', '" + sqlDate + "', '" + txtPURPOSE.Text + "')";

                MySqlDataAdapter adapter = new MySqlDataAdapter(save, connection);

                DialogResult msgResult = MessageBox.Show("คุณต้องการบันทึกข้อมูลใช่หรือไม่",
                                         "Notice",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

                if (msgResult == DialogResult.Yes)
                {
                    executeQuery(save);
                    updateGridView();
                }
            }

            else
            {
                MessageBox.Show("กรุณาเลือกห้องที่ต้องการใช้",
                                "Notice",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }

        private void delData()
        {
            string delete = "DELETE FROM cleanroom.tblbooking WHERE id = '" + txtID.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(delete, connection);

            DialogResult msgResult = MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่",
                                                     "Notice",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (msgResult == DialogResult.Yes)
            {
                executeQuery(delete);
                updateGridView();
                txtID.Clear();
            }
        }

        private void gridBooking_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = gridBooking.CurrentRow.Cells[0].Value.ToString();
            cbbNAME.Text = gridBooking.CurrentRow.Cells[1].Value.ToString();
            cbbROOM.Text = gridBooking.CurrentRow.Cells[2].Value.ToString();
            txtPURPOSE.Text = gridBooking.CurrentRow.Cells[6].Value.ToString();

            string selDateTime1 = gridBooking.CurrentRow.Cells[3].Value.ToString(); //106
            string selDateTime2 = gridBooking.CurrentRow.Cells[4].Value.ToString(); //304
            string selDateTime3 = gridBooking.CurrentRow.Cells[5].Value.ToString(); //StemCell

            if (selDateTime1 != "")
            {
                selectedDateTime.Text = selDateTime1;
                btn106.BackColor = Color.Red;
                btn304.BackColor = default(Color);
                btnStemCell.BackColor = default(Color);

                btn106.Text = "ผู้จองห้อง: " + cbbNAME.Text + "\n" +
                              "ห้องที่ใช้ : " + cbbROOM.Text + "\n" +
                              "วันที่ใช้ : " + selectedDateTime.Text + "\n" +
                              "วัตถุประสงค์ : " + txtPURPOSE.Text;

                btn304.Text = "Lab B \n ว่าง";
                btnStemCell.Text = "Lab C \n ว่าง";
            }

            else if (selDateTime2 != "")
            {
                selectedDateTime.Text = selDateTime2;
                btn304.BackColor = Color.Red;
                btn106.BackColor = default(Color);
                btnStemCell.BackColor = default(Color);

                btn304.Text = "ผู้จองห้อง: " + cbbNAME.Text + "\n" +
                              "ห้องที่ใช้ : " + cbbROOM.Text + "\n" +
                              "วันที่ใช้ : " + selectedDateTime.Text + "\n" +
                              "วัตถุประสงค์ : " + txtPURPOSE.Text;

                btn106.Text = "Lab A \n ว่าง";
                btnStemCell.Text = "Lab C \n ว่าง";
            }

            else
            {
                selectedDateTime.Text = selDateTime3;
                btnStemCell.BackColor = Color.Red;
                btn304.BackColor = default(Color);
                btn106.BackColor = default(Color);

                btnStemCell.Text = "ผู้จองห้อง: " + cbbNAME.Text + "\n" +
                                   "ห้องที่ใช้ : " + cbbROOM.Text + "\n" +
                                   "วันที่ใช้ : " + selectedDateTime.Text + "\n" +
                                   "วัตถุประสงค์ : " + txtPURPOSE.Text;

                btn106.Text = "Lab A \n ว่าง";
                btn304.Text = "Lab B \n ว่าง";
            }
        }

        private void exportExcel() // References Code. https://www.youtube.com/watch?v=ySkUEhNu4t4
        {
            string exportData = "SELECT * FROM cleanroom.tblbooking";
            MySqlDataAdapter adapter = new MySqlDataAdapter(exportData, connection);

            DataTable exportTable = new DataTable();
            adapter.Fill(exportTable);
            gridBooking.DataSource = exportTable;

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(exportTable, "cleanroom.tblbooking");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("ส่งออกไฟล์ excel สำเร็จ",
                                        "Notice",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                                        "Notice",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Laboratory Booking System v1.00 Programming by Danai J. \n   - Written using C# Windows Form Apps \n   - MySql Database \n   - ClosedXML library \n   - 26 Oct 2021", "About");
        }
    }
}