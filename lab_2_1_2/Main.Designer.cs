namespace lab_2_1_2 {
partial class Main {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

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

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
    this.panel_top = new System.Windows.Forms.Panel();
    this.box_mods = new System.Windows.Forms.ComboBox();
    this.panel_content = new System.Windows.Forms.Panel();
    this.panel_top.SuspendLayout();
    this.SuspendLayout();
    // 
    // panel_top
    // 
    this.panel_top.AutoSize = true;
    this.panel_top.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.panel_top.Controls.Add(this.box_mods);
    this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
    this.panel_top.Location = new System.Drawing.Point(0, 0);
    this.panel_top.MinimumSize = new System.Drawing.Size(0, 40);
    this.panel_top.Name = "panel_top";
    this.panel_top.Size = new System.Drawing.Size(784, 40);
    this.panel_top.TabIndex = 0;
    // 
    // box_mods
    // 
    this.box_mods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
    this.box_mods.FormattingEnabled = true;
    this.box_mods.Location = new System.Drawing.Point(12, 12);
    this.box_mods.Name = "box_mods";
    this.box_mods.Size = new System.Drawing.Size(121, 21);
    this.box_mods.TabIndex = 0;
    this.box_mods.SelectedIndexChanged += new System.EventHandler(this.box_mods_SelectedIndexChanged);
    // 
    // panel_content
    // 
    this.panel_content.AutoSize = true;
    this.panel_content.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
    this.panel_content.Location = new System.Drawing.Point(0, 40);
    this.panel_content.Name = "panel_content";
    this.panel_content.Size = new System.Drawing.Size(784, 371);
    this.panel_content.TabIndex = 1;
    // 
    // Main
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(784, 411);
    this.Controls.Add(this.panel_content);
    this.Controls.Add(this.panel_top);
    this.MinimumSize = new System.Drawing.Size(400, 225);
    this.Name = "Main";
    this.Text = "Main";
    this.panel_top.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
  private System.Windows.Forms.ComboBox box_mods;
  private System.Windows.Forms.Panel panel_content;
  private System.Windows.Forms.Panel panel_top;

  #endregion
}
}