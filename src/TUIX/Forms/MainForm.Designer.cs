﻿
namespace TweakUIX
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.btnOptions = new System.Windows.Forms.Button();
            this.tweaksTree = new System.Windows.Forms.TreeView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnTemplateLoad = new System.Windows.Forms.Button();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.richStatus = new System.Windows.Forms.RichTextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.cbTemplate = new System.Windows.Forms.ComboBox();
            this.btnTemplateSave = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSaveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSendLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProjectURI = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAppConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.contextMenuApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc
            // 
            this.sc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sc.Location = new System.Drawing.Point(4, 8);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.btnOptions);
            this.sc.Panel1.Controls.Add(this.tweaksTree);
            this.sc.Panel1.Controls.Add(this.textSearch);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.AutoScroll = true;
            this.sc.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.sc.Panel2.Controls.Add(this.groupBox);
            this.sc.Size = new System.Drawing.Size(806, 505);
            this.sc.SplitterDistance = 277;
            this.sc.TabIndex = 0;
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOptions.Location = new System.Drawing.Point(12, 461);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options...";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // tweaksTree
            // 
            this.tweaksTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tweaksTree.BackColor = System.Drawing.Color.White;
            this.tweaksTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tweaksTree.CausesValidation = false;
            this.tweaksTree.CheckBoxes = true;
            this.tweaksTree.HideSelection = false;
            this.tweaksTree.Indent = 19;
            this.tweaksTree.ItemHeight = 25;
            this.tweaksTree.Location = new System.Drawing.Point(12, 0);
            this.tweaksTree.Name = "tweaksTree";
            this.tweaksTree.ShowNodeToolTips = true;
            this.tweaksTree.Size = new System.Drawing.Size(262, 455);
            this.tweaksTree.TabIndex = 0;
            this.tweaksTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tweaksTree_AfterCheck);
            this.tweaksTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tweaksTree_AfterSelect);
            this.tweaksTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tweaksTree_MouseUp);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.Color.White;
            this.groupBox.Controls.Add(this.pnlBottom);
            this.groupBox.Controls.Add(this.btnTemplateLoad);
            this.groupBox.Controls.Add(this.lblTemplate);
            this.groupBox.Controls.Add(this.richStatus);
            this.groupBox.Controls.Add(this.progress);
            this.groupBox.Controls.Add(this.cbTemplate);
            this.groupBox.Controls.Add(this.btnTemplateSave);
            this.groupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox.Location = new System.Drawing.Point(6, 5);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(516, 497);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Tweak UI for Windows 10/11";
            this.tt.SetToolTip(this.groupBox, "Description box");
            // 
            // pnlBottom
            // 
            this.pnlBottom.AutoScroll = true;
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.lblInfo);
            this.pnlBottom.Controls.Add(this.btnCheck);
            this.pnlBottom.Controls.Add(this.btnUndo);
            this.pnlBottom.Controls.Add(this.btnApply);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.ForeColor = System.Drawing.Color.Black;
            this.pnlBottom.Location = new System.Drawing.Point(3, 391);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(510, 103);
            this.pnlBottom.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(9, 14);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(47, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "App Info";
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheck.Location = new System.Drawing.Point(6, 74);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Location = new System.Drawing.Point(432, 74);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(351, 74);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnTemplateLoad
            // 
            this.btnTemplateLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateLoad.BackColor = System.Drawing.Color.White;
            this.btnTemplateLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTemplateLoad.Location = new System.Drawing.Point(414, 33);
            this.btnTemplateLoad.Name = "btnTemplateLoad";
            this.btnTemplateLoad.Size = new System.Drawing.Size(96, 23);
            this.btnTemplateLoad.TabIndex = 3;
            this.btnTemplateLoad.Text = "Load template...";
            this.btnTemplateLoad.UseVisualStyleBackColor = false;
            this.btnTemplateLoad.Click += new System.EventHandler(this.btnTemplateLoad_Click);
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.ForeColor = System.Drawing.Color.Black;
            this.lblTemplate.Location = new System.Drawing.Point(9, 36);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(74, 13);
            this.lblTemplate.TabIndex = 4;
            this.lblTemplate.Text = "Tweakomatic:";
            // 
            // richStatus
            // 
            this.richStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richStatus.AutoWordSelection = true;
            this.richStatus.BackColor = System.Drawing.Color.White;
            this.richStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richStatus.HideSelection = false;
            this.richStatus.Location = new System.Drawing.Point(12, 72);
            this.richStatus.Name = "richStatus";
            this.richStatus.ReadOnly = true;
            this.richStatus.Size = new System.Drawing.Size(498, 313);
            this.richStatus.TabIndex = 1;
            this.richStatus.Text = "";
            this.richStatus.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richStatus_LinkClicked);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(9, 22);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(499, 5);
            this.progress.TabIndex = 167;
            this.progress.Visible = false;
            // 
            // cbTemplate
            // 
            this.cbTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTemplate.FormattingEnabled = true;
            this.cbTemplate.Location = new System.Drawing.Point(103, 35);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(258, 21);
            this.cbTemplate.TabIndex = 2;
            // 
            // btnTemplateSave
            // 
            this.btnTemplateSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateSave.BackColor = System.Drawing.Color.White;
            this.btnTemplateSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTemplateSave.Location = new System.Drawing.Point(366, 33);
            this.btnTemplateSave.Name = "btnTemplateSave";
            this.btnTemplateSave.Size = new System.Drawing.Size(42, 23);
            this.btnTemplateSave.TabIndex = 168;
            this.btnTemplateSave.Text = "Save";
            this.btnTemplateSave.UseVisualStyleBackColor = false;
            this.btnTemplateSave.Click += new System.EventHandler(this.btnTemplateSave_Click);
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFeatures,
            this.toolStripSeparator1,
            this.menuExpand,
            this.menuCheck,
            this.toolStripSeparator2,
            this.menuSaveLog,
            this.menuSendLog,
            this.menuProjectURI});
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuMain.Size = new System.Drawing.Size(228, 148);
            // 
            // menuFeatures
            // 
            this.menuFeatures.Name = "menuFeatures";
            this.menuFeatures.Size = new System.Drawing.Size(227, 22);
            this.menuFeatures.Text = "Add features";
            this.menuFeatures.Click += new System.EventHandler(this.menuFeatures_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // menuExpand
            // 
            this.menuExpand.Name = "menuExpand";
            this.menuExpand.Size = new System.Drawing.Size(227, 22);
            this.menuExpand.Text = "Expand all";
            this.menuExpand.Click += new System.EventHandler(this.menuExpand_Click);
            // 
            // menuCheck
            // 
            this.menuCheck.Name = "menuCheck";
            this.menuCheck.Size = new System.Drawing.Size(227, 22);
            this.menuCheck.Text = "Check all";
            this.menuCheck.Click += new System.EventHandler(this.menuCheck_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // menuSaveLog
            // 
            this.menuSaveLog.Name = "menuSaveLog";
            this.menuSaveLog.Size = new System.Drawing.Size(227, 22);
            this.menuSaveLog.Text = "Save log";
            this.menuSaveLog.Click += new System.EventHandler(this.menuSaveLog_Click);
            // 
            // menuSendLog
            // 
            this.menuSendLog.Name = "menuSendLog";
            this.menuSendLog.Size = new System.Drawing.Size(227, 22);
            this.menuSendLog.Text = "Upload log to Github";
            this.menuSendLog.Click += new System.EventHandler(this.menuSendLog_Click);
            // 
            // menuProjectURI
            // 
            this.menuProjectURI.BackColor = System.Drawing.Color.Gainsboro;
            this.menuProjectURI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProjectURI.Name = "menuProjectURI";
            this.menuProjectURI.Size = new System.Drawing.Size(227, 22);
            this.menuProjectURI.Text = "Follow project on Github...";
            this.menuProjectURI.Click += new System.EventHandler(this.menuProjectURI_Click);
            // 
            // contextMenuApp
            // 
            this.contextMenuApp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppConfigure});
            this.contextMenuApp.Name = "menuMain";
            this.contextMenuApp.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuApp.Size = new System.Drawing.Size(184, 26);
            // 
            // menuAppConfigure
            // 
            this.menuAppConfigure.Name = "menuAppConfigure";
            this.menuAppConfigure.Size = new System.Drawing.Size(183, 22);
            this.menuAppConfigure.Text = "Configure this app";
            this.menuAppConfigure.Click += new System.EventHandler(this.menuAppConfigure_Click);
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textSearch.Location = new System.Drawing.Point(102, 461);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(107, 20);
            this.textSearch.TabIndex = 4;
            this.textSearch.Text = "Search...";
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(822, 525);
            this.Controls.Add(this.sc);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tweak UIX";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.contextMenuApp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView tweaksTree;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RichTextBox richStatus;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cbTemplate;
        private System.Windows.Forms.Button btnTemplateLoad;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.Button btnTemplateSave;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuExpand;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuSaveLog;
        private System.Windows.Forms.ToolStripMenuItem menuCheck;
        private System.Windows.Forms.ToolStripMenuItem menuSendLog;
        private System.Windows.Forms.ToolStripMenuItem menuProjectURI;
        private System.Windows.Forms.ToolStripMenuItem menuFeatures;
        private System.Windows.Forms.ContextMenuStrip contextMenuApp;
        private System.Windows.Forms.ToolStripMenuItem menuAppConfigure;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.SplitContainer sc;
    }
}

