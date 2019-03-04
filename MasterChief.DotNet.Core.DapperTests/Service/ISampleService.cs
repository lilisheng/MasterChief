﻿using MasterChief.DotNet.Core.DapperTests.Model;
using System;

namespace MasterChief.DotNet.Core.DapperTests.Service
{
    /// <summary>
    /// 测试数据接口
    /// </summary>
    public interface ISampleService
    {
        /// <summary>
        /// Creates the specified samle.
        /// </summary>
        /// <param name="samle">The samle.</param>
        /// <returns></returns>
        bool Create(EFSample samle);

        EFSample Get(Guid id);
    }
}
