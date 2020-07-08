﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HohoemaLive.Models.Cache
{
	public enum NicoVideoCacheState
	{
        NotCacheRequested,
		Pending,
		Downloading,
		Cached,

		Failed,
		FailedWithQualityNotAvairable,
		DeletedFromUser,
		DeletedFromNiconicoServer,
	}
}
