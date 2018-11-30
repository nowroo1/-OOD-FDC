using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future {
    public partial class carrerPlanForm : ObjectivesForm {
        public carrerPlanForm() {
            InitializeComponent();
        }

        private void input_button_Click(object sender, EventArgs e) {
            this.prompt.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }
    }
}
