using ClosedXML.Excel;
using project.Dao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> readFile(string xFilePath)
        {
            
            List<string> lista = new List<string>();

            string[] lines;
            string str;

            if (System.IO.File.Exists(xFilePath))
            {
                lines = System.IO.File.ReadAllLines(xFilePath);
                int a = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    //Console.WriteLine(lines[i]);
                    //if (String.Compare(lines[i], "output:", true)==0)
                    if (lines[i].Equals("OUTPUT:"))
                    {
                        a = i;
                        break;
                    }

                }
                for (int i = 0; i < a; i++)
                {
                    lista.Add(lines[i]);
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            return lista;
        }
        private void btnPaper_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPaper.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCase.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        public void PrintDirectory(string dirPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            List<string> tp = new List<string>();
            DirectoryInfo[] childDirs = dirInfo.GetDirectories();
            for (int i = 0; i < childDirs.Length; i++)
            {
             
            }
        }

        private void InsertStudent(DirectoryInfo[] childDirs,string paper)
        {
            int count = 0;
        
            for (int j = 0; j < childDirs.Length; j++)
            {
                for (int i = 1; i <= 10; i++)
                {   
                   
                    string fullString = childDirs[j].ToString();


                    int index = fullString.LastIndexOf("_");
                    Console.WriteLine(index);
                    string RollName  = fullString.Substring(0, index);
               
                    string name = fullString.Remove(0, index + 1);
                    string noPaper = paper;
                    string NoQuestion = "Q" + i;
                    float Score = 0;
                    ArrayList list = new ArrayList
                    {
                        RollName,name,noPaper,Score,NoQuestion
                    };
                    DB db = new DB();
                    if (AddDetailScore(list) > 0)
                    {
                        count++;
                    }
                }

            }
       
        }
        // cái này tương đương với tổng số bản ghi (file .exe ) mà em chạy :
        int maxximum = 100;

        //bước sóng (bước nhảy) bằng 100 chia tổng số bản ghi (maxximum)
        int eachTime = 0;
        private Timer time = new Timer();
        private void InitializeMyTimer()
        {

            // thời gian nghỉ giữa mỗi lần chạy bước sóng
            time.Interval = 10;
            // Connect the Tick event of the timer to its event handler.
            time.Tick += new EventHandler(IncreaseProgressBar);
            // Start the timer.
            time.Start();

        }
        private void IncreaseProgressBar(object sender, EventArgs e)
        {

            // nếu muốn em muốn truyền bước nhảy của process thì chuyền vào đây
            prssBar.Increment(eachTime);
            // Display the textual value of the ProgressBar in the StatusBar control's first panel.
            lblProcess.Text = prssBar.Value.ToString() + "% Completed";

            // Determine if we have completed by comparing the value of the Value property to the Maximum value.
            //if (progressBar1.Value == progressBar1.Maximum)
            if (timestop >= maxximum)
                // Stop the timer.
                time.Stop();
        }
        int timestop = 0;

        private void btnRun_Click(object sender, EventArgs e)
        {
            prssBar.Maximum = 100;
            prssBar.Minimum = 0;
            if (txtCase.Text.Length == 0||txtPaper.Text.Length==0)
            {
                MessageBox.Show("Chọn Folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string folder = txtPaper.Text;
                DirectoryInfo dirInfo = new DirectoryInfo(folder);
                List<string> tp = new List<string>();
                DirectoryInfo[] childDirs = dirInfo.GetDirectories();
                //   InsertStudent(childDirs);
                // add student to db
                int lanchay = 100 / childDirs.Length;
                //InitializeMyTimer();
                for (int i = 0; i < childDirs.Length; i++)
                {
                    lblProcess.Text = prssBar.Value.ToString() + "%";
                    prssBar.Value = (i+1)*lanchay;
                    
                    string fileStudent = childDirs[i].ToString();
                    string foderStudent = folder + "\\" + fileStudent;
                    xulyfolderStudent(foderStudent, fileStudent, "\\run");
                }
                if (prssBar.Value==100)
                {
                    lblProcess.Text = prssBar.Value.ToString()+ "% Completed";
                }

                btnExport.Enabled = true;
            }
        }



        private void xulyfolderStudent(string folderPaper, string paper,string type)
        {
            string folder = folderPaper;
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            List<string> tp = new List<string>();
            DirectoryInfo[] childDirs = dirInfo.GetDirectories();
            InsertStudent(childDirs,paper);
            for (int i = 0; i < childDirs.Length; i++)
            {
                string fileQuest = "";// = folder + "\\" + childDirs[i] + "\\Q" + i + ".exe";
                                      //  lstPaper.Items.Add(fileQuest);
                for (int j = 1; j < 11; j++)
                {
                    if (type.Equals("\\src"))
                    { string fileSrc = folder + "\\" + childDirs[i] + "\\Q" + j + type;
                        string Q = "Q" + j;
                        runFileC(fileSrc, Q);
                    }
                    fileQuest = folder + "\\" + childDirs[i] + "\\Q" + j + type + "\\Q" + j + ".exe";
               
                    if (System.IO.File.Exists(fileQuest))
                    {
                        string fullString = childDirs[i].ToString();
                        int index = fullString.LastIndexOf("_");
                        string RollName = fullString.Substring(0, index);
                        string Studentname= fullString.Remove(0, index + 1);
                     
                        XulyDauVao(fileQuest, j.ToString(),RollName, paper,Studentname);
                    }
                    else
                    {
                        // input database để không điểm 
                    }
                }
            }

        }
        private int AddDetailScore(ArrayList list)
        {
           
            DB db = new DB();
            string sql = "INSERT INTO StudentScore VALUES(@RollName,@name,@noPaper,@Score,@NoQuestion)";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@RollName", SqlDbType.VarChar),
                new SqlParameter("@name", SqlDbType.VarChar),
                new SqlParameter("@noPaper", SqlDbType.VarChar),
                new SqlParameter("@Score", SqlDbType.Float),
                  new SqlParameter("@NoQuestion", SqlDbType.VarChar)

            };

            for (int i = 0; i < list.Count; i++)
            {
                parameters[i].Value = list[i];
            }
            return db.ExecuteSQL(sql, parameters);

        }
        private void XulyDauVao(string fileQuest, string question, string rollname, string paper,string Studentname)
        {
            string folder = txtCase.Text + "\\" + paper + "\\Q" + question;
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            List<string> tp = new List<string>();
            FileInfo[] childDirs = dirInfo.GetFiles();
          
            for (int j = 0; j < childDirs.Length; j++)
            {
                string filePathCase = folder + "\\tc" + (j + 1) + ".txt";
          
                List<string> lista = readFile(filePathCase);
                Process cmd = new Process();
                cmd.StartInfo.FileName = fileQuest;
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                for (int i = 0; i < lista.Count; i++)
                {
                    cmd.StandardInput.WriteLine(lista[i]);
                    cmd.StandardInput.Flush();
                }
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                textBox1.Text = cmd.StandardOutput.ReadToEnd();
                string a = textBox1.Text;
                textBox1.Text = a;
                string[] output = a.Split('\n');
                TachOutputStudent(output, filePathCase, j.ToString(), question, rollname,Studentname);

            }
        }

        private void Mark(Boolean checkTestCase, string testcase, string NoQuestion, string RollName, string fileTestCase,string StudentName)
        {
            if (checkTestCase == true)
            {
                string[] lines;
                string str;

                if (System.IO.File.Exists(fileTestCase))
                {
                    NoQuestion = "Q" + NoQuestion;
                    lines = System.IO.File.ReadAllLines(fileTestCase);
                    float mark = float.Parse(lines[lines.Length - 1].Trim());
                    //update điểm    
                    float Score = GetScore(RollName, NoQuestion);
             

                    Score = Score + mark;
                    ArrayList list = new ArrayList { Score, RollName, NoQuestion };
                    if (Update(list) > 0)
                    {

                    }
                }
            }
            else
            {


            }


        }

        internal int Update(ArrayList list)
        {
            DB db = new DB();
            string sql = "UPDATE StudentScore SET Score = @Score  Where RollName = @RollName and NoQuestion = @NoQuestion";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Score", SqlDbType.Float),
                        new SqlParameter("@RollName", SqlDbType.NVarChar),
                         new SqlParameter("@NoQuestion", SqlDbType.NVarChar)
            };

            // Gán giá trị cho các tham số trước khi thực thi truy vấn
            for (int i = 0; i < list.Count; i++)
            {
             
                parameters[i].Value = list[i];
            }

            return db.ExecuteSQL(sql, parameters);
        }


        internal float GetScore(string rollName, string noQuestion)
        {
            DB db = new DB();
            string sql = "Select Score from StudentScore where RollName = '" + rollName + "' and NoQuestion = '" + noQuestion + "'";
            DataTable dt = db.getDatabase(sql);
            return float.Parse(dt.Rows[0]["Score"].ToString());
        }








        public string[] subArrStrFromFile(string filePath)
        {


            string[] lines = new string[10];
            string str = "";
            string[] result = new string[10];
            int a = 0;
            int b = 0;
            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    //Console.WriteLine(lines[i]);
                    //if (String.Compare(lines[i], "output:", true)==0)
                    if (lines[i].Equals("OUTPUT:"))
                    {
                        a = i;


                    }
                    if (lines[i].Equals("mark:"))
                    {
                        b = i;


                        break;
                    }

                }
                for (int i = a + 1; i < b; i++)
                {


                    result[i] = lines[i];


                }


            }
            else
            {
                //Console.WriteLine("File does not exist");
                return null;
            }


            string[] resutlFinal = new string[b - a - 1];
            for (int i = 0; i < result.Length; i++)
            {

                Array.Copy(result, a + 1, resutlFinal, 0, b - a - 1);

            }


            return resutlFinal;
        }





        public bool checkMark(string pathPaper, string[] resultComplie)
        {
            string[] resultTestCase = subArrStrFromFile(pathPaper);


            if (resultTestCase.Length+1 == resultComplie.Length)
            {
               // txtImhear.Text = "da tung o day";
                //if (resultTestCase.SequenceEqual(resultComplie))
                //{

                //    return true;
                //}

                for (int i = 0; i < resultTestCase.Length; i++)
                {

                    if (!resultTestCase[i].TrimEnd().Equals(resultComplie[i].TrimEnd()))
                    {
                       // txtLenght.Text = resultTestCase[i];
                        //txtLengCase.Text = resultComplie[i];
                    
                        return false;
                    }

                }
                return true;
            }
            else
            {
     
                return false;
            }

            return false;

        }









        private void TachOutputStudent(string[] output, string filePathCase, string testcase, string question, string rollname,string Studentname)
        {
            Boolean CheckTestCase = false;


            string[] line = new string[output.Length];
            int a = -1;
            


            for (int i = 0; i < output.Length; i++)
            {
                //Console.WriteLine(lines[i]);
                //if (String.Compare(lines[i], "output:", true)==0)
                if (output[i].Trim().Equals("OUTPUT:"))
                {
                    a = i;
                    break;
                }

            }
            // txtTrueFalse.Text = a.ToString();
            if (a == -1)
            {

                CheckTestCase = false;
                Mark(CheckTestCase, testcase, question, rollname, filePathCase,Studentname);

            }

            else
            {
                //for (int i = a + 1; i < output.Length; i++)
                //{
                //    line[i]=output[i].Trim();
                //}
                string[] resutlFinal = new string[output.Length - a - 1];
                for (int i = 0; i < output.Length; i++)
                {

                    Array.Copy(output, a + 1, resutlFinal, 0, output.Length - a - 1);
                }
                // txtLenght.Text = resutlFinal.Length.ToString();
                //for (int i = 0; i < resutlFinal.Length; i++)
                //{

                //    txtLenght.Text += resutlFinal[i];
                //}
               
                // check mark o day
                CheckTestCase = checkMark(filePathCase, resutlFinal);
             
                Mark(CheckTestCase, testcase, question, rollname, filePathCase,Studentname);


            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DB db = new DB();
            sfd.Filter = "ExcelFile|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sql = "with t1 as(select*from(select * from StudentScore )" +
                        "src pivot(sum(Score) for NoQuestion in ([Q1],[Q2],[Q3],[Q4],[Q5],[Q6],[Q7],[Q8],[Q9],[Q10])) piv) " +
                        "select t.RollName, t.StudentName ,t.NoPaper,concat_ws(' ; ', (CONCAT('Q1=', Round(coalesce(t.Q1,0),2))),CONCAT('Q2=', " +
                        "Round(coalesce(t.Q2,0),2)),CONCAT('Q3=',  Round(coalesce(t.Q3,0),2)),CONCAT('Q4=',  Round(coalesce(t.Q4,0),2)), CONCAT('Q5=', " +
                        "Round(coalesce(t.Q5,0),2)),CONCAT('Q6=',  Round(coalesce(t.Q6,0),2)),CONCAT('Q7=',  Round(coalesce(t.Q7,0),2)), CONCAT('Q8=',  Round(coalesce(t.Q8,0),2)),CONCAT('Q9=',  " +
                        "Round(coalesce(t.Q9,0),2)),CONCAT('Q10=', Round(coalesce(t.Q10,0),2))) as Detail,((ROUND(coalesce(t.Q1,0),2))+(ROUND(coalesce(t.Q2,0),2))+(ROUND(coalesce(t.Q3,0),2))+(ROUND(coalesce(t.Q4,0),2))+(ROUND(coalesce(t.Q5,0),2))+(ROUND(coalesce(t.Q6,0),2))+" +
                        "(ROUND(coalesce(t.Q7,0),2))+(ROUND(coalesce(t.Q8,0),2))+(ROUND(coalesce(t.Q9,0),2))+(ROUND(coalesce(t.Q10,0),2)))as TotalMark from t1 as t";
                    DataTable dt = db.getDatabase(sql);
                    dt.TableName = "name";
                    XLWorkbook work = new XLWorkbook();
                    work.Worksheets.Add(dt);
                    work.SaveAs(sfd.FileName);
                    MessageBox.Show("Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            db.ExecuteSQL("Delete from StudentScore");
            prssBar.Value = 0;
            lblProcess.Text = "0%";
        }

        private void prssBar_Click(object sender, EventArgs e)
        {

        }
        private void runFileC(string file, string Question)
        {
            string fileC = file + "\\" + Question + ".c";
            if (System.IO.File.Exists(fileC))
            {
                string cdFile = "cd /d " + file;
                string Q = "gcc " + Question + ".c -o " + Question;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "CMD";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine(cdFile);
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine(Q);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }
        }



        private void btnSrc_Click(object sender, EventArgs e)
        {
            prssBar.Maximum = 100;
            prssBar.Minimum = 0;
            if (txtCase.Text.Length == 0 || txtPaper.Text.Length == 0)
            {
                MessageBox.Show("Chọn Folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { string folder = txtPaper.Text;
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            List<string> tp = new List<string>();
            DirectoryInfo[] childDirs = dirInfo.GetDirectories();
                //   InsertStudent(childDirs);
                // add student to db
                int lanchay = 100 / childDirs.Length;
                //InitializeMyTimer();
                for (int i = 0; i < childDirs.Length; i++)
            {
                    lblProcess.Text = prssBar.Value.ToString() + "%";
                    prssBar.Value = (i + 1) * lanchay;
                    string fileStudent = childDirs[i].ToString();
                string foderStudent = folder + "\\" + fileStudent;
                xulyfolderStudent(foderStudent, fileStudent, "\\src");
            }
                if (prssBar.Value == 100)
                {
                    lblProcess.Text = prssBar.Value.ToString() + "% Completed";
                }

                btnExport.Enabled = true;
        }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}