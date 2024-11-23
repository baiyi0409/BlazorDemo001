namespace BlazorDemo001.Models
{
    public class ListCardModel
    {
        /// <summary>
        /// 标签背景颜色
        /// </summary>
        public string TagBackColor { get; set; }

        /// <summary>
        /// 标签颜色
        /// </summary>
        public string TagColor { get; set; }

        /// <summary>
        /// 标签内容
        /// </summary>
        public string TagContent { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public List<string> Avatar { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string Count { get; set; }
    }
}
