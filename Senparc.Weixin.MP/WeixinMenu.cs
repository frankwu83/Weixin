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
                    ResponseMsgList.Add(DataCenter(2));
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
            ResponseMsg.PicUrl = "http://weixin.pescis.cn/rsd/imgs/show/show1.jpg";
            ResponseMsg.Url = "http://weixin.pescis.cn/rsd/imgs/show/show1.jpg";

            Article ResponseMsg2 = new Article();
            ResponseMsg2.Title = "璞缇客简介UI";
            ResponseMsg2.Description = "For iPhone Design";
            ResponseMsg2.PicUrl = "http://weixin.pescis.cn/rsd/imgs/show/show2.jpg";
            ResponseMsg2.Url = "http://weixin.pescis.cn/rsd/imgs/show/show2.jpg";

            Article ResponseMsg3 = new Article();
            ResponseMsg3.Title = "蓝色地平线";
            ResponseMsg3.Description = "这是一幅美图，请您欣赏！";
            ResponseMsg3.PicUrl = "http://weixin.pescis.cn/seaworld/imgs/3.jpg";
            ResponseMsg3.Url = "http://www.seaworldparks.cn/orando/biaoyan.html";

            Article ResponseMsg4 = new Article();
            ResponseMsg4.Title = "与夏慕一起进餐";
            ResponseMsg4.Description = "这是一幅美图，请您欣赏！";
            ResponseMsg4.PicUrl = "http://weixin.pescis.cn/seaworld/imgs/18.jpg";
            ResponseMsg4.Url = "http://www.seaworldparks.cn/orando/meishi.html";

            Article ResponseMsg5 = new Article();
            ResponseMsg5.Title = "视频中心";
            ResponseMsg5.Description = "主题公园视频。";
            ResponseMsg5.PicUrl = "http://weixin.pescis.cn/seaworld/imgs/1.jpg";
            ResponseMsg5.Url = "http://weixin.pescis.cn/seaworld/v1.html";

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
