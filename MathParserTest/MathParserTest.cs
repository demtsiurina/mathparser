/*
 * Author: Patrik Lundin, patrik@lundin.info
 * Web: http://www.lundin.info
 * 
 * Source code released under the Microsoft Public License (Ms-PL) 
 * http://www.microsoft.com/en-us/openness/licenses.aspx#MPL
*/
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using info.lundin.math;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace MathParserTestNS
{
    public partial class MathParserTest : Form
    {
        public MathParserTest()
        {
            InitializeComponent();
        }

        List<Node> shortExpr = new List<Node>();
        List<string> varNames = new List<string>();
        int labelCounter = 0;
        int deep = 0;
        private void LPK(Node n)
        {
            if (n == null)
                return;

            if (n.Type != NodeType.Expression)
            {
                if (n.Type == NodeType.Value)
                    n.Label = n.FullExpression = n.Value.ToString();
                else n.Label = n.FullExpression = n.Variable;
                return;
            }

            if (n.SecondArgument == null)//кусь говнокод конечно, но в 3:20 ночи я не хо придумывать что-то лучше
            {
                deep++;
                LPK(n.FirstArgument);
                deep--;

                n.FullExpression = n.Operator.ToString() + "(" + n.FirstArgument.FullExpression + ")";

                if (deep == 0)
                    n.Label = "F";
                else n.Label = ((char)('A' + labelCounter++)).ToString();

                n.ShortExpression = n.Operator.ToString() + "(" + n.FirstArgument.Label + ")";
                if (n.Label == "E")
                    labelCounter++;
                shortExpr.Add(n);
                return;
            }

            deep++;
            LPK(n.FirstArgument);
            LPK(n.SecondArgument);
            deep--;

            n.FullExpression = "(" + n.FirstArgument.FullExpression + n.Operator.ToString() + n.SecondArgument.FullExpression + ")";

            if (deep == 0)
                n.Label = "F";
            else n.Label = ((char)('A' + labelCounter++)).ToString();

            n.ShortExpression = n.FirstArgument.Label + n.Operator.ToString() + n.SecondArgument.Label;
            if (n.Label == "E")
                labelCounter++;
            shortExpr.Add(n);
        }

        void Increment(List<int> lst)
        {
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                lst[i] = (lst[i] + 1) % 2;
                if (lst[i] == 1)
                    break;
            }
        }

        public bool IsVariable(string s)
        {
            if (s.IndexOf('v') != -1) return false;
            if (s.IndexOf('V') != -1) return false;
            return Regex.IsMatch(s, @"^(_|[a-z]|[A-Z])\w*$");
        }

        public List<string> GetAllVariables(string s)
        {
            DefaultOperators op = new DefaultOperators();
            HashSet<string> set = new HashSet<string>();
            List<string> res = new List<string>();
            foreach (var item in op.Operators)
                s = s.Replace(item.Symbol, " ");

            s = s.Replace('(', ' ').Replace(')', ' ');

            var arr = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in arr)
                if (IsVariable(item))
                    set.Add(item);

            foreach (var item in set)
                res.Add(item);

            res.Sort();

            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(x+y*4)+x+(x+y*2)
            labelCounter = 0;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            varNames.Clear();
            shortExpr.Clear();
            textBox2.Clear();
            ExpressionParser oParser = new ExpressionParser();

            string sFunction = textBox1.Text.Trim();
            double fResult = 0f;

            try
            {
                // Parse expression once
                fResult = oParser.Parse(sFunction);

                // Fetch parsed tree
                Expression expression = oParser.Expressions[sFunction];
                LPK(expression.ExpressionTree);

                List<string> vars = GetAllVariables(sFunction);
                int n = vars.Count;
                int h = (int)Math.Pow(2, n) + 1;
                int w = n + shortExpr.Count + 1;

                string[,] table = new string[h, w];

                table[0, 0] = "N";

                foreach (var item in vars)
                    varNames.Add(item);

                varNames.Sort();

                for (int i = 0; i < n; i++)
                    table[0, i + 1] = varNames[i];

                for (int i = n + 1; i < w; i++)
                    table[0, i] = shortExpr[i - n - 1].Label + " = " + shortExpr[i - n - 1].ShortExpression;

                for (int i = 0; i < w; i++)
                    listView1.Columns.Add(table[0, i], 70);

                List<int> sets = new List<int>();
                for (int i = 0; i < n; i++)
                    sets.Add(0);

                for (int i = 1; i < h; i++)
                {
                    oParser.Values.Clear();

                    table[i, 0] = (i - 1).ToString();

                    for (int j = 1; j <= sets.Count; j++)
                        table[i, j] = sets[j - 1].ToString();

                    for (int j = 0; j < varNames.Count; j++)
                        oParser.Values.Add(varNames[j], sets[j]);

                    for (int j = 0; j < shortExpr.Count; j++)
                        table[i, j + vars.Count + 1] = oParser.Parse(shortExpr[j].FullExpression).ToString();

                    ListViewItem row = new ListViewItem();
                    row.Text = table[i, 0];
                    for (int j = 1; j < w; j++)
                        row.SubItems.Add(table[i, j]);

                    listView1.Items.Add(row);
                    Increment(sets);
                }
                if (textBox2.Text == "")
                    textBox2.Text = "Таблица успешно построена!";
            }
            catch (Exception ex)
            {
                textBox2.Text = ex.Message;
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            string s1 = textBox1.Text.Substring(0, textBox1.SelectionStart);
            string s2 = textBox1.Text.Substring(textBox1.SelectionStart + textBox1.SelectionLength, textBox1.Text.Length - textBox1.SelectionStart - textBox1.SelectionLength);
            textBox1.Text = s1 + s + s2;
            textBox1.SelectionStart = s1.Length + s.Length;
            textBox1.SelectionLength = 0;
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
