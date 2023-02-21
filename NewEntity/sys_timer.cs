using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///定时任务表
    ///</summary>
    [SugarTable("sys_timer")]
	[Tenant("newDb")]
    public partial class sys_timer
    {
           public sys_timer(){


           }
           /// <summary>
           /// Desc:Id主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:任务名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string JobName {get;set;}

           /// <summary>
           /// Desc:只执行一次
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool DoOnce {get;set;}

           /// <summary>
           /// Desc:立即执行
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool StartNow {get;set;}

           /// <summary>
           /// Desc:执行类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ExecuteType {get;set;}

           /// <summary>
           /// Desc:间隔时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Interval {get;set;}

           /// <summary>
           /// Desc:Cron表达式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Cron {get;set;}

           /// <summary>
           /// Desc:定时器类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TimerType {get;set;}

           /// <summary>
           /// Desc:请求url
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RequestUrl {get;set;}

           /// <summary>
           /// Desc:请求参数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RequestParameters {get;set;}

           /// <summary>
           /// Desc:Headers
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Headers {get;set;}

           /// <summary>
           /// Desc:请求类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RequestType {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

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
