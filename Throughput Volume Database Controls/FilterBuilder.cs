using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Throughput_Volume_Database_Controls
{
    public partial class FilterBuilder : UserControl
    {
        private class OrNode : TreeNode
        {
            public OrNode()
            {
                base.Text = "ANY OF:";
            }
        };
        private class AndNode : TreeNode
        {
            public AndNode()
            {
                base.Text = "ALL OF:";
            }
        };
        private class ParameterNode : TreeNode
        {
            public ParameterNode(string Parameter) : base(Parameter)
            {
            }
        };

        public FilterBuilder()
        {
            InitializeComponent();
            buttonAdd.Click += new EventHandler(AddCriterion);
            buttonAnd.Click += new EventHandler(AddANDGroup);
            buttonOr.Click += new EventHandler(AddORGroup);
            buttonDelete.Click += new EventHandler(DeleteNode);
            buttonApply.Click += new EventHandler(BuildFilterCommand);
            treeFilter.MouseDown += new MouseEventHandler(DeselectNode);
        }

        private void DeleteNode(object sender, EventArgs e)
        {
            try
            {
                treeFilter.SelectedNode.Remove();
            }
            catch
            {
            }
        }

        private void AddCriterion(object sender, EventArgs e)
        {
            string parameter = textParameter.Text;

            if (parameter.Trim().Length > 0)
            {
                ParameterNode tempNode = new ParameterNode(parameter);

                try
                {
                    if (treeFilter.SelectedNode.GetType() != typeof(ParameterNode))
                    {
                        treeFilter.SelectedNode.Nodes.Add(tempNode);
                        treeFilter.SelectedNode.Expand();
                    }
                }
                catch
                {
                    treeFilter.Nodes.Add(tempNode);
                }
            }
        }

        private void AddANDGroup(object sender, EventArgs e)
        {
            AndNode andNode = new AndNode();
            if (treeFilter.SelectedNode != null)
            {
                if (treeFilter.SelectedNode.GetType() != typeof(ParameterNode))
                {
                    treeFilter.SelectedNode.Nodes.Add(andNode);
                    treeFilter.SelectedNode.Expand();
                }
            }
            else
            {
                treeFilter.Nodes.Add(andNode);
            }

            treeFilter.SelectedNode = andNode;

        }

        private void AddORGroup(object sender, EventArgs e)
        {
            OrNode orNode = new OrNode();
            if (treeFilter.SelectedNode != null)
            {
                if (treeFilter.SelectedNode.GetType() != typeof(ParameterNode))
                {
                    treeFilter.SelectedNode.Nodes.Add(orNode);
                    treeFilter.SelectedNode.Expand();

                }
            }
            else
            {
                treeFilter.Nodes.Add(orNode);
            }

            treeFilter.SelectedNode = orNode;

        }

        private void DeselectNode(object sender, MouseEventArgs e)
        {
            var hit = treeFilter.HitTest(e.X, e.Y);

            if (hit.Node == null)
            {
                treeFilter.SelectedNode = null;
            }
        }

        public string Filter;
        private void BuildFilterCommand(object sender, EventArgs e)
        {
            Filter = "";
            foreach(TreeNode Node in treeFilter.Nodes)
            {
                if (Filter.Trim().Length > 0) {Filter += " AND "; }
                Filter += $"({BuildFilter(Node)})";
            };

            MessageBox.Show(Filter);
        }

        private string BuildFilter(TreeNode node)
        {
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    return BuildFilter(subNode);
                }
            }
            else
            {
                return node.Text;
            }

            return null;
            
        }
    }
}
