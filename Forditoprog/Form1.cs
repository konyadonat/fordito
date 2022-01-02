using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forditoprog
{
    public partial class Form1 : Form
    {
        Stack<string> stack;
        private string input;
        private List<string> steps;
        public string Input
        {
            get => input;
            set
            {

                if (value.Length == 0)
                {
                    throw new InputEmptyException();
                }
                if (value.Last() != '#')
                {
                    throw new InputDoesNotHaveHasmarkAtEndException();
                }
                input = value;
            }
        }

        public string Modified_input
        {
            get => modified_input;
            set
            {
                if (value == null)
                {
                    throw new ModifiedInputNullException();
                }
                if (value == "")
                {
                    throw new ModifiedInputEmptyException();
                }
                if(value.Last() != '#')
                {
                    throw new ModifiedInputInvalidException();
                }
                modified_input = value;
            }
        }

        private string modified_input;

        private string path;



        public string Path
        {
            get => path;
            set
            {
                if (value == string.Empty)
                {
                    throw new PathEmptyException();
                }
                if (value.Length < 1)
                {
                    throw new PathTooShortException();
                }
                path = value;
            }
        }

        public Stack<string> Stack { get => stack; set => stack = value; }
        public List<string> Steps { get => steps; set => steps = value; }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modified_input_Tb.Enabled = false;
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToResizeRows = true;
            datagrid.AllowUserToResizeColumns = true;
            Stack = new Stack<string>();
            Steps = new List<string>();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Input = input_Tb.Text;
                modified_input_Tb.Text = Regex.Replace(Input,"[0-9]+","i");
                Modified_input = modified_input_Tb.Text;
                modified_input_Tb.Refresh();

            }
            catch (InputEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InputDoesNotHaveHasmarkAtEndException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ModifiedInputEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ModifiedInputNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ModifiedInputInvalidException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void path_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Text and CSV Files(*.txt, *.csv)|*.txt;*.csv|Text Files(*.txt)|*.txt|CSV Files(*.csv)|*.csv|All Files(*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Path = openFileDialog.FileName;
                    path_Tb.Text = Path;

                    using (StreamReader sr = new StreamReader(Path))
                    {
                        string Line = sr.ReadLine();
                        string[] array = Line.Split(';');

                        foreach (string value in array)
                        {
                            dt.Columns.Add(value.Trim());
                        }
                        DataRow dr = dt.NewRow();

                        while (sr.Peek() >= 0)
                        {
                            Line = sr.ReadLine();
                            array = Line.Split(';');
                            dt.Rows.Add(array);
                        }
                        //dt.Rows.RemoveAt(dt.Rows.Count-1);
                    }
                    datagrid.DataSource = dt;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Modified_input = modified_input_Tb.Text;
                Stack.Clear();
                listBox1.Items.Clear();
                Steps.Clear();
                Stack.Push("#");
                Stack.Push("E");

                int inputIndex = 0;

                while (true)
                {
                    int stackSideIndex = -1;
                    for (int i = 0; i < datagrid.Rows.Count; i++)
                    {
                        if (Stack.Peek() == datagrid.Rows[i].Cells[0].FormattedValue.ToString())
                        {
                            stackSideIndex = i;
                            break;
                        }
                    }

                    int inputSideIndex = -1;
                    for (int i = 0; i < datagrid.Columns.Count; i++)
                    {
                        if (Modified_input[inputIndex].ToString() == datagrid.Columns[i].Name)
                        {
                            inputSideIndex = i;
                            break;
                        }
                    }


                    if (inputSideIndex == -1 || stackSideIndex == -1)
                    {
                        throw new InvalidTableSyntaxException();
                    }

                    //Ha üres cellára futunk
                    if (datagrid[inputSideIndex, stackSideIndex].FormattedValue.ToString() == "")
                    {
                        throw new ErrorDuringIterationException();
                    }

                    //Ha elfogadó állapotba futunk
                    else if (datagrid[inputSideIndex, stackSideIndex].FormattedValue.ToString() == "accept")
                    {
                        MessageBox.Show("A műveletek végrehajtása sikeresek voltak!");
                        break;
                    }

                    else if (datagrid[inputSideIndex, stackSideIndex].FormattedValue.ToString() == "pop")
                    {
                        Stack.Pop();
                        inputIndex++;
                    }

                    else
                    {
                        string[] cella = datagrid[inputSideIndex, stackSideIndex].FormattedValue.ToString()[1..^1].Split(',');
                        Stack.Pop();

                        for (int i = cella[0].Length - 1; i >= 0; i--)
                        {
                            if (cella[0] == "e")
                                continue;
                            //Ha vesszős a formátum akkor így rakom bele
                            if (cella[0][i] == '\'')
                            {
                                Stack.Push(cella[0].Substring(i - 1, 2));
                                i--;
                                continue;
                            }

                            Stack.Push(cella[0][i].ToString());
                            Steps.Add(cella[1]);
                            listBox1.Items.Add($"{Modified_input.Substring(inputIndex)},{getStack()},\t\t{getSteps()}");
                        }
                    }
                }

            }
            catch (InvalidTableSyntaxException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ErrorDuringIterationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Kifutott az index a táblázatból!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private string getStack()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string item in Stack)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }

        private string getSteps()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string s in this.Steps)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }
    }
}
