using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///操作日志表
    ///</summary>
    [SugarTable("sys_log_op")]
	[Tenant("newDb")]
    public partial class sys_log_op
    {
           public sys_log_op(){


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
           /// Desc:请求地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Url {get;set;}

           /// <summary>
           /// Desc:类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ClassName {get;set;}

           /// <summary>
           /// Desc:方法名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MethodName {get;set;}

           /// <summary>
           /// Desc:请求方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReqMethod {get;set;}

           /// <summary>
           /// Desc:请求参数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Param {get;set;}

           /// <summary>
           /// Desc:返回结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Result {get;set;}

           /// <summary>
           /// Desc:耗时
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ElapsedTime {get;set;}

           /// <summary>
           /// Desc:操作时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OpTime {get;set;}

           /// <summary>
           /// Desc:操作人
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
