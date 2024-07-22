namespace efcode_first;

partial class Form1
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
        search = new Button();
        table = new DataGridView();
        reset = new Button();
        label1 = new Label();
        fname = new TextBox();
        lname = new TextBox();
        label2 = new Label();
        age = new TextBox();
        label3 = new Label();
        gender = new TextBox();
        label4 = new Label();
        items = new ComboBox();
        label5 = new Label();
        add = new Button();
        user_name = new TextBox();
        ((System.ComponentModel.ISupportInitialize)table).BeginInit();
        SuspendLayout();
        // 
        // search
        // 
        search.Location = new Point(199, 336);
        search.Name = "search";
        search.Size = new Size(96, 29);
        search.TabIndex = 0;
        search.Text = "search";
        search.UseVisualStyleBackColor = true;
        search.Click += search_Click;
        // 
        // table
        // 
        table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        table.Location = new Point(58, 45);
        table.Name = "table";
        table.RowHeadersWidth = 51;
        table.Size = new Size(482, 282);
        table.TabIndex = 1;
        // 
        // reset
        // 
        reset.Location = new Point(412, 336);
        reset.Name = "reset";
        reset.Size = new Size(94, 29);
        reset.TabIndex = 2;
        reset.Text = "reset";
        reset.UseVisualStyleBackColor = true;
        reset.Click += reset_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(639, 106);
        label1.Name = "label1";
        label1.Size = new Size(51, 20);
        label1.TabIndex = 3;
        label1.Text = "fname";
        // 
        // fname
        // 
        fname.Location = new Point(639, 129);
        fname.Name = "fname";
        fname.Size = new Size(125, 27);
        fname.TabIndex = 4;
        // 
        // lname
        // 
        lname.Location = new Point(836, 129);
        lname.Name = "lname";
        lname.Size = new Size(125, 27);
        lname.TabIndex = 6;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(836, 106);
        label2.Name = "label2";
        label2.Size = new Size(50, 20);
        label2.TabIndex = 5;
        label2.Text = "lname";
        // 
        // age
        // 
        age.Location = new Point(639, 223);
        age.Name = "age";
        age.Size = new Size(125, 27);
        age.TabIndex = 8;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(639, 200);
        label3.Name = "label3";
        label3.Size = new Size(34, 20);
        label3.TabIndex = 7;
        label3.Text = "age";
        // 
        // gender
        // 
        gender.Location = new Point(836, 223);
        gender.Name = "gender";
        gender.Size = new Size(125, 27);
        gender.TabIndex = 10;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(836, 200);
        label4.Name = "label4";
        label4.Size = new Size(56, 20);
        label4.TabIndex = 9;
        label4.Text = "gender";
        // 
        // items
        // 
        items.FormattingEnabled = true;
        items.Location = new Point(639, 331);
        items.Name = "items";
        items.Size = new Size(151, 28);
        items.TabIndex = 11;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(640, 308);
        label5.Name = "label5";
        label5.Size = new Size(45, 20);
        label5.TabIndex = 12;
        label5.Text = "items";
        // 
        // add
        // 
        add.Location = new Point(740, 443);
        add.Name = "add";
        add.Size = new Size(94, 29);
        add.TabIndex = 13;
        add.Text = "submit";
        add.UseVisualStyleBackColor = true;
        add.Click += add_Click;
        // 
        // user_name
        // 
        user_name.Location = new Point(58, 336);
        user_name.Name = "user_name";
        user_name.Size = new Size(125, 27);
        user_name.TabIndex = 14;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1049, 636);
        Controls.Add(user_name);
        Controls.Add(add);
        Controls.Add(label5);
        Controls.Add(items);
        Controls.Add(gender);
        Controls.Add(label4);
        Controls.Add(age);
        Controls.Add(label3);
        Controls.Add(lname);
        Controls.Add(label2);
        Controls.Add(fname);
        Controls.Add(label1);
        Controls.Add(reset);
        Controls.Add(table);
        Controls.Add(search);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)table).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    private Button search;
    private DataGridView table;
    private Button reset;
    private Label label1;
    private TextBox fname;
    private TextBox lname;
    private Label label2;
    private TextBox age;
    private Label label3;
    private TextBox gender;
    private Label label4;
    private ComboBox items;
    private Label label5;
    private Button add;
    private TextBox user_name;

    #endregion
}
