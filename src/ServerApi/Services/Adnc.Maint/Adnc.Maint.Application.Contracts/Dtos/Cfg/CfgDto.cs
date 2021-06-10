﻿using Adnc.Infra.Application.Dtos;
using System;

namespace Adnc.Maint.Application.Contracts.Dtos
{
    /// <summary>
    /// 系统配置
    /// </summary>
    [Serializable]
    public class CfgDto : OutputFullAuditInfoDto
    {
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 参数名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        public string Value { get; set; }
    }
}