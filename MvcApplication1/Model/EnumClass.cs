using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Conris.DBA.Model
{
    public class EnumClass
    {

    }

    /// <summary>
    /// 文章级别
    /// </summary>
    public enum Lever
    {
        [Description("一般正常")]
        All = 0,
        [Description("推荐")]
        Tuijian = 1,
        [Description("置顶")]
        Zhiding = 2
    }
    /// <summary>
    /// 文章下拉框
    /// </summary>
    public enum TypeSelect
    {
        [Description("学习园地")]
        External = 0,
        [Description("通知公告")]
        Internal = 1
    }
    /// <summary>
    /// 用户类型选择
    /// </summary>
    public enum UserTypeSelect
    {
        [Description("全部")]
        All = 0,
        [Description("管理员")]
        Admin = 1,
        [Description("普通用户")]
        User = 2
    }

    /// <summary>
    /// 用户类型
    /// </summary>
    public enum UserType
    {
        [Description("超级管理员")]
        Super = 0,
        [Description("管理员")]
        Admin = 1,
        [Description("咨询员")]
        ZXUser = 2,
        [Description("项目负责人")]
        FZUser = 3,
        [Description("经营人")]
        JYUser = 4,
        [Description("技术负责人")]
        JSUser = 5,
        [Description("部门负责人")]
        BMUser = 6,
        [Description("登录")]
        DLUser = 8,
        [Description("游客")]
        Youke = 7
    }


    public enum DeleteState
    {
        [Description("删除")]
        Delete = 1,
        [Description("未删除")]
        Undelete = 2
    }
}
