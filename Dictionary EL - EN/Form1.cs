using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_EL___EN
{
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
        }

        private void lblDictionaryName_Click(object sender, EventArgs e)
        {

        }

        
        private void Dictionary_Load(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
          
            var input = tbxWord.Text;
            var inputLength = tbxWord.Text.Length / 2;
            var firstPart = input.Substring(0, inputLength);
            var secondPart = input.Substring(inputLength);
            var result = (secondPart+firstPart).ToLower();

            MessageBox.Show(result);
        }
    }
}
