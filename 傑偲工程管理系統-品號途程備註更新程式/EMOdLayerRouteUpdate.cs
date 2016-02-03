using System;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 傑偲工程管理系統_品號途程備註更新程式
{
    public partial class EMOdLayerRouteUpdate : Form
    {
        string FilePath = "";
        string strCon = "server=ERP;database=EW;uid=JSIS;pwd=JSIS";
        string strComm = "";

        public EMOdLayerRouteUpdate()
        {
            InitializeComponent();
            txtFilePath.ReadOnly = true;
            rtbResult.ReadOnly = true;
            dgvLoadData.ReadOnly = true;
        }

        /// <summary>
        /// 檢查使用者上傳的Excel版本，依版本選擇對應的連線字串
        /// </summary>
        /// <param name="filePath">檔案路徑</param>
        /// <returns></returns>
        private string CheckExcelVersion(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            string extension = file.Extension;
            string strConn = "";
            //透過上傳的Excel副檔名來判斷Excel版本，以對應符合版本的連線字串
            switch (extension)
            {
                //Excel2003
                case ".xls":
                    strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath +
                        ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;Readonly=0'";
                    break;

                //Excel2007 Up
                case ".xlsx":
                    strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath +
                        ";Extended Properties='Excel 12.0 Xml;HDR=YES'";
                    break;

                //副檔名都不符合，就套用Excel2003
                default:
                    strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath +
                        ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;Readonly=0'";
                    break;
            }
            return strConn;
        }

        /// <summary>
        /// 取得Excel Sheet名稱並轉為Table
        /// </summary>
        /// <param name="filepath">檔案路徑</param>
        /// <returns></returns>
        private DataTable GetExcelSheetNames(string filepath)
        {
            OleDbConnection Conn = new OleDbConnection(CheckExcelVersion(filepath));
            DataTable dt = new DataTable();
            Conn.Open();
            dt = Conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            Conn.Close();
            return dt;
        }

        /// <summary>
        /// 讀取Excel並轉為Table
        /// </summary>
        /// <param name="filepath">檔案路徑</param>
        /// <param name="load">要執行的OleDB Command</param>
        /// <returns></returns>
        private DataTable GetExcelDataTable(string filepath, string oledbcomm)
        {
            OleDbConnection Conn = new OleDbConnection(CheckExcelVersion(filepath));
            OleDbDataAdapter Load = new OleDbDataAdapter(oledbcomm, Conn);
            DataTable dt = new DataTable();
            Load.Fill(dt);
            Conn.Close();
            return dt;
        }

        /// <summary>
        /// 取得EMOdLayerRoute表的Notes欄位值
        /// </summary>
        /// <param name="PartNum">料號</param>
        /// <param name="Revision">版序</param>
        /// <param name="LayerId">層別</param>
        /// <param name="ProcCode">途層代碼</param>
        /// <returns></returns>
        private string CheckNotes(string PartNum,string Revision,string LayerId,string ProcCode)
        {
            string result = "";
            strComm = "select * from EMOdLayerRoute where PartNum=@PartNum and Revision=@Revision and " +
                "LayerId=@LayerId and ProcCode=@ProcCode";
            using (SqlConnection sqlcon = new SqlConnection(strCon))
            {
                using (SqlCommand sqlcomm = new SqlCommand(strComm, sqlcon))
                {
                    sqlcomm.Parameters.Clear();
                    sqlcomm.Parameters.Add("@PartNum", SqlDbType.Char);
                    sqlcomm.Parameters.Add("@Revision", SqlDbType.Char);
                    sqlcomm.Parameters.Add("@LayerId", SqlDbType.Char);
                    sqlcomm.Parameters.Add("@ProcCode", SqlDbType.Char);
                    sqlcomm.Parameters["@PartNum"].Value = PartNum;
                    sqlcomm.Parameters["@Revision"].Value = Revision;
                    sqlcomm.Parameters["@LayerId"].Value = LayerId;
                    sqlcomm.Parameters["@ProcCode"].Value = ProcCode;
                    try
                    {
                        sqlcon.Open();
                        SqlDataReader read = sqlcomm.ExecuteReader();
                        read.Read();
                        if(read["Notes"].ToString()!="")
                        {
                            result = read.GetString(read.GetOrdinal("Notes"));
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 更新EMOdLayerRoute表的Notes欄位值
        /// </summary>
        /// <param name="PartNum">料號</param>
        /// <param name="Revision">版序</param>
        /// <param name="LayerId">層別</param>
        /// <param name="ProcCode">途層代碼</param>
        /// <param name="Notes">備註</param>
        /// <returns></returns>
        private int UpdateNotes(string PartNum,string Revision,string LayerId,string ProcCode,string Notes)
        {
            int result = 0;
            strComm = "update EMOdLayerRoute set Notes=@Notes where PartNum=@PartNum and Revision=@Revision and " +
                "LayerId=@LayerId and ProcCode=@ProcCode";
            using (SqlConnection sqlcon = new SqlConnection(strCon))
            {
                using (SqlCommand sqlcomm = new SqlCommand(strComm, sqlcon))
                {
                    sqlcomm.Parameters.Clear();
                    sqlcomm.Parameters.Add("@PartNum", SqlDbType.Char);
                    sqlcomm.Parameters.Add("@Revision", SqlDbType.Char);
                    sqlcomm.Parameters.Add("@LayerId", SqlDbType.Char);
                    sqlcomm.Parameters.Add("@ProcCode", SqlDbType.Char);
                    sqlcomm.Parameters.Add("@Notes", SqlDbType.VarChar);
                    sqlcomm.Parameters["@PartNum"].Value = PartNum;
                    sqlcomm.Parameters["@Revision"].Value = Revision;
                    sqlcomm.Parameters["@LayerId"].Value = LayerId;
                    sqlcomm.Parameters["@ProcCode"].Value = ProcCode;
                    sqlcomm.Parameters["@Notes"].Value = Notes;
                    try
                    {
                        sqlcon.Open();
                        result = sqlcomm.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return result;
        }

        private void btnOpenFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog Path = new OpenFileDialog();
            if (Path.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            FilePath = Path.FileName;
            txtFilePath.Text = FilePath;
            string SheetName = "Upload$";
            int SheetNum = 0;
            DataTable dtSheet = GetExcelSheetNames(FilePath);
            //檢查Sheet名稱是否符合規定的名稱格式，若不符就中止程式
            for (int i = 0; i < dtSheet.Rows.Count; i++)
            {
                if (dtSheet.Rows[i]["TABLE_NAME"].ToString() == SheetName)
                {
                    SheetNum++;
                }
            }
            if (SheetNum != 1)
            {
                MessageBox.Show("Excel檔的Sheet名稱錯誤，Sheet名稱應為[Upload]，請檢查！", "提示訊息", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
            //透過SQL語法去撈Excel Sheet資料時，需在Sheet名稱前後補上[]
            string strOleDbComm = "select * from [" + SheetName + "]";
            DataTable LoadData = GetExcelDataTable(FilePath, strOleDbComm);
            dgvLoadData.DataSource = LoadData;
            dgvLoadData.Columns[1].Width = 60;
            dgvLoadData.Columns[2].Width = 60;
            dgvLoadData.Columns[3].Width = 60;
            dgvLoadData.Columns[4].Width = 80;
            dgvLoadData.Columns[5].Width = 100;
            dgvLoadData.Columns[6].Width = 240;
            lblTotalData.Text = "共 " + (dgvLoadData.Rows.Count - 1).ToString() + " 筆。";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (txtFilePath.Text == "")
            {
                MessageBox.Show("尚未選擇要上傳的Excel檔案！", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            for (int i = 0; i < (dgvLoadData.Rows.Count - 1); i++)
            {
                string compare = CheckNotes(
                    dgvLoadData.Rows[i].Cells[0].Value.ToString(),
                    dgvLoadData.Rows[i].Cells[1].Value.ToString(),
                    dgvLoadData.Rows[i].Cells[2].Value.ToString(),
                    dgvLoadData.Rows[i].Cells[4].Value.ToString());
                if (compare == "")
                {
                    total += UpdateNotes(
                        dgvLoadData.Rows[i].Cells[0].Value.ToString(),
                        dgvLoadData.Rows[i].Cells[1].Value.ToString(),
                        dgvLoadData.Rows[i].Cells[2].Value.ToString(),
                        dgvLoadData.Rows[i].Cells[4].Value.ToString(),
                        dgvLoadData.Rows[i].Cells[6].Value.ToString());
                }
                else
                {
                    total += UpdateNotes(
                        dgvLoadData.Rows[i].Cells[0].Value.ToString(),
                        dgvLoadData.Rows[i].Cells[1].Value.ToString(),
                        dgvLoadData.Rows[i].Cells[2].Value.ToString(),
                        dgvLoadData.Rows[i].Cells[4].Value.ToString(),
                        dgvLoadData.Rows[i].Cells[6].Value.ToString() + "，" + compare);
                }
                rtbResult.Text += dgvLoadData.Rows[i].Cells[0].Value.ToString() + "  " +
                    dgvLoadData.Rows[i].Cells[1].Value.ToString() + "  " +
                    dgvLoadData.Rows[i].Cells[2].Value.ToString() + "  " +
                    dgvLoadData.Rows[i].Cells[4].Value.ToString() + "  " +
                    dgvLoadData.Rows[i].Cells[6].Value.ToString() + "，" + compare + "\r\n";
            }
            lblTotalSuccess.Text = "共 " + total + "筆。";
        }
    }
}
