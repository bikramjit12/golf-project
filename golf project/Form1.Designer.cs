namespace golf_project
{
    partial class Form1
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
            this.LbGolf = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.suburb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Handicap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LbGolf
            // 
            this.LbGolf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.Firstname,
            this.Surname,
            this.Gender,
            this.DOB,
            this.Street,
            this.suburb,
            this.City,
            this.Available,
            this.Handicap});
            this.LbGolf.Location = new System.Drawing.Point(1, 2);
            this.LbGolf.Name = "LbGolf";
            this.LbGolf.Size = new System.Drawing.Size(787, 291);
            this.LbGolf.TabIndex = 0;
            this.LbGolf.UseCompatibleStateImageBehavior = false;
            this.LbGolf.View = System.Windows.Forms.View.Details;
            this.LbGolf.SelectedIndexChanged += new System.EventHandler(this.LbGolf_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Title
            // 
            this.Title.Text = "Tilte";
            // 
            // Firstname
            // 
            this.Firstname.Text = "Firstname";
            // 
            // Surname
            // 
            this.Surname.Text = "surname";
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            // 
            // DOB
            // 
            this.DOB.Text = "DOB";
            // 
            // Street
            // 
            this.Street.Text = "Street";
            // 
            // suburb
            // 
            this.suburb.Text = "suburb";
            // 
            // City
            // 
            this.City.Text = "City";
            // 
            // Available
            // 
            this.Available.Text = "Available";
            // 
            // Handicap
            // 
            this.Handicap.Text = "Handicap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbGolf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LbGolf;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Firstname;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader suburb;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Available;
        private System.Windows.Forms.ColumnHeader Handicap;
    }
}

