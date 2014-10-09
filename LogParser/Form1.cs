using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LogParser
{
    public partial class Form1 : Form
    {


        //Log path
        public string Path = "";
        //Parametrs count
        public int elements_count = 1;

        //Form Init
        public Form1()
        {
            InitializeComponent();

            listView1.Columns[1].Width = listView1.Width - listView1.Columns[0].Width - 4;
        }
        
        //Log Open. 
        private void buttonCesta_Click(object sender, EventArgs e)
        {
            try
            {

                if (buttonCesta.Visible)
                {
                    buttonCesta.Visible = false;
                }
                if (listView1.Items.Count > 0)
                {
                    listView1.Items.Clear();
                }



                openFileDialogCesta.Filter = "Log Files (.log)|*.log|All Files (*.*)|*.*";
                openFileDialogCesta.FilterIndex = 0;
                //openFileDialogCesta.Multiselect = true;

                if (openFileDialogCesta.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    Path = openFileDialogCesta.FileName;
                    textBoxCesta.Text = Path;
                }
                else
                {
                    Path = "";
                    textBoxCesta.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Chyba");
            }

        }

        //Start button
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Path.Length > 0 && textBoxPodm_1.Text.Length > 0)
                {


                    listView1.Items.Clear();

                    TextBox tx1 = null;
                    int z = 0;
                    this.Cursor = Cursors.WaitCursor;


                    foreach (Control c in groupBoxParametrers.Controls)
                    {
                        if (c.Name.Contains("textBoxPodm_1"))
                        {
                            
                        }
                        else if (c.Name.Contains("textBoxPodm_"))
                        {
                            z++;
                        }

                    }

                    
                    System.IO.Stream fileStream = File.OpenRead(openFileDialogCesta.FileName);
                    int counter = 0;
                    string line = "";
                    StreamReader reader = new StreamReader(fileStream);

                    while ((line = reader.ReadLine()) != null)
                    {
                        counter++;

                        if (line.ToLower().Contains(textBoxPodm_1.Text.ToLower()))
                        {

                            if (z > 0)
                            {
                                bool finde = false;

                                for (int x = 0; x < z; x++)
                                {
                                    foreach (Control c in groupBoxParametrers.Controls)
                                    {
                                        if (c.Name.Contains("textBoxPodm_" + (x+2).ToString()))
                                        {
                                            tx1 = (TextBox)c;

                                            if (line.ToLower().Contains(tx1.Text.ToLower()))
                                            {
                                                finde = true;
                                                break;
                                            }
                                            else
                                            {
                                                finde = false;
                                            }
                                        }

                                    }
                                }

                                if (finde)
                                {
                                    string[] str = new string[2];
                                    str[0] = counter.ToString();
                                    str[1] = line;

                                    ListViewItem itm = new ListViewItem(str);
                                    listView1.Items.Add(itm);
                                }
                            }
                            else
                            {

                                string[] str = new string[2];
                                str[0] = counter.ToString();
                                str[1] = line;

                                ListViewItem itm = new ListViewItem(str);
                                listView1.Items.Add(itm);
                            }
                        }
                        
                    }

                    fileStream.Close();
                    this.Cursor = Cursors.Arrow;

                    if (listView1.Items.Count > 0)
                    {
                        buttonExport.Visible = true;
                    }
                    else
                    {
                        buttonExport.Visible = false;
                    }

                    MessageBox.Show("Pocet radku " + counter.ToString());
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba");
            }

        }

        //Button plus
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox tx1 = null;
                Button btn1 = null;

                foreach (Control c in groupBoxParametrers.Controls)
                {
                    if (c.Name == "textBoxPodm_" + elements_count.ToString())
                    {
                        tx1 = (TextBox)c;
                    }
                    if (c.Name == "buttonPodm_" + elements_count.ToString())
                    {
                        btn1 = (Button)c;
                    }
                }

                elements_count++;
                
                groupBoxParametrers.Height = groupBoxParametrers.Height + textBoxPodm_1.Height + 3;
                listView1.Location = new Point(listView1.Location.X, listView1.Location.Y + textBoxPodm_1.Height + 3);
                listView1.Height = listView1.Height - textBoxPodm_1.Height - 3;
                //buttonStart.Location = new Point(buttonStart.Location.X, buttonStart.Location.Y + buttonStart.Height + 3);
                //this.Height = this.Height + textBoxPodm_1.Height + buttonStart.Height;

                TextBox txtPodm = new TextBox();
                txtPodm.Name = "textBoxPodm_" + elements_count.ToString();
                txtPodm.Width = textBoxPodm_1.Width;
                txtPodm.Location = new Point(tx1.Location.X, tx1.Location.Y + txtPodm.Height + 3);
                groupBoxParametrers.Controls.Add(txtPodm);

                Button btnPodm = new Button();
                btnPodm.Name = "buttonPodm_" + elements_count.ToString();
                btnPodm.Width = btn1.Width;
                btnPodm.Text = "-";
                btnPodm.Location = new Point(btn1.Location.X, btn1.Location.Y + btnPodm.Height);
                btnPodm.Click += new EventHandler(btnPodm_Click);

                groupBoxParametrers.Controls.Add(btnPodm);



                if (elements_count > 2)
                {

                    for (int z = 2; z < elements_count; z++)
                    {

                        foreach (Control cc in groupBoxParametrers.Controls)
                        {

                            if (cc.Name == "buttonPodm_" + z.ToString())
                            {
                                Button cxc = (Button)cc;

                                cxc.Enabled = false;
                                break;
                            }
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button minus
        void btnPodm_Click(object sender, EventArgs e)
        {
            try
            {
                Button obj = (Button)sender;
                elements_count--;
                string[] s = obj.Name.ToString().Split(new Char[] { '_' });
                string name = s[1];
                //this.Height = this.Height - textBoxPodm_1.Height - 3;
                groupBoxParametrers.Height = groupBoxParametrers.Height - textBoxPodm_1.Height - 3;
                //listView1.Location = new Point(listView1.Location.X, listView1.Location.Y - textBoxPodm_1.Height - 3);
                listView1.Location = new Point(listView1.Location.X, listView1.Location.Y - textBoxPodm_1.Height - 3);
                listView1.Height = listView1.Height + textBoxPodm_1.Height + 3;

                if (buttonCesta.Visible)
                {
                    buttonCesta.Visible = false;
                }
                if (listView1.Items.Count > 0)
                {
                    listView1.Items.Clear();
                }
                

                int count = groupBoxParametrers.Controls.Count;

                for (int z = 0; z < count; z++)
                {
                    foreach (Control ctrl in groupBoxParametrers.Controls)
                    {
                        string[] ss = ctrl.Name.ToString().Split(new Char[] { '_' });
                        if (ss.Length == 2)
                        {
                            string names = ss[1];
                            if (name == names)
                            {
                                groupBoxParametrers.Controls.Remove(ctrl);
                                break;
                            }
                        }
                    }
                }

                if (elements_count >= 2)
                {
                    foreach (Control cc in groupBoxParametrers.Controls)
                    {

                        if (cc.Name == "buttonPodm_" + elements_count.ToString())
                        {
                            Button cxc = (Button)cc;

                            cxc.Enabled = true;
                            break;
                        }
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ListView resize
        private void listView1_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                listView1.Columns[1].Width = listView1.Width - listView1.Columns[0].Width - 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Form resize event
        private void Form1_Resize(object sender, EventArgs e)
        {
            try
            {
               // listView1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Export button
        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0)
                {
                    saveFileDialogExport.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialogExport.FilterIndex = 0;
                    saveFileDialogExport.RestoreDirectory = true;

                    if (saveFileDialogExport.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialogExport.FileName))
                        {
                            foreach (ListViewItem itm in listView1.Items)
                            {
                                file.WriteLine(itm.SubItems[1].Text);
                            }
                        }

                        MessageBox.Show("Export OK", "Pozor!",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
