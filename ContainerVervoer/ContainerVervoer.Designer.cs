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
            cb_ContainerWeight = new ComboBox();
            cb_IsCooled = new CheckBox();
            cb_HasValuables = new CheckBox();
            isCooled = new Label();
            lb_Containers = new ListBox();
            btn_AddContainer = new Button();
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
            gb_Ship.Location = new Point(10, 9);
            gb_Ship.Margin = new Padding(3, 2, 3, 2);
            gb_Ship.Name = "gb_Ship";
            gb_Ship.Padding = new Padding(3, 2, 3, 2);
            gb_Ship.Size = new Size(324, 150);
            gb_Ship.TabIndex = 3;
            gb_Ship.TabStop = false;
            gb_Ship.Text = "Ship Creation";
            // 
            // txt_ShipLayout
            // 
            txt_ShipLayout.Font = new Font("Segoe UI", 6F);
            txt_ShipLayout.Location = new Point(214, 21);
            txt_ShipLayout.Margin = new Padding(3, 2, 3, 2);
            txt_ShipLayout.Multiline = true;
            txt_ShipLayout.Name = "txt_ShipLayout";
            txt_ShipLayout.ReadOnly = true;
            txt_ShipLayout.ScrollBars = ScrollBars.Both;
            txt_ShipLayout.Size = new Size(103, 124);
            txt_ShipLayout.TabIndex = 7;
            // 
            // btn_ClearShip
            // 
            btn_ClearShip.Font = new Font("Segoe UI", 9F);
            btn_ClearShip.Location = new Point(9, 118);
            btn_ClearShip.Margin = new Padding(3, 2, 3, 2);
            btn_ClearShip.Name = "btn_ClearShip";
            btn_ClearShip.Size = new Size(200, 26);
            btn_ClearShip.TabIndex = 6;
            btn_ClearShip.Text = "Clear Ship";
            btn_ClearShip.UseVisualStyleBackColor = true;
            btn_ClearShip.Click += btn_ClearShip_Click;
            // 
            // btn_InitializeShip
            // 
            btn_InitializeShip.Font = new Font("Segoe UI", 9F);
            btn_InitializeShip.Location = new Point(9, 88);
            btn_InitializeShip.Margin = new Padding(3, 2, 3, 2);
            btn_InitializeShip.Name = "btn_InitializeShip";
            btn_InitializeShip.Size = new Size(200, 26);
            btn_InitializeShip.TabIndex = 5;
            btn_InitializeShip.Text = "Initialize Ship";
            btn_InitializeShip.UseVisualStyleBackColor = true;
            btn_InitializeShip.Click += btn_InitializeShip_Click;
            // 
            // txt_ShipWidth
            // 
            txt_ShipWidth.Font = new Font("Segoe UI", 9F);
            txt_ShipWidth.Location = new Point(165, 63);
            txt_ShipWidth.Margin = new Padding(3, 2, 3, 2);
            txt_ShipWidth.Name = "txt_ShipWidth";
            txt_ShipWidth.Size = new Size(43, 23);
            txt_ShipWidth.TabIndex = 4;
            // 
            // txt_ShipLength
            // 
            txt_ShipLength.Font = new Font("Segoe UI", 9F);
            txt_ShipLength.Location = new Point(165, 35);
            txt_ShipLength.Margin = new Padding(3, 2, 3, 2);
            txt_ShipLength.Name = "txt_ShipLength";
            txt_ShipLength.Size = new Size(43, 23);
            txt_ShipLength.TabIndex = 0;
            // 
            // width
            // 
            width.AutoSize = true;
            width.Font = new Font("Segoe UI", 10F);
            width.Location = new Point(15, 64);
            width.Name = "width";
            width.Size = new Size(134, 19);
            width.TabIndex = 2;
            width.Text = "Width in Containers:";
            // 
            // length
            // 
            length.AutoSize = true;
            length.Font = new Font("Segoe UI", 10F);
            length.Location = new Point(9, 38);
            length.Name = "length";
            length.Size = new Size(140, 19);
            length.TabIndex = 1;
            length.Text = "Length in Containers:";
            // 
            // gb_Container
            // 
            gb_Container.Controls.Add(cb_ContainerWeight);
            gb_Container.Controls.Add(cb_IsCooled);
            gb_Container.Controls.Add(cb_HasValuables);
            gb_Container.Controls.Add(isCooled);
            gb_Container.Controls.Add(lb_Containers);
            gb_Container.Controls.Add(btn_AddContainer);
            gb_Container.Controls.Add(hasValuables);
            gb_Container.Controls.Add(weight);
            gb_Container.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            gb_Container.Location = new Point(340, 9);
            gb_Container.Margin = new Padding(3, 2, 3, 2);
            gb_Container.Name = "gb_Container";
            gb_Container.Padding = new Padding(3, 2, 3, 2);
            gb_Container.Size = new Size(415, 150);
            gb_Container.TabIndex = 4;
            gb_Container.TabStop = false;
            gb_Container.Text = "Container Creation";
            // 
            // cb_ContainerWeight
            // 
            cb_ContainerWeight.Font = new Font("Segoe UI", 9F);
            cb_ContainerWeight.FormattingEnabled = true;
            cb_ContainerWeight.Location = new Point(113, 39);
            cb_ContainerWeight.Name = "cb_ContainerWeight";
            cb_ContainerWeight.Size = new Size(78, 23);
            cb_ContainerWeight.TabIndex = 9;
            // 
            // cb_IsCooled
            // 
            cb_IsCooled.AutoSize = true;
            cb_IsCooled.Location = new Point(113, 93);
            cb_IsCooled.Margin = new Padding(3, 2, 3, 2);
            cb_IsCooled.Name = "cb_IsCooled";
            cb_IsCooled.Size = new Size(15, 14);
            cb_IsCooled.TabIndex = 9;
            cb_IsCooled.UseVisualStyleBackColor = true;
            // 
            // cb_HasValuables
            // 
            cb_HasValuables.AutoSize = true;
            cb_HasValuables.Location = new Point(113, 68);
            cb_HasValuables.Margin = new Padding(3, 2, 3, 2);
            cb_HasValuables.Name = "cb_HasValuables";
            cb_HasValuables.Size = new Size(15, 14);
            cb_HasValuables.TabIndex = 9;
            cb_HasValuables.UseVisualStyleBackColor = true;
            // 
            // isCooled
            // 
            isCooled.AutoSize = true;
            isCooled.Font = new Font("Segoe UI", 10F);
            isCooled.Location = new Point(43, 92);
            isCooled.Name = "isCooled";
            isCooled.Size = new Size(65, 19);
            isCooled.TabIndex = 7;
            isCooled.Text = "IsCooled:";
            // 
            // lb_Containers
            // 
            lb_Containers.Font = new Font("Segoe UI", 9F);
            lb_Containers.FormattingEnabled = true;
            lb_Containers.ItemHeight = 15;
            lb_Containers.Location = new Point(197, 28);
            lb_Containers.Margin = new Padding(3, 2, 3, 2);
            lb_Containers.Name = "lb_Containers";
            lb_Containers.Size = new Size(213, 109);
            lb_Containers.TabIndex = 6;
            // 
            // btn_AddContainer
            // 
            btn_AddContainer.Font = new Font("Segoe UI", 9F);
            btn_AddContainer.Location = new Point(5, 111);
            btn_AddContainer.Margin = new Padding(3, 2, 3, 2);
            btn_AddContainer.Name = "btn_AddContainer";
            btn_AddContainer.Size = new Size(186, 26);
            btn_AddContainer.TabIndex = 5;
            btn_AddContainer.Text = "Add Container";
            btn_AddContainer.UseVisualStyleBackColor = true;
            btn_AddContainer.Click += btn_AddContainer_Click;
            // 
            // hasValuables
            // 
            hasValuables.AutoSize = true;
            hasValuables.Font = new Font("Segoe UI", 10F);
            hasValuables.Location = new Point(13, 65);
            hasValuables.Name = "hasValuables";
            hasValuables.Size = new Size(92, 19);
            hasValuables.TabIndex = 2;
            hasValuables.Text = "HasValuables:";
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Font = new Font("Segoe UI", 10F);
            weight.Location = new Point(9, 40);
            weight.Name = "weight";
            weight.Size = new Size(96, 19);
            weight.TabIndex = 1;
            weight.Text = "Weight in Ton:";
            // 
            // txt_Output
            // 
            txt_Output.Location = new Point(10, 188);
            txt_Output.Margin = new Padding(3, 2, 3, 2);
            txt_Output.Multiline = true;
            txt_Output.Name = "txt_Output";
            txt_Output.Size = new Size(923, 204);
            txt_Output.TabIndex = 5;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 10F);
            total.Location = new Point(5, 17);
            total.Name = "total";
            total.Size = new Size(111, 19);
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
            gb_Summary.Location = new Point(760, 21);
            gb_Summary.Margin = new Padding(3, 2, 3, 2);
            gb_Summary.Name = "gb_Summary";
            gb_Summary.Padding = new Padding(3, 2, 3, 2);
            gb_Summary.Size = new Size(173, 138);
            gb_Summary.TabIndex = 7;
            gb_Summary.TabStop = false;
            gb_Summary.Text = "Summary";
            // 
            // btn_Execute
            // 
            btn_Execute.Font = new Font("Segoe UI", 12F);
            btn_Execute.Location = new Point(5, 99);
            btn_Execute.Margin = new Padding(3, 2, 3, 2);
            btn_Execute.Name = "btn_Execute";
            btn_Execute.Size = new Size(163, 34);
            btn_Execute.TabIndex = 12;
            btn_Execute.Text = "Execute";
            btn_Execute.UseVisualStyleBackColor = true;
            btn_Execute.Click += btn_Execute_Click;
            // 
            // lbl_IsCooled
            // 
            lbl_IsCooled.AutoSize = true;
            lbl_IsCooled.Font = new Font("Segoe UI", 10F);
            lbl_IsCooled.Location = new Point(130, 67);
            lbl_IsCooled.Name = "lbl_IsCooled";
            lbl_IsCooled.Size = new Size(18, 19);
            lbl_IsCooled.TabIndex = 11;
            lbl_IsCooled.Text = "...";
            // 
            // withcooling
            // 
            withcooling.AutoSize = true;
            withcooling.Font = new Font("Segoe UI", 10F);
            withcooling.Location = new Point(25, 67);
            withcooling.Name = "withcooling";
            withcooling.Size = new Size(92, 19);
            withcooling.TabIndex = 10;
            withcooling.Text = "With Cooling:";
            // 
            // lbl_WithValuables
            // 
            lbl_WithValuables.AutoSize = true;
            lbl_WithValuables.Font = new Font("Segoe UI", 10F);
            lbl_WithValuables.Location = new Point(130, 41);
            lbl_WithValuables.Name = "lbl_WithValuables";
            lbl_WithValuables.Size = new Size(18, 19);
            lbl_WithValuables.TabIndex = 9;
            lbl_WithValuables.Text = "...";
            // 
            // withvaluables
            // 
            withvaluables.AutoSize = true;
            withvaluables.Font = new Font("Segoe UI", 10F);
            withvaluables.Location = new Point(14, 41);
            withvaluables.Name = "withvaluables";
            withvaluables.Size = new Size(102, 19);
            withvaluables.TabIndex = 8;
            withvaluables.Text = "With Valuables:";
            // 
            // lbl_TotalContainers
            // 
            lbl_TotalContainers.AutoSize = true;
            lbl_TotalContainers.Font = new Font("Segoe UI", 10F);
            lbl_TotalContainers.Location = new Point(130, 17);
            lbl_TotalContainers.Name = "lbl_TotalContainers";
            lbl_TotalContainers.Size = new Size(18, 19);
            lbl_TotalContainers.TabIndex = 7;
            lbl_TotalContainers.Text = "...";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            output.Location = new Point(10, 161);
            output.Name = "output";
            output.Size = new Size(81, 25);
            output.TabIndex = 8;
            output.Text = "Output:";
            // 
            // ContainerVervoer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 399);
            Controls.Add(output);
            Controls.Add(gb_Summary);
            Controls.Add(txt_Output);
            Controls.Add(gb_Container);
            Controls.Add(gb_Ship);
            Margin = new Padding(3, 2, 3, 2);
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
        private ComboBox cb_ContainerWeight;
    }
}
