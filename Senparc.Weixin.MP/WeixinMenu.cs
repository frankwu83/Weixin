using Senparc.Weixin.MP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP
{
    public class WeixinMenu
    {
        public WeixinMenu()
        {
 
        }

        public List<Article> MenuListening(string value)
        {
            List<Article> ResponseMsgList = new List<Article>();
            Article Msg;
            switch (value)
            {
                case "ui":
                    ResponseMsgList.Add(DataCenter(2));
                    ResponseMsgList.Add(DataCenter(1));
                    break;
                case "site":
                    ResponseMsgList.Add(DataCenter(3));
                    break;
                case "sell":
                    ResponseMsgList.Add(DataCenter(4));
                    break;
                default:
                    ResponseMsgList.Add(DataCenter(2));
                    break;
            }

            return ResponseMsgList;
        }

        private Article DataCenter(int num)
        {
            List<Article> ResponseMsgList = new List<Article>();

            Article ResponseMsg = new Article();
            ResponseMsg.Title = "璞缇客订单UI";
            ResponseMsg.Description = "For iPhone Design";
            ResponseMsg.PicUrl = "http://weixin.gongkai.asia/rsd/imgs/show/show1.jpg";
            ResponseMsg.Url = "http://weixin.gongkai.asia/rsd/imgs/show/show1.jpg";

            Article ResponseMsg2 = new Article();
            ResponseMsg2.Title = "璞缇客简介UI";
            ResponseMsg2.Description = "For iPhone Design";
            ResponseMsg2.PicUrl = "http://weixin.gongkai.asia/rsd/imgs/show/show2.jpg";
            ResponseMsg2.Url = "http://weixin.gongkai.asia/rsd/imgs/show/show2.jpg";

            Article ResponseMsg3 = new Article();
            ResponseMsg3.Title = "MobileSite";
            ResponseMsg3.Description = "手机站点测试";
            ResponseMsg3.PicUrl = "http://weixin.gongkai.asia/seaworld/imgs/3.jpg";
            ResponseMsg3.Url = "http://weixin.gongkai.asia/rsd/HTML5/mobileUI.html";

            Article ResponseMsg4 = new Article();
            ResponseMsg4.Title = "Heat Bear 浪漫薰衣草味";
            ResponseMsg4.Description = "澳洲正品进口！纯手工制作！内部填充澳洲风干小麦和精选薰衣草干花，香气可以持续2年以上！";
            ResponseMsg4.PicUrl = "http://weixin.gongkai.asia/rsd/imgs/sell/1.jpg";
            ResponseMsg4.Url = "http://item.taobao.com/item.htm?spm=a1z10.1.w5003-3490726580.1.nrS0Ov&id=20243813453&scene=taobao_shop&qq-pf-to=pcqq.c2c";

            Article ResponseMsg5 = new Article();
            ResponseMsg5.Title = "视频中心";
            ResponseMsg5.Description = "主题公园视频。";
            ResponseMsg5.PicUrl = "http://weixin.gongkai.asia/seaworld/imgs/1.jpg";
            ResponseMsg5.Url = "http://weixin.gongkai.asia/seaworld/v1.html";

            ResponseMsgList.Add(ResponseMsg);
            ResponseMsgList.Add(ResponseMsg2);
            ResponseMsgList.Add(ResponseMsg3);
            ResponseMsgList.Add(ResponseMsg4);
            ResponseMsgList.Add(ResponseMsg5);

            Article Msg;

            switch (num)
            {
                case 1:
                    Msg = ResponseMsgList[0];
                    break;
                case 2:
                    Msg = ResponseMsgList[1];
                    break;
                case 3:
                    Msg = ResponseMsgList[2];
                    break;
                case 4:
                    Msg = ResponseMsgList[3];
                    break;
                case 5:
                    Msg = ResponseMsgList[4];
                    break;
                default:
                    Msg = ResponseMsgList[4];
                    break;
            }

            return Msg;

        }
    }
}
