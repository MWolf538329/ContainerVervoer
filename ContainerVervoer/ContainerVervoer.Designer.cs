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
            txt_ShipOutput = new TextBox();
            gb_Ship = new GroupBox();
            length = new Label();
            width = new Label();
            txt_ShipLength = new TextBox();
            txt_ShipWidth = new TextBox();
            btn_AddShip = new Button();
            gb_Container = new GroupBox();
            btn_AddContainer = new Button();
            txt_ContainerWeight = new TextBox();
            hasValuables = new Label();
            weight = new Label();
            lb_Containers = new ListBox();
            isCooled = new Label();
            rb_HasValuables = new RadioButton();
            rb_IsCooled = new RadioButton();
            txt_Output = new TextBox();
            total = new Label();
            gb_Summary = new GroupBox();
            lbl_TotalContainers = new Label();
            lbl_WithValuables = new Label();
            withvaluables = new Label();
            lbl_IsCooled = new Label();
            withcooling = new Label();
            output = new Label();
            gb_Ship.SuspendLayout();
            gb_Container.SuspendLayout();
            gb_Summary.SuspendLayout();
            SuspendLayout();
            // 
            // txt_ShipOutput
            // 
            txt_ShipOutput.Location = new Point(244, 29);
            txt_ShipOutput.Multiline = true;
            txt_ShipOutput.Name = "txt_ShipOutput";
            txt_ShipOutput.Size = new Size(224, 123);
            txt_ShipOutput.TabIndex = 0;
            // 
            // gb_Ship
            // 
            gb_Ship.Controls.Add(btn_AddShip);
            gb_Ship.Controls.Add(txt_ShipWidth);
            gb_Ship.Controls.Add(txt_ShipLength);
            gb_Ship.Controls.Add(width);
            gb_Ship.Controls.Add(length);
            gb_Ship.Controls.Add(txt_ShipOutput);
            gb_Ship.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            gb_Ship.Location = new Point(12, 12);
            gb_Ship.Name = "gb_Ship";
            gb_Ship.Size = new Size(474, 169);
            gb_Ship.TabIndex = 3;
            gb_Ship.TabStop = false;
            gb_Ship.Text = "Ship Creation";
            gb_Ship.Enter += this.groupBox1_Enter;
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
            // txt_ShipLength
            // 
            txt_ShipLength.Font = new Font("Segoe UI", 9F);
            txt_ShipLength.Location = new Point(189, 47);
            txt_ShipLength.Name = "txt_ShipLength";
            txt_ShipLength.Size = new Size(49, 27);
            txt_ShipLength.TabIndex = 3;
            // 
            // txt_ShipWidth
            // 
            txt_ShipWidth.Font = new Font("Segoe UI", 9F);
            txt_ShipWidth.Location = new Point(189, 84);
            txt_ShipWidth.Name = "txt_ShipWidth";
            txt_ShipWidth.Size = new Size(49, 27);
            txt_ShipWidth.TabIndex = 4;
            // 
            // btn_AddShip
            // 
            btn_AddShip.Font = new Font("Segoe UI", 9F);
            btn_AddShip.Location = new Point(10, 118);
            btn_AddShip.Name = "btn_AddShip";
            btn_AddShip.Size = new Size(228, 34);
            btn_AddShip.TabIndex = 5;
            btn_AddShip.Text = "Add Ship";
            btn_AddShip.UseVisualStyleBackColor = true;
            // 
            // gb_Container
            // 
            gb_Container.Controls.Add(rb_IsCooled);
            gb_Container.Controls.Add(rb_HasValuables);
            gb_Container.Controls.Add(isCooled);
            gb_Container.Controls.Add(lb_Containers);
            gb_Container.Controls.Add(btn_AddContainer);
            gb_Container.Controls.Add(txt_ContainerWeight);
            gb_Container.Controls.Add(hasValuables);
            gb_Container.Controls.Add(weight);
            gb_Container.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            gb_Container.Location = new Point(492, 12);
            gb_Container.Name = "gb_Container";
            gb_Container.Size = new Size(474, 194);
            gb_Container.TabIndex = 4;
            gb_Container.TabStop = false;
            gb_Container.Text = "Container Creation";
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
            weight.Size = new Size(119, 23);
            weight.TabIndex = 1;
            weight.Text = "Weight in Ton:";
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
            // rb_HasValuables
            // 
            rb_HasValuables.AutoSize = true;
            rb_HasValuables.Font = new Font("Segoe UI", 9F);
            rb_HasValuables.Location = new Point(130, 91);
            rb_HasValuables.Name = "rb_HasValuables";
            rb_HasValuables.Size = new Size(17, 16);
            rb_HasValuables.TabIndex = 8;
            rb_HasValuables.TabStop = true;
            rb_HasValuables.UseVisualStyleBackColor = true;
            // 
            // rb_IsCooled
            // 
            rb_IsCooled.AutoSize = true;
            rb_IsCooled.Font = new Font("Segoe UI", 9F);
            rb_IsCooled.Location = new Point(130, 126);
            rb_IsCooled.Name = "rb_IsCooled";
            rb_IsCooled.Size = new Size(17, 16);
            rb_IsCooled.TabIndex = 9;
            rb_IsCooled.TabStop = true;
            rb_IsCooled.UseVisualStyleBackColor = true;
            // 
            // txt_Output
            // 
            txt_Output.Location = new Point(12, 289);
            txt_Output.Multiline = true;
            txt_Output.Name = "txt_Output";
            txt_Output.Size = new Size(954, 271);
            txt_Output.TabIndex = 5;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(6, 23);
            total.Name = "total";
            total.Size = new Size(119, 20);
            total.TabIndex = 6;
            total.Text = "Total Containers:";
            // 
            // gb_Summary
            // 
            gb_Summary.Controls.Add(lbl_IsCooled);
            gb_Summary.Controls.Add(withcooling);
            gb_Summary.Controls.Add(lbl_WithValuables);
            gb_Summary.Controls.Add(withvaluables);
            gb_Summary.Controls.Add(lbl_TotalContainers);
            gb_Summary.Controls.Add(total);
            gb_Summary.Location = new Point(492, 212);
            gb_Summary.Name = "gb_Summary";
            gb_Summary.Size = new Size(474, 71);
            gb_Summary.TabIndex = 7;
            gb_Summary.TabStop = false;
            gb_Summary.Text = "Summary";
            // 
            // lbl_TotalContainers
            // 
            lbl_TotalContainers.AutoSize = true;
            lbl_TotalContainers.Location = new Point(131, 23);
            lbl_TotalContainers.Name = "lbl_TotalContainers";
            lbl_TotalContainers.Size = new Size(18, 20);
            lbl_TotalContainers.TabIndex = 7;
            lbl_TotalContainers.Text = "...";
            // 
            // lbl_WithValuables
            // 
            lbl_WithValuables.AutoSize = true;
            lbl_WithValuables.Location = new Point(271, 23);
            lbl_WithValuables.Name = "lbl_WithValuables";
            lbl_WithValuables.Size = new Size(18, 20);
            lbl_WithValuables.TabIndex = 9;
            lbl_WithValuables.Text = "...";
            lbl_WithValuables.Click += this.label1_Click;
            // 
            // withvaluables
            // 
            withvaluables.AutoSize = true;
            withvaluables.Location = new Point(155, 23);
            withvaluables.Name = "withvaluables";
            withvaluables.Size = new Size(110, 20);
            withvaluables.TabIndex = 8;
            withvaluables.Text = "With Valuables:";
            // 
            // lbl_IsCooled
            // 
            lbl_IsCooled.AutoSize = true;
            lbl_IsCooled.Location = new Point(411, 23);
            lbl_IsCooled.Name = "lbl_IsCooled";
            lbl_IsCooled.Size = new Size(18, 20);
            lbl_IsCooled.TabIndex = 11;
            lbl_IsCooled.Text = "...";
            // 
            // withcooling
            // 
            withcooling.AutoSize = true;
            withcooling.Location = new Point(295, 23);
            withcooling.Name = "withcooling";
            withcooling.Size = new Size(110, 20);
            withcooling.TabIndex = 10;
            withcooling.Text = "With Valuables:";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            output.Location = new Point(12, 251);
            output.Name = "output";
            output.Size = new Size(102, 32);
            output.TabIndex = 8;
            output.Text = "Output:";
            // 
            // ContainerVervoer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 572);
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

        private TextBox txt_ShipOutput;
        private GroupBox gb_Ship;
        private TextBox txt_ShipWidth;
        private TextBox txt_ShipLength;
        private Label width;
        private Label length;
        private Button btn_AddShip;
        private GroupBox gb_Container;
        private ListBox lb_Containers;
        private Button btn_AddContainer;
        private TextBox textBox3;
        private TextBox txt_ContainerWeight;
        private Label hasValuables;
        private Label weight;
        private Label isCooled;
        private RadioButton rb_IsCooled;
        private RadioButton rb_HasValuables;
        private TextBox txt_Output;
        private Label total;
        private GroupBox gb_Summary;
        private Label lbl_WithValuables;
        private Label withvaluables;
        private Label lbl_TotalContainers;
        private Label lbl_IsCooled;
        private Label withcooling;
        private Label output;
    }
}
