﻿using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;

namespace HohoemaLive.Services.Commands.Ranking
{
    class UnFavoriteRankingGenreItemCommand : DelegateCommandBase
    {
        protected override bool CanExecute(object parameter)
        {
            return parameter is ViewModels.RankingItem;
        }

        protected override void Execute(object parameter)
        {
            if (parameter is ViewModels.FavoriteRankingGenreGroupItem favGroup)
            {

            }
            if (parameter is ViewModels.RankingItem rankingItem)
            {
                var ea = App.Current.Container.Resolve<IEventAggregator>();

                if (rankingItem.Genre == null)
                {
                    throw new NotSupportedException();
                }

                ea.GetEvent<Events.RankingGenreUnFavoriteRequestedEvent>()
                    .Publish(new Events.RankingGenreCustomizeEventArgs()
                    {
                        RankingGenre = rankingItem.Genre.Value,
                        Tag = rankingItem.Tag
                    });

                System.Diagnostics.Debug.WriteLine("UnFavoriteRankingGenreItemCommand with RankingItem");
            }
        }
    }
}
