using System;
using System.Diagnostics;
using System.Web;
using Senparc.Weixin.MP.Context;
using Senparc.Weixin.MP.Entities;
using Senparc.Weixin.MP.MessageHandlers;
using Senparc.Weixin.MP.Sample.CommonService;

namespace Senparc.Weixin.MP.MessageHandlers
{
    /// <summary>
    /// 自定义MessageHandler
    /// </summary>
    public partial class CustomMessageHandler : MessageHandler<MessageContext>
    {
        public override IResponseMessageBase OnEvent_EnterRequest(RequestMessageEvent_Enter requestMessage)
        {
            var responseMessage = ResponseMessageBase.CreateFromRequestMessage<ResponseMessageText>(requestMessage);
            responseMessage.Content = "您刚才发送了ENTER事件请求。";
            return responseMessage;
        }

        public override IResponseMessageBase OnEvent_LocationRequest(RequestMessageEvent_Location requestMessage)
        {
            throw new Exception("暂不可用");
        }

        /// <summary>
        /// 订阅（关注）事件
        /// </summary>
        /// <returns></returns>
        public override IResponseMessageBase OnEvent_SubscribeRequest(RequestMessageEvent_Subscribe requestMessage)
        {
            var responseMessage = ResponseMessageBase.CreateFromRequestMessage<ResponseMessageText>(requestMessage);

            //获取Senparc.Weixin.MP.dll版本信息
//            var fileVersionInfo = FileVersionInfo.GetVersionInfo(HttpContext.Current.Server.MapPath("~/bin/Senparc.Weixin.MP.dll"));
//            var version = string.Format("{0}.{1}", fileVersionInfo.FileMajorPart, fileVersionInfo.FileMinorPart);
//            responseMessage.Content = string.Format(
//@"欢迎关注【Senparc.Weixin.MP 微信公众平台SDK】，当前运行版本：v{0}。
//您可以发送【文字】【位置】【图片】【语音】等不同类型的信息，查看不同格式的回复。
//
//SDK官方地址：http://weixin.senparc.com
//源代码及Demo下载地址：https://github.com/JeffreySu/WeiXinMPSDK",
//                version);
            WeixinClient WC = new WeixinClient();
            responseMessage.Content = WC.TxtWelcome();
            return responseMessage;
        }

        /// <summary>
        /// 退订
        /// 实际上用户无法收到非订阅账号的消息，所以这里可以随便写。
        /// unsubscribe事件的意义在于及时删除网站应用中已经记录的OpenID绑定，消除冗余数据。并且关注用户流失的情况。
        /// </summary>
        /// <returns></returns>
        public override IResponseMessageBase OnEvent_UnsubscribeRequest(RequestMessageEvent_Unsubscribe requestMessage)
        {
            var responseMessage = base.CreateResponseMessage<ResponseMessageText>();
            responseMessage.Content = "有空再来";
            return responseMessage;
        }

        public override IResponseMessageBase OnEvent_ClickRequest(RequestMessageEvent_Click requestMessage)
        {
            var responseMessage = base.CreateResponseMessage<ResponseMessageText>();
            var responseMessageNews = base.CreateResponseMessage<ResponseMessageNews>();
            var responseMessageLocation = base.CreateResponseMessage<ResponseMessageNews>();
            LocationService locationService = new LocationService();
            

            if (requestMessage.Event == Event.CLICK)
            {
                WeixinMenu WM = new WeixinMenu();
                string RequestState = requestMessage.EventKey;
                switch (RequestState)
                {
                    case "ui":
                        responseMessageNews.Articles.Add(WM.MenuListening("ui")[0]);
                        responseMessageNews.Articles.Add(WM.MenuListening("ui")[1]);
                        return responseMessageNews;
                    //break;
                    case "site":
                        responseMessage.Content = "更多内容敬请期待！";
                        return responseMessage;
                    //break;
                    case "things":
                        responseMessage.Content = "家事国事天下事，事事关心！";
                        return responseMessage;
                    case "week":
                        responseMessage.Content = "每个月总有那么30几天不想上班！";
                        return responseMessage;
                    case "find":
                        responseMessageLocation.Articles.Add(locationService.GetResponseLocation()[0]);
                        return responseMessageLocation;
                    case "about":
                        responseMessage.Content = "更多内容敬请期待！";
                        return responseMessage;
                    default:
                        responseMessage.Content = "未知指令！";
                        return responseMessage;
                    //break;
                }
            }
            else
            {
                responseMessage.Content = "未知事件！";
                return responseMessage;
            }
            
            //throw new Exception("Demo中还没有加入CLICK的测试！");
        }
    }
}