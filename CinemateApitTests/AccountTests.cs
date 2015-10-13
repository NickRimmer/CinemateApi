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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinemateApitTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Account_GetAuth_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.BaseUrl);

            var result = cinemate.Account.GetAuth(Constants.UserName, Constants.Password);

            Assert.IsNotNull(result.PassKey, "passkey is empty");
            Console.WriteLine("passkey: {0}", result.PassKey);
        }
    }
}