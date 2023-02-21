using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///记录现场不规范行为标记，处理，审核
    ///</summary>
    [SugarTable("T_GW_MarkInfo")]
	[Tenant("oldDb")]
    public partial class T_GW_MarkInfo
    {
           public T_GW_MarkInfo(){


           }
           /// <summary>
           /// Desc:自增主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public decimal ID {get;set;}

           /// <summary>
           /// Desc:项目单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:工地
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WorkPlace {get;set;}

           /// <summary>
           /// Desc:x坐标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? Xaxes {get;set;}

           /// <summary>
           /// Desc:y坐标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? Yaxes {get;set;}

           /// <summary>
           /// Desc:是否改正
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IsHandled {get;set;}

           /// <summary>
           /// Desc:处理图片路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HandlePicPath {get;set;}

           /// <summary>
           /// Desc:处理结果描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HandleDes {get;set;}

           /// <summary>
           /// Desc:警告等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarnLevel {get;set;}

           /// <summary>
           /// Desc:异常类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Mark {get;set;}

           /// <summary>
           /// Desc:异常描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExceptionDes {get;set;}

           /// <summary>
           /// Desc:异常处理建议
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExceptionHandleSug {get;set;}

           /// <summary>
           /// Desc:异常图片路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExcPicPath {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditMethod {get;set;}

           /// <summary>
           /// Desc:审核结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditResult {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:报告人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReportMan {get;set;}

           /// <summary>
           /// Desc:报告时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ReportTime {get;set;}

           /// <summary>
           /// Desc:处理人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HandleMan {get;set;}

           /// <summary>
           /// Desc:处理时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? HandleTime {get;set;}

           /// <summary>
           /// Desc:审核人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditMan {get;set;}

           /// <summary>
           /// Desc:审核时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AuditTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PunishPath {get;set;}

    }
}
