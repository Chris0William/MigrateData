using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///现场时间计划表
    ///</summary>
    [SugarTable("T_GW_FieldSchedule")]
	[Tenant("oldDb")]
    public partial class T_GW_FieldSchedule
    {
           public T_GW_FieldSchedule(){


           }
           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
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
           /// Desc:计划完工50%时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProHalfPlanTime {get;set;}

           /// <summary>
           /// Desc:实际完工50%时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProHalfRealTime {get;set;}

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
           public string ProProcess {get;set;}

           /// <summary>
           /// Desc:输入人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InputMan {get;set;}

           /// <summary>
           /// Desc:输入时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? InputTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Stopped {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:项目收入确定日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProIncomeTime {get;set;}

    }
}
