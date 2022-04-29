
namespace RogerD_1175Final2
{
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SortedReservationListBox = new System.Windows.Forms.ListBox();
            this.ClearCurrentRButton = new System.Windows.Forms.Button();
            this.CreateCurrentRButton = new System.Windows.Forms.Button();
            this.CurrentReservationListBox = new System.Windows.Forms.ListBox();
            this.CNLabel = new System.Windows.Forms.Label();
            this.NATLabel = new System.Windows.Forms.Label();
            this.NCTLabel = new System.Windows.Forms.Label();
            this.CNTextBox = new System.Windows.Forms.TextBox();
            this.NATTextBox = new System.Windows.Forms.TextBox();
            this.NCTTextBox = new System.Windows.Forms.TextBox();
            this.AddCurrentRButton = new System.Windows.Forms.Button();
            this.WriteRButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(147, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(835, 39);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Roger Diaz-300341127-1175 Final";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SortedReservationListBox
            // 
            this.SortedReservationListBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortedReservationListBox.FormattingEnabled = true;
            this.SortedReservationListBox.ItemHeight = 15;
            this.SortedReservationListBox.Location = new System.Drawing.Point(341, 264);
            this.SortedReservationListBox.Name = "SortedReservationListBox";
            this.SortedReservationListBox.Size = new System.Drawing.Size(767, 154);
            this.SortedReservationListBox.TabIndex = 1;
            // 
            // ClearCurrentRButton
            // 
            this.ClearCurrentRButton.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearCurrentRButton.Location = new System.Drawing.Point(957, 81);
            this.ClearCurrentRButton.Name = "ClearCurrentRButton";
            this.ClearCurrentRButton.Size = new System.Drawing.Size(116, 80);
            this.ClearCurrentRButton.TabIndex = 2;
            this.ClearCurrentRButton.Text = "Clear Current Reservation";
            this.ClearCurrentRButton.UseVisualStyleBackColor = true;
            this.ClearCurrentRButton.Click += new System.EventHandler(this.ClearCurrentRButton_Click);
            // 
            // CreateCurrentRButton
            // 
            this.CreateCurrentRButton.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCurrentRButton.Location = new System.Drawing.Point(428, 76);
            this.CreateCurrentRButton.Name = "CreateCurrentRButton";
            this.CreateCurrentRButton.Size = new System.Drawing.Size(131, 79);
            this.CreateCurrentRButton.TabIndex = 3;
            this.CreateCurrentRButton.Text = "Create Current Reservation";
            this.CreateCurrentRButton.UseVisualStyleBackColor = true;
            this.CreateCurrentRButton.Click += new System.EventHandler(this.CreateCurrentRButton_Click);
            // 
            // CurrentReservationListBox
            // 
            this.CurrentReservationListBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentReservationListBox.FormattingEnabled = true;
            this.CurrentReservationListBox.ItemHeight = 15;
            this.CurrentReservationListBox.Location = new System.Drawing.Point(597, 57);
            this.CurrentReservationListBox.Name = "CurrentReservationListBox";
            this.CurrentReservationListBox.Size = new System.Drawing.Size(311, 109);
            this.CurrentReservationListBox.TabIndex = 4;
            // 
            // CNLabel
            // 
            this.CNLabel.AutoSize = true;
            this.CNLabel.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CNLabel.Location = new System.Drawing.Point(12, 51);
            this.CNLabel.Name = "CNLabel";
            this.CNLabel.Size = new System.Drawing.Size(120, 17);
            this.CNLabel.TabIndex = 5;
            this.CNLabel.Text = "Customer Name:";
            // 
            // NATLabel
            // 
            this.NATLabel.AutoSize = true;
            this.NATLabel.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NATLabel.Location = new System.Drawing.Point(12, 101);
            this.NATLabel.Name = "NATLabel";
            this.NATLabel.Size = new System.Drawing.Size(200, 17);
            this.NATLabel.TabIndex = 6;
            this.NATLabel.Text = "Number Of Adult Tickets:";
            // 
            // NCTLabel
            // 
            this.NCTLabel.AutoSize = true;
            this.NCTLabel.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NCTLabel.Location = new System.Drawing.Point(17, 154);
            this.NCTLabel.Name = "NCTLabel";
            this.NCTLabel.Size = new System.Drawing.Size(200, 17);
            this.NCTLabel.TabIndex = 7;
            this.NCTLabel.Text = "Number Of Child Tickets:";
            // 
            // CNTextBox
            // 
            this.CNTextBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CNTextBox.Location = new System.Drawing.Point(147, 51);
            this.CNTextBox.Name = "CNTextBox";
            this.CNTextBox.Size = new System.Drawing.Size(125, 23);
            this.CNTextBox.TabIndex = 8;
            // 
            // NATTextBox
            // 
            this.NATTextBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NATTextBox.Location = new System.Drawing.Point(218, 98);
            this.NATTextBox.Name = "NATTextBox";
            this.NATTextBox.Size = new System.Drawing.Size(125, 23);
            this.NATTextBox.TabIndex = 9;
            // 
            // NCTTextBox
            // 
            this.NCTTextBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NCTTextBox.Location = new System.Drawing.Point(215, 154);
            this.NCTTextBox.Name = "NCTTextBox";
            this.NCTTextBox.Size = new System.Drawing.Size(125, 23);
            this.NCTTextBox.TabIndex = 10;
            // 
            // AddCurrentRButton
            // 
            this.AddCurrentRButton.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCurrentRButton.Location = new System.Drawing.Point(580, 181);
            this.AddCurrentRButton.Name = "AddCurrentRButton";
            this.AddCurrentRButton.Size = new System.Drawing.Size(357, 66);
            this.AddCurrentRButton.TabIndex = 11;
            this.AddCurrentRButton.Text = "Add Current Reservation To Reservation List (Sorted By Ascending Order Of Custome" +
    "rName)";
            this.AddCurrentRButton.UseVisualStyleBackColor = true;
            this.AddCurrentRButton.Click += new System.EventHandler(this.AddCurrentRButton_Click);
            // 
            // WriteRButton
            // 
            this.WriteRButton.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WriteRButton.Location = new System.Drawing.Point(564, 434);
            this.WriteRButton.Name = "WriteRButton";
            this.WriteRButton.Size = new System.Drawing.Size(244, 77);
            this.WriteRButton.TabIndex = 12;
            this.WriteRButton.Text = "Write List And Grand Total Cost (Sum Of Total Cost) To File";
            this.WriteRButton.UseVisualStyleBackColor = true;
            this.WriteRButton.Click += new System.EventHandler(this.WriteRButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1148, 523);
            this.Controls.Add(this.WriteRButton);
            this.Controls.Add(this.AddCurrentRButton);
            this.Controls.Add(this.NCTTextBox);
            this.Controls.Add(this.NATTextBox);
            this.Controls.Add(this.CNTextBox);
            this.Controls.Add(this.NCTLabel);
            this.Controls.Add(this.NATLabel);
            this.Controls.Add(this.CNLabel);
            this.Controls.Add(this.CurrentReservationListBox);
            this.Controls.Add(this.CreateCurrentRButton);
            this.Controls.Add(this.ClearCurrentRButton);
            this.Controls.Add(this.SortedReservationListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox SortedReservationListBox;
        private System.Windows.Forms.Button ClearCurrentRButton;
        private System.Windows.Forms.Button CreateCurrentRButton;
        private System.Windows.Forms.ListBox CurrentReservationListBox;
        private System.Windows.Forms.Label CNLabel;
        private System.Windows.Forms.Label NATLabel;
        private System.Windows.Forms.Label NCTLabel;
        private System.Windows.Forms.TextBox CNTextBox;
        private System.Windows.Forms.TextBox NATTextBox;
        private System.Windows.Forms.TextBox NCTTextBox;
        private System.Windows.Forms.Button AddCurrentRButton;
        private System.Windows.Forms.Button WriteRButton;
    }
}

