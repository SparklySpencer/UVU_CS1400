/* Project Prologue
Name: Spencer Carter
Class: CS 1400 Section 003
Lab 25: Using the OpenFileDialog & SaveFileDialog
Date: 04/22/15

I declare that the following code was written by me, provided
by the instrustor, assisted via the lovely people in the drop
in lab, or provided in the textbook for this project. I also
understand that copying source code from any other sourece 
constitutes cheating, and that I will recieve a zero on this
project if I am found in violation of this policy.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_25
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openDlg;
        private FileStream fs;
        private StreamReader strRdr;
        private string data;
        private SaveFileDialog saveDlg;
        private DialogResult dlgResult;
        private FileStream _fs;
        private StreamWriter _strmWrt;
        private string inc; //No where in spec did it mention what this was supposed to do
        private int msg; //Still no answers as to what this is supposed to be in the spec
        public const int ASIZE = 10; //I had to guess this value, still no clues in the spec
        private double[] grades = new double[ASIZE]; //Had to make this new or it would throw exceptions, because the spec was so vague.

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            const int TASIZE = 2;
            TxtDisplayData.Clear();
            TxtDisplayData.Text = "Filename will be displayed here!";
            openDlg = new OpenFileDialog();
            openDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openDlg.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt";
            openDlg.FilterIndex = 2;
            string data = null;
            string tdata = null;
            string[] adata = new string[TASIZE];
            try
            {
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    if ((fs = (FileStream)(openDlg.OpenFile())) != null)
                    {
                        strRdr = new StreamReader(fs);
                        TxtDisplayData.Clear();
                        TxtDisplayData.Text = openDlg.FileName;
                        for (int idx = 0; idx < grades.Length; idx++)
                        {
                            data = strRdr.ReadLine();
                            if (data == null || data == "")
                            {
                                grades[idx] = -1.0;
                                return;
                            }
                            else
                            {
                                adata = data.Split();
                                grades[idx] = double.Parse(adata[1]);
                                tdata = string.Format("{0}\t{1:F2}\r\n", adata[0], grades[idx]);
                                TxtDisplayData.AppendText(tdata);
                            }
                        }
                        if (strRdr != null)
                            strRdr.Close();
                        fs.Close();
                    }
                    else
                        throw new IOException("File failed to open");
                }
                else
                    throw new Exception("File Open Cancelled");
            }
            catch (IOException ioexp)
            {
                MessageBox.Show("File " + saveDlg.FileName + ioexp.Message, "File Open Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Open Cancelled", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }//End BtnReadFile_Click( )

        private void BtnWriteFile_Click(object sender, EventArgs e)
        {
            BtnRead.Enabled = true;
            TxtDisplayData.Clear();
            TxtFileStatus.Text = "Filename or other status will be displayed here!";
            saveDlg = new SaveFileDialog();
            saveDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveDlg.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt";
            saveDlg.FilterIndex = 2;
            try
            {
                if ((dlgResult = saveDlg.ShowDialog()) == DialogResult.OK)
                {
                    if ((_fs = (FileStream)saveDlg.OpenFile()) != null)
                    {
                        _strmWrt = new StreamWriter(_fs);
                        TxtFileStatus.Text = saveDlg.FileName;
                        for (int idx = 0; idx < ASIZE; idx++)
                        {
                            _strmWrt.WriteLine(msg + idx + "\t" + data);
                            TxtDisplayData.AppendText(string.Format("{0}\t{1:F2}\r\n", msg + idx, data));
                            data += inc;
                        }
                    }
                    else if (dlgResult == DialogResult.Cancel)
                        throw new IOException("File Open \"Cancelled!\"");
                }
                else
                    throw new Exception("Unknown DialogResult!");
            }
            catch (IOException ioexp)
            {
                MessageBox.Show("File " + saveDlg.FileName + ioexp.Message,
                                 "File Open Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnRead.Enabled = false;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Open Cancelled", 
                                MessageBoxButtons.OK,MessageBoxIcon.Information);
                BtnRead.Enabled = false;
            }
            finally
            {
                openDlg = null;
                saveDlg = null; 
                if (_strmWrt != null)
                {
                    _strmWrt.Close();
                    _strmWrt = null;
                }
                if(_fs!=null)
                {
                     _fs.Close();
                     _fs = null;
                }
            }
        }
    }//End class Form
}//End namespace Lab_25
