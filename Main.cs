using System;
using SiteServer.Plugin;
using SiteServer.Plugin.Features;
using SiteServer.Plugin.Models;

namespace SiteServer.Crowler
{ 
    public class Main : PluginBase, IMenu
    {
        public override Func<int, PluginMenu> SiteMenu => GetMenu;

        private static PluginMenu GetMenu(int publishmentSystemId)
        {
            return new PluginMenu
            {
                Text = "Web爬虫",
                Href = "@/plugins/pageGatherRule.aspx"
            };
        }
    }
}