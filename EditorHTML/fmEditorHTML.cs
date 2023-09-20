using System;
using System.ComponentModel;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace EditorHTML
{
    /*
    2D-Position	IDM_2D_POSITION (0x095A)
    AbsolutePosition	IDM_ABSOLUTE_POSITION (0x095D)
    AutoDetect	IDM_AUTODETECT (0x0919)
    BackColor	IDM_BACKCOLOR (0x0033)
    BackgroundImageCache	IDM_BACKGROUNDIMAGECACHE (0x097E)
    BlockDirLTR	IDM_BLOCKDIRLTR (0x0930)
    BlockDirRTL	IDM_BLOCKDIRRTL (0x0931)
    Bold	IDM_BOLD (0x0034)
    BrowseMode	IDM_BROWSEMODE (0x084E)
    ClearAuthenticationCache	IDM_CLEARAUTHENTICATIONCACHE (0x3A9B)
    Copy	IDM_COPY (0x000F)
    CreateBookmark	IDM_BOOKMARK (0x084B)
    CreateLink	IDM_HYPERLINK (0x084C)
    Cut	IDM_CUT (0x0010)
    Delete	IDM_DELETE (0x0011)
    DirLTR	IDM_DIRLTR (0x092E)
    DirRTL	IDM_DIRRTL (0x092F)
    EditMode	IDM_EDITMODE (0x084F)
    FontName	IDM_FONTNAME (0x0012)
    FontSize	IDM_FONTSIZE (0x0013)
    ForeColor	IDM_FORECOLOR (0x0037)
    FormatBlock	IDM_BLOCKFMT (0x08BA)
    GetBlockFormats	IDM_GETBLOCKFMTS (0x08B9)
    Indent	IDM_INDENT (0x088A)
    InlineDirLTR	IDM_INLINEDIRLTR (0x0932)
    InlineDirRTL	IDM_INLINEDIRRTL (0x0933)
    InsertButton	IDM_BUTTON (0x0877)
    InsertFieldset	IDM_INSFIELDSET (0x0847)
    InsertHorizontalRule	IDM_HORIZONTALLINE (0x0866)
    InsertIFrame	IDM_IFRAME (0x086E)
    InsertImage	IDM_IMAGE (0x0878)
    InsertInputButton	IDM_INSINPUTBUTTON (0x0843)
    InsertInputCheckbox	IDM_CHECKBOX (0x0873)
    InsertInputFileUpload	IDM_INSINPUTUPLOAD (0x0846)
    InsertInputHidden	IDM_INSINPUTHIDDEN (0x0908)
    InsertInputImage	IDM_INSINPUTIMAGE (0x0842)
    InsertInputPassword	IDM_INSINPUTPASSWORD (0x0909)
    InsertInputRadio	IDM_RADIOBUTTON (0x0874)
    InsertInputReset	IDM_INSINPUTRESET (0x0844)
    InsertInputSubmit	IDM_INSINPUTSUBMIT (0x0845)
    InsertInputText	IDM_TEXTBOX (0x0871)
    InsertMarquee	IDM_MARQUEE (0x0886)
    InsertOrderedList	IDM_ORDERLIST (0x0888)
    InsertParagraph	IDM_PARAGRAPH (0x0884)
    InsertSelectDropdown	IDM_DROPDOWNBOX (0x0875)
    InsertSelectListbox	IDM_LISTBOX (0x0876)
    InsertTextArea	IDM_TEXTAREA (0x0872)
    InsertUnorderedList	IDM_UNORDERLIST (0x0889)
    Italic	IDM_ITALIC (0x0038)
    JustifyCenter	IDM_JUSTIFYCENTER (0x0039)
    JustifyFull	IDM_JUSTIFYFULL (0x0032)
    JustifyLeft	IDM_JUSTIFYLEFT (0x003B)
    JustifyNone	IDM_JUSTIFYNONE (0x005E)
    JustifyRight	IDM_JUSTIFYRIGHT (0x003C)
    KeepSelection	IDM_KEEPSELECTION (0x096A)
    LiveResize	IDM_LIVERESIZE (0x095E)
    MultipleSelection	IDM_MULTIPLESELECTION (0x0959)
    Open	IDM_OPEN (0x07D0)
    Outdent	IDM_OUTDENT (0x088B)
    OverWrite	IDM_OVERWRITE (0x090A)
    Paste	IDM_PASTE (0x001A)
    PlayImage	IDM_DYNSRCPLAY (0x08DF)
    Print	IDM_EXECPRINT (0x005D)
    Redo	IDM_REDO (0x001D)
    Refresh	IDM_REFRESH (0x08FC)
    RemoveFormat	IDM_REMOVEFORMAT (0x08B6)
    RemoveParaFormat	IDM_REMOVEPARAFORMAT (0x08CD)
    RespectVisibilityInDesign	IDM_RESPECTVISIBILITY_INDESIGN (0x0965)
    SaveAs	IDM_SAVEAS (0x0047)
    SelectAll	IDM_SELECTALL (0x001F)
    SizeToControl	IDM_SIZETOCONTROL (0x0023)
    SizeToControlHeight	IDM_SIZETOCONTROLHEIGHT (0x0024)
    SizeToControlWidth	IDM_SIZETOCONTROLWIDTH (0x0025)
    Stop	IDM_STOP (0x085A)
    StopImage	IDM_DYNSRCSTOP (0x08E0)
    StrikeThrough	IDM_STRIKETHROUGH (0x005B)
    Subscript	IDM_SUBSCRIPT (0x08C7)
    Superscript	IDM_SUPERSCRIPT (0x08C8)
    TristateBold	IDM_TRISTATEBOLD (0x005F)
    TristateItalic	IDM_TRISTATEITALIC (0x0060)
    TristateUnderline	IDM_TRISTATEUNDERLINE (0x0061)
    UIOutdent	IDM_UI_OUTDENT (0x0967)
    UnBookmark	IDM_UNBOOKMARK (0x0850)
    Underline	IDM_UNDERLINE (0x003F)
    Undo	IDM_UNDO (0x002B)
    UnloadDocument	IDM_UNLOADDOCUMENT (0x096B)
    Unlink	IDM_UNLINK (0x084D)
    Unselect	IDM_CLEARSELECTION (0x07D7)         
    */
    enum EventosIE
    {
        WM_COMMAND = 0x0111,
        IDM_MARCADOR = 2184,
        IDM_MARCADOR_LISTA = 2185,
        IDM_OUTDENT = 2187,
        IDM_INDENT = 2186,
        IDM_ALINHARESQ = 59,
        IDM_CENTRALIZAR = 57,
        IDM_ALINHADIR = 60,
        IDM_JUSTIFYFULL = 50,
        IDM_IMAGEM = 2168,
        IDM_LINHAHORIZ = 2150,
        IDM_RECORTAR = 16,
        IDM_COPIAR = 15,
        IDM_COLAR = 26,
        IDM_HYPERLINK = 2124,
        IDM_DESFAZER = 43
    };

    public partial class fmEditorHTML : Form
    {
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        public fmEditorHTML()
        {
            InitializeComponent();
            //22/09/2019 -  Adicionar ao evento DocumentComplent setando a propiedade DesignMode=On
            wbEditorHTML.DocumentCompleted += delegate
            {
                setWebEditor(true);
            };
            wbEditorHTML.Navigate("about:blank");
        }

        public void setWebEditor(bool isActive)
        {
            if (wbEditorHTML.Document.Body != null)
            {                
                wbEditorHTML.Document.Body.SetAttribute("contentEditable", isActive ? "true" : "false");
            }
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            popularFontes();
            tamanhoFonteStripComboBox.SelectedIndex = 3;
            FonteStripComboBox.SelectedIndex = -1;
        }

        private void popularFontes()
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            FonteStripComboBox.Items.Clear();
            foreach (var item in installedFontCollection.Families)
            {
                FonteStripComboBox.Items.Add(item.Name);
            }
        }
        #region Botões menu
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            setWebEditor(false);
            wbEditorHTML.Navigate("about:blank");
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "HTML|*.html|Arquivo texto|*.txt";
            saveFileDialog.Title = "Salvar arquivo";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, wbEditorHTML.DocumentText);
            }
        }

        private void corFonteStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                executarComando("ForeColor", colorDialog.Color);
            }
        }

        

        private void negritoStripButton_Click(object sender, EventArgs e)
        {
            executarComando("Bold");
        }

        private void italicoStripButton_Click(object sender, EventArgs e)
        {
            executarComando("Italic");
        }

        private void sublinhadoStripButton_Click(object sender, EventArgs e)
        {
            executarComando("Underline");
        }
        private void FonteStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            executarComando("FontName", FonteStripComboBox.Text);
        }

        private void tamanhoFonteStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            executarComando("FontSize", tamanhoFonteStripComboBox.SelectedIndex);
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            enviarMensagem((int)EventosIE.IDM_COLAR);
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            enviarMensagem((int)EventosIE.IDM_COPIAR);
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            enviarMensagem((int)EventosIE.IDM_RECORTAR);
        }

        private void alinhaEsquerdaStripButton_Click(object sender, EventArgs e)
        {
            enviarMensagem((int)EventosIE.IDM_ALINHARESQ);
        }

        private void CentralizadoStripButton_Click(object sender, EventArgs e)
        {
            enviarMensagem((int)EventosIE.IDM_CENTRALIZAR);
        }

        private void alinhaDireitaStripButton_Click(object sender, EventArgs e)
        {
            enviarMensagem((int)EventosIE.IDM_ALINHADIR);
        }

        private void JustificadoStripButton_Click(object sender, EventArgs e)
        {
            enviarMensagem((int)EventosIE.IDM_JUSTIFYFULL);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "HTML|*.html|Arquivo texto|*.txt";
            openFileDialog.Title = "Salvar arquivo";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                setWebEditor(false);
                wbEditorHTML.Navigate(openFileDialog.FileName);
            }
        }
        

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            wbEditorHTML.ShowPrintDialog();
        }
        private void insertImageStripButton_Click(object sender, EventArgs e)
        {
            enviarMensagem((int)EventosIE.IDM_IMAGEM);
        }
        #endregion
        private void wbEditorHTML_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }
        
        public void executarComando(string comando, object obj = null)
        {
            wbEditorHTML.Document.ExecCommand(comando, false, obj);
        }

        public void enviarMensagem(int command)
        {
            IntPtr handle = GetIEHandle();
            SendMessage(handle, (int)EventosIE.WM_COMMAND, command, "0");
        }

        public IntPtr GetIEHandle()
        {
            IntPtr handle = wbEditorHTML.Handle;
            StringBuilder className = new StringBuilder(100);
            int i = 0;
            while (className.ToString() != "Internet Explorer_Server") // your mileage may vary with this classname
            {
                handle = GetWindow(handle, 5); // 5 == child
                GetClassName(handle, className, className.Capacity);
                i++;
            }
            return handle;
        }

    }//class
}//namespace
