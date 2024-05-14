namespace ContainerVervoer
{
    partial class ContainerVervoer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_Ship = new GroupBox();
            txt_ShipLayout = new TextBox();
            btn_ClearShip = new Button();
            btn_InitializeShip = new Button();
            txt_ShipWidth = new TextBox();
            txt_ShipLength = new TextBox();
            width = new Label();
            length = new Label();
            gb_Container = new GroupBox();
            cb_IsCooled = new CheckBox();
            cb_HasValuables = new CheckBox();
            isCooled = new Label();
            lb_Containers = new ListBox();
            btn_AddContainer = new Button();
            txt_ContainerWeight = new TextBox();
            hasValuables = new Label();
            weight = new Label();
            txt_Output = new TextBox();
            total = new Label();
            gb_Summary = new GroupBox();
            btn_Execute = new Button();
            lbl_IsCooled = new Label();
            withcooling = new Label();
            lbl_WithValuables = new Label();
            withvaluables = new Label();
            lbl_TotalContainers = new Label();
            output = new Label();
            gb_Ship.SuspendLayout();
            gb_Container.SuspendLayout();
            gb_Summary.SuspendLayout();
            SuspendLayout();
            // 
            // gb_Ship
            // 
            gb_Ship.Controls.Add(txt_ShipLayout);
            gb_Ship.Controls.Add(btn_ClearShip);
            gb_Ship.Controls.Add(btn_InitializeShip);
            gb_Ship.Controls.Add(txt_ShipWidth);
            gb_Ship.Controls.Add(txt_ShipLength);
            gb_Ship.Controls.Add(width);
            gb_Ship.Controls.Add(length);
            gb_Ship.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            gb_Ship.Location = new Point(12, 12);
            gb_Ship.Name = "gb_Ship";
            gb_Ship.Size = new Size(370, 200);
            gb_Ship.TabIndex = 3;
            gb_Ship.TabStop = false;
            gb_Ship.Text = "Ship Creation";
            // 
            // txt_ShipLayout
            // 
            txt_ShipLayout.Font = new Font("Segoe UI", 6F);
            txt_ShipLayout.Location = new Point(244, 28);
            txt_ShipLayout.Multiline = true;
            txt_ShipLayout.Name = "txt_ShipLayout";
            txt_ShipLayout.ReadOnly = true;
            txt_ShipLayout.ScrollBars = ScrollBars.Both;
            txt_ShipLayout.Size = new Size(117, 164);
            txt_ShipLayout.TabIndex = 7;
            // 
            // btn_ClearShip
            // 
            btn_ClearShip.Font = new Font("Segoe UI", 9F);
            btn_ClearShip.Location = new Point(10, 158);
            btn_ClearShip.Name = "btn_ClearShip";
            btn_ClearShip.Size = new Size(228, 34);
            btn_ClearShip.TabIndex = 6;
            btn_ClearShip.Text = "Clear Ship";
            btn_ClearShip.UseVisualStyleBackColor = true;
            btn_ClearShip.Click += btn_ClearShip_Click;
            // 
            // btn_InitializeShip
            // 
            btn_InitializeShip.Font = new Font("Segoe UI", 9F);
            btn_InitializeShip.Location = new Point(10, 118);
            btn_InitializeShip.Name = "btn_InitializeShip";
            btn_InitializeShip.Size = new Size(228, 34);
            btn_InitializeShip.TabIndex = 5;
            btn_InitializeShip.Text = "Initialize Ship";
            btn_InitializeShip.UseVisualStyleBackColor = true;
            btn_InitializeShip.Click += btn_InitializeShip_Click;
            // 
            // txt_ShipWidth
            // 
            txt_ShipWidth.Font = new Font("Segoe UI", 9F);
            txt_ShipWidth.Location = new Point(189, 84);
            txt_ShipWidth.Name = "txt_ShipWidth";
            txt_ShipWidth.Size = new Size(49, 27);
            txt_ShipWidth.TabIndex = 4;
            // 
            // txt_ShipLength
            // 
            txt_ShipLength.Font = new Font("Segoe UI", 9F);
            txt_ShipLength.Location = new Point(189, 47);
            txt_ShipLength.Name = "txt_ShipLength";
            txt_ShipLength.Size = new Size(49, 27);
            txt_ShipLength.TabIndex = 0;
            // 
            // width
            // 
            width.AutoSize = true;
            width.Font = new Font("Segoe UI", 10F);
            width.Location = new Point(17, 85);
            width.Name = "width";
            width.Size = new Size(166, 23);
            width.TabIndex = 2;
            width.Text = "Width in Containers:";
            // 
            // length
            // 
            length.AutoSize = true;
            length.Font = new Font("Segoe UI", 10F);
            length.Location = new Point(10, 50);
            length.Name = "length";
            length.Size = new Size(173, 23);
            length.TabIndex = 1;
            length.Text = "Length in Containers:";
            // 
            // gb_Container
            // 
            gb_Container.Controls.Add(cb_IsCooled);
            gb_Container.Controls.Add(cb_HasValuables);
            gb_Container.Controls.Add(isCooled);
            gb_Container.Controls.Add(lb_Containers);
            gb_Container.Controls.Add(btn_AddContainer);
            gb_Container.Controls.Add(txt_ContainerWeight);
            gb_Container.Controls.Add(hasValuables);
            gb_Container.Controls.Add(weight);
            gb_Container.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            gb_Container.Location = new Point(388, 12);
            gb_Container.Name = "gb_Container";
            gb_Container.Size = new Size(474, 200);
            gb_Container.TabIndex = 4;
            gb_Container.TabStop = false;
            gb_Container.Text = "Container Creation";
            // 
            // cb_IsCooled
            // 
            cb_IsCooled.AutoSize = true;
            cb_IsCooled.Location = new Point(129, 124);
            cb_IsCooled.Name = "cb_IsCooled";
            cb_IsCooled.Size = new Size(18, 17);
            cb_IsCooled.TabIndex = 9;
            cb_IsCooled.UseVisualStyleBackColor = true;
            // 
            // cb_HasValuables
            // 
            cb_HasValuables.AutoSize = true;
            cb_HasValuables.Location = new Point(129, 91);
            cb_HasValuables.Name = "cb_HasValuables";
            cb_HasValuables.Size = new Size(18, 17);
            cb_HasValuables.TabIndex = 9;
            cb_HasValuables.UseVisualStyleBackColor = true;
            // 
            // isCooled
            // 
            isCooled.AutoSize = true;
            isCooled.Font = new Font("Segoe UI", 10F);
            isCooled.Location = new Point(49, 122);
            isCooled.Name = "isCooled";
            isCooled.Size = new Size(80, 23);
            isCooled.TabIndex = 7;
            isCooled.Text = "IsCooled:";
            // 
            // lb_Containers
            // 
            lb_Containers.Font = new Font("Segoe UI", 9F);
            lb_Containers.FormattingEnabled = true;
            lb_Containers.Location = new Point(225, 38);
            lb_Containers.Name = "lb_Containers";
            lb_Containers.Size = new Size(243, 144);
            lb_Containers.TabIndex = 6;
            // 
            // btn_AddContainer
            // 
            btn_AddContainer.Font = new Font("Segoe UI", 9F);
            btn_AddContainer.Location = new Point(6, 148);
            btn_AddContainer.Name = "btn_AddContainer";
            btn_AddContainer.Size = new Size(213, 34);
            btn_AddContainer.TabIndex = 5;
            btn_AddContainer.Text = "Add Container";
            btn_AddContainer.UseVisualStyleBackColor = true;
            btn_AddContainer.Click += btn_AddContainer_Click;
            // 
            // txt_ContainerWeight
            // 
            txt_ContainerWeight.Font = new Font("Segoe UI", 9F);
            txt_ContainerWeight.Location = new Point(130, 49);
            txt_ContainerWeight.Name = "txt_ContainerWeight";
            txt_ContainerWeight.Size = new Size(89, 27);
            txt_ContainerWeight.TabIndex = 3;
            // 
            // hasValuables
            // 
            hasValuables.AutoSize = true;
            hasValuables.Font = new Font("Segoe UI", 10F);
            hasValuables.Location = new Point(15, 87);
            hasValuables.Name = "hasValuables";
            hasValuables.Size = new Size(114, 23);
            hasValuables.TabIndex = 2;
            hasValuables.Text = "HasValuables:";
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Font = new Font("Segoe UI", 10F);
            weight.Location = new Point(10, 53);
            weight.Name = "weight";
            weight.Size = new Size(113, 23);
            weight.TabIndex = 1;
            weight.Text = "Weight in KG:";
            // 
            // txt_Output
            // 
            txt_Output.Location = new Point(12, 250);
            txt_Output.Multiline = true;
            txt_Output.Name = "txt_Output";
            txt_Output.Size = new Size(1054, 271);
            txt_Output.TabIndex = 5;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 10F);
            total.Location = new Point(6, 23);
            total.Name = "total";
            total.Size = new Size(137, 23);
            total.TabIndex = 6;
            total.Text = "Total Containers:";
            // 
            // gb_Summary
            // 
            gb_Summary.Controls.Add(btn_Execute);
            gb_Summary.Controls.Add(lbl_IsCooled);
            gb_Summary.Controls.Add(withcooling);
            gb_Summary.Controls.Add(lbl_WithValuables);
            gb_Summary.Controls.Add(withvaluables);
            gb_Summary.Controls.Add(lbl_TotalContainers);
            gb_Summary.Controls.Add(total);
            gb_Summary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gb_Summary.Location = new Point(868, 28);
            gb_Summary.Name = "gb_Summary";
            gb_Summary.Size = new Size(198, 184);
            gb_Summary.TabIndex = 7;
            gb_Summary.TabStop = false;
            gb_Summary.Text = "Summary";
            // 
            // btn_Execute
            // 
            btn_Execute.Font = new Font("Segoe UI", 12F);
            btn_Execute.Location = new Point(6, 132);
            btn_Execute.Name = "btn_Execute";
            btn_Execute.Size = new Size(186, 46);
            btn_Execute.TabIndex = 12;
            btn_Execute.Text = "Execute";
            btn_Execute.UseVisualStyleBackColor = true;
            btn_Execute.Click += btn_Execute_Click;
            // 
            // lbl_IsCooled
            // 
            lbl_IsCooled.AutoSize = true;
            lbl_IsCooled.Font = new Font("Segoe UI", 10F);
            lbl_IsCooled.Location = new Point(149, 89);
            lbl_IsCooled.Name = "lbl_IsCooled";
            lbl_IsCooled.Size = new Size(22, 23);
            lbl_IsCooled.TabIndex = 11;
            lbl_IsCooled.Text = "...";
            // 
            // withcooling
            // 
            withcooling.AutoSize = true;
            withcooling.Font = new Font("Segoe UI", 10F);
            withcooling.Location = new Point(29, 89);
            withcooling.Name = "withcooling";
            withcooling.Size = new Size(114, 23);
            withcooling.TabIndex = 10;
            withcooling.Text = "With Cooling:";
            // 
            // lbl_WithValuables
            // 
            lbl_WithValuables.AutoSize = true;
            lbl_WithValuables.Font = new Font("Segoe UI", 10F);
            lbl_WithValuables.Location = new Point(149, 55);
            lbl_WithValuables.Name = "lbl_WithValuables";
            lbl_WithValuables.Size = new Size(22, 23);
            lbl_WithValuables.TabIndex = 9;
            lbl_WithValuables.Text = "...";
            // 
            // withvaluables
            // 
            withvaluables.AutoSize = true;
            withvaluables.Font = new Font("Segoe UI", 10F);
            withvaluables.Location = new Point(16, 55);
            withvaluables.Name = "withvaluables";
            withvaluables.Size = new Size(127, 23);
            withvaluables.TabIndex = 8;
            withvaluables.Text = "With Valuables:";
            // 
            // lbl_TotalContainers
            // 
            lbl_TotalContainers.AutoSize = true;
            lbl_TotalContainers.Font = new Font("Segoe UI", 10F);
            lbl_TotalContainers.Location = new Point(149, 23);
            lbl_TotalContainers.Name = "lbl_TotalContainers";
            lbl_TotalContainers.Size = new Size(22, 23);
            lbl_TotalContainers.TabIndex = 7;
            lbl_TotalContainers.Text = "...";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            output.Location = new Point(12, 215);
            output.Name = "output";
            output.Size = new Size(102, 32);
            output.TabIndex = 8;
            output.Text = "Output:";
            // 
            // ContainerVervoer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 532);
            Controls.Add(output);
            Controls.Add(gb_Summary);
            Controls.Add(txt_Output);
            Controls.Add(gb_Container);
            Controls.Add(gb_Ship);
            Name = "ContainerVervoer";
            Text = "ContainerVervoer";
            gb_Ship.ResumeLayout(false);
            gb_Ship.PerformLayout();
            gb_Container.ResumeLayout(false);
            gb_Container.PerformLayout();
            gb_Summary.ResumeLayout(false);
            gb_Summary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gb_Ship;
        private TextBox txt_ShipWidth;
        private TextBox txt_ShipLength;
        private Label width;
        private Label length;
        private Button btn_InitializeShip;
        private GroupBox gb_Container;
        private ListBox lb_Containers;
        private Button btn_AddContainer;
        private TextBox txt_ContainerWeight;
        private Label hasValuables;
        private Label weight;
        private Label isCooled;
        private TextBox txt_Output;
        private Label total;
        private GroupBox gb_Summary;
        private Label lbl_WithValuables;
        private Label withvaluables;
        private Label lbl_TotalContainers;
        private Label lbl_IsCooled;
        private Label withcooling;
        private Label output;
        private CheckBox cb_HasValuables;
        private CheckBox cb_IsCooled;
        private Button btn_ClearShip;
        private Button btn_Execute;
        private TextBox txt_ShipLayout;
    }
}
