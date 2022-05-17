using Dalamud.Game.Command;
using Dalamud.IoC;
using Dalamud.Plugin;
using System.IO;
using System.Reflection;
using Dalamud.Game.Gui.ContextMenus;

namespace CopyItemName
{
    public sealed class Plugin : IDalamudPlugin
    {
        [PluginService]
        private ContextMenu ContextMenu { get; init; }
        public string Name => "CopyItemName";
        public Plugin()
        {
            System.IO.File.AppendAllText(@"C:\Users\MainPC\source\repos\DalamudCopyItemname\Log\log.txt", "Started!");
            ContextMenu.ContextMenuOpened += ContextMenu_ContextMenuOpened;
            System.IO.File.AppendAllText(@"C:\Users\MainPC\source\repos\DalamudCopyItemname\Log\log.txt", "Appended!");
        }

        private void ContextMenu_ContextMenuOpened(ContextMenuOpenedArgs args)
        {
            System.IO.File.AppendAllText(@"C:\Users\MainPC\source\repos\DalamudCopyItemname\Log\log.txt", "Registered...");
            args.AddCustomItem("Testing123", (_) =>
            {
                System.IO.File.AppendAllText(@"C:\Users\MainPC\source\repos\DalamudCopyItemname\Log\log.txt", "Clicked...");
            });
        }

        public void Dispose()
        {

        }
    }
}
