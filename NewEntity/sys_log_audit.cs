using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///审计日志表
    ///</summary>
    [SugarTable("sys_log_audit")]
	[Tenant("newDb")]
    public partial class sys_log_audit
    {
           public sys_log_audit(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:表名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TableName {get;set;}

           /// <summary>
           /// Desc:列名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ColumnName {get;set;}

           /// <summary>
           /// Desc:新值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NewValue {get;set;}

           /// <summary>
           /// Desc:旧值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OldValue {get;set;}

           /// <summary>
           /// Desc:操作时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:操作人Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:操作人名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// Desc:操作方式
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Operate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public Guid? TenantId {get;set;}

    }
}
