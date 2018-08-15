using System;
using System.IO;
using System.Windows.Forms;

namespace MakeHumanMhx2Merger
{
    public partial class FormMain : Form
    {

        private Mhx2Model mhx2Left;
        private Mhx2Model mhx2Right;

        public FormMain()
        {
            InitializeComponent();

            ResetLeft();
            ResetRight();
        }


        private void SetMhx2Left(Mhx2Model mhx2)
        {
            mhx2Left = mhx2;
            listBoxSkeletonLeft.ClearSelected();
            listBoxMaterialsLeft.ClearSelected();
            listBoxGeometriesLeft.ClearSelected();

            listBoxSkeletonLeft.Items.Clear();
            listBoxMaterialsLeft.Items.Clear();
            listBoxGeometriesLeft.Items.Clear();

            listBoxSkeletonLeft.Items.AddRange(mhx2.GetSkeletonBoneNames());
            listBoxMaterialsLeft.Items.AddRange(mhx2.GetMaterialNames());
            listBoxGeometriesLeft.Items.AddRange(mhx2.GetGeometryNames());

            ResetLeft();
        }

        private void SetMhx2Right(Mhx2Model mhx2)
        {
            mhx2Right = mhx2;
            listBoxSkeletonRight.ClearSelected();
            listBoxMaterialsRight.ClearSelected();
            listBoxGeometriesRight.ClearSelected();

            listBoxSkeletonRight.Items.Clear();
            listBoxMaterialsRight.Items.Clear();
            listBoxGeometriesRight.Items.Clear();

            listBoxSkeletonRight.Items.AddRange(mhx2.GetSkeletonBoneNames());
            listBoxMaterialsRight.Items.AddRange(mhx2.GetMaterialNames());
            listBoxGeometriesRight.Items.AddRange(mhx2.GetGeometryNames());

            ResetRight();
        }


        private void ResetLeft()
        {
            buttonSkeletonLeftToRight.Enabled = false;
            buttonMaterialsLeftToRight.Enabled = false;
            buttonGeometriesLeftToRight.Enabled = false;
        }

        private void ResetRight()
        {
            buttonSkeletonRightToLeft.Enabled = false;
            buttonMaterialsRightToLeft.Enabled = false;
            buttonGeometriesRightToLeft.Enabled = false;
        }


        private void ButtonSelectFileLeft_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialogMain.FileName;
                textBoxFileLeft.Text = path;
                SetMhx2Left(new Mhx2Model(path));
            }
        }

        private void ButtonSelectFileRight_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialogMain.FileName;
                textBoxFileRight.Text = path;
                SetMhx2Right(new Mhx2Model(path));
            }
        }


        private void AddSelectedSkeletonBones(ListBox listBoxFrom, ListBox listBoxTo, Mhx2Model mhx2From, Mhx2Model mhx2To)
        {
            foreach (int index in listBoxFrom.SelectedIndices)
            {
                mhx2To.AddSkeletonBone(mhx2From.GetSkeletonBone(index));
            }
            listBoxTo.ClearSelected();
            listBoxTo.Items.Clear();
            listBoxTo.Items.AddRange(mhx2To.GetSkeletonBoneNames());
        }

        private void AddSelectedMaterials(ListBox listBoxFrom, ListBox listBoxTo, Mhx2Model mhx2From, Mhx2Model mhx2To)
        {
            foreach (int index in listBoxFrom.SelectedIndices)
            {
                mhx2To.AddMaterial(mhx2From.GetMaterial(index));
            }
            listBoxTo.ClearSelected();
            listBoxTo.Items.Clear();
            listBoxTo.Items.AddRange(mhx2To.GetMaterialNames());
        }

        private void AddSelectedGeometries(ListBox listBoxFrom, ListBox listBoxTo, Mhx2Model mhx2From, Mhx2Model mhx2To)
        {
            foreach (int index in listBoxFrom.SelectedIndices)
            {
                mhx2To.AddGeometry(mhx2From.GetGeometry(index));
            }
            listBoxTo.ClearSelected();
            listBoxTo.Items.Clear();
            listBoxTo.Items.AddRange(mhx2To.GetGeometryNames());
        }




        private void ListBoxSkeletonLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSkeletonLeftToRight.Enabled = listBoxSkeletonLeft.SelectedIndices.Count > 0;
        }

        private void ListBoxSkeletonRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSkeletonRightToLeft.Enabled = listBoxSkeletonRight.SelectedIndices.Count > 0;
        }

        private void ListBoxMaterialsLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonMaterialsLeftToRight.Enabled = listBoxMaterialsLeft.SelectedIndices.Count > 0;
        }

        private void ListBoxMaterialsRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonMaterialsRightToLeft.Enabled = listBoxMaterialsRight.SelectedIndices.Count > 0;
        }

        private void ListBoxGeometriesLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGeometriesLeftToRight.Enabled = listBoxGeometriesLeft.SelectedIndices.Count > 0;
        }

        private void ListBoxGeometriesRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGeometriesRightToLeft.Enabled = listBoxGeometriesRight.SelectedIndices.Count > 0;
        }


        private void ButtonSkeletonRightToLeft_Click(object sender, EventArgs e)
        {
            AddSelectedSkeletonBones(listBoxSkeletonRight, listBoxSkeletonLeft, mhx2Right, mhx2Left);
        }

        private void ButtonSkeletonLeftToRight_Click(object sender, EventArgs e)
        {
            AddSelectedSkeletonBones(listBoxSkeletonLeft, listBoxSkeletonRight, mhx2Left, mhx2Right);
        }

        private void ButtonMaterialsRightToLeft_Click(object sender, EventArgs e)
        {
            AddSelectedMaterials(listBoxMaterialsRight, listBoxMaterialsLeft, mhx2Right, mhx2Left);
        }

        private void ButtonMaterialsLeftToRight_Click(object sender, EventArgs e)
        {
            AddSelectedMaterials(listBoxMaterialsLeft, listBoxMaterialsRight, mhx2Left, mhx2Right);
        }

        private void ButtonGeometriesRightToLeft_Click(object sender, EventArgs e)
        {
            AddSelectedGeometries(listBoxGeometriesRight, listBoxGeometriesLeft, mhx2Right, mhx2Left);
        }

        private void ButtonGeometriesLeftToRight_Click(object sender, EventArgs e)
        {
            AddSelectedGeometries(listBoxGeometriesLeft, listBoxGeometriesRight, mhx2Left, mhx2Right);
        }


        private void ButtonSaveFileLeft_Click(object sender, EventArgs e)
        {
            saveFileDialogMain.FileName = new FileInfo(mhx2Left.GetPath()).Name;
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                mhx2Left.Save(saveFileDialogMain.FileName);
            }
        }

        private void ButtonSaveFileRight_Click(object sender, EventArgs e)
        {
            saveFileDialogMain.FileName = new FileInfo(mhx2Right.GetPath()).Name;
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                mhx2Right.Save(saveFileDialogMain.FileName);
            }
        }
    }
}
