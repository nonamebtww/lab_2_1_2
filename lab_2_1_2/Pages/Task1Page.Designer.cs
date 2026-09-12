using System.ComponentModel;

namespace lab_2_1_2.Pages {
partial class Task1Page {
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
    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task1Page));
    this.table_main = new System.Windows.Forms.TableLayoutPanel();
    this.text_b = new System.Windows.Forms.TextBox();
    this.text_a = new System.Windows.Forms.TextBox();
    this.text_x = new System.Windows.Forms.TextBox();
    this.text_y = new System.Windows.Forms.TextBox();
    this.text_z = new System.Windows.Forms.TextBox();
    this.lbl_x = new System.Windows.Forms.Label();
    this.lbl_y = new System.Windows.Forms.Label();
    this.lbl_z = new System.Windows.Forms.Label();
    this.lbl_a = new System.Windows.Forms.Label();
    this.lbl_b = new System.Windows.Forms.Label();
    this.lbl_task = new System.Windows.Forms.Label();
    this.picture_b = new System.Windows.Forms.PictureBox();
    this.picture_a = new System.Windows.Forms.PictureBox();
    this.table_main.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this.picture_b)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.picture_a)).BeginInit();
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
    this.table_main.Controls.Add(this.text_x, 1, 0);
    this.table_main.Controls.Add(this.text_y, 1, 1);
    this.table_main.Controls.Add(this.text_z, 1, 2);
    this.table_main.Controls.Add(this.lbl_x, 0, 0);
    this.table_main.Controls.Add(this.lbl_y, 0, 1);
    this.table_main.Controls.Add(this.lbl_z, 0, 2);
    this.table_main.Controls.Add(this.lbl_a, 3, 0);
    this.table_main.Controls.Add(this.lbl_b, 3, 2);
    this.table_main.Controls.Add(this.lbl_task, 2, 1);
    this.table_main.Controls.Add(this.picture_b, 2, 2);
    this.table_main.Controls.Add(this.picture_a, 2, 0);
    this.table_main.Dock = System.Windows.Forms.DockStyle.Fill;
    this.table_main.Location = new System.Drawing.Point(0, 0);
    this.table_main.Name = "table_main";
    this.table_main.RowCount = 3;
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
    this.table_main.Size = new System.Drawing.Size(607, 311);
    this.table_main.TabIndex = 0;
    // 
    // text_b
    // 
    this.text_b.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_b.Location = new System.Drawing.Point(510, 248);
    this.text_b.Name = "text_b";
    this.text_b.ReadOnly = true;
    this.text_b.Size = new System.Drawing.Size(94, 20);
    this.text_b.TabIndex = 4;
    // 
    // text_a
    // 
    this.text_a.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_a.Location = new System.Drawing.Point(510, 41);
    this.text_a.Name = "text_a";
    this.text_a.ReadOnly = true;
    this.text_a.Size = new System.Drawing.Size(94, 20);
    this.text_a.TabIndex = 3;
    // 
    // text_x
    // 
    this.text_x.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_x.Location = new System.Drawing.Point(100, 41);
    this.text_x.MaxLength = 10;
    this.text_x.Name = "text_x";
    this.text_x.Size = new System.Drawing.Size(91, 20);
    this.text_x.TabIndex = 2;
    this.text_x.TextChanged += new System.EventHandler(this.text_x_TextChanged);
    this.text_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // text_y
    // 
    this.text_y.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_y.Location = new System.Drawing.Point(100, 144);
    this.text_y.MaxLength = 10;
    this.text_y.Name = "text_y";
    this.text_y.Size = new System.Drawing.Size(91, 20);
    this.text_y.TabIndex = 1;
    this.text_y.TextChanged += new System.EventHandler(this.text_y_TextChanged);
    this.text_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // text_z
    // 
    this.text_z.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_z.Location = new System.Drawing.Point(100, 248);
    this.text_z.MaxLength = 10;
    this.text_z.Name = "text_z";
    this.text_z.Size = new System.Drawing.Size(91, 20);
    this.text_z.TabIndex = 0;
    this.text_z.TextChanged += new System.EventHandler(this.text_z_TextChanged);
    this.text_z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // lbl_x
    // 
    this.lbl_x.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_x.Location = new System.Drawing.Point(3, 40);
    this.lbl_x.Name = "lbl_x";
    this.lbl_x.Size = new System.Drawing.Size(91, 23);
    this.lbl_x.TabIndex = 5;
    this.lbl_x.Text = "Введите X";
    this.lbl_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_y
    // 
    this.lbl_y.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_y.Location = new System.Drawing.Point(3, 143);
    this.lbl_y.Name = "lbl_y";
    this.lbl_y.Size = new System.Drawing.Size(91, 23);
    this.lbl_y.TabIndex = 6;
    this.lbl_y.Text = "Введите Y";
    this.lbl_y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_z
    // 
    this.lbl_z.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_z.Location = new System.Drawing.Point(3, 247);
    this.lbl_z.Name = "lbl_z";
    this.lbl_z.Size = new System.Drawing.Size(91, 23);
    this.lbl_z.TabIndex = 7;
    this.lbl_z.Text = "Введите Z";
    this.lbl_z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_a
    // 
    this.lbl_a.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_a.Location = new System.Drawing.Point(413, 40);
    this.lbl_a.Name = "lbl_a";
    this.lbl_a.Size = new System.Drawing.Size(91, 23);
    this.lbl_a.TabIndex = 8;
    this.lbl_a.Text = "Результат A";
    this.lbl_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_b
    // 
    this.lbl_b.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_b.Location = new System.Drawing.Point(413, 247);
    this.lbl_b.Name = "lbl_b";
    this.lbl_b.Size = new System.Drawing.Size(91, 23);
    this.lbl_b.TabIndex = 9;
    this.lbl_b.Text = "Результат B";
    this.lbl_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_task
    // 
    this.lbl_task.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_task.Location = new System.Drawing.Point(204, 129);
    this.lbl_task.Name = "lbl_task";
    this.lbl_task.Size = new System.Drawing.Size(196, 50);
    this.lbl_task.TabIndex = 10;
    this.lbl_task.Text = "Даны x, y, z . Вычислить a, b, если:";
    this.lbl_task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // picture_b
    // 
    this.picture_b.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.picture_b.Image = ((System.Drawing.Image)(resources.GetObject("picture_b.Image")));
    this.picture_b.Location = new System.Drawing.Point(197, 232);
    this.picture_b.Name = "picture_b";
    this.picture_b.Size = new System.Drawing.Size(210, 52);
    this.picture_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    this.picture_b.TabIndex = 11;
    this.picture_b.TabStop = false;
    // 
    // picture_a
    // 
    this.picture_a.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.picture_a.Image = ((System.Drawing.Image)(resources.GetObject("picture_a.Image")));
    this.picture_a.Location = new System.Drawing.Point(214, 21);
    this.picture_a.Name = "picture_a";
    this.picture_a.Size = new System.Drawing.Size(175, 61);
    this.picture_a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    this.picture_a.TabIndex = 12;
    this.picture_a.TabStop = false;
    // 
    // Task1Page
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Controls.Add(this.table_main);
    this.Name = "Task1Page";
    this.Size = new System.Drawing.Size(607, 311);
    this.table_main.ResumeLayout(false);
    this.table_main.PerformLayout();
    ((System.ComponentModel.ISupportInitialize)(this.picture_b)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.picture_a)).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
  private System.Windows.Forms.PictureBox picture_a;
  private System.Windows.Forms.PictureBox picture_b;
  private System.Windows.Forms.Label lbl_task;
  private System.Windows.Forms.Label lbl_a;
  private System.Windows.Forms.Label lbl_b;
  private System.Windows.Forms.Label lbl_y;
  private System.Windows.Forms.Label lbl_z;
  private System.Windows.Forms.Label lbl_x;
  private System.Windows.Forms.TextBox text_a;
  private System.Windows.Forms.TextBox text_b;
  private System.Windows.Forms.TextBox text_z;
  private System.Windows.Forms.TextBox text_y;
  private System.Windows.Forms.TextBox text_x;
  private System.Windows.Forms.TableLayoutPanel table_main;

  #endregion
}
}