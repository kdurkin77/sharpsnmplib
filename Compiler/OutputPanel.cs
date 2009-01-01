/*
 * Created by SharpDevelop.
 * User: lextm
 * Date: 2008/6/28
 * Time: 15:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

namespace Lextm.SharpSnmpLib.Compiler
{
	/// <summary>
	/// Description of OutputPanel.
	/// </summary>
	partial class OutputPanel : DockContent, IOutput
	{
		public OutputPanel()
		{
			InitializeComponent();
		}

        public void ReportMessage(string message)
        {
            txtMessages.AppendText(string.Format("[{0}] {1}", DateTime.Now, message));
            txtMessages.AppendText(Environment.NewLine);
            txtMessages.ScrollToCaret();
        }

        private void actClear_Execute(object sender, EventArgs e)
        {
            txtMessages.Clear();
        }

        private void txtMessages_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextOuputMenu.Show(txtMessages, e.Location);
            }
        }
	}
}