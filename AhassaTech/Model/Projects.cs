
using System;
namespace AhassaTech.Model
{
    public class Projects
    {
	public int ID{ set; get; }
        public int userId { set; get; }
        public int teamId { set; get; }
        public string title { set; get; }
        public string description { set; get; }
        public string topic_img { set; get; }
	public string content { set; get; }
        public Date date_submit { set; get; }
        public int view_count { set; get; }
        public int like_count { set; get; }
        public int comm_count { set; get; }
        public bool visible_to_any { set; get; }
        }
}