﻿using System;
using System.Collections.Generic;
using System.Linq;
using Totem.Runtime.Map;

namespace Totem.Runtime
{
	/// <summary>
	/// Describes a persistent set of settings for areas of a runtime
	/// </summary>
	public interface ISettingsDb
	{
		void Write<T>(Func<Id, T> create) where T : SettingsView;

		void Delete<T>() where T : SettingsView;

		T Read<T>(bool strict = true) where T : SettingsView;
	}
}