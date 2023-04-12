using ReaLTaiizor.Controls;

namespace WinformRESTest
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControlMain = new MaterialTabControl();
            tabPageTestApi = new System.Windows.Forms.TabPage();
            materialMultiLineTextBoxEditContent = new MaterialMultiLineTextBoxEdit();
            materialMultiLineTextBoxEditResponse = new MaterialMultiLineTextBoxEdit();
            materialSwitchJson = new MaterialSwitch();
            materialComboBoxMethod = new MaterialComboBox();
            materialMultiLineTextBoxEditData = new MaterialMultiLineTextBoxEdit();
            pictureBoxWait = new System.Windows.Forms.PictureBox();
            materialTextBoxApiUrl = new MaterialTextBoxEdit();
            materialButtonTest = new MaterialButton();
            tabPageAbout = new System.Windows.Forms.TabPage();
            webViewGitHubProfile = new Microsoft.Web.WebView2.WinForms.WebView2();
            imageListTabCtrl = new System.Windows.Forms.ImageList(components);
            tabControlMain.SuspendLayout();
            tabPageTestApi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWait).BeginInit();
            tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewGitHubProfile).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            resources.ApplyResources(tabControlMain, "tabControlMain");
            tabControlMain.Controls.Add(tabPageTestApi);
            tabControlMain.Controls.Add(tabPageAbout);
            tabControlMain.Depth = 0;
            tabControlMain.ImageList = imageListTabCtrl;
            tabControlMain.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlMain.Multiline = true;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            // 
            // tabPageTestApi
            // 
            resources.ApplyResources(tabPageTestApi, "tabPageTestApi");
            tabPageTestApi.BackColor = System.Drawing.SystemColors.Control;
            tabPageTestApi.Controls.Add(materialMultiLineTextBoxEditContent);
            tabPageTestApi.Controls.Add(materialMultiLineTextBoxEditResponse);
            tabPageTestApi.Controls.Add(materialSwitchJson);
            tabPageTestApi.Controls.Add(materialComboBoxMethod);
            tabPageTestApi.Controls.Add(materialMultiLineTextBoxEditData);
            tabPageTestApi.Controls.Add(pictureBoxWait);
            tabPageTestApi.Controls.Add(materialTextBoxApiUrl);
            tabPageTestApi.Controls.Add(materialButtonTest);
            tabPageTestApi.Name = "tabPageTestApi";
            // 
            // materialMultiLineTextBoxEditContent
            // 
            resources.ApplyResources(materialMultiLineTextBoxEditContent, "materialMultiLineTextBoxEditContent");
            materialMultiLineTextBoxEditContent.AnimateReadOnly = true;
            materialMultiLineTextBoxEditContent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialMultiLineTextBoxEditContent.Depth = 0;
            materialMultiLineTextBoxEditContent.HideSelection = true;
            materialMultiLineTextBoxEditContent.MaxLength = 32767;
            materialMultiLineTextBoxEditContent.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMultiLineTextBoxEditContent.Name = "materialMultiLineTextBoxEditContent";
            materialMultiLineTextBoxEditContent.PasswordChar = '\0';
            materialMultiLineTextBoxEditContent.ReadOnly = true;
            materialMultiLineTextBoxEditContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            materialMultiLineTextBoxEditContent.SelectedText = "";
            materialMultiLineTextBoxEditContent.SelectionLength = 0;
            materialMultiLineTextBoxEditContent.SelectionStart = 0;
            materialMultiLineTextBoxEditContent.ShortcutsEnabled = true;
            materialMultiLineTextBoxEditContent.TabStop = false;
            materialMultiLineTextBoxEditContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialMultiLineTextBoxEditContent.UseSystemPasswordChar = false;
            // 
            // materialMultiLineTextBoxEditResponse
            // 
            resources.ApplyResources(materialMultiLineTextBoxEditResponse, "materialMultiLineTextBoxEditResponse");
            materialMultiLineTextBoxEditResponse.AnimateReadOnly = true;
            materialMultiLineTextBoxEditResponse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialMultiLineTextBoxEditResponse.Depth = 0;
            materialMultiLineTextBoxEditResponse.HideSelection = true;
            materialMultiLineTextBoxEditResponse.MaxLength = 32767;
            materialMultiLineTextBoxEditResponse.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMultiLineTextBoxEditResponse.Name = "materialMultiLineTextBoxEditResponse";
            materialMultiLineTextBoxEditResponse.PasswordChar = '\0';
            materialMultiLineTextBoxEditResponse.ReadOnly = true;
            materialMultiLineTextBoxEditResponse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            materialMultiLineTextBoxEditResponse.SelectedText = "";
            materialMultiLineTextBoxEditResponse.SelectionLength = 0;
            materialMultiLineTextBoxEditResponse.SelectionStart = 0;
            materialMultiLineTextBoxEditResponse.ShortcutsEnabled = true;
            materialMultiLineTextBoxEditResponse.TabStop = false;
            materialMultiLineTextBoxEditResponse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialMultiLineTextBoxEditResponse.UseSystemPasswordChar = false;
            // 
            // materialSwitchJson
            // 
            resources.ApplyResources(materialSwitchJson, "materialSwitchJson");
            materialSwitchJson.Checked = true;
            materialSwitchJson.CheckState = System.Windows.Forms.CheckState.Checked;
            materialSwitchJson.Depth = 0;
            materialSwitchJson.MouseLocation = new System.Drawing.Point(-1, -1);
            materialSwitchJson.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialSwitchJson.Name = "materialSwitchJson";
            materialSwitchJson.Ripple = true;
            materialSwitchJson.UseAccentColor = false;
            materialSwitchJson.UseVisualStyleBackColor = true;
            // 
            // materialComboBoxMethod
            // 
            resources.ApplyResources(materialComboBoxMethod, "materialComboBoxMethod");
            materialComboBoxMethod.AutoResize = false;
            materialComboBoxMethod.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialComboBoxMethod.Depth = 0;
            materialComboBoxMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            materialComboBoxMethod.DropDownHeight = 174;
            materialComboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            materialComboBoxMethod.DropDownWidth = 121;
            materialComboBoxMethod.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            materialComboBoxMethod.FormattingEnabled = true;
            materialComboBoxMethod.Items.AddRange(new object[] { resources.GetString("materialComboBoxMethod.Items"), resources.GetString("materialComboBoxMethod.Items1"), resources.GetString("materialComboBoxMethod.Items2"), resources.GetString("materialComboBoxMethod.Items3") });
            materialComboBoxMethod.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBoxMethod.Name = "materialComboBoxMethod";
            materialComboBoxMethod.StartIndex = 0;
            materialComboBoxMethod.SelectedIndexChanged += materialComboBoxMethod_SelectedIndexChanged;
            // 
            // materialMultiLineTextBoxEditData
            // 
            resources.ApplyResources(materialMultiLineTextBoxEditData, "materialMultiLineTextBoxEditData");
            materialMultiLineTextBoxEditData.AnimateReadOnly = false;
            materialMultiLineTextBoxEditData.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialMultiLineTextBoxEditData.Depth = 0;
            materialMultiLineTextBoxEditData.HideSelection = true;
            materialMultiLineTextBoxEditData.MaxLength = 32767;
            materialMultiLineTextBoxEditData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMultiLineTextBoxEditData.Name = "materialMultiLineTextBoxEditData";
            materialMultiLineTextBoxEditData.PasswordChar = '\0';
            materialMultiLineTextBoxEditData.ReadOnly = false;
            materialMultiLineTextBoxEditData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            materialMultiLineTextBoxEditData.SelectedText = "";
            materialMultiLineTextBoxEditData.SelectionLength = 0;
            materialMultiLineTextBoxEditData.SelectionStart = 0;
            materialMultiLineTextBoxEditData.ShortcutsEnabled = true;
            materialMultiLineTextBoxEditData.TabStop = false;
            materialMultiLineTextBoxEditData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialMultiLineTextBoxEditData.UseSystemPasswordChar = false;
            // 
            // pictureBoxWait
            // 
            resources.ApplyResources(pictureBoxWait, "pictureBoxWait");
            pictureBoxWait.Name = "pictureBoxWait";
            pictureBoxWait.TabStop = false;
            // 
            // materialTextBoxApiUrl
            // 
            resources.ApplyResources(materialTextBoxApiUrl, "materialTextBoxApiUrl");
            materialTextBoxApiUrl.AnimateReadOnly = false;
            materialTextBoxApiUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            materialTextBoxApiUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            materialTextBoxApiUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialTextBoxApiUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            materialTextBoxApiUrl.Depth = 0;
            materialTextBoxApiUrl.HideSelection = true;
            materialTextBoxApiUrl.LeadingIcon = null;
            materialTextBoxApiUrl.MaxLength = 0;
            materialTextBoxApiUrl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxApiUrl.Name = "materialTextBoxApiUrl";
            materialTextBoxApiUrl.PasswordChar = '\0';
            materialTextBoxApiUrl.ReadOnly = false;
            materialTextBoxApiUrl.SelectedText = "";
            materialTextBoxApiUrl.SelectionLength = 0;
            materialTextBoxApiUrl.SelectionStart = 0;
            materialTextBoxApiUrl.ShortcutsEnabled = true;
            materialTextBoxApiUrl.TabStop = false;
            materialTextBoxApiUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBoxApiUrl.TrailingIcon = (System.Drawing.Image)resources.GetObject("materialTextBoxApiUrl.TrailingIcon");
            materialTextBoxApiUrl.UseSystemPasswordChar = false;
            // 
            // materialButtonTest
            // 
            resources.ApplyResources(materialButtonTest, "materialButtonTest");
            materialButtonTest.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButtonTest.Depth = 0;
            materialButtonTest.HighEmphasis = true;
            materialButtonTest.Icon = (System.Drawing.Image)resources.GetObject("materialButtonTest.Icon");
            materialButtonTest.IconType = MaterialButton.MaterialIconType.Rebase;
            materialButtonTest.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButtonTest.Name = "materialButtonTest";
            materialButtonTest.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonTest.Type = MaterialButton.MaterialButtonType.Contained;
            materialButtonTest.UseAccentColor = false;
            materialButtonTest.UseVisualStyleBackColor = true;
            materialButtonTest.Click += materialButtonTestApi_Click;
            // 
            // tabPageAbout
            // 
            resources.ApplyResources(tabPageAbout, "tabPageAbout");
            tabPageAbout.Controls.Add(webViewGitHubProfile);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // webViewGitHubProfile
            // 
            resources.ApplyResources(webViewGitHubProfile, "webViewGitHubProfile");
            webViewGitHubProfile.AllowExternalDrop = false;
            webViewGitHubProfile.CreationProperties = null;
            webViewGitHubProfile.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            webViewGitHubProfile.Name = "webViewGitHubProfile";
            webViewGitHubProfile.Source = new System.Uri("https://github.com/DevElkami", System.UriKind.Absolute);
            webViewGitHubProfile.ZoomFactor = 1D;
            // 
            // imageListTabCtrl
            // 
            imageListTabCtrl.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageListTabCtrl.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageListTabCtrl.ImageStream");
            imageListTabCtrl.TransparentColor = System.Drawing.Color.Transparent;
            imageListTabCtrl.Images.SetKeyName(0, "show-mini.png");
            imageListTabCtrl.Images.SetKeyName(1, "GitHub-Mark.png");
            // 
            // MainForm
            // 
            AcceptButton = materialButtonTest;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            Controls.Add(tabControlMain);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControlMain;
            DrawerUseColors = true;
            Name = "MainForm";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += MainForm_Load;
            tabControlMain.ResumeLayout(false);
            tabPageTestApi.ResumeLayout(false);
            tabPageTestApi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWait).EndInit();
            tabPageAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webViewGitHubProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialTabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTestApi;
        private System.Windows.Forms.ImageList imageListTabCtrl;
        private System.Windows.Forms.TabPage tabPageAbout;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewGitHubProfile;
        private MaterialTextBoxEdit materialTextBoxApiUrl;
        private MaterialButton materialButtonTest;
        private System.Windows.Forms.PictureBox pictureBoxWait;
        private MaterialMultiLineTextBoxEdit materialMultiLineTextBoxEditData;
        private MaterialComboBox materialComboBoxMethod;
        private MaterialSwitch materialSwitchJson;
        private MaterialMultiLineTextBoxEdit materialMultiLineTextBoxEditContent;
        private MaterialMultiLineTextBoxEdit materialMultiLineTextBoxEditResponse;
    }
}

