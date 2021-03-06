﻿using HohoemaLive.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HohoemaLive.UseCase.Playlist.Commands
{
    public class WatchAfterRemoveItemCommand : VideoContentSelectionCommandBase
    {
        private readonly HohoemaPlaylist _hohoemaPlaylist;

        public WatchAfterRemoveItemCommand(HohoemaPlaylist hohoemaPlaylist)
        {
            _hohoemaPlaylist = hohoemaPlaylist;
        }

        protected override void Execute(IVideoContent content)
        {
            _hohoemaPlaylist.RemoveWatchAfter(content);
        }
    }
}
