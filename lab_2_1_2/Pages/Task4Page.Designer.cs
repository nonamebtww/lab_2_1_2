using System.ComponentModel;

namespace lab_2_1_2.Pages {
partial class Task4Page {
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
    this.lbl_task = new System.Windows.Forms.Label();
    this.lbl_hours = new System.Windows.Forms.Label();
    this.text_hours = new System.Windows.Forms.TextBox();
    this.lbl_time = new System.Windows.Forms.Label();
    this.lbl_result = new System.Windows.Forms.Label();
    this.text_time = new System.Windows.Forms.TextBox();
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
    this.table_main.Controls.Add(this.lbl_task, 2, 1);
    this.table_main.Controls.Add(this.lbl_hours, 0, 1);
    this.table_main.Controls.Add(this.text_hours, 1, 1);
    this.table_main.Controls.Add(this.lbl_time, 3, 1);
    this.table_main.Controls.Add(this.lbl_result, 4, 0);
    this.table_main.Controls.Add(this.text_time, 4, 1);
    this.table_main.Dock = System.Windows.Forms.DockStyle.Fill;
    this.table_main.Location = new System.Drawing.Point(0, 0);
    this.table_main.Name = "table_main";
    this.table_main.RowCount = 3;
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
    this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
    this.table_main.Size = new System.Drawing.Size(731, 484);
    this.table_main.TabIndex = 3;
    // 
    // lbl_task
    // 
    this.lbl_task.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_task.Location = new System.Drawing.Point(266, 216);
    this.lbl_task.Name = "lbl_task";
    this.lbl_task.Size = new System.Drawing.Size(196, 50);
    this.lbl_task.TabIndex = 10;
    this.lbl_task.Text = "Напишите программу, которая по введенному числу из промежутка 0..24, определяет в" + "ремя суток.";
    this.lbl_task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_hours
    // 
    this.lbl_hours.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_hours.Location = new System.Drawing.Point(13, 223);
    this.lbl_hours.Name = "lbl_hours";
    this.lbl_hours.Size = new System.Drawing.Size(91, 36);
    this.lbl_hours.TabIndex = 5;
    this.lbl_hours.Text = "Введите кол-во часов";
    this.lbl_hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // text_hours
    // 
    this.text_hours.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_hours.Location = new System.Drawing.Point(130, 231);
    this.text_hours.MaxLength = 10;
    this.text_hours.Name = "text_hours";
    this.text_hours.Size = new System.Drawing.Size(91, 20);
    this.text_hours.TabIndex = 2;
    this.text_hours.TextChanged += new System.EventHandler(this.text_hours_TextChanged);
    this.text_hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAllowDigits);
    // 
    // lbl_time
    // 
    this.lbl_time.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_time.Location = new System.Drawing.Point(508, 230);
    this.lbl_time.Name = "lbl_time";
    this.lbl_time.Size = new System.Drawing.Size(91, 23);
    this.lbl_time.TabIndex = 8;
    this.lbl_time.Text = "Результат";
    this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_result
    // 
    this.lbl_result.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_result.Location = new System.Drawing.Point(621, 69);
    this.lbl_result.Name = "lbl_result";
    this.lbl_result.Size = new System.Drawing.Size(100, 23);
    this.lbl_result.TabIndex = 11;
    this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // text_time
    // 
    this.text_time.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_time.Location = new System.Drawing.Point(624, 231);
    this.text_time.Name = "text_time";
    this.text_time.ReadOnly = true;
    this.text_time.Size = new System.Drawing.Size(94, 20);
    this.text_time.TabIndex = 3;
    // 
    // Task4Page
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Controls.Add(this.table_main);
    this.Name = "Task4Page";
    this.Size = new System.Drawing.Size(731, 484);
    this.table_main.ResumeLayout(false);
    this.table_main.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
  private System.Windows.Forms.TableLayoutPanel table_main;
  private System.Windows.Forms.TextBox text_time;
  private System.Windows.Forms.TextBox text_hours;
  private System.Windows.Forms.Label lbl_hours;
  private System.Windows.Forms.Label lbl_time;
  private System.Windows.Forms.Label lbl_task;
  private System.Windows.Forms.Label lbl_result;

  #endregion
}
}