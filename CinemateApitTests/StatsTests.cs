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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinemateApitTests
{
    [TestClass]
    public class StatsTests
    {
        [TestMethod]
        public void Stats_GetNew_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);

            var result = cinemate.Stats.GetNew();
            Assert.IsNotNull(result, "result stats.new is empty");
        }
    }
}