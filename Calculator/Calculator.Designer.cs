namespace Calculator
{
    partial class Calculator
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
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            DotBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            ModuleBtn = new Button();
            MultiplyBtn = new Button();
            PlusBtn = new Button();
            MinusPlusBtn = new Button();
            DevideBtn = new Button();
            MinusBtn = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox.Location = new Point(12, 12);
            TxtBox.Name = "TxtBox";
            TxtBox.ReadOnly = true;
            TxtBox.Size = new Size(503, 51);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            TxtBox.TextChanged += textBox1_TextChanged;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SevenBtn.Location = new Point(12, 72);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(87, 84);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FourBtn.Location = new Point(12, 162);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(87, 84);
            FourBtn.TabIndex = 2;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OneBtn.Location = new Point(12, 252);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(87, 84);
            OneBtn.TabIndex = 3;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += button3_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ZeroBtn.Location = new Point(12, 342);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(87, 84);
            ZeroBtn.TabIndex = 4;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += button4_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DotBtn.Location = new Point(105, 342);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(87, 84);
            DotBtn.TabIndex = 8;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TwoBtn.Location = new Point(105, 252);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(87, 84);
            TwoBtn.TabIndex = 7;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FiveBtn.Location = new Point(105, 162);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(87, 84);
            FiveBtn.TabIndex = 6;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FIveBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EightBtn.Location = new Point(105, 72);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(87, 84);
            EightBtn.TabIndex = 5;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EIghtBtn_Click;
            EightBtn.Resize += EightBtn_Resize;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EqualBtn.Location = new Point(198, 342);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(87, 84);
            EqualBtn.TabIndex = 12;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ThreeBtn.Location = new Point(198, 252);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(87, 84);
            ThreeBtn.TabIndex = 11;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SixBtn.Location = new Point(198, 162);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(87, 84);
            SixBtn.TabIndex = 10;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SIxBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NineBtn.Location = new Point(198, 69);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(87, 84);
            NineBtn.TabIndex = 9;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // ModuleBtn
            // 
            ModuleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModuleBtn.Location = new Point(428, 342);
            ModuleBtn.Name = "ModuleBtn";
            ModuleBtn.Size = new Size(87, 84);
            ModuleBtn.TabIndex = 16;
            ModuleBtn.Text = "%";
            ModuleBtn.UseVisualStyleBackColor = true;
            ModuleBtn.Click += button13_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MultiplyBtn.Location = new Point(428, 252);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(87, 84);
            MultiplyBtn.TabIndex = 15;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += button14_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlusBtn.Location = new Point(428, 162);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(87, 84);
            PlusBtn.TabIndex = 14;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += button15_Click;
            // 
            // MinusPlusBtn
            // 
            MinusPlusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinusPlusBtn.Location = new Point(336, 342);
            MinusPlusBtn.Name = "MinusPlusBtn";
            MinusPlusBtn.Size = new Size(87, 84);
            MinusPlusBtn.TabIndex = 20;
            MinusPlusBtn.Text = "-/+";
            MinusPlusBtn.UseVisualStyleBackColor = true;
            MinusPlusBtn.Click += button17_Click;
            // 
            // DevideBtn
            // 
            DevideBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DevideBtn.Location = new Point(336, 252);
            DevideBtn.Name = "DevideBtn";
            DevideBtn.Size = new Size(87, 84);
            DevideBtn.TabIndex = 19;
            DevideBtn.Text = "/";
            DevideBtn.UseVisualStyleBackColor = true;
            DevideBtn.Click += button18_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinusBtn.Location = new Point(336, 162);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(87, 84);
            MinusBtn.TabIndex = 18;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += button19_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.Location = new Point(336, 72);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(177, 84);
            ClearBtn.TabIndex = 17;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += button20_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 437);
            Controls.Add(MinusPlusBtn);
            Controls.Add(DevideBtn);
            Controls.Add(MinusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(ModuleBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(PlusBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            Resize += Calculator_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button DotBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button ModuleBtn;
        private Button MultiplyBtn;
        private Button PlusBtn;
        private Button MinusPlusBtn;
        private Button DevideBtn;
        private Button MinusBtn;
        private Button ClearBtn;
    }
}