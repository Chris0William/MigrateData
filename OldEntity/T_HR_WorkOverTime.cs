using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///可调休加班时数
    ///</summary>
    [SugarTable("T_HR_WorkOverTime")]
	[Tenant("oldDb")]
    public partial class T_HR_WorkOverTime
    {
           public T_HR_WorkOverTime(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StaffID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Year {get;set;}

           /// <summary>
           /// Desc:上年度延续可调休时数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LastYear {get;set;}

           /// <summary>
           /// Desc:本年度累计可调休时数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CurrentYear {get;set;}

           /// <summary>
           /// Desc:本年度可调休总时数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CurrentYearSum {get;set;}

           /// <summary>
           /// Desc:个人调休时数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Personal {get;set;}

           /// <summary>
           /// Desc:公司调休时数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Company {get;set;}

           /// <summary>
           /// Desc:本年度剩余调休时数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CurrentYearLast {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Valid {get;set;}

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
