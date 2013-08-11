using Senparc.Weixin.MP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP
{
    public class WeixinClient
    {
        public WeixinClient()
        {
 
        }

        public string TxtMenu(string menu)
        {
            string txt = "欢迎咨询，以下是菜单：请直接回复数字。\r\n[1]曼塔鳐鱼过山车\r\n[2]同一片海洋\r\n[3]蓝色地平线\r\n[4]与夏慕一起进餐\r\n[5]视频中心\r\n[6]全部图片";
            return txt;
        }

        public string TxtWelcome()
        {
            string txt = "欢迎关注，以下是菜单：请直接回复数字。\r\n[1]曼塔鳐鱼过山车\r\n[2]同一片海洋\r\n[3]蓝色地平线\r\n[4]与夏慕一起进餐\r\n[5]视频中心\r\n[6]全部图片";
            return txt;
        }

        public Article TxtMsg(string request)
        {
            if (request.Trim() == "1")
            {
                return DataCenter(1);
            }
            if (request.Trim() == "2")
            {
                return DataCenter(2);
            }
            if (request.Trim() == "3")
            {
                return DataCenter(3);
            }
            if (request.Trim() == "4")
            {
                return DataCenter(4);
            }
            if (request.Trim() == "logo")
            {
                return DataCenter(5);
            }

            return DataCenter(5);
        }

        private Article DataCenter(int num)
        {
            List<Article> ResponseMsgList = new List<Article>();

            Article ResponseMsg = new Article();
            ResponseMsg.Title = "曼塔鳐鱼过山车";
            ResponseMsg.Description = "这是一幅美图，请您欣赏！";
            ResponseMsg.PicUrl = "http://weixin.pescis.cn/seaworld/imgs/1.jpg";
            ResponseMsg.Url = "http://www.seaworldparks.cn/orando/jingxian.html";

            Article ResponseMsg2 = new Article();
            ResponseMsg2.Title = "同一片海洋";
            ResponseMsg2.Description = "这是一幅美图，请您欣赏！";
            ResponseMsg2.PicUrl = "http://weixin.pescis.cn/seaworld/imgs/2.jpg";
            ResponseMsg2.Url = "http://www.seaworldparks.cn/orando/biaoyan.html";

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

            switch(num)
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
