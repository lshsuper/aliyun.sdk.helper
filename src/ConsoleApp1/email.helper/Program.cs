using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Dm.Model.V20151123;
using email.helper.tools;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           bool result=AliyunSdkHelper.SendEmail(new AliyunEmailOption()
            {
                AppKey = "你的应用key",
                AppSecret = "你的应用密码",
                FromAddr = "你的发信地址",
                TargetAddr = "接收人地址",
                FromNickName = "发信人昵称",
                Subject = "标题",
                HtmlBody = "内容"
           });
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
