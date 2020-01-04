namespace EditorHTML
{
    partial class fmEditorHTML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmEditorHTML));
            this.wbEditorHTML = new System.Windows.Forms.WebBrowser();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.negritoStripButton = new System.Windows.Forms.ToolStripButton();
            this.italicoStripButton = new System.Windows.Forms.ToolStripButton();
            this.sublinhadoStripButton = new System.Windows.Forms.ToolStripButton();
            this.corFonteStripButton = new System.Windows.Forms.ToolStripButton();
            this.FonteStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.tamanhoFonteStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alinhaEsquerdaStripButton = new System.Windows.Forms.ToolStripButton();
            this.CentralizadoStripButton = new System.Windows.Forms.ToolStripButton();
            this.alinhaDireitaStripButton = new System.Windows.Forms.ToolStripButton();
            this.JustificadoStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuEditor = new System.Windows.Forms.ToolStrip();
            this.insertImageStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbEditorHTML
            // 
            this.wbEditorHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbEditorHTML.Location = new System.Drawing.Point(0, 31);
            this.wbEditorHTML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wbEditorHTML.MinimumSize = new System.Drawing.Size(27, 25);
            this.wbEditorHTML.Name = "wbEditorHTML";
            this.wbEditorHTML.Size = new System.Drawing.Size(1045, 690);
            this.wbEditorHTML.TabIndex = 0;
            this.wbEditorHTML.NewWindow += new System.ComponentModel.CancelEventHandler(this.wbEditorHTML_NewWindow);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "Novo";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "Abrir";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.saveToolStripButton.Text = "Salvar como";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printToolStripButton.Text = "Imprimir";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // negritoStripButton
            // 
            this.negritoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.negritoStripButton.Font = new System.Drawing.Font("Cambria", 9.25F, System.Drawing.FontStyle.Bold);
            this.negritoStripButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.negritoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.negritoStripButton.Name = "negritoStripButton";
            this.negritoStripButton.Size = new System.Drawing.Size(29, 24);
            this.negritoStripButton.Text = "N";
            this.negritoStripButton.Click += new System.EventHandler(this.negritoStripButton_Click);
            // 
            // italicoStripButton
            // 
            this.italicoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicoStripButton.Font = new System.Drawing.Font("Cambria", 9.25F, System.Drawing.FontStyle.Italic);
            this.italicoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicoStripButton.Name = "italicoStripButton";
            this.italicoStripButton.Size = new System.Drawing.Size(29, 24);
            this.italicoStripButton.Text = "I";
            this.italicoStripButton.Click += new System.EventHandler(this.italicoStripButton_Click);
            // 
            // sublinhadoStripButton
            // 
            this.sublinhadoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sublinhadoStripButton.Font = new System.Drawing.Font("Cambria", 9.25F, System.Drawing.FontStyle.Underline);
            this.sublinhadoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sublinhadoStripButton.Name = "sublinhadoStripButton";
            this.sublinhadoStripButton.Size = new System.Drawing.Size(29, 24);
            this.sublinhadoStripButton.Text = "S";
            this.sublinhadoStripButton.Click += new System.EventHandler(this.sublinhadoStripButton_Click);
            // 
            // corFonteStripButton
            // 
            this.corFonteStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.corFonteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("corFonteStripButton.Image")));
            this.corFonteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.corFonteStripButton.Name = "corFonteStripButton";
            this.corFonteStripButton.Size = new System.Drawing.Size(29, 24);
            this.corFonteStripButton.Text = "Selecionar Cor da Fonte";
            this.corFonteStripButton.Click += new System.EventHandler(this.corFonteStripButton_Click);
            // 
            // FonteStripComboBox
            // 
            this.FonteStripComboBox.Font = new System.Drawing.Font("Arial", 9F);
            this.FonteStripComboBox.Items.AddRange(new object[] {
            "Arial"});
            this.FonteStripComboBox.Name = "FonteStripComboBox";
            this.FonteStripComboBox.Size = new System.Drawing.Size(160, 27);
            this.FonteStripComboBox.Text = "Arial";
            this.FonteStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FonteStripComboBox_SelectedIndexChanged);
            // 
            // tamanhoFonteStripComboBox
            // 
            this.tamanhoFonteStripComboBox.Font = new System.Drawing.Font("Arial", 9F);
            this.tamanhoFonteStripComboBox.Items.AddRange(new object[] {
            "Pequena",
            "Média",
            "Normal",
            "Maior",
            "Grande",
            "Extra Grande"});
            this.tamanhoFonteStripComboBox.Name = "tamanhoFonteStripComboBox";
            this.tamanhoFonteStripComboBox.Size = new System.Drawing.Size(132, 27);
            this.tamanhoFonteStripComboBox.Text = "Pequena";
            this.tamanhoFonteStripComboBox.SelectedIndexChanged += new System.EventHandler(this.tamanhoFonteStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // alinhaEsquerdaStripButton
            // 
            this.alinhaEsquerdaStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alinhaEsquerdaStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alinhaEsquerdaStripButton.Image")));
            this.alinhaEsquerdaStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alinhaEsquerdaStripButton.Name = "alinhaEsquerdaStripButton";
            this.alinhaEsquerdaStripButton.Size = new System.Drawing.Size(29, 24);
            this.alinhaEsquerdaStripButton.Text = "Alinhas Esquerda";
            this.alinhaEsquerdaStripButton.Click += new System.EventHandler(this.alinhaEsquerdaStripButton_Click);
            // 
            // CentralizadoStripButton
            // 
            this.CentralizadoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CentralizadoStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CentralizadoStripButton.Image")));
            this.CentralizadoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CentralizadoStripButton.Name = "CentralizadoStripButton";
            this.CentralizadoStripButton.Size = new System.Drawing.Size(29, 24);
            this.CentralizadoStripButton.Text = "Centralizar";
            this.CentralizadoStripButton.Click += new System.EventHandler(this.CentralizadoStripButton_Click);
            // 
            // alinhaDireitaStripButton
            // 
            this.alinhaDireitaStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alinhaDireitaStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alinhaDireitaStripButton.Image")));
            this.alinhaDireitaStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alinhaDireitaStripButton.Name = "alinhaDireitaStripButton";
            this.alinhaDireitaStripButton.Size = new System.Drawing.Size(29, 24);
            this.alinhaDireitaStripButton.Text = "Alinha Direita";
            this.alinhaDireitaStripButton.Click += new System.EventHandler(this.alinhaDireitaStripButton_Click);
            // 
            // JustificadoStripButton
            // 
            this.JustificadoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.JustificadoStripButton.Image = ((System.Drawing.Image)(resources.GetObject("JustificadoStripButton.Image")));
            this.JustificadoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JustificadoStripButton.Name = "JustificadoStripButton";
            this.JustificadoStripButton.Size = new System.Drawing.Size(29, 24);
            this.JustificadoStripButton.Text = "Justificar";
            this.JustificadoStripButton.Click += new System.EventHandler(this.JustificadoStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.cutToolStripButton.Text = "Recortar";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.copyToolStripButton.Text = "Copiar";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.pasteToolStripButton.Text = "Copiar";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // menuEditor
            // 
            this.menuEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator3,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator,
            this.negritoStripButton,
            this.italicoStripButton,
            this.sublinhadoStripButton,
            this.alinhaEsquerdaStripButton,
            this.CentralizadoStripButton,
            this.alinhaDireitaStripButton,
            this.JustificadoStripButton,
            this.toolStripSeparator2,
            this.corFonteStripButton,
            this.insertImageStripButton,
            this.FonteStripComboBox,
            this.tamanhoFonteStripComboBox});
            this.menuEditor.Location = new System.Drawing.Point(0, 0);
            this.menuEditor.Name = "menuEditor";
            this.menuEditor.Size = new System.Drawing.Size(1045, 27);
            this.menuEditor.TabIndex = 1;
            // 
            // insertImageStripButton
            // 
            this.insertImageStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertImageStripButton.Image = ((System.Drawing.Image)(resources.GetObject("insertImageStripButton.Image")));
            this.insertImageStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertImageStripButton.Name = "insertImageStripButton";
            this.insertImageStripButton.Size = new System.Drawing.Size(29, 24);
            this.insertImageStripButton.Text = "Inserir Imagem";
            this.insertImageStripButton.Click += new System.EventHandler(this.insertImageStripButton_Click);
            // 
            // fmEditorHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.menuEditor);
            this.Controls.Add(this.wbEditorHTML);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmEditorHTML";
            this.Text = "Editor HTML";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.menuEditor.ResumeLayout(false);
            this.menuEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbEditorHTML;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton negritoStripButton;
        private System.Windows.Forms.ToolStripButton italicoStripButton;
        private System.Windows.Forms.ToolStripButton sublinhadoStripButton;
        private System.Windows.Forms.ToolStripButton corFonteStripButton;
        private System.Windows.Forms.ToolStripComboBox FonteStripComboBox;
        private System.Windows.Forms.ToolStripComboBox tamanhoFonteStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton alinhaEsquerdaStripButton;
        private System.Windows.Forms.ToolStripButton CentralizadoStripButton;
        private System.Windows.Forms.ToolStripButton alinhaDireitaStripButton;
        private System.Windows.Forms.ToolStripButton JustificadoStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStrip menuEditor;
        private System.Windows.Forms.ToolStripButton insertImageStripButton;
    }
}