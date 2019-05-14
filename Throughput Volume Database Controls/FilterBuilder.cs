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
            buttonNegate.Click += new EventHandler(NegateNode);
            treeFilter.MouseDown += new MouseEventHandler(DeselectNode);
            string[] logics = { "=","<>",">","<","LIKE" };
            cmbLogic.Items.AddRange(logics);
        }

        private void NegateNode(object sender, EventArgs e)
        {
            try
            {
                var selectedNode = treeFilter.SelectedNode;
                if (selectedNode.GetType() == typeof(ParameterNode))
                {
                    if (selectedNode.Text.Substring(0, 4) == "NOT ")
                    {
                        selectedNode.Text = selectedNode.Text.Remove(0, 4);
                    }
                    else
                    {
                        selectedNode.Text = "NOT " + selectedNode.Text;
                    }
                }
            }
            catch
            {
            }

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
        private void AddCriterionOrGroup(object sender, EventArgs e)
        {
            string parameter = textParameter.Text;

            var tempNode = new TreeNode();
            Button btn = (Button)sender;

            //ChangeNodeType(tempNode, btn.Name);

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


        private void AddCriterion(object sender, EventArgs e)
        {
            string parameter = textParameter.Text;

            if (parameter.Trim().Length > 0)
            {
                ParameterNode tempNode = new ParameterNode($"{cmbFields.Text} {cmbLogic.Text} '{parameter}'");

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
            Filter = BuildFilter(treeFilter.Nodes);

        }
        private string BuildFilter(TreeNodeCollection nodes)
        {
            string tempFilter = "";
            foreach (var Node in nodes)
            {
                if (tempFilter.Trim().Length > 0) { tempFilter += " AND "; };
                if (Node.GetType() == typeof(ParameterNode)) { tempFilter += BuildFilter((ParameterNode)Node); };
                if (Node.GetType() == typeof(AndNode)) { tempFilter += BuildFilter((AndNode)Node); };
                if (Node.GetType() == typeof(OrNode)) { tempFilter += BuildFilter((OrNode)Node); };
            }
            return tempFilter;
        }
        private string BuildFilter(ParameterNode node)
        {
            string tempFilter = "";
            tempFilter += node.Text;
            return tempFilter;
        }
        private string BuildFilter(AndNode andNode)
        {
            string tempFilter = "";
            foreach (var Node in andNode.Nodes)
            {
                if (tempFilter.Trim().Length > 0) { tempFilter += " AND "; };
                if (Node.GetType() == typeof(ParameterNode)) { tempFilter += BuildFilter((ParameterNode)Node); };
                if (Node.GetType() == typeof(AndNode)) { tempFilter += BuildFilter((AndNode)Node); };
                if (Node.GetType() == typeof(OrNode)) { tempFilter += BuildFilter((OrNode)Node); };
            }
            return $"({tempFilter})";
        }
        private string BuildFilter(OrNode orNode)
        {
            string tempFilter = "";
            foreach (var Node in orNode.Nodes)
            {
                if (tempFilter.Trim().Length > 0) { tempFilter += " OR "; };
                if (Node.GetType() == typeof(ParameterNode)) { tempFilter += BuildFilter((ParameterNode)Node); };
                if (Node.GetType() == typeof(AndNode)) { tempFilter += BuildFilter((AndNode)Node); };
                if (Node.GetType() == typeof(OrNode)) { tempFilter += BuildFilter((OrNode)Node); };
            }
            return $"({tempFilter})";
        }
    }
}
