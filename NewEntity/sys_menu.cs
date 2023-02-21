using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///菜单表
    ///</summary>
    [SugarTable("sys_menu")]
	[Tenant("newDb")]
    public partial class sys_menu
    {
           public sys_menu(){


           }
           /// <summary>
           /// Desc:Id主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:父Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Pid {get;set;}

           /// <summary>
           /// Desc:父Ids
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Pids {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Code {get;set;}

           /// <summary>
           /// Desc:菜单类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Type {get;set;}

           /// <summary>
           /// Desc:图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Icon {get;set;}

           /// <summary>
           /// Desc:路由地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Router {get;set;}

           /// <summary>
           /// Desc:组件地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Component {get;set;}

           /// <summary>
           /// Desc:权限标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Permission {get;set;}

           /// <summary>
           /// Desc:应用分类
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Application {get;set;}

           /// <summary>
           /// Desc:打开方式
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int OpenType {get;set;}

           /// <summary>
           /// Desc:是否可见
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Visible {get;set;}

           /// <summary>
           /// Desc:内链地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Link {get;set;}

           /// <summary>
           /// Desc:重定向地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Redirect {get;set;}

           /// <summary>
           /// Desc:权重
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Weight {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Sort {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsIframe {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OutLink {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsHide {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsAffix {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsKeepAlive {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:创建者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

           /// <summary>
           /// Desc:创建者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:修改者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:修改者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:软删除标记
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsDeleted {get;set;}

    }
}
