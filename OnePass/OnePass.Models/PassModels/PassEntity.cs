using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Models.PassModels
{
    /// <summary>
    /// 账号密码基类
    /// </summary>
    public class PassEntity
    {
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}
