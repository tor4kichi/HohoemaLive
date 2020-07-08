﻿using System;
using System.ComponentModel;

namespace HohoemaLive.Dialogs
{
    public interface ISelectableContainer : INotifyPropertyChanged, IDisposable
	{
		string Label { get; }
		SelectDialogPayload GetResult();
		bool IsValidatedSelection { get; }
		event Action<ISelectableContainer> SelectionItemChanged;
	}
}
