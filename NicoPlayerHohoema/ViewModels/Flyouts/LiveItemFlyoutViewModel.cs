﻿using HohoemaLive.UseCase.NicoVideoPlayer.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HohoemaLive.ViewModels.Flyouts
{
    public sealed class LiveItemFlyoutViewModel : BindableBase
    {
        public LiveItemFlyoutViewModel(
            Services.ExternalAccessService externalAccessService,
            OpenLiveContentCommand openLiveContentCommand
            )
        {
            ExternalAccessService = externalAccessService;
            OpenLiveContentCommand = openLiveContentCommand;
        }

        public Services.ExternalAccessService ExternalAccessService { get; }
        public OpenLiveContentCommand OpenLiveContentCommand { get; }
    }
}
