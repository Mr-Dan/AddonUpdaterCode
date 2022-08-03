using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Models
{
    class PanelAddon
    {
        private DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();

        private PanelAddonSetings panelAddonSetings = new PanelAddonSetings();
        public GitHub GitHub { get; set; }
        public Panel AddonPanel { get; set; }
        public Label AddonName { get; set; }
        public Button AddonVersion { get; set; }
        public Button AddonDelete { get; set; }
        public Label AddonAuthor { get; set; }
        public Label AddonCategory { get; set; }
        public ProgressBar ProgressBar { get; set; }

        public PictureBox PictureBox { get; set; }

        private int xNext = 0;

        public int Row = -1;

        public PanelAddon(GitHub gitHub, int row, Panel panelParent, PanelAddonSetings panelAddonSetings_)
        {
            GitHub = gitHub;
            Row = row;
            panelAddonSetings = panelAddonSetings_;
            SetAddonPanel(panelParent);
            SetAddonName();
            SetAddonVersion();
            SetAddonCategory();
            SetAddonAuthor();
            SetProgreddBar();
            SetPictureBox();
            if (panelAddonSetings_.AddonDelete != null) SetAddonDelete();
            ControlsAdd(AddonName);
            ControlsAdd(AddonVersion);
            ControlsAdd(AddonAuthor);
            ControlsAdd(AddonCategory);
            ControlsAdd(PictureBox);
            if (panelAddonSetings_.AddonDelete != null) ControlsAdd(AddonDelete);
            ControlsAdd(ProgressBar);

        }
        void ControlsAdd(Control control)
        {
            AddonPanel.Controls.Add(control);
            control.BringToFront();
        }
        void SetAddonPanel(Panel panelParent)
        {
            AddonPanel = new Panel
            {
                Name = "Panel" + GitHub.Name + "row" + Row,
                Width = 885,
                Height = 40,
                Parent = panelParent.Parent,
                Location = new Point(0, Row * 40)
            };
            if (Row % 2 == 0)
                AddonPanel.BackColor = Color.FromArgb(223, 225, 229);
            else
                AddonPanel.BackColor = Color.FromArgb(239, 240, 242);

        }
        void SetAddonName()
        {
            AddonName = new Label
            {
                Name = "LabelName_" + GitHub.Name + "_row_" + Row,
                Text = GitHub.Name,
                Width = panelAddonSetings.AddonName.Width,
                Height = panelAddonSetings.AddonName.Height,
                Parent = AddonPanel.Parent,
                Location = new Point(0, 0),
                Font = panelAddonSetings.AddonName.Font,
                TextAlign = panelAddonSetings.AddonName.TextAlign,
                Cursor = panelAddonSetings.AddonName.Cursor
            };
            if (GitHub.NeedUpdate == true) AddonName.ForeColor = Color.FromArgb(166, 0, 0);
            else AddonName.ForeColor = Color.FromArgb(44, 42, 63);
            xNext += AddonName.Width;
        }
        void SetAddonVersion()
        {
            AddonVersion = new Button
            {
                Name = "Button_" + GitHub.Name + "_row_" + Row,
                Width = panelAddonSetings.AddonVersion.Width,
                Height = panelAddonSetings.AddonVersion.Height,
                Parent = AddonPanel.Parent,
                Location = new Point(xNext, 0),
                Font = panelAddonSetings.AddonVersion.Font,
                FlatStyle = panelAddonSetings.AddonVersion.FlatStyle,
                TabStop = panelAddonSetings.AddonVersion.TabStop
            };
            AddonVersion.FlatAppearance.BorderSize = panelAddonSetings.AddonVersion.FlatAppearance.BorderSize;

            if (GitHub.MyVersion != null)
                if (GitHub.Blacklist) AddonVersion.Text = "В игноре";
                else
                    if (GitHub.NeedUpdate) AddonVersion.Text = "Актуальная: " + GitHub.Version + "\n" + "У Вас: " + GitHub.MyVersion;
                else
                        if (DownloadAddonGitHub.lastUpdateAddon.FindIndex(f => f.AddonName == GitHub.Name) > -1) AddonVersion.Text = "Актуальная: " + GitHub.Version + "\n" + DownloadAddonGitHub.lastUpdateAddon[DownloadAddonGitHub.lastUpdateAddon.FindIndex(f => f.AddonName == GitHub.Name)].LastUpdate;
                else AddonVersion.Text = "Актуальная: " + GitHub.Version;
            else if (GitHub.MyVersion == null) AddonVersion.Text = "Актуальная: " + GitHub.Version + "\n";

            if (GitHub.NeedUpdate == true) AddonVersion.ForeColor = Color.FromArgb(166, 0, 0);
            else AddonVersion.ForeColor = Color.FromArgb(44, 42, 63);
            if (GitHub.Blacklist) AddonVersion.Enabled = false;
            xNext += AddonVersion.Width;
        }

        void SetAddonCategory()
        {
            AddonCategory = new Label
            {
                Name = "LabelAuthor" + GitHub.Name + "row" + Row,
                Text = GitHub.Category,
                Width = panelAddonSetings.AddonCategory.Width,
                Height = panelAddonSetings.AddonCategory.Height,
                Parent = AddonPanel.Parent,
                Location = new Point(xNext, 0),
                Font = panelAddonSetings.AddonCategory.Font,
                ForeColor = panelAddonSetings.AddonCategory.ForeColor,
                TextAlign = panelAddonSetings.AddonCategory.TextAlign
            };
            xNext += AddonCategory.Width;
        }
        void SetAddonAuthor()
        {
            AddonAuthor = new Label
            {
                Name = "LabelAuthor" + GitHub.Name + "row" + Row,
                Text = GitHub.Author,
                Width = panelAddonSetings.AddonAuthor.Width,
                Height = panelAddonSetings.AddonAuthor.Height,
                Parent = AddonPanel.Parent,
                Location = new Point(xNext, 0),
                Font = panelAddonSetings.AddonAuthor.Font,
                ForeColor = panelAddonSetings.AddonAuthor.ForeColor,
                TextAlign = panelAddonSetings.AddonAuthor.TextAlign
            };
            xNext += AddonAuthor.Width;
        }

        void SetProgreddBar()
        {
            ProgressBar = new ProgressBar
            {
                Name = $"progressBar{GitHub.Name}" + "row" + Row,
                Width = panelAddonSetings.ProgressBar.Width,
                Height = panelAddonSetings.ProgressBar.Height,
                Parent = AddonPanel.Parent,
                Location = new Point(0, 30),
                Visible = panelAddonSetings.ProgressBar.Visible
            };
        }
        void SetAddonDelete()
        {
            AddonDelete = new Button
            {
                Name = "AddonDelete_" + GitHub.Name + "_row_" + Row,
                Width = panelAddonSetings.AddonDelete.Width,
                Height = panelAddonSetings.AddonDelete.Height,
                Parent = AddonPanel.Parent,
                Location = new Point(xNext, 0),
                Font = panelAddonSetings.AddonDelete.Font,
                FlatStyle = panelAddonSetings.AddonDelete.FlatStyle,
                TabStop = panelAddonSetings.AddonDelete.TabStop,
                Image = panelAddonSetings.AddonDelete.Image,
                BackgroundImageLayout = panelAddonSetings.AddonDelete.BackgroundImageLayout,
                ImageAlign = panelAddonSetings.AddonDelete.ImageAlign
            };
            AddonDelete.FlatAppearance.BorderSize = panelAddonSetings.AddonDelete.FlatAppearance.BorderSize;
            xNext += AddonDelete.Width;
        }
        void SetPictureBox()
        {
            PictureBox = new PictureBox
            {
                Name = "PictureBox_" + GitHub.Name + "_row_" + Row,
                Width = 40,
                Height = 40,
                Parent = AddonPanel.Parent,
                Location = new Point(AddonName.Width - 40, 0),
                Visible = panelAddonSetings.PictureBox.Visible,
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = downloadAddonGitHub.GetAddonUpdate(GitHub.Name) ? Properties.Resources.eyes_open : Properties.Resources.eyes_closed,
                Cursor = panelAddonSetings.PictureBox.Cursor
            };
           
        }
    }
}
