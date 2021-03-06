﻿#region Copyright
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
    /// Movie states
    /// </summary>
    public enum MovieStateEnum : byte
    {
        /// <summary>
        /// (0) "soon" value
        /// </summary>
        Soon = 0,

        /// <summary>
        /// (1, default) "cinema" value
        /// </summary>
        Cinema = 1
    }
}