using System.ComponentModel;

namespace lab_2_1_2.Pages {
partial class Task2Page {
  /// <summary> 
  /// Required designer variable.
  /// </summary>
  private IContainer components = null;

  /// <summary> 
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  #region Component Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
    this.table_main = new System.Windows.Forms.TableLayoutPanel();
    this.text_b = new System.Windows.Forms.TextBox();
    this.text_a = new System.Windows.Forms.TextBox();
    this.text_x = new System.Windows.Forms.TextBox();
    this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
    this.text_x_x = new System.Windows.Forms.TextBox();
    this.text_y_x = new System.Windows.Forms.TextBox();
    this.text_z_x = new System.Windows.Forms.TextBox();
    this.lbl_x = new System.Windows.Forms.Label();
    this.lbl_y = new System.Windows.Forms.Label();
    this.lbl_z = new System.Windows.Forms.Label();
    this.lbl_result = new System.Windows.Forms.Label();
    this.text_result = new System.Windows.Forms.TextBox();
    this.lbl_task = new System.Windows.Forms.Label();
    this.text_x_y = new System.Windows.Forms.TextBox();
    this.text_y_y = new System.Windows.Forms.TextBox();
    this.text_z_y = new System.Windows.Forms.TextBox();
    this.table_main.SuspendLayout();
    this.tableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    // 
    // table_main
    // 
    this.table_main.AutoSize = true;
    this.table_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.table_main.ColumnCount = 5;
    this.table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.07143F));
    this.table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.07143F));
    this.table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71428F));
    this.table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.07143F));
    this.table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.07143F));
    this.table_main.Controls.Add(this.text_b, 4, 2);
    this.table_main.Controls.Add(this.text_a, 4, 0);
    this.table_main.Location = new System.Drawing.Point(0, 0);
    this.table_main.Name = "table_main";
    this.table_main.RowCount = 3;
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
    this.table_main.Size = new System.Drawing.Size(200, 100);
    this.table_main.TabIndex = 0;
    // 
    // text_b
    // 
    this.text_b.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_b.Location = new System.Drawing.Point(170, 60);
    this.text_b.Name = "text_b";
    this.text_b.ReadOnly = true;
    this.text_b.Size = new System.Drawing.Size(27, 20);
    this.text_b.TabIndex = 4;
    // 
    // text_a
    // 
    this.text_a.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_a.Location = new System.Drawing.Point(170, 3);
    this.text_a.Name = "text_a";
    this.text_a.ReadOnly = true;
    this.text_a.Size = new System.Drawing.Size(27, 20);
    this.text_a.TabIndex = 3;
    // 
    // text_x
    // 
    this.text_x.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_x.Location = new System.Drawing.Point(35, 3);
    this.text_x.MaxLength = 10;
    this.text_x.Name = "text_x";
    this.text_x.Size = new System.Drawing.Size(26, 20);
    this.text_x.TabIndex = 2;
    // 
    // tableLayoutPanel1
    // 
    this.tableLayoutPanel1.AutoSize = true;
    this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.tableLayoutPanel1.ColumnCount = 6;
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.08292F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.005719F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.005719F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.73981F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.08292F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.08292F));
    this.tableLayoutPanel1.Controls.Add(this.text_x_x, 1, 0);
    this.tableLayoutPanel1.Controls.Add(this.text_y_x, 1, 1);
    this.tableLayoutPanel1.Controls.Add(this.text_z_x, 1, 2);
    this.tableLayoutPanel1.Controls.Add(this.lbl_x, 0, 0);
    this.tableLayoutPanel1.Controls.Add(this.lbl_y, 0, 1);
    this.tableLayoutPanel1.Controls.Add(this.lbl_z, 0, 2);
    this.tableLayoutPanel1.Controls.Add(this.lbl_result, 4, 1);
    this.tableLayoutPanel1.Controls.Add(this.text_result, 5, 1);
    this.tableLayoutPanel1.Controls.Add(this.lbl_task, 3, 1);
    this.tableLayoutPanel1.Controls.Add(this.text_x_y, 2, 0);
    this.tableLayoutPanel1.Controls.Add(this.text_y_y, 2, 1);
    this.tableLayoutPanel1.Controls.Add(this.text_z_y, 2, 2);
    this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
    this.tableLayoutPanel1.RowCount = 3;
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
    this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 395);
    this.tableLayoutPanel1.TabIndex = 1;
    // 
    // text_x_x
    // 
    this.text_x_x.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_x_x.Location = new System.Drawing.Point(111, 55);
    this.text_x_x.MaxLength = 10;
    this.text_x_x.Name = "text_x_x";
    this.text_x_x.Size = new System.Drawing.Size(48, 20);
    this.text_x_x.TabIndex = 2;
    this.text_x_x.TextChanged += new System.EventHandler(this.text_x_x_TextChanged);
    this.text_x_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // text_y_x
    // 
    this.text_y_x.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_y_x.Location = new System.Drawing.Point(111, 186);
    this.text_y_x.MaxLength = 10;
    this.text_y_x.Name = "text_y_x";
    this.text_y_x.Size = new System.Drawing.Size(48, 20);
    this.text_y_x.TabIndex = 1;
    this.text_y_x.TextChanged += new System.EventHandler(this.text_y_x_TextChanged);
    this.text_y_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // text_z_x
    // 
    this.text_z_x.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_z_x.Location = new System.Drawing.Point(111, 318);
    this.text_z_x.MaxLength = 10;
    this.text_z_x.Name = "text_z_x";
    this.text_z_x.Size = new System.Drawing.Size(48, 20);
    this.text_z_x.TabIndex = 0;
    this.text_z_x.TextChanged += new System.EventHandler(this.text_z_x_TextChanged);
    this.text_z_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // lbl_x
    // 
    this.lbl_x.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_x.Location = new System.Drawing.Point(8, 54);
    this.lbl_x.Name = "lbl_x";
    this.lbl_x.Size = new System.Drawing.Size(91, 23);
    this.lbl_x.TabIndex = 5;
    this.lbl_x.Text = "Введите точку X";
    this.lbl_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_y
    // 
    this.lbl_y.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_y.Location = new System.Drawing.Point(8, 185);
    this.lbl_y.Name = "lbl_y";
    this.lbl_y.Size = new System.Drawing.Size(91, 23);
    this.lbl_y.TabIndex = 6;
    this.lbl_y.Text = "Введите точку Y";
    this.lbl_y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_z
    // 
    this.lbl_z.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_z.Location = new System.Drawing.Point(8, 317);
    this.lbl_z.Name = "lbl_z";
    this.lbl_z.Size = new System.Drawing.Size(91, 23);
    this.lbl_z.TabIndex = 7;
    this.lbl_z.Text = "Введите точку Z";
    this.lbl_z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_result
    // 
    this.lbl_result.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_result.Location = new System.Drawing.Point(465, 185);
    this.lbl_result.Name = "lbl_result";
    this.lbl_result.Size = new System.Drawing.Size(91, 23);
    this.lbl_result.TabIndex = 8;
    this.lbl_result.Text = "Результат";
    this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // text_result
    // 
    this.text_result.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_result.Location = new System.Drawing.Point(573, 186);
    this.text_result.Name = "text_result";
    this.text_result.ReadOnly = true;
    this.text_result.Size = new System.Drawing.Size(94, 20);
    this.text_result.TabIndex = 3;
    // 
    // lbl_task
    // 
    this.lbl_task.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_task.Location = new System.Drawing.Point(237, 147);
    this.lbl_task.Name = "lbl_task";
    this.lbl_task.Size = new System.Drawing.Size(198, 98);
    this.lbl_task.TabIndex = 9;
    this.lbl_task.Text = "Треугольник задан координатами (x1, y1, (x2, y2, (x3, y3) своих вершин. Вычислить" + " радиус окружности, описанной около треугольника.";
    this.lbl_task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // text_x_y
    // 
    this.text_x_y.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_x_y.Location = new System.Drawing.Point(165, 55);
    this.text_x_y.MaxLength = 10;
    this.text_x_y.Name = "text_x_y";
    this.text_x_y.Size = new System.Drawing.Size(48, 20);
    this.text_x_y.TabIndex = 10;
    this.text_x_y.TextChanged += new System.EventHandler(this.text_x_y_TextChanged);
    this.text_x_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // text_y_y
    // 
    this.text_y_y.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_y_y.Location = new System.Drawing.Point(165, 186);
    this.text_y_y.MaxLength = 10;
    this.text_y_y.Name = "text_y_y";
    this.text_y_y.Size = new System.Drawing.Size(48, 20);
    this.text_y_y.TabIndex = 11;
    this.text_y_y.TextChanged += new System.EventHandler(this.text_y_y_TextChanged);
    this.text_y_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // text_z_y
    // 
    this.text_z_y.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_z_y.Location = new System.Drawing.Point(165, 318);
    this.text_z_y.MaxLength = 10;
    this.text_z_y.Name = "text_z_y";
    this.text_z_y.Size = new System.Drawing.Size(48, 20);
    this.text_z_y.TabIndex = 12;
    this.text_z_y.TextChanged += new System.EventHandler(this.text_z_y_TextChanged);
    this.text_z_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // Task2Page
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Controls.Add(this.tableLayoutPanel1);
    this.Name = "Task2Page";
    this.Size = new System.Drawing.Size(675, 395);
    this.table_main.ResumeLayout(false);
    this.table_main.PerformLayout();
    this.tableLayoutPanel1.ResumeLayout(false);
    this.tableLayoutPanel1.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
  private System.Windows.Forms.TextBox text_y_y;
  private System.Windows.Forms.TextBox text_z_y;
  private System.Windows.Forms.Label lbl_task;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  private System.Windows.Forms.TextBox text_x_y;
  private System.Windows.Forms.TextBox text_result;
  private System.Windows.Forms.TextBox text_x_x;
  private System.Windows.Forms.TextBox text_y_x;
  private System.Windows.Forms.TextBox text_z_x;
  private System.Windows.Forms.Label lbl_x;
  private System.Windows.Forms.Label lbl_y;
  private System.Windows.Forms.Label lbl_z;
  private System.Windows.Forms.Label lbl_result;
  private System.Windows.Forms.Label lbl_b;
  private System.Windows.Forms.TableLayoutPanel table_main;
  private System.Windows.Forms.TextBox text_b;
  private System.Windows.Forms.TextBox text_a;
  private System.Windows.Forms.TextBox text_x;

  #endregion
}
}