using HohoemaLive.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HohoemaLive.UseCase.Playlist.Commands
{
    public sealed class LocalPlaylistRemoveItemCommand : VideoContentSelectionCommandBase
    {
        private readonly LocalPlaylist _playlist;

        public LocalPlaylistRemoveItemCommand(LocalPlaylist playlist)
        {
            _playlist = playlist;
        }

        protected override void Execute(IVideoContent content)
        {
            _playlist.RemovePlaylistItem(content);
        }

        protected override void Execute(IEnumerable<IVideoContent> items)
        {
            _playlist.RemovePlaylistItems(items);
        }
    }
}
