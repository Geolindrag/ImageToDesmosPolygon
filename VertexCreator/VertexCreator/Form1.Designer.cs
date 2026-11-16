namespace VertexCreator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picCanvas = new PictureBox();
            btnLoad = new Button();
            lblDebug = new Label();
            listVertex = new ListBox();
            btnSave = new Button();
            frameN = new NumericUpDown();
            btnClr = new Button();
            btnWhite = new Button();
            btnBl = new Button();
            lblFrameText = new Label();
            helpVertex = new ToolTip(components);
            lblHelpVertex = new Label();
            lblHelpBtn = new Label();
            helpBtn = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frameN).BeginInit();
            SuspendLayout();
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(145, 12);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(480, 360);
            picCanvas.SizeMode = PictureBoxSizeMode.AutoSize;
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            picCanvas.MouseClick += picCanvas_MouseClick;
            picCanvas.MouseMove += picCanvas_MouseMove;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 277);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(48, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblDebug
            // 
            lblDebug.AutoSize = true;
            lblDebug.Location = new Point(12, 419);
            lblDebug.Name = "lblDebug";
            lblDebug.Size = new Size(22, 15);
            lblDebug.TabIndex = 2;
            lblDebug.Text = "0,0";
            lblDebug.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listVertex
            // 
            listVertex.FormattingEnabled = true;
            listVertex.ItemHeight = 15;
            listVertex.Location = new Point(12, 27);
            listVertex.Name = "listVertex";
            listVertex.Size = new Size(120, 244);
            listVertex.TabIndex = 5;
            listVertex.KeyPress += listVertex_KeyPress;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 8F);
            btnSave.Location = new Point(66, 277);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(54, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "(F) Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frameN
            // 
            frameN.Location = new Point(73, 364);
            frameN.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            frameN.Name = "frameN";
            frameN.Size = new Size(57, 23);
            frameN.TabIndex = 7;
            // 
            // btnClr
            // 
            btnClr.Location = new Point(12, 393);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(120, 23);
            btnClr.TabIndex = 8;
            btnClr.Text = "(X)Clear all vertexes";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // btnWhite
            // 
            btnWhite.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnWhite.Location = new Point(12, 306);
            btnWhite.Name = "btnWhite";
            btnWhite.Size = new Size(120, 23);
            btnWhite.TabIndex = 9;
            btnWhite.Text = "(R)Create white poly";
            btnWhite.UseVisualStyleBackColor = true;
            btnWhite.Click += btnWhite_Click;
            // 
            // btnBl
            // 
            btnBl.Font = new Font("Segoe UI", 8F);
            btnBl.Location = new Point(12, 335);
            btnBl.Name = "btnBl";
            btnBl.Size = new Size(120, 23);
            btnBl.TabIndex = 10;
            btnBl.Text = "(E) Create black poly";
            btnBl.UseVisualStyleBackColor = true;
            btnBl.Click += btnBl_Click;
            // 
            // lblFrameText
            // 
            lblFrameText.AutoSize = true;
            lblFrameText.Location = new Point(12, 366);
            lblFrameText.Name = "lblFrameText";
            lblFrameText.Size = new Size(58, 15);
            lblFrameText.TabIndex = 11;
            lblFrameText.Text = "Frame N :";
            // 
            // helpVertex
            // 
            helpVertex.AutoPopDelay = 15000;
            helpVertex.InitialDelay = 500;
            helpVertex.ReshowDelay = 100;
            // 
            // lblHelpVertex
            // 
            lblHelpVertex.AutoSize = true;
            lblHelpVertex.Cursor = Cursors.Help;
            lblHelpVertex.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblHelpVertex.ForeColor = SystemColors.Highlight;
            lblHelpVertex.Location = new Point(12, 9);
            lblHelpVertex.Name = "lblHelpVertex";
            lblHelpVertex.Size = new Size(125, 15);
            lblHelpVertex.TabIndex = 13;
            lblHelpVertex.Text = "How to use this thing?";
            lblHelpVertex.MouseHover += lblHelpVertex_MouseHover;
            // 
            // lblHelpBtn
            // 
            lblHelpBtn.AutoSize = true;
            lblHelpBtn.Cursor = Cursors.Help;
            lblHelpBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblHelpBtn.ForeColor = SystemColors.Highlight;
            lblHelpBtn.Location = new Point(120, 281);
            lblHelpBtn.Name = "lblHelpBtn";
            lblHelpBtn.Size = new Size(12, 15);
            lblHelpBtn.TabIndex = 14;
            lblHelpBtn.Text = "?";
            lblHelpBtn.MouseHover += lblHelpBtn_MouseHover;
            // 
            // helpBtn
            // 
            helpBtn.AutoPopDelay = 15000;
            helpBtn.InitialDelay = 500;
            helpBtn.ReshowDelay = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(637, 440);
            Controls.Add(lblHelpBtn);
            Controls.Add(lblHelpVertex);
            Controls.Add(lblFrameText);
            Controls.Add(btnBl);
            Controls.Add(btnWhite);
            Controls.Add(btnClr);
            Controls.Add(frameN);
            Controls.Add(btnSave);
            Controls.Add(listVertex);
            Controls.Add(lblDebug);
            Controls.Add(btnLoad);
            Controls.Add(picCanvas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ManzanoMaloOsi";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)frameN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCanvas;
        private Button btnLoad;
        private Label lblDebug;
        private ListBox listVertex;
        private Button btnSave;
        private NumericUpDown frameN;
        private Button btnClr;
        private Button btnWhite;
        private Button btnBl;
        private Label lblFrameText;
        private ToolTip helpVertex;
        private Label lblHelpVertex;
        private Label lblHelpBtn;
        private ToolTip helpBtn;
    }
}
