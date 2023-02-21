using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///异常日志表
    ///</summary>
    [SugarTable("sys_log_ex")]
	[Tenant("newDb")]
    public partial class sys_log_ex
    {
           public sys_log_ex(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:操作人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Account {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:类名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ClassName {get;set;}

           /// <summary>
           /// Desc:方法名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MethodName {get;set;}

           /// <summary>
           /// Desc:异常名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExceptionName {get;set;}

           /// <summary>
           /// Desc:异常信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExceptionMsg {get;set;}

           /// <summary>
           /// Desc:异常源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExceptionSource {get;set;}

           /// <summary>
           /// Desc:堆栈信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StackTrace {get;set;}

           /// <summary>
           /// Desc:参数对象
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ParamsObj {get;set;}

           /// <summary>
           /// Desc:异常时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ExceptionTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public Guid? TenantId {get;set;}

    }
}
