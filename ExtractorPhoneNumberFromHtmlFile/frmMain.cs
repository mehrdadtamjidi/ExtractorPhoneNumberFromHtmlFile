using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExtractorPhoneNumberFromHtmlFile
{
    public partial class frmMain : Form
    {
        string htmlString = "";
        string fileName = "";
        List<string> FilePath;
        SaveFileDialog f;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoadContact_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "html files|*.html|txt files|*.txt|All files (*.*)|*.*";
            open.Multiselect = true;
            FilePath = new List<string>();
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in open.FileNames)
                {
                    FilePath.Add(file);
                }

                lblCountFile.Text = FilePath.Count.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (FilePath.Count > 0)
            {
                bgwExtractor.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please select File");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            f = new SaveFileDialog();
            f.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            f.ShowDialog();

            string textout = "";

            // assume the li is a string - will fail if not
            foreach (string li in lbPhoneNumberList.Items)
            {
                textout = textout + li + Environment.NewLine;
            }

            File.WriteAllText(f.FileName, textout);
            lbPhoneNumberList.Items.Clear();
            _lblCount.Text = lbPhoneNumberList.Items.Count.ToString();
            MessageBox.Show("all saved!", "Message");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbPhoneNumberList.SelectedIndex != -1)
            {
                lbPhoneNumberList.Items.RemoveAt(lbPhoneNumberList.SelectedIndex);
                _lblCount.Text = (lbPhoneNumberList.Items.Count).ToString();
            }
            else
                MessageBox.Show("the item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbPhoneNumberList.Items.Clear();
            _lblCount.Text = lbPhoneNumberList.Items.Count.ToString();
        }

        private void bgwExtractor_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int i = 1;
            List<string> mobile = new List<string>();
            foreach (var path in FilePath)
            {
                StreamReader read = new StreamReader(path);

                if (Path.GetExtension(path).ToLower().Contains(".html"))
                {
                    htmlString = read.ReadToEnd();

                    lblLoadMessage.Invoke((MethodInvoker)delegate
                    {
                        lblLoadMessage.Text = string.Format("File{0} - {1} is load", i.ToString(), Path.GetFileName(path));
                    });

                    fileName = Path.GetFileName(path);
                    read.Close();

                    HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
                    html.OptionOutputAsXml = true;
                    html.LoadHtml(htmlString);
                    HtmlNode document = html.DocumentNode;

                    foreach (HtmlNode link in document.SelectNodes("//a[@href]"))
                    {
                        HtmlAttribute att = link.Attributes["href"];
                        string hrefValue = att.Value;
                        lbPhoneNumberList.Invoke((MethodInvoker)delegate
                        {
                            if (hrefValue.Contains("tel"))
                            {
                                hrefValue = hrefValue.Replace("tel:", "").Replace("-", "").Replace(".", "").Replace("+1", "").Replace("(", "").Replace(")", "").Trim();
                                hrefValue = Regex.Replace(hrefValue, @"\s", "");

                                if (!lbPhoneNumberList.Items.Contains(hrefValue) && hrefValue.Length > 8 && hrefValue.Length <= 10)
                                {
                                    lbPhoneNumberList.Items.Add(hrefValue);
                                }

                            }
                        });

                        _lblCount.Invoke((MethodInvoker)delegate
                        {
                            _lblCount.Text = lbPhoneNumberList.Items.Count.ToString();
                        });
                    }

                    Regex rePhone = new Regex(@"(?:(?:\+?([1-9]|[0-9][0-9]|[0-9][0-9][0-9])\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([0-9][1-9]|[0-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{5})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?");
                    Match m = rePhone.Match(htmlString);
                    while (m.Success)
                    {
                        string phone = m.Value;
                        mobile.Add(phone);
                        lbPhoneNumberList.Invoke((MethodInvoker)delegate
                        {
                            phone = phone.Replace("-", "").Replace(".", "").Replace("+1", "").Replace("(", "").Replace(")", "").Trim();
                            phone = Regex.Replace(phone, @"\s", "");
                            if (!lbPhoneNumberList.Items.Contains(phone) && phone.Length > 8 && phone.Length <= 10)
                            {
                                lbPhoneNumberList.Items.Add(phone);
                            }
                        });
                        _lblCount.Invoke((MethodInvoker)delegate
                        {
                            _lblCount.Text = lbPhoneNumberList.Items.Count.ToString();
                        });
                        m = m.NextMatch();
                    }
                }

                else if (Path.GetExtension(path).ToLower().Contains(".txt"))
                {
                    lblLoadMessage.Invoke((MethodInvoker)delegate
                    {
                        lblLoadMessage.Text = string.Format("File{0} - {1} is load", i.ToString(), Path.GetFileName(path));
                    });

                    fileName = Path.GetFileName(path);

                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        lbPhoneNumberList.Invoke((MethodInvoker)delegate
                        {
                            line = line.Replace("-", "").Replace(".", "").Replace("+1", "").Replace("(", "").Replace(")", "").Trim();
                            line = Regex.Replace(line, @"\s", "");

                            if (!lbPhoneNumberList.Items.Contains(line))
                            {
                                lbPhoneNumberList.Items.Add(line);
                            }

                        });

                        _lblCount.Invoke((MethodInvoker)delegate
                        {
                            _lblCount.Text = lbPhoneNumberList.Items.Count.ToString();
                        });
                    }
                    read.Close();
                }
                ++i;
            }
            MessageBox.Show("The operation was successful.", "Message");
        }
    }
}
