
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project2_Filling_mesh
{
    public partial class ProjectForm : Form
    {
        Triangle[,] triangles;
        double M, N;
        double dX, dY;

        double ks, kd, m;
        bool nvTexture = true;
        bool lvConstant = true;
        bool ocTexture = true;
        bool fPrecision = true;
        Vertex currVertex = null;

        int pBWidth, pBHeight;
        Bitmap tmpBackgroundImage, tmpNormalVectorMap;
        DirectBitmap backgroundImage, workingImage, normalVectorMap;
        Graphics backgroundImageGraphics, workingImageGraphics, normalVectorMapGraphics, graphics;

        Color lightColor, constObjectColor;
        Vector3D lightVector = new Vector3D(Constants.constantLightVersor);
        double t = 1;

        public ProjectForm()
        {
            InitializeComponent();

            GenerateMesh();

            ks = trackBarKS.Value / Constants.kskdMaxVal;
            kd = trackBarKD.Value / Constants.kskdMaxVal;
            m = trackBarM.Value;

            (pBWidth, pBHeight) = (pictureBox.Width, pictureBox.Height);
            tmpBackgroundImage = new Bitmap(Properties.Resources.default_bg, pBWidth, pBHeight);
            backgroundImage = new DirectBitmap(pBWidth, pBHeight);
            backgroundImageGraphics = Graphics.FromImage(backgroundImage.Bitmap);
            backgroundImageGraphics.DrawImage(tmpBackgroundImage, 0, 0, pBWidth, pBHeight);

            workingImage = new DirectBitmap(pBWidth, pBHeight);
            workingImageGraphics = Graphics.FromImage(workingImage.Bitmap);
            workingImageGraphics.DrawImage(backgroundImage.Bitmap, 0, 0, pBWidth, pBHeight);

            tmpNormalVectorMap = new Bitmap(Properties.Resources.brick_normalmap, pBWidth, pBHeight);
            normalVectorMap = new DirectBitmap(pBWidth, pBHeight);
            normalVectorMapGraphics = Graphics.FromImage(normalVectorMap.Bitmap);
            normalVectorMapGraphics.DrawImage(tmpNormalVectorMap, 0, 0, pBWidth, pBHeight);

            lightColor = labelLightColor.BackColor;
            constObjectColor = labelObjectColor.BackColor;

            pictureBox.Image = new Bitmap(workingImage.Bitmap);
            graphics = Graphics.FromImage(pictureBox.Image);
            RedrawAll();
        }

        #region MouseActions

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (meshVisible.Checked && (currVertex = GetVertexClicked(e.X, e.Y)) != null)
                if (!lvConstant)
                    Timer.Stop();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (currVertex != null)
            {
                MoveVertex(currVertex, e.X, e.Y);
                RedrawTrianglesEdges();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (currVertex != null)
                if (!lvConstant)
                    Timer.Start();
            currVertex = null;
        }

        #endregion

        #region MeshParametersChanging

        private void numericUpDownM_ValueChanged(object sender, EventArgs e)
        {
            if (dynamicRefresh.Checked)
            {
                GenerateMesh();
                if (lvConstant)
                    RedrawAll();
            }
        }

        private void numericUpDownN_ValueChanged(object sender, EventArgs e)
        {
            if (dynamicRefresh.Checked)
            {
                GenerateMesh();
                if (lvConstant)
                    RedrawAll();
            }
        }

        private void meshVisible_CheckedChanged(object sender, EventArgs e)
        {
            RedrawTrianglesEdges();
        }

        #endregion

        #region FactorsChanging

        private void trackBarKS_Scroll(object sender, EventArgs e)
        {
            if (dynamicRefresh.Checked)
            {
                ks = trackBarKS.Value / Constants.kskdMaxVal;
                if (lvConstant)
                    RedrawAll();
            }
        }

        private void trackBarKD_Scroll(object sender, EventArgs e)
        {
            if (dynamicRefresh.Checked)
            {
                kd = trackBarKD.Value / Constants.kskdMaxVal;
                if (lvConstant)
                    RedrawAll();
            }
        }

        private void trackBarM_Scroll(object sender, EventArgs e)
        {
            if (dynamicRefresh.Checked)
            {
                m = trackBarM.Value;
                if (lvConstant)
                    RedrawAll();
            }
        }

        #endregion

        #region NormalVectorChanging

        private void normalVectorTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (dynamicRefresh.Checked)
            {
                nvTexture = normalVectorTexture.Checked;
                if (nvTexture)
                    normalVectorMapGraphics.DrawImage(tmpNormalVectorMap, 0, 0, pBWidth, pBHeight);
                if (lvConstant)
                    RedrawAll();
            }
        }

        private void nvTextureLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = ImagesFileDialog("Selet normal vector");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                tmpNormalVectorMap = new Bitmap(new Bitmap(openFileDialog.FileName), pBWidth, pBHeight);
            if (dynamicRefresh.Checked)
            {
                normalVectorMapGraphics.DrawImage(tmpNormalVectorMap, 0, 0, pBWidth, pBHeight);
                if (lvConstant)
                    RedrawAll();
            }
        }

        #endregion

        #region LightChanging

        private void labelLightColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                labelLightColor.BackColor = colorDialog.Color;
            if (dynamicRefresh.Checked)
            {
                lightColor = labelLightColor.BackColor;
                if (lvConstant)
                    RedrawAll();
            }
        }

        private void lightVersorConstant_CheckedChanged(object sender, EventArgs e)
        {
            if (dynamicRefresh.Checked)
            {
                lvConstant = lightVersorConstant.Checked;
                if (lvConstant)
                {
                    Timer.Stop();
                    t = 1;
                    Constants.timeFactor = 1;
                    lightVector = new Vector3D(Constants.constantLightVersor);
                    RedrawAll();
                }
                else
                    Timer.Start();
            }
        }

        #endregion

        #region ObjectColorChanging

        private void objectColorTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (dynamicRefresh.Checked)
            {
                ocTexture = objectColorTexture.Checked;
                if (ocTexture)
                    backgroundImageGraphics.DrawImage(tmpBackgroundImage, 0, 0, pBWidth, pBHeight);
                if (lvConstant)
                    RedrawAll();
            }
        }

        private void ocTextureLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = ImagesFileDialog("Selet object color texture");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                tmpBackgroundImage = new Bitmap(new Bitmap(openFileDialog.FileName), pBWidth, pBHeight);
            if (dynamicRefresh.Checked)
            {
                backgroundImageGraphics.DrawImage(tmpBackgroundImage, 0, 0, pBWidth, pBHeight);
                if (lvConstant)
                    RedrawAll();
            }
        }

        private void labelObjectColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                labelObjectColor.BackColor = colorDialog.Color;
            if (dynamicRefresh.Checked)
                constObjectColor = labelObjectColor.BackColor;
        }

        #endregion

        #region FillingModeChanging

        private void fillingPrecision_CheckedChanged(object sender, EventArgs e)
        {
            if (dynamicRefresh.Checked)
            {
                fPrecision = fillingPrecision.Checked;
                if (lvConstant)
                    RedrawAll();
            }
        }

        #endregion

        #region Refreshing

        private void dynamicRefresh_CheckedChanged(object sender, EventArgs e)
        {
            buttonRefresh.Enabled = true;
            if (dynamicRefresh.Checked)
            {
                buttonRefresh_Click(sender, e);
                buttonRefresh.Enabled = false;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (N != ((double)numericUpDownN.Value) || M != (double)(numericUpDownM.Value))
                GenerateMesh();

            ks = trackBarKS.Value / Constants.kskdMaxVal;
            kd = trackBarKD.Value / Constants.kskdMaxVal;
            m = trackBarM.Value;

            nvTexture = normalVectorTexture.Checked;
            normalVectorMapGraphics.DrawImage(tmpNormalVectorMap, 0, 0, pBWidth, pBHeight);

            lightColor = labelLightColor.BackColor;
            lvConstant = lightVersorConstant.Checked;

            ocTexture = objectColorTexture.Checked;
            backgroundImageGraphics.DrawImage(tmpBackgroundImage, 0, 0, pBWidth, pBHeight);
            constObjectColor = labelObjectColor.BackColor;

            fPrecision = fillingPrecision.Checked;

            if (lvConstant)
            {
                Timer.Stop();
                t = 1;
                Constants.timeFactor = 1;
                lightVector = new Vector3D(Constants.constantLightVersor);
                RedrawAll();
            }
            else
                Timer.Start();
        }

        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            t += (Constants.timeInterval * Constants.timeFactor);
            double radians = t * Math.PI / 180f;
            double k = ((double)pictureBox.Width) / ((double)pictureBox.Height);
            double X = 2 * k * t * Math.Sin(8 * radians) + pictureBox.Width / 2f;
            double Y = 2 * t * Math.Cos(8 * radians) + pictureBox.Height / 2f;
            if (t == Constants.maxTime)
                Constants.timeFactor = -1;
            if (t == 1)
                Constants.timeFactor = 1;
            double Z = 2.5 * t;
            lightVector = new Vector3D(X, Y, Z);
            RedrawAll();
        }

        private void ProjectForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Timer.Stop();
            if (WindowState == FormWindowState.Normal)
                if (!lvConstant)
                    Timer.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
