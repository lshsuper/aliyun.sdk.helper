using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Dm.Model.V20151123;
using System;
using System.Collections.Generic;
using System.Text;

namespace email.helper.tools
{
    public class AliyunSdkHelper
    {

        /// <summary>
        /// 发邮件
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public static bool SendEmail(AliyunEmailOption option)
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", option.AppKey, option.AppSecret);
            IAcsClient client = new DefaultAcsClient(profile);
            SingleSendMailRequest request = new SingleSendMailRequest();
            try
            {
                //Version must set to "2017-06-22" when the regionId is not "cn-hangzhou"
                //request.Version = "2017-06-22";
                request.AccountName =option.FromAddr;
                request.FromAlias = option.FromNickName;
                request.AddressType = 1;
                request.TagName = "控制台创建的标签";
                request.ReplyToAddress = true;
                request.ToAddress =option.TargetAddr;
                request.Subject = option.Subject ;
                request.HtmlBody = option.HtmlBody;
                
                SingleSendMailResponse httpResponse = client.GetAcsResponse(request);
                if (httpResponse == null) return false;
                return httpResponse.HttpResponse.isSuccess();
            }
            catch (ServerException e)
            {
                return false;
            }
            catch (ClientException e)
            {
                return false;
            }catch (Exception e)
            {
                return false;
            }
        }
    }
}
