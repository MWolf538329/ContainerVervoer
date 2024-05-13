using ContainerVervoer.Classes;
using System.Text.RegularExpressions;

namespace ContainerVervoer
{
    public partial class ContainerVervoer : Form
    {
        ContainerShip? ship;
        private const string _VALIDCHARACTERS = "[0-9]";

        public ContainerVervoer()
        {
            InitializeComponent();
        }

        private void btn_InitializeShip_Click(object sender, EventArgs e)
        {
            if (CheckIfShipLengthWidthValid())
            {
                ship = new ContainerShip(Convert.ToInt32(txt_ShipLength.Text), Convert.ToInt32(txt_ShipWidth.Text));
                EnableDisableShipInput(false);
            }
        }

        private void btn_ClearShip_Click(object sender, EventArgs e)
        {
            EnableDisableShipInput(true);
            txt_ShipLength.Text = string.Empty;
            txt_ShipWidth.Text = string.Empty;
            ship = null;
        }

        private void btn_AddContainer_Click(object sender, EventArgs e)
        {
            if (ContainerWeightValid())
            {
                lb_Containers.Items.Add($"W: {txt_ContainerWeight.Text} - V: {cb_HasValuables.Checked} - C: {cb_IsCooled.Checked}");
            }

            txt_ContainerWeight.Text = string.Empty;
            cb_HasValuables.Checked = false;
            cb_IsCooled.Checked = false;
        }

        private bool CheckIfShipLengthWidthValid()
        {
            bool valid = true;

            if (!ShipLengthValid())
            {
                valid = false;
                MessageBox.Show("Invalid Length!");
            }

            if (!ShipWidthValid())
            {
                valid = false;
                MessageBox.Show("Invalid Width!");
            }
            return valid;
        }

        private bool ShipLengthValid()
        {
            bool lengthValid = true;

            if (txt_ShipLength.Text.Length == 0)
            {
                lengthValid = false;
            }

            char[] length = txt_ShipLength.Text.ToArray();

            foreach (char c in length)
            {
                if (!Regex.IsMatch(c.ToString(), _VALIDCHARACTERS))
                {
                    lengthValid = false;
                }
            }
            return lengthValid;
        }

        private bool ShipWidthValid()
        {
            bool widthValid = true;

            if (txt_ShipWidth.Text.Length == 0)
            {
                widthValid = false;
            }

            char[] width = txt_ShipWidth.Text.ToArray();

            foreach (char c in width)
            {
                if (!Regex.IsMatch(c.ToString(), _VALIDCHARACTERS))
                {
                    widthValid = false;
                }
            }
            return widthValid;
        }

        private bool ContainerWeightValid()
        {
            bool weightValid = true;

            if (txt_ContainerWeight.Text.Length == 0)
            {
                weightValid = false;
                MessageBox.Show("No Value!");
            }
            else
            {
                if (Convert.ToInt32(txt_ContainerWeight.Text) < Classes.Container._MINWEIGHT)
                {
                    weightValid = false;
                    MessageBox.Show("Container does not meet the minumum weight!");
                }

                if (Convert.ToInt32(txt_ContainerWeight.Text) > Classes.Container._MAXWEIGHT)
                {
                    weightValid = false;
                    MessageBox.Show("Container exceeds the maximum weight limit!");
                }
            }
            return weightValid;
        }

        private void UpdateSummary()
        {
            
        }

        private void EnableDisableShipInput(bool enable)
        {
            txt_ShipLength.Enabled = enable;
            txt_ShipWidth.Enabled = enable;
            btn_InitializeShip.Enabled = enable;
        }
    }
}
