using System.Drawing;
using System.Drawing.Imaging;
using System.Xml.Serialization;

//TODO CONTROLES DE TECLADO; ETIQUETA DESCRIPTIVA ; BLOQUEAR ETIQUETA

namespace VertexCreator
{
    public partial class Form1 : Form
    {
        //public int[,] vertex = new int[128, 2];
        public int currInd = 0;
        public int selected = 0;
        public string lastFile = string.Empty;
        public Bitmap curBmp;
        public bool delConfirm = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int oldVal = (int)frameN.Value;
            OpenFileDialog loadImg = new OpenFileDialog();
            if (loadImg.ShowDialog() == DialogResult.OK)
            {
                var filePath = loadImg.FileName;
                lastFile = filePath;
                using (Stream str = loadImg.OpenFile())
                {
                    Bitmap bmp = (Bitmap)Image.FromFile(filePath);
                    picCanvas.Image = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), PixelFormat.Format32bppRgb);
                    curBmp = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), PixelFormat.Format32bppRgb);
                    try
                    {
                        frameN.Value = int.Parse(filePath.Split('-')[1].Split('.')[0]);
                    }
                    catch (Exception)
                    {

                        frameN.Value = oldVal;
                    }


                    reDraw();
                    if (File.Exists(filePath.Replace(".png", ".txt")))
                    {
                        listVertex.Items.Clear();
                        using (StreamReader dat = new StreamReader(filePath.Replace(".png", ".txt")))
                        {
                            string vertex;

                            while ((vertex = dat.ReadLine()) != null)
                            {
                                listVertex.Items.Add(vertex);
                                currInd++;
                            }

                            /*
                            // Pen pen = new Pen(Color.FromArgb(255, 16, 64));
                            while ((vertex = dat.ReadLine()) != null)
                            {
                                using (Pen pen = new Pen(Color.FromArgb(255, 16, 64)))
                                {
                                    Graphics pnt = Graphics.FromImage(picCanvas.Image);
                                    vX = int.Parse(vertex.Split(",")[0]);
                                    vY = int.Parse(vertex.Split(",")[1]);
                                    Rectangle rect = new Rectangle(new Point(vX + 2, vY + 2), new Size(4, 4));
                                    pnt.DrawEllipse(pen, rect);
                                    if (vY < 180)
                                        pnt.DrawString(currInd.ToString(), new Font("VCR OSD Mono", 8), Brushes.Red, new Point(vX + 2, vY + 2));
                                    else
                                        pnt.DrawString(currInd.ToString(), new Font("VCR OSD Mono", 8), Brushes.Red, new Point(vX + 2, vY - 6));
                                    pnt.Dispose();
                                    listVertex.Items.Add(vertex);
                                    currInd++;
                                    pen.Dispose();

                                }
                            }
                            //pen.Dispose();
                            picCanvas.Refresh();*/
                            reDraw();
                        }

                    }
                }
            }
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            delConfirm = false;
            lblDebug.Text = e.X.ToString() + "," + e.Y.ToString();
            //vertex[currInd, 0] = e.X; vertex[currInd, 1] = e.Y;
            if (picCanvas.Image != null)
            {
                Graphics pnt = Graphics.FromImage(picCanvas.Image);
                using (Pen pen = new Pen(Color.FromArgb(255, 16, 64)))
                {
                    Rectangle rect = new Rectangle(new Point(e.X - 2, e.Y - 2), new Size(4, 4));
                    pnt.DrawEllipse(pen, rect);
                    if (e.Y < 180)
                        pnt.DrawString(currInd.ToString(), new Font("VCR OSD Mono", 8), Brushes.Red, new Point(e.X + 2, e.Y + 2));
                    else
                        pnt.DrawString(currInd.ToString(), new Font("VCR OSD Mono", 8), Brushes.Red, new Point(e.X + 2, e.Y - 6));
                    picCanvas.Refresh();
                    pnt.Dispose();
                }

                listVertex.Items.Add(lblDebug.Text + "\n");
                listVertex.SelectedIndex = currInd;
                currInd++;
            }

            listVertex.Focus();

        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblDebug.Text = e.X.ToString() + "," + e.Y.ToString();
        }

        private void listVertex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (listVertex.SelectedIndex != -1)
            {
                int pX = int.Parse(listVertex.Items[listVertex.SelectedIndex].ToString().Split(',')[0]);
                int pY = int.Parse(listVertex.Items[listVertex.SelectedIndex].ToString().Split(',')[1]);

                switch (e.KeyChar)
                {
                    case 'w':
                        if (pY > 0)
                        {
                            listVertex.Items[listVertex.SelectedIndex] = pX.ToString() + "," + (pY - 1).ToString();
                        }
                        reDraw();
                        delConfirm = false;
                        break;
                    case 'a':
                        if (pX > 0)
                        {
                            listVertex.Items[listVertex.SelectedIndex] = (pX - 1).ToString() + "," + pY.ToString();
                        }
                        reDraw();
                        delConfirm = false;
                        break;
                    case 's':
                        if (pY < picCanvas.Size.Height)
                        {
                            listVertex.Items[listVertex.SelectedIndex] = pX.ToString() + "," + (pY + 1).ToString();
                        }
                        reDraw();
                        delConfirm = false;
                        break;
                    case 'd':
                        if (pX < picCanvas.Size.Width)
                        {
                            listVertex.Items[listVertex.SelectedIndex] = (pX + 1).ToString() + "," + pY.ToString();
                        }
                        reDraw();
                        delConfirm = false;
                        break;
                    case 'q':
                        listVertex.Items.RemoveAt(listVertex.SelectedIndex);
                        reDraw();
                        delConfirm = false;
                        break;
                    case 'e':
                        createPoly("000000");
                        lblDebug.Text = "Copied black poly to clipboard!";
                        delConfirm = false;
                        break;
                    case 'r':
                        createPoly("FFFFFF");
                        lblDebug.Text = "Copied white poly to clipboard!";
                        delConfirm = false;
                        break;
                    case 'f':
                        createPoly("000000");
                        lblDebug.Text = "Saved and copied black poly to clipboard!";
                        delConfirm = false;
                        break;
                    case 'x':
                        if (delConfirm == false)
                        {

                            delConfirm = true;

                        }
                        else{
                            listVertex.Items.Clear();
                            if (picCanvas.Image != null)
                            {
                                delConfirm=false;
                                reDraw();
                            }
                        }
                    break;
                }
            }
        }

        private void reDraw()
        {
            delConfirm = false;
            currInd = 0;
            string vertex;
            int vX = 0, vY = 0;
            int cycles = listVertex.Items.Count;
            picCanvas.Image.Dispose();
            picCanvas.Image = (Image)curBmp.Clone();

            for (int i = 0; i < cycles; i++)
            {
                using (Pen pen = new Pen(Color.FromArgb(255, 16, 64)))
                {
                    vertex = listVertex.Items[i].ToString();

                    Graphics pnt = Graphics.FromImage(picCanvas.Image);
                    vX = int.Parse(vertex.Split(",")[0]);
                    vY = int.Parse(vertex.Split(",")[1]);
                    Rectangle rect = new Rectangle(new Point(vX - 2, vY - 2), new Size(4, 4));
                    pnt.DrawEllipse(pen, rect);
                    if (vY < 180)
                        pnt.DrawString(currInd.ToString(), new Font("VCR OSD Mono", 8), Brushes.Red, new Point(vX + 2, vY + 2));
                    else
                        pnt.DrawString(currInd.ToString(), new Font("VCR OSD Mono", 8), Brushes.Red, new Point(vX + 2, vY - 6));
                    pnt.Dispose();
                    currInd++;
                    pen.Dispose();
                }
            }

            picCanvas.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            createPoly("000000");

            saveToFile();
            lblDebug.Text = "Saved and copied black poly to clipboard!";
        }

        private void saveToFile()
        {
            using (StreamWriter sw = new StreamWriter(lastFile.Replace(".png", ".txt"), false))
            {
                foreach (var item in listVertex.Items)
                {
                    sw.WriteLine(item.ToString().TrimEnd());
                }
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            listVertex.Items.Clear();
            if (picCanvas.Image != null)
            {
                reDraw();
            }
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            createPoly("FFFFFF");
            lblDebug.Text = "Copied white poly to clipboard!";

        }

        private void btnBl_Click(object sender, EventArgs e)
        {
            createPoly("000000");
            lblDebug.Text = "Copied black poly to clipboard!";

        }

        private void createPoly(string color)
        {
            if (listVertex.Items.Count == 0) return;
            string exp = "Calc.setExpression({latex: \"\\\\left\\\\{F=" + frameN.Value + ":\\\\operatorname{polygon}\\\\left(";
            for (int i = 0; i < listVertex.Items.Count; i++)
            {
                exp += "(" + listVertex.Items[i].ToString().Split(",")[0].TrimEnd() + ",-" + listVertex.Items[i].ToString().Split(",")[1].TrimEnd() + "),";
            }
            exp = exp.Remove(exp.Length - 1) + "\\\\right)\\\\right\\\\}\", color: \"#" + color + "\"})";
            Clipboard.SetText(exp.Trim());
        }

        private void lblHelpVertex_MouseHover(object sender, EventArgs e)
        {
            helpVertex.Show("You can create vertexes by clicking on the canvas\nSelect a vertex from the list to modify it\nMove it with WASD\nDelete it with \"Q\"\nYou can quick select also with the arrow keys\n\nExtra controls :\nE: Create quick black polygon\nR: Create quick white polygon\nF: Quick save\n\"X\" 2 times: Quick delete all", lblHelpVertex);
        }

        private void lblHelpBtn_MouseHover(object sender, EventArgs e)
        {
            helpBtn.Show("Saving does create a txt file that will load once you load an image again\n this will save your current vertex list\nSaving or creating a poly will paste a command into your clipboard\n You can paste this one into Desmos via f12 (devtools) in the console\n  in order to get your ecuation", lblHelpBtn);
        }
    }
}
