#region Copyright
// Library for use www.cinemate.cc API
// Copyright (C) 2016 Nick Rimmer. Contacts: <xan@dipteam.com>
// 
// This file is part of CinemateApi.
// 
// CinemateApi is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// License: http://opensource.org/licenses/GPL-2.0
#endregion
namespace CinemateApi.Models
{
	public class CinimateProperties
	{
		/// <summary>
		/// Base url for requests
		/// </summary>
		public string BaseUrl { get; set; }

		/// <summary>
		/// For access methods whe reqiured Api key (account methods)
		/// </summary>
		public string ApiKey { get; set; }

		/// <summary>
		/// For access methods whe reqiured Pass key (movie, person methods)
		/// </summary>
		public string PassKey { get; set; }
	}
}