using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fly
{
    public partial class DisplayId : Form
    {

        private readonly int _ticketId;

        public DisplayId(int ticketId)
        {
            InitializeComponent();

            _ticketId = ticketId;
        }

        private void DisplayId_Load(object sender, EventArgs e)
        {
            lbl_ticketId.Text = _ticketId.ToString();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
