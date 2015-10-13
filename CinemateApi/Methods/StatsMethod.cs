#region Copyright
// Library for use www.cinemate.cc API
// Copyright (C) 2015 Nick Rimmer. Contacts: <xan@dipteam.com>
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

using System.Collections.Generic;
using CinemateApi.Models.Response;
using CinemateApi.Tools;

namespace CinemateApi.Methods
{
    /// <summary>
    /// Collection of "stats" methods
    /// </summary>
    public class StatsMethod
    {
        private Cinemate _cinemate;

        /// <summary>
        /// Collection of "stats" methods
        /// </summary>
        /// <param name="cinemate">instance of <see cref="Cinemate"/>, with prepared preferences</param>
        public StatsMethod(Cinemate cinemate)
        {
            _cinemate = cinemate;
        }

        public StatsNewResponseModel GetNew()
        {
            var args = new Dictionary<string, object>();

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<StatsNewResponseModel>(_cinemate.BaseUrl, "stats.new", args);
        }
    }
}