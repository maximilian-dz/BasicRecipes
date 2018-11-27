namespace BasicRcps
{
    partial class AddRecipe
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
            this.labelCategory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.textBoxIngredient = new System.Windows.Forms.TextBox();
            this.buttonSaveRecipe = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(28, 45);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(99, 25);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(142, 94);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(313, 31);
            this.textBoxName.TabIndex = 5;
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.ItemHeight = 25;
            this.listBoxIngredients.Location = new System.Drawing.Point(33, 214);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(422, 354);
            this.listBoxIngredients.TabIndex = 7;
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAddIngredient.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddIngredient.Font = new System.Drawing.Font("Myanmar Text", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddIngredient.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonAddIngredient.Location = new System.Drawing.Point(473, 260);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(485, 75);
            this.buttonAddIngredient.TabIndex = 9;
            this.buttonAddIngredient.Text = "Add Ingredient";
            this.buttonAddIngredient.UseVisualStyleBackColor = false;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // textBoxIngredient
            // 
            this.textBoxIngredient.Location = new System.Drawing.Point(473, 214);
            this.textBoxIngredient.Name = "textBoxIngredient";
            this.textBoxIngredient.Size = new System.Drawing.Size(297, 31);
            this.textBoxIngredient.TabIndex = 10;
            // 
            // buttonSaveRecipe
            // 
            this.buttonSaveRecipe.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSaveRecipe.Font = new System.Drawing.Font("Myanmar Text", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveRecipe.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonSaveRecipe.Location = new System.Drawing.Point(473, 39);
            this.buttonSaveRecipe.Name = "buttonSaveRecipe";
            this.buttonSaveRecipe.Size = new System.Drawing.Size(489, 75);
            this.buttonSaveRecipe.TabIndex = 11;
            this.buttonSaveRecipe.Text = "Save Values";
            this.buttonSaveRecipe.UseVisualStyleBackColor = false;
            this.buttonSaveRecipe.Click += new System.EventHandler(this.buttonSaveValues_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClose.Font = new System.Drawing.Font("Myanmar Text", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonClose.Location = new System.Drawing.Point(473, 493);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(489, 75);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close And Save Recipe";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(142, 45);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(313, 33);
            this.comboBoxCategory.TabIndex = 13;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(142, 149);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(313, 31);
            this.textBoxDescription.TabIndex = 14;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(806, 213);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(136, 31);
            this.textBoxQuantity.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(806, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quantity";
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 593);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSaveRecipe);
            this.Controls.Add(this.textBoxIngredient);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.listBoxIngredients);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCategory);
            this.Name = "AddRecipe";
            this.Text = "AddRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.TextBox textBoxIngredient;
        private System.Windows.Forms.Button buttonSaveRecipe;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}