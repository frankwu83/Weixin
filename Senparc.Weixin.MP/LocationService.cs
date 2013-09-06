using System.Collections.Generic;
using Senparc.Weixin.MP.Entities;
using Senparc.Weixin.MP.Entities.GoogleMap;
using Senparc.Weixin.MP.Helpers;

namespace Senparc.Weixin.MP.Sample.CommonService
{
    public class LocationService
    {
        public ResponseMessageNews GetResponseMessage(RequestMessageLocation requestMessage)
        {
            var responseMessage = ResponseMessageBase.CreateFromRequestMessage<ResponseMessageNews>(requestMessage);

            var markersList = new List<Markers>();
            markersList.Add(new Markers()
            {
                X = requestMessage.Location_X,
                Y = requestMessage.Location_Y,
                Color = "red",
                Label = "S",
                Size = MarkerSize.Default,
            });
            var mapSize = "480x600";
            var mapUrl = GoogleMapHelper.GetGoogleStaticMap(19 /*requestMessage.Scale*//*微信和GoogleMap的Scale不一致，这里建议使用固定值*/,
                                                            markersList, mapSize);
            responseMessage.Articles.Add(new Article()
            {
                Description = string.Format("您刚才发送了地理位置信息。Location_X：{0}，Location_Y：{1}，Scale：{2}，标签：{3}",
                              requestMessage.Location_X, requestMessage.Location_Y,
                              requestMessage.Scale, requestMessage.Label),
                PicUrl = mapUrl,
                Title = "定位地点周边地图",
                Url = mapUrl
            });
            responseMessage.Articles.Add(new Article()
            {
                Title = "微信公众平台SDK 官网链接",
                Description = "Senparc.Weixin.MK SDK地址",
                PicUrl = "http://weixin.senparc.com/images/logo.jpg",
                Url = "http://weixin.senparc.com"
            });

            return responseMessage;
        }

        public List<Article> GetResponseLocation()
        {
            List<Article> ResponseMsgList = new List<Article>();

            var markersList = new List<Markers>();
            markersList.Add(new Markers()
            {
                X = 31.232101,
                Y = 121.476136,
                Color = "red",
                Label = "S",
                Size = MarkerSize.Default,
            });
            var mapSize = "480x600";
            var mapUrl = GoogleMapHelper.GetGoogleStaticMap(19 /*requestMessage.Scale*//*微信和GoogleMap的Scale不一致，这里建议使用固定值*/,
                                                            markersList, mapSize);
            ResponseMsgList.Add(new Article()
            {
                Description = "公司地址XXXXX，电话：XXXXX。欢迎光临。",
                PicUrl = mapUrl,
                Title = "工作室周边地图",
                Url = "http://ditu.google.cn/maps?q=%E4%B8%8A%E6%B5%B7%E5%B8%82%E9%BB%84%E6%B5%A6%E5%8C%BA+%E8%A5%BF%E8%97%8F%E4%B8%AD%E8%B7%AF268%E5%8F%B7&hl=zh-CN&ie=UTF8&ll=31.231933,121.476702&spn=0.00203,0.004128&sll=31.232052,121.476127&sspn=0.008119,0.016512&brcurrent=3,0x35b2705884ada08f:0x4d67b64076816a37,0,0x35b270634e678b93:0x9bab911934f9a6c2%3B5,0,0&hnear=%E4%B8%8A%E6%B5%B7%E5%B8%82%E9%BB%84%E6%B5%A6%E5%8C%BA%E8%A5%BF%E8%97%8F%E4%B8%AD%E8%B7%AF268%E5%8F%B7&t=m&z=19"
            });
            ResponseMsgList.Add(new Article()
            {
                Title = "恭候阁下君临",
                Description = "工作室地址",
                PicUrl = "http://weixin.pescis.cn/rsd/imgs/logo1.jpg",
                Url = "http://weixin.pescis.cn/rsd/imgs/logo1.jpg"
            });

            return ResponseMsgList;
        }
    }
}