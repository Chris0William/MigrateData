using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///个人工作日报
    ///</summary>
    [SugarTable("t_us_DailyWorkReport")]
	[Tenant("newDb")]
    public partial class t_us_DailyWorkReport
    {
           public t_us_DailyWorkReport(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:考勤归属地
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProjectSite {get;set;}

           /// <summary>
           /// Desc:考勤日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime Date {get;set;}

           /// <summary>
           /// Desc:关联审核ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperationID {get;set;}

           /// <summary>
           /// Desc:项目进度
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ProgressPercentage {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Description {get;set;}

           /// <summary>
           /// Desc:来料状况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MaterialComing {get;set;}

           /// <summary>
           /// Desc:来料状况是否异常(1异常)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? MaterialComing_QU {get;set;}

           /// <summary>
           /// Desc:质量状况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Quality {get;set;}

           /// <summary>
           /// Desc:质量状况是否异常（1异常）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Quality_QU {get;set;}

           /// <summary>
           /// Desc:进度状况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProgressStatus {get;set;}

           /// <summary>
           /// Desc:进度状况是否异常（1异常）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? ProgressStatus_QU {get;set;}

           /// <summary>
           /// Desc:安全状况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Security {get;set;}

           /// <summary>
           /// Desc:安全状况（1异常）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Security_QU {get;set;}

           /// <summary>
           /// Desc:客户反馈情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomerComplaints {get;set;}

           /// <summary>
           /// Desc:客户反馈情况（1异常）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? CustomerComplaints_QU {get;set;}

           /// <summary>
           /// Desc:现场人员每天工作安排
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Theset {get;set;}

           /// <summary>
           /// Desc:现场人员每天工作安排异常（1异常）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Theset_QU {get;set;}

           /// <summary>
           /// Desc:经办时间
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
           /// Desc:经办人
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
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

           /// <summary>
           /// Desc:附件地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PirturePath {get;set;}

    }
}
