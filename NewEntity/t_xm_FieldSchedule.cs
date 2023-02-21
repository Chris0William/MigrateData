using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///现场时间进度计划表
    ///</summary>
    [SugarTable("t_xm_FieldSchedule")]
	[Tenant("newDb")]
    public partial class t_xm_FieldSchedule
    {
           public t_xm_FieldSchedule(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:计划开工时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProStartPlanTime {get;set;}

           /// <summary>
           /// Desc:实际开工时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProStartRealTime {get;set;}

           /// <summary>
           /// Desc:计划完工时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProEndPlanTime {get;set;}

           /// <summary>
           /// Desc:实际完工时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProEndRealTime {get;set;}

           /// <summary>
           /// Desc:计划验收时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProAcceptPlanTime {get;set;}

           /// <summary>
           /// Desc:实际验收时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProAcceptRealTime {get;set;}

           /// <summary>
           /// Desc:计划客户入库时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProWarePlanTime {get;set;}

           /// <summary>
           /// Desc:实际客户入库时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProWareRealTime {get;set;}

           /// <summary>
           /// Desc:项目总体进度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ProProcess {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:项目收入确定日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProIncomeTime {get;set;}

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
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

           /// <summary>
           /// Desc:计划完工过半日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProHalfPlanTime {get;set;}

           /// <summary>
           /// Desc:实际完工过半日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProHalfRealTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Stopped {get;set;}

    }
}
