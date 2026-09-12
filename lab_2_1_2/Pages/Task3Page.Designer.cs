using System.ComponentModel;

namespace lab_2_1_2.Pages {
partial class Task3Page {
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
    this.text_mult = new System.Windows.Forms.TextBox();
    this.text_sum = new System.Windows.Forms.TextBox();
    this.text_a = new System.Windows.Forms.TextBox();
    this.text_b = new System.Windows.Forms.TextBox();
    this.lbl_a = new System.Windows.Forms.Label();
    this.lbl_b = new System.Windows.Forms.Label();
    this.lbl_sum = new System.Windows.Forms.Label();
    this.lbl_mult = new System.Windows.Forms.Label();
    this.lbl_task = new System.Windows.Forms.Label();
    this.lbl_result = new System.Windows.Forms.Label();
    this.table_main.SuspendLayout();
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
    this.table_main.Controls.Add(this.text_mult, 4, 2);
    this.table_main.Controls.Add(this.text_sum, 4, 0);
    this.table_main.Controls.Add(this.text_a, 1, 0);
    this.table_main.Controls.Add(this.text_b, 1, 2);
    this.table_main.Controls.Add(this.lbl_a, 0, 0);
    this.table_main.Controls.Add(this.lbl_b, 0, 2);
    this.table_main.Controls.Add(this.lbl_sum, 3, 0);
    this.table_main.Controls.Add(this.lbl_mult, 3, 2);
    this.table_main.Controls.Add(this.lbl_task, 2, 1);
    this.table_main.Controls.Add(this.lbl_result, 4, 1);
    this.table_main.Dock = System.Windows.Forms.DockStyle.Fill;
    this.table_main.Location = new System.Drawing.Point(0, 0);
    this.table_main.Name = "table_main";
    this.table_main.RowCount = 3;
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
    this.table_main.Size = new System.Drawing.Size(672, 426);
    this.table_main.TabIndex = 2;
    // 
    // text_mult
    // 
    this.text_mult.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_mult.Location = new System.Drawing.Point(570, 344);
    this.text_mult.Name = "text_mult";
    this.text_mult.ReadOnly = true;
    this.text_mult.Size = new System.Drawing.Size(94, 20);
    this.text_mult.TabIndex = 4;
    // 
    // text_sum
    // 
    this.text_sum.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_sum.Location = new System.Drawing.Point(570, 60);
    this.text_sum.Name = "text_sum";
    this.text_sum.ReadOnly = true;
    this.text_sum.Size = new System.Drawing.Size(94, 20);
    this.text_sum.TabIndex = 3;
    // 
    // text_a
    // 
    this.text_a.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_a.Location = new System.Drawing.Point(116, 60);
    this.text_a.MaxLength = 10;
    this.text_a.Name = "text_a";
    this.text_a.Size = new System.Drawing.Size(91, 20);
    this.text_a.TabIndex = 2;
    this.text_a.TextChanged += new System.EventHandler(this.text_a_TextChanged);
    this.text_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // text_b
    // 
    this.text_b.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_b.Location = new System.Drawing.Point(116, 344);
    this.text_b.MaxLength = 10;
    this.text_b.Name = "text_b";
    this.text_b.Size = new System.Drawing.Size(91, 20);
    this.text_b.TabIndex = 0;
    this.text_b.TextChanged += new System.EventHandler(this.text_b_TextChanged);
    this.text_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // lbl_a
    // 
    this.lbl_a.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_a.Location = new System.Drawing.Point(8, 59);
    this.lbl_a.Name = "lbl_a";
    this.lbl_a.Size = new System.Drawing.Size(91, 23);
    this.lbl_a.TabIndex = 5;
    this.lbl_a.Text = "Введите A";
    this.lbl_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_b
    // 
    this.lbl_b.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_b.Location = new System.Drawing.Point(8, 343);
    this.lbl_b.Name = "lbl_b";
    this.lbl_b.Size = new System.Drawing.Size(91, 23);
    this.lbl_b.TabIndex = 7;
    this.lbl_b.Text = "Введите B";
    this.lbl_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_sum
    // 
    this.lbl_sum.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_sum.Location = new System.Drawing.Point(463, 59);
    this.lbl_sum.Name = "lbl_sum";
    this.lbl_sum.Size = new System.Drawing.Size(91, 23);
    this.lbl_sum.TabIndex = 8;
    this.lbl_sum.Text = "Сумма";
    this.lbl_sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_mult
    // 
    this.lbl_mult.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_mult.Location = new System.Drawing.Point(463, 343);
    this.lbl_mult.Name = "lbl_mult";
    this.lbl_mult.Size = new System.Drawing.Size(91, 23);
    this.lbl_mult.TabIndex = 9;
    this.lbl_mult.Text = "Произведение";
    this.lbl_mult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_task
    // 
    this.lbl_task.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_task.Location = new System.Drawing.Point(237, 187);
    this.lbl_task.Name = "lbl_task";
    this.lbl_task.Size = new System.Drawing.Size(196, 50);
    this.lbl_task.TabIndex = 10;
    this.lbl_task.Text = "Даны два числа. Если они не равны, то найти их сумму и произведение.";
    this.lbl_task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_result
    // 
    this.lbl_result.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_result.Location = new System.Drawing.Point(567, 200);
    this.lbl_result.Name = "lbl_result";
    this.lbl_result.Size = new System.Drawing.Size(100, 23);
    this.lbl_result.TabIndex = 11;
    this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // Task3Page
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Controls.Add(this.table_main);
    this.Name = "Task3Page";
    this.Size = new System.Drawing.Size(672, 426);
    this.table_main.ResumeLayout(false);
    this.table_main.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
  private System.Windows.Forms.Label lbl_result;
  private System.Windows.Forms.TableLayoutPanel table_main;
  private System.Windows.Forms.TextBox text_mult;
  private System.Windows.Forms.TextBox text_sum;
  private System.Windows.Forms.TextBox text_a;
  private System.Windows.Forms.TextBox text_b;
  private System.Windows.Forms.Label lbl_a;
  private System.Windows.Forms.Label lbl_b;
  private System.Windows.Forms.Label lbl_sum;
  private System.Windows.Forms.Label lbl_mult;
  private System.Windows.Forms.Label lbl_task;
  private System.Windows.Forms.TextBox text_x;
  private System.Windows.Forms.TextBox text_z;
  private System.Windows.Forms.Label lbl_x;
  private System.Windows.Forms.Label lbl_z;

  #endregion
}
}