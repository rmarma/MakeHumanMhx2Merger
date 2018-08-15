namespace MakeHumanMhx2Merger
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxFileLeft = new System.Windows.Forms.GroupBox();
            this.buttonSaveFileLeft = new System.Windows.Forms.Button();
            this.buttonSelectFileLeft = new System.Windows.Forms.Button();
            this.textBoxFileLeft = new System.Windows.Forms.TextBox();
            this.groupBoxFileRight = new System.Windows.Forms.GroupBox();
            this.buttonSaveFileRight = new System.Windows.Forms.Button();
            this.buttonSelectFileRight = new System.Windows.Forms.Button();
            this.textBoxFileRight = new System.Windows.Forms.TextBox();
            this.groupBoxSkeleton = new System.Windows.Forms.GroupBox();
            this.buttonSkeletonLeftToRight = new System.Windows.Forms.Button();
            this.buttonSkeletonRightToLeft = new System.Windows.Forms.Button();
            this.listBoxSkeletonRight = new System.Windows.Forms.ListBox();
            this.listBoxSkeletonLeft = new System.Windows.Forms.ListBox();
            this.groupBoxMaterials = new System.Windows.Forms.GroupBox();
            this.buttonMaterialsLeftToRight = new System.Windows.Forms.Button();
            this.listBoxMaterialsRight = new System.Windows.Forms.ListBox();
            this.buttonMaterialsRightToLeft = new System.Windows.Forms.Button();
            this.listBoxMaterialsLeft = new System.Windows.Forms.ListBox();
            this.groupBoxGeometries = new System.Windows.Forms.GroupBox();
            this.buttonGeometriesLeftToRight = new System.Windows.Forms.Button();
            this.listBoxGeometriesRight = new System.Windows.Forms.ListBox();
            this.buttonGeometriesRightToLeft = new System.Windows.Forms.Button();
            this.listBoxGeometriesLeft = new System.Windows.Forms.ListBox();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxFileLeft.SuspendLayout();
            this.groupBoxFileRight.SuspendLayout();
            this.groupBoxSkeleton.SuspendLayout();
            this.groupBoxMaterials.SuspendLayout();
            this.groupBoxGeometries.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFileLeft
            // 
            this.groupBoxFileLeft.Controls.Add(this.buttonSaveFileLeft);
            this.groupBoxFileLeft.Controls.Add(this.buttonSelectFileLeft);
            this.groupBoxFileLeft.Controls.Add(this.textBoxFileLeft);
            this.groupBoxFileLeft.Location = new System.Drawing.Point(9, 9);
            this.groupBoxFileLeft.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxFileLeft.Name = "groupBoxFileLeft";
            this.groupBoxFileLeft.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxFileLeft.Size = new System.Drawing.Size(280, 45);
            this.groupBoxFileLeft.TabIndex = 2;
            this.groupBoxFileLeft.TabStop = false;
            this.groupBoxFileLeft.Text = "File Left";
            // 
            // buttonSaveFileLeft
            // 
            this.buttonSaveFileLeft.Image = global::MakeHumanMhx2Merger.Properties.Resources.Save_16x;
            this.buttonSaveFileLeft.Location = new System.Drawing.Point(246, 14);
            this.buttonSaveFileLeft.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.buttonSaveFileLeft.Name = "buttonSaveFileLeft";
            this.buttonSaveFileLeft.Size = new System.Drawing.Size(26, 23);
            this.buttonSaveFileLeft.TabIndex = 2;
            this.buttonSaveFileLeft.UseVisualStyleBackColor = true;
            this.buttonSaveFileLeft.Click += new System.EventHandler(this.ButtonSaveFileLeft_Click);
            // 
            // buttonSelectFileLeft
            // 
            this.buttonSelectFileLeft.AutoSize = true;
            this.buttonSelectFileLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSelectFileLeft.Location = new System.Drawing.Point(212, 14);
            this.buttonSelectFileLeft.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.buttonSelectFileLeft.Name = "buttonSelectFileLeft";
            this.buttonSelectFileLeft.Size = new System.Drawing.Size(26, 23);
            this.buttonSelectFileLeft.TabIndex = 1;
            this.buttonSelectFileLeft.Text = "...";
            this.buttonSelectFileLeft.UseVisualStyleBackColor = true;
            this.buttonSelectFileLeft.Click += new System.EventHandler(this.ButtonSelectFileLeft_Click);
            // 
            // textBoxFileLeft
            // 
            this.textBoxFileLeft.Location = new System.Drawing.Point(8, 16);
            this.textBoxFileLeft.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFileLeft.Name = "textBoxFileLeft";
            this.textBoxFileLeft.ReadOnly = true;
            this.textBoxFileLeft.Size = new System.Drawing.Size(200, 20);
            this.textBoxFileLeft.TabIndex = 0;
            // 
            // groupBoxFileRight
            // 
            this.groupBoxFileRight.Controls.Add(this.buttonSaveFileRight);
            this.groupBoxFileRight.Controls.Add(this.buttonSelectFileRight);
            this.groupBoxFileRight.Controls.Add(this.textBoxFileRight);
            this.groupBoxFileRight.Location = new System.Drawing.Point(343, 9);
            this.groupBoxFileRight.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxFileRight.Name = "groupBoxFileRight";
            this.groupBoxFileRight.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxFileRight.Size = new System.Drawing.Size(280, 45);
            this.groupBoxFileRight.TabIndex = 3;
            this.groupBoxFileRight.TabStop = false;
            this.groupBoxFileRight.Text = "File Right";
            // 
            // buttonSaveFileRight
            // 
            this.buttonSaveFileRight.Image = global::MakeHumanMhx2Merger.Properties.Resources.Save_16x;
            this.buttonSaveFileRight.Location = new System.Drawing.Point(246, 14);
            this.buttonSaveFileRight.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.buttonSaveFileRight.Name = "buttonSaveFileRight";
            this.buttonSaveFileRight.Size = new System.Drawing.Size(26, 23);
            this.buttonSaveFileRight.TabIndex = 2;
            this.buttonSaveFileRight.UseVisualStyleBackColor = true;
            this.buttonSaveFileRight.Click += new System.EventHandler(this.ButtonSaveFileRight_Click);
            // 
            // buttonSelectFileRight
            // 
            this.buttonSelectFileRight.AutoSize = true;
            this.buttonSelectFileRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSelectFileRight.Location = new System.Drawing.Point(212, 14);
            this.buttonSelectFileRight.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.buttonSelectFileRight.Name = "buttonSelectFileRight";
            this.buttonSelectFileRight.Size = new System.Drawing.Size(26, 23);
            this.buttonSelectFileRight.TabIndex = 1;
            this.buttonSelectFileRight.Text = "...";
            this.buttonSelectFileRight.UseVisualStyleBackColor = true;
            this.buttonSelectFileRight.Click += new System.EventHandler(this.ButtonSelectFileRight_Click);
            // 
            // textBoxFileRight
            // 
            this.textBoxFileRight.Location = new System.Drawing.Point(8, 16);
            this.textBoxFileRight.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFileRight.Name = "textBoxFileRight";
            this.textBoxFileRight.ReadOnly = true;
            this.textBoxFileRight.Size = new System.Drawing.Size(200, 20);
            this.textBoxFileRight.TabIndex = 0;
            // 
            // groupBoxSkeleton
            // 
            this.groupBoxSkeleton.Controls.Add(this.buttonSkeletonLeftToRight);
            this.groupBoxSkeleton.Controls.Add(this.buttonSkeletonRightToLeft);
            this.groupBoxSkeleton.Controls.Add(this.listBoxSkeletonRight);
            this.groupBoxSkeleton.Controls.Add(this.listBoxSkeletonLeft);
            this.groupBoxSkeleton.Location = new System.Drawing.Point(9, 63);
            this.groupBoxSkeleton.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxSkeleton.Name = "groupBoxSkeleton";
            this.groupBoxSkeleton.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxSkeleton.Size = new System.Drawing.Size(614, 118);
            this.groupBoxSkeleton.TabIndex = 3;
            this.groupBoxSkeleton.TabStop = false;
            this.groupBoxSkeleton.Text = "Skeleton";
            // 
            // buttonSkeletonLeftToRight
            // 
            this.buttonSkeletonLeftToRight.Location = new System.Drawing.Point(275, 69);
            this.buttonSkeletonLeftToRight.Name = "buttonSkeletonLeftToRight";
            this.buttonSkeletonLeftToRight.Size = new System.Drawing.Size(64, 23);
            this.buttonSkeletonLeftToRight.TabIndex = 3;
            this.buttonSkeletonLeftToRight.Text = "->";
            this.buttonSkeletonLeftToRight.UseVisualStyleBackColor = true;
            this.buttonSkeletonLeftToRight.Click += new System.EventHandler(this.ButtonSkeletonLeftToRight_Click);
            // 
            // buttonSkeletonRightToLeft
            // 
            this.buttonSkeletonRightToLeft.Location = new System.Drawing.Point(275, 40);
            this.buttonSkeletonRightToLeft.Name = "buttonSkeletonRightToLeft";
            this.buttonSkeletonRightToLeft.Size = new System.Drawing.Size(64, 23);
            this.buttonSkeletonRightToLeft.TabIndex = 2;
            this.buttonSkeletonRightToLeft.Text = "<-";
            this.buttonSkeletonRightToLeft.UseVisualStyleBackColor = true;
            this.buttonSkeletonRightToLeft.Click += new System.EventHandler(this.ButtonSkeletonRightToLeft_Click);
            // 
            // listBoxSkeletonRight
            // 
            this.listBoxSkeletonRight.FormattingEnabled = true;
            this.listBoxSkeletonRight.Location = new System.Drawing.Point(342, 16);
            this.listBoxSkeletonRight.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxSkeletonRight.Name = "listBoxSkeletonRight";
            this.listBoxSkeletonRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSkeletonRight.Size = new System.Drawing.Size(264, 95);
            this.listBoxSkeletonRight.TabIndex = 1;
            this.listBoxSkeletonRight.SelectedIndexChanged += new System.EventHandler(this.ListBoxSkeletonRight_SelectedIndexChanged);
            // 
            // listBoxSkeletonLeft
            // 
            this.listBoxSkeletonLeft.FormattingEnabled = true;
            this.listBoxSkeletonLeft.Location = new System.Drawing.Point(8, 16);
            this.listBoxSkeletonLeft.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxSkeletonLeft.Name = "listBoxSkeletonLeft";
            this.listBoxSkeletonLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSkeletonLeft.Size = new System.Drawing.Size(264, 95);
            this.listBoxSkeletonLeft.TabIndex = 0;
            this.listBoxSkeletonLeft.SelectedIndexChanged += new System.EventHandler(this.ListBoxSkeletonLeft_SelectedIndexChanged);
            // 
            // groupBoxMaterials
            // 
            this.groupBoxMaterials.Controls.Add(this.buttonMaterialsLeftToRight);
            this.groupBoxMaterials.Controls.Add(this.listBoxMaterialsRight);
            this.groupBoxMaterials.Controls.Add(this.buttonMaterialsRightToLeft);
            this.groupBoxMaterials.Controls.Add(this.listBoxMaterialsLeft);
            this.groupBoxMaterials.Location = new System.Drawing.Point(9, 190);
            this.groupBoxMaterials.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxMaterials.Name = "groupBoxMaterials";
            this.groupBoxMaterials.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxMaterials.Size = new System.Drawing.Size(614, 119);
            this.groupBoxMaterials.TabIndex = 4;
            this.groupBoxMaterials.TabStop = false;
            this.groupBoxMaterials.Text = "Materials";
            // 
            // buttonMaterialsLeftToRight
            // 
            this.buttonMaterialsLeftToRight.Location = new System.Drawing.Point(275, 68);
            this.buttonMaterialsLeftToRight.Name = "buttonMaterialsLeftToRight";
            this.buttonMaterialsLeftToRight.Size = new System.Drawing.Size(64, 23);
            this.buttonMaterialsLeftToRight.TabIndex = 5;
            this.buttonMaterialsLeftToRight.Text = "->";
            this.buttonMaterialsLeftToRight.UseVisualStyleBackColor = true;
            this.buttonMaterialsLeftToRight.Click += new System.EventHandler(this.ButtonMaterialsLeftToRight_Click);
            // 
            // listBoxMaterialsRight
            // 
            this.listBoxMaterialsRight.FormattingEnabled = true;
            this.listBoxMaterialsRight.Location = new System.Drawing.Point(342, 16);
            this.listBoxMaterialsRight.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxMaterialsRight.Name = "listBoxMaterialsRight";
            this.listBoxMaterialsRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMaterialsRight.Size = new System.Drawing.Size(264, 95);
            this.listBoxMaterialsRight.TabIndex = 2;
            this.listBoxMaterialsRight.SelectedIndexChanged += new System.EventHandler(this.ListBoxMaterialsRight_SelectedIndexChanged);
            // 
            // buttonMaterialsRightToLeft
            // 
            this.buttonMaterialsRightToLeft.Location = new System.Drawing.Point(275, 39);
            this.buttonMaterialsRightToLeft.Name = "buttonMaterialsRightToLeft";
            this.buttonMaterialsRightToLeft.Size = new System.Drawing.Size(64, 23);
            this.buttonMaterialsRightToLeft.TabIndex = 4;
            this.buttonMaterialsRightToLeft.Text = "<-";
            this.buttonMaterialsRightToLeft.UseVisualStyleBackColor = true;
            this.buttonMaterialsRightToLeft.Click += new System.EventHandler(this.ButtonMaterialsRightToLeft_Click);
            // 
            // listBoxMaterialsLeft
            // 
            this.listBoxMaterialsLeft.FormattingEnabled = true;
            this.listBoxMaterialsLeft.Location = new System.Drawing.Point(8, 16);
            this.listBoxMaterialsLeft.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxMaterialsLeft.Name = "listBoxMaterialsLeft";
            this.listBoxMaterialsLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMaterialsLeft.Size = new System.Drawing.Size(264, 95);
            this.listBoxMaterialsLeft.TabIndex = 1;
            this.listBoxMaterialsLeft.SelectedIndexChanged += new System.EventHandler(this.ListBoxMaterialsLeft_SelectedIndexChanged);
            // 
            // groupBoxGeometries
            // 
            this.groupBoxGeometries.Controls.Add(this.buttonGeometriesLeftToRight);
            this.groupBoxGeometries.Controls.Add(this.listBoxGeometriesRight);
            this.groupBoxGeometries.Controls.Add(this.buttonGeometriesRightToLeft);
            this.groupBoxGeometries.Controls.Add(this.listBoxGeometriesLeft);
            this.groupBoxGeometries.Location = new System.Drawing.Point(9, 318);
            this.groupBoxGeometries.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxGeometries.Name = "groupBoxGeometries";
            this.groupBoxGeometries.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxGeometries.Size = new System.Drawing.Size(614, 119);
            this.groupBoxGeometries.TabIndex = 5;
            this.groupBoxGeometries.TabStop = false;
            this.groupBoxGeometries.Text = "Geometries";
            // 
            // buttonGeometriesLeftToRight
            // 
            this.buttonGeometriesLeftToRight.Location = new System.Drawing.Point(275, 69);
            this.buttonGeometriesLeftToRight.Name = "buttonGeometriesLeftToRight";
            this.buttonGeometriesLeftToRight.Size = new System.Drawing.Size(64, 23);
            this.buttonGeometriesLeftToRight.TabIndex = 7;
            this.buttonGeometriesLeftToRight.Text = "->";
            this.buttonGeometriesLeftToRight.UseVisualStyleBackColor = true;
            this.buttonGeometriesLeftToRight.Click += new System.EventHandler(this.ButtonGeometriesLeftToRight_Click);
            // 
            // listBoxGeometriesRight
            // 
            this.listBoxGeometriesRight.FormattingEnabled = true;
            this.listBoxGeometriesRight.Location = new System.Drawing.Point(342, 16);
            this.listBoxGeometriesRight.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxGeometriesRight.Name = "listBoxGeometriesRight";
            this.listBoxGeometriesRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxGeometriesRight.Size = new System.Drawing.Size(264, 95);
            this.listBoxGeometriesRight.TabIndex = 4;
            this.listBoxGeometriesRight.SelectedIndexChanged += new System.EventHandler(this.ListBoxGeometriesRight_SelectedIndexChanged);
            // 
            // buttonGeometriesRightToLeft
            // 
            this.buttonGeometriesRightToLeft.Location = new System.Drawing.Point(275, 40);
            this.buttonGeometriesRightToLeft.Name = "buttonGeometriesRightToLeft";
            this.buttonGeometriesRightToLeft.Size = new System.Drawing.Size(64, 23);
            this.buttonGeometriesRightToLeft.TabIndex = 6;
            this.buttonGeometriesRightToLeft.Text = "<-";
            this.buttonGeometriesRightToLeft.UseVisualStyleBackColor = true;
            this.buttonGeometriesRightToLeft.Click += new System.EventHandler(this.ButtonGeometriesRightToLeft_Click);
            // 
            // listBoxGeometriesLeft
            // 
            this.listBoxGeometriesLeft.FormattingEnabled = true;
            this.listBoxGeometriesLeft.Location = new System.Drawing.Point(8, 16);
            this.listBoxGeometriesLeft.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxGeometriesLeft.Name = "listBoxGeometriesLeft";
            this.listBoxGeometriesLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxGeometriesLeft.Size = new System.Drawing.Size(264, 95);
            this.listBoxGeometriesLeft.TabIndex = 3;
            this.listBoxGeometriesLeft.SelectedIndexChanged += new System.EventHandler(this.ListBoxGeometriesLeft_SelectedIndexChanged);
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.Filter = "Mhx2|*.mhx2|All Files|*.*";
            // 
            // saveFileDialogMain
            // 
            this.saveFileDialogMain.Filter = "Mhx2|*.mhx2|All Files|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.groupBoxGeometries);
            this.Controls.Add(this.groupBoxMaterials);
            this.Controls.Add(this.groupBoxSkeleton);
            this.Controls.Add(this.groupBoxFileRight);
            this.Controls.Add(this.groupBoxFileLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeHuman mhx2 merger";
            this.groupBoxFileLeft.ResumeLayout(false);
            this.groupBoxFileLeft.PerformLayout();
            this.groupBoxFileRight.ResumeLayout(false);
            this.groupBoxFileRight.PerformLayout();
            this.groupBoxSkeleton.ResumeLayout(false);
            this.groupBoxMaterials.ResumeLayout(false);
            this.groupBoxGeometries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFileLeft;
        private System.Windows.Forms.Button buttonSelectFileLeft;
        private System.Windows.Forms.TextBox textBoxFileLeft;
        private System.Windows.Forms.Button buttonSaveFileLeft;
        private System.Windows.Forms.GroupBox groupBoxFileRight;
        private System.Windows.Forms.Button buttonSaveFileRight;
        private System.Windows.Forms.Button buttonSelectFileRight;
        private System.Windows.Forms.TextBox textBoxFileRight;
        private System.Windows.Forms.GroupBox groupBoxSkeleton;
        private System.Windows.Forms.GroupBox groupBoxMaterials;
        private System.Windows.Forms.GroupBox groupBoxGeometries;
        private System.Windows.Forms.ListBox listBoxSkeletonLeft;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.ListBox listBoxMaterialsLeft;
        private System.Windows.Forms.ListBox listBoxSkeletonRight;
        private System.Windows.Forms.ListBox listBoxMaterialsRight;
        private System.Windows.Forms.ListBox listBoxGeometriesRight;
        private System.Windows.Forms.ListBox listBoxGeometriesLeft;
        private System.Windows.Forms.Button buttonSkeletonLeftToRight;
        private System.Windows.Forms.Button buttonSkeletonRightToLeft;
        private System.Windows.Forms.Button buttonMaterialsLeftToRight;
        private System.Windows.Forms.Button buttonMaterialsRightToLeft;
        private System.Windows.Forms.Button buttonGeometriesLeftToRight;
        private System.Windows.Forms.Button buttonGeometriesRightToLeft;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
    }
}

