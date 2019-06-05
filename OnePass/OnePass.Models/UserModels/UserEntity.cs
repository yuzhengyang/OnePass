using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePass.Models.UserModels
{
    public class UserEntity
    {
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 加密后的密码
        /// </summary>
        public string  Passcode { get; set; }
    }
}
