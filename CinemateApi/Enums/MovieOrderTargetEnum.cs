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
namespace CinemateApi.Enums
{
    /// <summary>
    /// Order by criterion
    /// </summary>
    public enum MovieOrderTargetEnum : byte
    {
        /// <summary>
        /// (0) added date to site
        /// </summary>
        CreateDate = 0,

        /// <summary>
        /// (1) release date in world
        /// </summary>
        ReleaseDateWorld = 1,

        /// <summary>
        /// (2, default) release date in Russia
        /// </summary>
        ReleaseDateRus = 2
    }
}