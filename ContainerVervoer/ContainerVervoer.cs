using ContainerVervoer.Models;
using System.Diagnostics;
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
            FillContainerWeightComboBox();
            EnableDisableInput(true);
        }

        private void btn_InitializeShip_Click(object sender, EventArgs e)
        {
            if (CheckIfShipLengthWidthInputValid())
            {
                ship = new ContainerShip(Convert.ToInt32(txt_ShipLength.Text), Convert.ToInt32(txt_ShipWidth.Text));
                //DrawShip();
                EnableDisableInput(false);
            }
        }

        private void btn_AddContainer_Click(object sender, EventArgs e)
        {
            if (ship != null)
            {
                if (CheckIfContainerWeightInputValid())
                {
                    lb_Containers.Items.Add($"W: {cb_ContainerWeight.SelectedItem} - V: {cb_HasValuables.Checked} - C: {cb_IsCooled.Checked}");
                    try
                    {
                        ship!.AddContainerToBay(Convert.ToInt32(cb_ContainerWeight.SelectedItem), cb_HasValuables.Checked, cb_IsCooled.Checked);
                    }
                    catch(Exception ex)
                    {

                    }
                        UpdateSummary();
                }

                cb_ContainerWeight.SelectedItem = null;
                cb_HasValuables.Checked = false;
                cb_IsCooled.Checked = false;
            }
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            if (ship != null)
            {
                if (ship!.ContainersOnBay.Count() != 0)
                {
                    ship!.DivideContainersOverShip();

                    txt_Output.Text = DebugShip();
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
            return ShipLengthInputValid() && ShipWidthInputValid();
        }

        private bool ShipLengthInputValid()
        {
            if (txt_ShipLength.Text.Length == 0 || !CharactersValid(txt_ShipLength.Text.ToArray())) 
            {
                MessageBox.Show("Invalid Length!");
                return false;
            }
            return true;
        }

        private bool ShipWidthInputValid()
        {
            if (txt_ShipWidth.Text.Length == 0 || !CharactersValid(txt_ShipWidth.Text.ToArray()))
            {
                MessageBox.Show("Invalid Width!");
                return false;
            }
            return true;
        }

        private bool CheckIfContainerWeightInputValid()
        {
            return cb_ContainerWeight.SelectedItem != null && ContainerWeightInputValid();
        }

        private bool ContainerWeightInputValid()
        {
            return CharactersValid(cb_ContainerWeight.SelectedItem!.ToString()!.ToArray());
        }

        private bool CharactersValid(char[] characters)
        {
            bool valid = true;

            foreach (char c in characters)
            {
                if (!Regex.IsMatch(c.ToString(), _VALIDCHARACTERS)) valid = false;
            }
            return valid;
        }
        #endregion

        #region UI Functions
        //private void DrawShip()
        //{
        //    txt_ShipLayout.Text += "  ^  " + Environment.NewLine + @" /  \" + Environment.NewLine;
        //    int determineNewLine = 0;

        //    for (int spot = 0; spot < ship!.ContainerSpots.Count(); spot++)
        //    {
        //        if (determineNewLine == ship.WidthInContainers)
        //        {
        //            txt_ShipLayout.Text += Environment.NewLine;
        //            determineNewLine = 0;
        //        }

        //        txt_ShipLayout.Text += "[ ]";
        //        determineNewLine++;
        //    }

        //    txt_ShipLayout.Text += Environment.NewLine + "_____";
        //}

        private string CreateThreeDVisualizationURL()
        {
            // stacks=111,111,111/111,111,111/111,111,111&weights=1-1-1,1-1-1,1-1-1/1-1-1,1-1-1,1-1-1/1-1-1,1-1-1,1-1-1
            string stacks = "";
            string weights = "";

            for (int rowIndex = 0; rowIndex < ship!.ContainerStackRows.Count(); rowIndex++)
            {
                for (int stackIndex = 0; stackIndex < ship!.ContainerStackRows[rowIndex].ContainerStacks.Count(); stackIndex++)
                {
                    for (int containerIndex = 0; containerIndex < ship!.ContainerStackRows[rowIndex].ContainerStacks[stackIndex].Containers.Count(); containerIndex++)
                    {
                        if (IsContainerCooled(ship!.ContainerStackRows[rowIndex].ContainerStacks[stackIndex].Containers[containerIndex]))
                        {
                            stacks += "3";
                        }
                        else if (IsContainerCooledValuable(ship!.ContainerStackRows[rowIndex].ContainerStacks[stackIndex].Containers[containerIndex]))
                        {
                            stacks += "4";
                        }
                        else if (IsContainerValuable(ship!.ContainerStackRows[rowIndex].ContainerStacks[stackIndex].Containers[containerIndex]))
                        {
                            stacks += "2";
                        }
                        else
                        {
                            stacks += "1";
                        }

                        weights += $"{ship!.ContainerStackRows[rowIndex].ContainerStacks[stackIndex].Containers[containerIndex].Weight}";
                    }

                    if (stackIndex < ship!.ContainerStackRows[rowIndex].ContainerStacks.Count())
                    {
                        stacks += ",";
                    }
                }

                if (rowIndex < ship!.ContainerStackRows.Count())
                {
                    stacks += "/";
                }
            }

            return $"https://i872272.luna.fhict.nl/ContainerVisualizer/index.html?width={ship!.LengthInContainers}&length={ship!.WidthInContainers}&stacks={stacks}&weights={weights}";
        }

        private string DebugShip()
        {
            return $"https://i872272.luna.fhict.nl/ContainerVisualizer/index.html?width={ship!.LengthInContainers}&length={ship!.WidthInContainers}&stacks={string.Join("/", ship.ContainerStackRows.Select(
                        r => string.Join(",", r.ContainerStacks.Select(
                            s => string.Join("-", s.Containers.Select(
                                c => 1 + (c.HasValuables ? 1 : 0) + 2 * (c.HasCooling ? 1 : 0)
                            ))
                        ))
                    ))}&weights={string.Join("/", ship.ContainerStackRows.Select(
                        r => string.Join(",", r.ContainerStacks.Select(
                            s => string.Join("-", s.Containers.Select(
                                c => c.Weight
                            ))
                        ))
                    ))}";
        }

        #region Container Types
        private bool IsContainerCooled(Container container)
        {
            return container.HasCooling && !container.HasValuables;
        }
        private bool IsContainerCooledValuable(Container container)
        {
            return container.HasCooling && container.HasValuables;
        }
        private bool IsContainerValuable(Container container)
        {
            return !container.HasCooling && container.HasValuables;
        }
        #endregion

        private void FillContainerWeightComboBox()
        {
            for (int weight = Models.Container._MINWEIGHTINTON; weight <= Models.Container._MAXWEIGHTINTON; weight++)
            {
                cb_ContainerWeight.Items.Add(weight);
            }
        }

        private void UpdateSummary()
        {
            lbl_TotalContainers.Text = ship!.ContainersOnBay.Count().ToString();
            lbl_WithValuables.Text = ship!.ContainersOnBay.Where(c => c.HasValuables).Count().ToString();
            lbl_IsCooled.Text = ship!.ContainersOnBay.Where(c => c.HasCooling).Count().ToString();
        }

        private void ClearUIFields()
        {
            txt_ShipLength.Text = string.Empty;
            txt_ShipWidth.Text = string.Empty;
            txt_ShipLayout.Text = string.Empty;
            cb_ContainerWeight.Text = string.Empty;
            cb_ContainerWeight.SelectedItem = null;
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
            cb_ContainerWeight.Enabled = enable;
            cb_HasValuables.Enabled = enable;
            cb_IsCooled.Enabled = enable;
            btn_AddContainer.Enabled = enable;
        }
        #endregion
    }
}
