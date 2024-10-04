using Gtk;
using Ryujinx.Common.Utilities;
using Ryujinx.UI.Common.Helper;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;

namespace Ryujinx.UI.Windows
{
    public partial class AboutWindow : Window
    {
        public AboutWindow() : base($"Ryujinx {Program.Version} - About")
        {
            Icon = new Gdk.Pixbuf(Assembly.GetAssembly(typeof(OpenHelper)), "Ryujinx.UI.Common.Resources.Logo_Ryujinx.png");
            InitializeComponent();
        }

        //
        // Events
        //
        private void RyujinxButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://ryujinx.org");
        }

        private void AmiiboApiButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://amiiboapi.com");
        }

        private void GitHubButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://github.com/LukeWarnut/Ryujinx2");
        }

        private void DiscordButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://discordapp.com/invite/N2FmfVc");
        }

        private void TwitterButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://twitter.com/RyujinxEmu");
        }

        private void ContributorsButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://github.com/LukeWarnut/Ryujinx2/graphs/contributors?type=a");
        }

        private void ChangelogButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://github.com/LukeWarnut/Ryujinx2/wiki/Changelog#ryujinx-changelog");
        }
    }
}
