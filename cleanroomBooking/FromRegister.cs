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

namespace cleanroomBooking
{
    public partial class FromRegister : Form
    {
        public FromRegister()
        {
            InitializeComponent();
        }


        MySqlConnection connection = new MySqlConnection("host = localhost; user = root; password = 1234; database = cleanroom");
        MySqlCommand command;


        public void executeQuery(string query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("บันทึกสำเร็จ",
                                    "Notice",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                                "Notice",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string save = "INSERT INTO cleanroom.tblusername (UserName, Institution) " +
                          "VALUES('" + txtNAME.Text + "', '" + txtINSTITUTE.Text + "')";
            MySqlDataAdapter adapter = new MySqlDataAdapter(save, connection);

            if (txtNAME.Text != "" && txtINSTITUTE.Text != "")
            {
                DialogResult msgResult = MessageBox.Show("คุณต้องการบันทึกข้อมูลใช่หรือไม่",
                                                         "Notice",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                if (msgResult == DialogResult.Yes)
                {
                    executeQuery(save);
                    txtNAME.Clear();
                    txtINSTITUTE.Clear();
                }
            }
            else
            {
                MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ กรุณากรอกข้อมูลให้ครบ",
                                "Notice",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}
