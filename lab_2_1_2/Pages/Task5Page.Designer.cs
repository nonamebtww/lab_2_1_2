using System.ComponentModel;

namespace lab_2_1_2.Pages {
partial class Task5Page {
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
    this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
    this.lbl_country = new System.Windows.Forms.Label();
    this.lbl_region = new System.Windows.Forms.Label();
    this.lbl_city = new System.Windows.Forms.Label();
    this.lbl_street = new System.Windows.Forms.Label();
    this.lbl_number = new System.Windows.Forms.Label();
    this.lbl_floor = new System.Windows.Forms.Label();
    this.lbl_zip = new System.Windows.Forms.Label();
    this.text_country = new System.Windows.Forms.TextBox();
    this.text_region = new System.Windows.Forms.TextBox();
    this.text_city = new System.Windows.Forms.TextBox();
    this.text_street = new System.Windows.Forms.TextBox();
    this.text_number = new System.Windows.Forms.TextBox();
    this.text_floor = new System.Windows.Forms.TextBox();
    this.text_zip = new System.Windows.Forms.TextBox();
    this.tableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    // 
    // tableLayoutPanel1
    // 
    this.tableLayoutPanel1.AutoSize = true;
    this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.tableLayoutPanel1.ColumnCount = 4;
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
    this.tableLayoutPanel1.Controls.Add(this.lbl_country, 1, 0);
    this.tableLayoutPanel1.Controls.Add(this.lbl_region, 1, 1);
    this.tableLayoutPanel1.Controls.Add(this.lbl_city, 1, 2);
    this.tableLayoutPanel1.Controls.Add(this.lbl_street, 1, 3);
    this.tableLayoutPanel1.Controls.Add(this.lbl_number, 1, 4);
    this.tableLayoutPanel1.Controls.Add(this.lbl_floor, 1, 5);
    this.tableLayoutPanel1.Controls.Add(this.lbl_zip, 1, 6);
    this.tableLayoutPanel1.Controls.Add(this.text_country, 2, 0);
    this.tableLayoutPanel1.Controls.Add(this.text_region, 2, 1);
    this.tableLayoutPanel1.Controls.Add(this.text_city, 2, 2);
    this.tableLayoutPanel1.Controls.Add(this.text_street, 2, 3);
    this.tableLayoutPanel1.Controls.Add(this.text_number, 2, 4);
    this.tableLayoutPanel1.Controls.Add(this.text_floor, 2, 5);
    this.tableLayoutPanel1.Controls.Add(this.text_zip, 2, 6);
    this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
    this.tableLayoutPanel1.RowCount = 7;
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
    this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 331);
    this.tableLayoutPanel1.TabIndex = 0;
    // 
    // lbl_country
    // 
    this.lbl_country.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_country.Location = new System.Drawing.Point(192, 12);
    this.lbl_country.Name = "lbl_country";
    this.lbl_country.Size = new System.Drawing.Size(57, 23);
    this.lbl_country.TabIndex = 0;
    this.lbl_country.Text = "Страна";
    this.lbl_country.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_region
    // 
    this.lbl_region.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_region.Location = new System.Drawing.Point(192, 59);
    this.lbl_region.Name = "lbl_region";
    this.lbl_region.Size = new System.Drawing.Size(57, 23);
    this.lbl_region.TabIndex = 1;
    this.lbl_region.Text = "Область";
    this.lbl_region.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_city
    // 
    this.lbl_city.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_city.Location = new System.Drawing.Point(192, 106);
    this.lbl_city.Name = "lbl_city";
    this.lbl_city.Size = new System.Drawing.Size(57, 23);
    this.lbl_city.TabIndex = 2;
    this.lbl_city.Text = "Город";
    this.lbl_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_street
    // 
    this.lbl_street.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_street.Location = new System.Drawing.Point(192, 153);
    this.lbl_street.Name = "lbl_street";
    this.lbl_street.Size = new System.Drawing.Size(57, 23);
    this.lbl_street.TabIndex = 3;
    this.lbl_street.Text = "Улица";
    this.lbl_street.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_number
    // 
    this.lbl_number.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_number.Location = new System.Drawing.Point(192, 200);
    this.lbl_number.Name = "lbl_number";
    this.lbl_number.Size = new System.Drawing.Size(57, 23);
    this.lbl_number.TabIndex = 4;
    this.lbl_number.Text = "Номер";
    this.lbl_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_floor
    // 
    this.lbl_floor.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_floor.Location = new System.Drawing.Point(192, 247);
    this.lbl_floor.Name = "lbl_floor";
    this.lbl_floor.Size = new System.Drawing.Size(57, 23);
    this.lbl_floor.TabIndex = 5;
    this.lbl_floor.Text = "Этаж";
    this.lbl_floor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // lbl_zip
    // 
    this.lbl_zip.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_zip.Location = new System.Drawing.Point(192, 295);
    this.lbl_zip.Name = "lbl_zip";
    this.lbl_zip.Size = new System.Drawing.Size(57, 23);
    this.lbl_zip.TabIndex = 6;
    this.lbl_zip.Text = "ZIP";
    this.lbl_zip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // text_country
    // 
    this.text_country.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_country.Location = new System.Drawing.Point(271, 13);
    this.text_country.Name = "text_country";
    this.text_country.ReadOnly = true;
    this.text_country.Size = new System.Drawing.Size(150, 20);
    this.text_country.TabIndex = 7;
    // 
    // text_region
    // 
    this.text_region.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_region.Location = new System.Drawing.Point(271, 60);
    this.text_region.Name = "text_region";
    this.text_region.ReadOnly = true;
    this.text_region.Size = new System.Drawing.Size(150, 20);
    this.text_region.TabIndex = 8;
    // 
    // text_city
    // 
    this.text_city.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_city.Location = new System.Drawing.Point(271, 107);
    this.text_city.Name = "text_city";
    this.text_city.ReadOnly = true;
    this.text_city.Size = new System.Drawing.Size(150, 20);
    this.text_city.TabIndex = 9;
    // 
    // text_street
    // 
    this.text_street.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_street.Location = new System.Drawing.Point(271, 154);
    this.text_street.Name = "text_street";
    this.text_street.ReadOnly = true;
    this.text_street.Size = new System.Drawing.Size(150, 20);
    this.text_street.TabIndex = 10;
    // 
    // text_number
    // 
    this.text_number.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_number.Location = new System.Drawing.Point(271, 201);
    this.text_number.Name = "text_number";
    this.text_number.ReadOnly = true;
    this.text_number.Size = new System.Drawing.Size(150, 20);
    this.text_number.TabIndex = 11;
    // 
    // text_floor
    // 
    this.text_floor.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_floor.Location = new System.Drawing.Point(271, 248);
    this.text_floor.Name = "text_floor";
    this.text_floor.ReadOnly = true;
    this.text_floor.Size = new System.Drawing.Size(150, 20);
    this.text_floor.TabIndex = 12;
    // 
    // text_zip
    // 
    this.text_zip.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_zip.Location = new System.Drawing.Point(271, 296);
    this.text_zip.Name = "text_zip";
    this.text_zip.ReadOnly = true;
    this.text_zip.Size = new System.Drawing.Size(150, 20);
    this.text_zip.TabIndex = 13;
    // 
    // Task5Page
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Controls.Add(this.tableLayoutPanel1);
    this.Name = "Task5Page";
    this.Size = new System.Drawing.Size(633, 331);
    this.tableLayoutPanel1.ResumeLayout(false);
    this.tableLayoutPanel1.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
  private System.Windows.Forms.TextBox text_region;
  private System.Windows.Forms.TextBox text_city;
  private System.Windows.Forms.TextBox text_street;
  private System.Windows.Forms.TextBox text_number;
  private System.Windows.Forms.TextBox text_floor;
  private System.Windows.Forms.TextBox text_zip;
  private System.Windows.Forms.TextBox text_country;
  private System.Windows.Forms.Label lbl_region;
  private System.Windows.Forms.Label lbl_city;
  private System.Windows.Forms.Label lbl_street;
  private System.Windows.Forms.Label lbl_number;
  private System.Windows.Forms.Label lbl_floor;
  private System.Windows.Forms.Label lbl_zip;
  private System.Windows.Forms.Label lbl_country;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

  #endregion
}
}