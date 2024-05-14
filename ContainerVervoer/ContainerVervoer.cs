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
            ClearUIFields();
            EnableDisableInput(true);
        }

        private void btn_InitializeShip_Click(object sender, EventArgs e)
        {
            if (CheckIfShipLengthWidthInputValid())
            {
                ship = new ContainerShip(Convert.ToInt32(txt_ShipLength.Text), Convert.ToInt32(txt_ShipWidth.Text));
                DrawShip();
                EnableDisableInput(false);
            }
        }

        private void btn_AddContainer_Click(object sender, EventArgs e)
        {
            if (ship != null)
            {
                if (CheckIfContainerWeightInputValid())
                {
                    lb_Containers.Items.Add($"W: {txt_ContainerWeight.Text} - V: {cb_HasValuables.Checked} - C: {cb_IsCooled.Checked}");

                    ship!.AddContainer(Convert.ToInt32(txt_ContainerWeight.Text), cb_HasValuables.Checked, cb_IsCooled.Checked);
                    UpdateSummary();
                }

                txt_ContainerWeight.Text = string.Empty;
                cb_HasValuables.Checked = false;
                cb_IsCooled.Checked = false;
            }
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            if (ship != null)
            {
                if (ship!.Containers.Count() != 0)
                {
                    ship!.DevideContainersOverShip();
                }
                else
                {
                    MessageBox.Show("Container List Empty!");
                }
            }
            else
            {
                MessageBox.Show("Ship not Initialized!");
            }   
        }

        private void btn_ClearShip_Click(object sender, EventArgs e)
        {
            ship = null;

            ClearUIFields();
            EnableDisableInput(true);
        }

        #region Validation Functions
        private bool CheckIfShipLengthWidthInputValid()
        {
            bool valid = true;

            if (!ShipLengthInputValid())
            {
                valid = false;
                MessageBox.Show("Invalid Length!");
            }

            if (!ShipWidthInputValid())
            {
                valid = false;
                MessageBox.Show("Invalid Width!");
            }
            return valid;
        }

        private bool ShipLengthInputValid()
        {
            bool lengthValid = true;

            if (txt_ShipLength.Text.Length == 0)
            {
                lengthValid = false;
            }
            else
            {
                lengthValid = CharacterValid(txt_ShipLength.Text.ToArray());
            }

            return lengthValid;
        }

        private bool ShipWidthInputValid()
        {
            bool widthValid = true;

            if (txt_ShipWidth.Text.Length == 0)
            {
                widthValid = false;
            }
            else
            {
                widthValid = CharacterValid(txt_ShipWidth.Text.ToArray());
            }

            return widthValid;
        }

        private bool CheckIfContainerWeightInputValid()
        {
            bool weightValid = true;

            if (txt_ContainerWeight.Text.Length == 0)
            {
                weightValid = false;
                MessageBox.Show("No Weight Value!");
            }
            else
            {
                if (ContainerWeightInputValid())
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
                else
                {
                    weightValid = false;
                    MessageBox.Show("Invalid Container Weight!");
                }
            }
            return weightValid;
        }

        private bool ContainerWeightInputValid()
        {
            bool weightValid = true;

            if (txt_ContainerWeight.Text.Length == 0)
            {
                weightValid = false;
            }
            else
            {
                weightValid = CharacterValid(txt_ContainerWeight.Text.ToArray());
            }

            return weightValid;
        }

        private bool CharacterValid(char[] characters)
        {
            bool valid = true;

            foreach (char c in characters)
            {
                if (!Regex.IsMatch(c.ToString(), _VALIDCHARACTERS))
                {
                    valid = false;
                }
            }
            return valid;
        }
        #endregion

        #region UI Functions
        private void DrawShip()
        {
            txt_ShipLayout.Text += "  ^  " + Environment.NewLine + @" /  \" + Environment.NewLine;
            int determineNewLine = 0;

            for (int spot = 0; spot < ship!.ContainerSpots.Count(); spot++)
            {
                if (determineNewLine == ship.WidthInContainers)
                {
                    determineNewLine = 0;
                    txt_ShipLayout.Text += Environment.NewLine;
                }

                txt_ShipLayout.Text += "[ ]";
                determineNewLine++;
            }

            txt_ShipLayout.Text += Environment.NewLine + "_____";
        }

        private void UpdateSummary()
        {
            lbl_TotalContainers.Text = ship!.Containers.Count().ToString();
            lbl_WithValuables.Text = ship!.Containers.Where(c => c.HasValuables).Count().ToString();
            lbl_IsCooled.Text = ship!.Containers.Where(c => c.HasCooling).Count().ToString();
        }

        private void ClearUIFields()
        {
            txt_ShipLength.Text = string.Empty;
            txt_ShipWidth.Text = string.Empty;
            txt_ShipLayout.Text = string.Empty;
            txt_ContainerWeight.Text = string.Empty;
            cb_HasValuables.Checked = false;
            cb_IsCooled.Checked = false;
            lb_Containers.Items.Clear();
            lbl_TotalContainers.Text = string.Empty;
            lbl_WithValuables.Text = string.Empty;
            lbl_IsCooled.Text = string.Empty;
        }

        private void EnableDisableInput(bool enable)
        {
            EnableDisableShipInput(enable);
            EnableDisableContainerInput(!enable);
        }

        private void EnableDisableShipInput(bool enable)
        {
            txt_ShipLength.Enabled = enable;
            txt_ShipWidth.Enabled = enable;
            btn_InitializeShip.Enabled = enable;
        }

        private void EnableDisableContainerInput(bool enable)
        {
            txt_ContainerWeight.Enabled = enable;
            cb_HasValuables.Enabled = enable;
            cb_IsCooled.Enabled = enable;
            btn_AddContainer.Enabled = enable;
        }
        #endregion
    }
}
