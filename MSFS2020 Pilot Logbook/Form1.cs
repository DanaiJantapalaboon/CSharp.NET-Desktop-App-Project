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
using System.IO;
using ClosedXML.Excel;

namespace MSFS2020_Pilot_Logbook
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
            loadPicture();
        }

        MySqlConnection conn = new MySqlConnection("host = localhost; user = root; password = 1234; database = flightlog");
        MySqlCommand command;

        public void loadPicture()
        {
            conn.Open();

            //Retrieve BLOB from database into DataSet.
            command = new MySqlCommand("SELECT Photos FROM flightlog.tblpilot WHERE id = 3", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "flightlog.tblpilot");

            int c = ds.Tables["flightlog.tblpilot"].Rows.Count;

            if (c > 0)
            {
                //BLOB is read into Byte array, then used to construct MemoryStream,
                //then passed to PictureBox.
                Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])(ds.Tables["flightlog.tblpilot"].Rows[c - 1]["Photos"]);
                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                pictureBox1.Image = Image.FromStream(stmBLOBData);
            }
            conn.Close();
        }

        public void updateGridView()
        {
            try
            {
                string viewTable = "SELECT * FROM flightlog.tblflightlog";
                MySqlDataAdapter adapterTable = new MySqlDataAdapter(viewTable, conn);

                DataTable table = new DataTable();
                    adapterTable.Fill(table);
                    gridView.DataSource = table;
                    lbltotFlight.Text = "Total Flight : " + table.Rows.Count.ToString();


                string viewCbb = "SELECT plane FROM flightlog.tblplane";
                MySqlDataAdapter adapterCbb = new MySqlDataAdapter(viewCbb, conn);

                DataTable cbb = new DataTable();
                    adapterCbb.Fill(cbb);
                    cbbPlane.DisplayMember = "plane";
                    cbbPlane.DataSource = cbb;

                //show PilotData
                string viewCbbPilot = "SELECT * FROM flightlog.tblpilot";
                MySqlDataAdapter adapterCbbPilot = new MySqlDataAdapter(viewCbbPilot, conn);

                DataTable cbbPl = new DataTable();
                    adapterCbbPilot.Fill(cbbPl);
                    cbbPl.Columns.Add("FullName", typeof(string), "Name + ' ' + Lastname");
                    cbbPilot.DisplayMember = "Fullname";
                    cbbPilot.DataSource = cbbPl;
                    lblPilotName.Text = cbbPilot.Text + " Logbook";

                string myDOB = Convert.ToDateTime(cbbPl.Rows[0]["DOB"]).ToString("dd/MM/yyyy");
                lblDOB.Text = "Date of Birth : " + myDOB;
                lblAge.Text = "Age : " + cbbPl.Rows[0]["Age"];
                lblGender.Text = "Gender : " + cbbPl.Rows[0]["Gender"];
                //End

                //Sum Flight Time
                TimeSpan sum;
                TimeSpan totFltTime = TimeSpan.Parse("00:00:00");

                for (int i = 0; i < gridView.Rows.Count - 1; i++)
                {
                    string time = Convert.ToString(gridView.Rows[i].Cells[14].Value);
                    sum = TimeSpan.Parse(time);
                    totFltTime = totFltTime.Add(sum);
                }
                lblTotFltTime.Text = "Total Flight Time : " + totFltTime.ToString();

                //Sum Takeoff Day
                int sumTODay = 0;
                for (int i = 0; i <= gridView.Rows.Count - 1; i++)
                {
                    sumTODay = sumTODay + Convert.ToInt32(gridView.Rows[i].Cells[10].Value);
                }
                lblSumTODay.Text = "Takeoffs DAY : " + sumTODay.ToString();

                //Sum Landing Day
                int sumLDGDay = 0;
                for (int i = 0; i <= gridView.Rows.Count - 1; i++)
                {
                    sumLDGDay = sumLDGDay + Convert.ToInt32(gridView.Rows[i].Cells[12].Value);
                }
                lblSumLDGDay.Text = "Landings DAY : " + sumLDGDay.ToString();

                //Sum Takeoff Night
                int sumTONight = 0;
                for (int i = 0; i <= gridView.Rows.Count - 1; i++)
                {
                    sumTONight = sumTONight + Convert.ToInt32(gridView.Rows[i].Cells[11].Value);
                }
                lblSumTONight.Text = "Takeoffs NIGHT : " + sumTONight.ToString();

                //Sum Landing Night
                int sumLDGNight = 0;
                for (int i = 0; i <= gridView.Rows.Count - 1; i++)
                {
                    sumLDGNight = sumLDGNight + Convert.ToInt32(gridView.Rows[i].Cells[13].Value);
                }
                lblSumLDGNight.Text = "Landings NIGHT : " + sumLDGNight.ToString();

                //Sum Distance
                decimal sumDistance = 0;
                for (int i = 0; i <= gridView.Rows.Count - 1; i++)
                {
                    sumDistance = sumDistance + Convert.ToDecimal(gridView.Rows[i].Cells[9].Value);
                }
                lblSumDistance.Text = "Distance : " + sumDistance.ToString() + " nm";
            }

            catch (Exception e)
            {
                MessageBox.Show(e+"Database offline, Please check your connection", "MSFS2020 Pilot Logbook");
            }
        }

        private void executeQuery(string query)
        {
            try
            {
                conn.Open();
                command = new MySqlCommand(query, conn);

                if (command.ExecuteNonQuery() == 1)
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            //DATE
            DateTime myFltDate = fltDate.Value;
            string sqlDate = myFltDate.ToString("yyyy:MM:dd"); //Convert SQL Date

            //DEPARTURE TIME
            DateTime myDeptTime = deptTime.Value;
            string sqldeptTime = myDeptTime.ToString("hh:mm:ss"); //Convert SQL Departure Time

            //ARRIVAL TIME
            DateTime myArrTime = ArrTime.Value;
            string sqlarrTime = myArrTime.ToString("hh:mm:ss"); //Convert SQL Arrival Time

            //FLIGHT TIME Calculation
            TimeSpan fltTime = myArrTime - myDeptTime;

            try
            {
                if (txtDeptPlace.Text == "")
                {
                    MessageBox.Show("Please enter your departure airport.", "Error");
                }

                else if (txtArrPlace.Text == "")
                {
                    MessageBox.Show("Please enter your arrival airport.", "Error");
                }

                else
                {
                    string append = "INSERT INTO flightlog.tblflightlog (Date, FltNo, Type, Plane, DeptTime, DeptPlace, ArrTime, ArrPlace, TODay, TONight, LDGDay, LDGNight, FLTTime, Note)" +
                                    "VALUES ('" + sqlDate + "' , '" + txtFltNo.Text + "', '" + cbbType.Text + "', '" + cbbPlane.Text + "', '" + sqldeptTime + "', '" + txtDeptPlace.Text + "', '" + sqlarrTime + "', '" + txtArrPlace.Text + "', '" + txtTODay.Text + "', '" + txtTONight.Text + "', '" + txtLDGDay.Text + "', '" + txtLDGNight.Text + "', '" + fltTime + "', '" + txtNotes.Text + "')";

                    executeQuery(append);
                    updateGridView();
                }
            }
            catch
            {
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            //string update = "UPDATE flightlog.tblflightlog SET Date WHERE id = '" + txtid.Text + "';
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void gridView_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = gridView.CurrentRow.Cells[0].Value.ToString();
            fltDate.Text = gridView.CurrentRow.Cells[1].Value.ToString();
            txtFltNo.Text = gridView.CurrentRow.Cells[2].Value.ToString();
            cbbType.Text = gridView.CurrentRow.Cells[3].Value.ToString();
            cbbPlane.Text = gridView.CurrentRow.Cells[4].Value.ToString();
            deptTime.Text = gridView.CurrentRow.Cells[5].Value.ToString();
            txtDeptPlace.Text = gridView.CurrentRow.Cells[6].Value.ToString();
            ArrTime.Text = gridView.CurrentRow.Cells[7].Value.ToString();
            txtArrPlace.Text = gridView.CurrentRow.Cells[8].Value.ToString();
            txtTODay.Text = gridView.CurrentRow.Cells[10].Value.ToString();
            txtTONight.Text = gridView.CurrentRow.Cells[11].Value.ToString();
            txtLDGDay.Text = gridView.CurrentRow.Cells[12].Value.ToString();
            txtLDGNight.Text = gridView.CurrentRow.Cells[13].Value.ToString();
            txtNotes.Text = gridView.CurrentRow.Cells[15].Value.ToString();
        }

        private void exportxlsxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exportData = "SELECT * FROM flightlog.tblflightlog";
            MySqlDataAdapter adapter = new MySqlDataAdapter(exportData, conn);

            DataTable exportTable = new DataTable();
            adapter.Fill(exportTable);
            gridView.DataSource = exportTable;

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(exportTable, "flightlog.tblflightlog");
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
    }
}
