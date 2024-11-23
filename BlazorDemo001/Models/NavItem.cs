namespace BlazorDemo001.Models
{
    public class NavItem
    {
        //标题名
        public string Name { get; set; }

        //路由地址
        public string? Url { get; set; }

        //图标
        public string? Icon { get; set; }

        //子列表
        public List<NavItem>? Children { get; set; }

        //子列表的路由地址
        public List<string>? Group => Children?.Select(x => x.Url)?.ToList();

        //是否开启精确匹配
        public bool Exact { get; set; }

        //自定义正则表达式
        public string? MatchPattern { get; set; }

        #region 多种使用方式

        public NavItem()
        {

        }

        //标题名 + 路由路径
        public NavItem(string name, string url)
        {
            Name = name;
            Url = url;
        }

        //标题名 + 路由路径 + 精确匹配
        public NavItem(string name, string url, bool exact) : this(name, url)
        {
            Exact = exact;
        }

        //标题名 + 路由路径 + 精确匹配
        public NavItem(string name, string url, string matchPattern) : this(name, url)
        {
            MatchPattern = matchPattern;
        }

        //标题名 + 路由路径 + 子列表
        public NavItem(string name, string icon, List<NavItem> children)
        {
            Name = name;
            Icon = icon;
            Children = children;
        }

        //标题名 + 子列表
        public NavItem(string name, List<NavItem> children)
        {
            Name = name;
            Children = children;
        }
        #endregion
    }
}
