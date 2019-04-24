using System;
using System.Collections.Generic;
using System.Text;

namespace email.helper.tools
{

    /// <summary>
    /// 阿里云email配置
    /// </summary>
    public class AliyunEmailOption:AliyunSdkOption
    {
        /// <summary>
        /// 账号地址
        /// </summary>
        public string FromAddr { get; set; }
        /// <summary>
        /// 账号昵称
        /// </summary>
        public string FromNickName { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 目标邮箱
        /// </summary>
        public string TargetAddr { get; set; }
        /// <summary>
        /// 内容体
        /// </summary>
        public string HtmlBody { get; set; }
    }
}
