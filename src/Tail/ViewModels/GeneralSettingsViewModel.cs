﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tail.Extensibility;

namespace Tail.ViewModels
{
	public sealed class GeneralSettingsViewModel : Screen, ITailSettings
	{
		public bool IsDirty
		{
			get { return false; }
		}

		public bool Validate(out string error)
		{
			error = string.Empty;
			return true;
		}

		public void Load(ITailSettingService service)
		{
		}

		public void Save(ITailSettingService service)
		{
		}
	}
}
