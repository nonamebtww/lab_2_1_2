using System.ComponentModel;

namespace lab_2_1_2.Pages {
partial class HomePage {
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
    this.lbl_welcome = new System.Windows.Forms.Label();
    this.SuspendLayout();
    // 
    // lbl_welcome
    // 
    this.lbl_welcome.Dock = System.Windows.Forms.DockStyle.Fill;
    this.lbl_welcome.Location = new System.Drawing.Point(0, 0);
    this.lbl_welcome.Name = "lbl_welcome";
    this.lbl_welcome.Size = new System.Drawing.Size(446, 338);
    this.lbl_welcome.TabIndex = 0;
    this.lbl_welcome.Text = "Выберите одно из задание, в левом верхнем углу!";
    this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // HomePage
    // 
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
    this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.Controls.Add(this.lbl_welcome);
    this.Name = "HomePage";
    this.Size = new System.Drawing.Size(446, 338);
    this.ResumeLayout(false);
  }
  private System.Windows.Forms.Label lbl_welcome;

  #endregion
}
}