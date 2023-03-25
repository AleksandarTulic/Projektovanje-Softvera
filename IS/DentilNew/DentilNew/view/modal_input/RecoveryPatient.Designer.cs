
namespace DentilNew.view.modal_input
{
    partial class RecoveryPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtbPatientID = new MaterialSkin.Controls.MaterialTextBox();
            this.mbtnSubmitRecovery = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // mtbPatientID
            // 
            this.mtbPatientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbPatientID.AnimateReadOnly = false;
            this.mtbPatientID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbPatientID.Depth = 0;
            this.mtbPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbPatientID.Hint = "Patient ID";
            this.mtbPatientID.LeadingIcon = null;
            this.mtbPatientID.Location = new System.Drawing.Point(17, 80);
            this.mtbPatientID.MaxLength = 13;
            this.mtbPatientID.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbPatientID.Multiline = false;
            this.mtbPatientID.Name = "mtbPatientID";
            this.mtbPatientID.Size = new System.Drawing.Size(317, 50);
            this.mtbPatientID.TabIndex = 1;
            this.mtbPatientID.Text = "";
            this.mtbPatientID.TrailingIcon = null;
            // 
            // mbtnSubmitRecovery
            // 
            this.mbtnSubmitRecovery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnSubmitRecovery.AutoSize = false;
            this.mbtnSubmitRecovery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSubmitRecovery.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSubmitRecovery.Depth = 0;
            this.mbtnSubmitRecovery.HighEmphasis = true;
            this.mbtnSubmitRecovery.Icon = null;
            this.mbtnSubmitRecovery.Location = new System.Drawing.Point(105, 158);
            this.mbtnSubmitRecovery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnSubmitRecovery.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSubmitRecovery.Name = "mbtnSubmitRecovery";
            this.mbtnSubmitRecovery.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnSubmitRecovery.Size = new System.Drawing.Size(133, 36);
            this.mbtnSubmitRecovery.TabIndex = 2;
            this.mbtnSubmitRecovery.Text = "Recovery";
            this.mbtnSubmitRecovery.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnSubmitRecovery.UseAccentColor = false;
            this.mbtnSubmitRecovery.UseVisualStyleBackColor = true;
            this.mbtnSubmitRecovery.Click += new System.EventHandler(this.mbtnSubmitRecovery_Click);
            // 
            // RecoveryPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 203);
            this.Controls.Add(this.mbtnSubmitRecovery);
            this.Controls.Add(this.mtbPatientID);
            this.Name = "RecoveryPatient";
            this.Text = "RECOVERY PATIENT";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox mtbPatientID;
        private MaterialSkin.Controls.MaterialButton mbtnSubmitRecovery;
    }
}