﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tail.Extensibility
{
	public interface ITailConfiguration : IScreen
	{
		bool Validate();
	}
}
