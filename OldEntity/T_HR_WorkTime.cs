using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///上班时间表
    ///</summary>
    [SugarTable("T_HR_WorkTime")]
	[Tenant("oldDb")]
    public partial class T_HR_WorkTime
    {
           public T_HR_WorkTime(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:月份
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Month {get;set;}

           /// <summary>
           /// Desc:上午上班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AMClassGoOn {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EarlistTimeACG {get;set;}

           /// <summary>
           /// Desc:上午下班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AMClassOff {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LatestTimeACO {get;set;}

           /// <summary>
           /// Desc:下午上班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PMClassGoOn {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EarlistTimePCG {get;set;}

           /// <summary>
           /// Desc:下午下班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PMClassOff {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LatestTimePCO {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreaterName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EditorName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EditeTime {get;set;}

    }
}
