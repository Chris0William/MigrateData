using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///访问日志表
    ///</summary>
    [SugarTable("sys_log_vis")]
	[Tenant("newDb")]
    public partial class sys_log_vis
    {
           public sys_log_vis(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:是否执行成功
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Success {get;set;}

           /// <summary>
           /// Desc:具体消息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Message {get;set;}

           /// <summary>
           /// Desc:IP
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Ip {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Location {get;set;}

           /// <summary>
           /// Desc:浏览器
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Browser {get;set;}

           /// <summary>
           /// Desc:操作系统
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Os {get;set;}

           /// <summary>
           /// Desc:访问类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int VisType {get;set;}

           /// <summary>
           /// Desc:访问时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? VisTime {get;set;}

           /// <summary>
           /// Desc:访问人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Account {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public Guid? TenantId {get;set;}

    }
}
