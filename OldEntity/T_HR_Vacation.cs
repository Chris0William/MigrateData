using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///请假
    ///</summary>
    [SugarTable("T_HR_Vacation")]
	[Tenant("oldDb")]
    public partial class T_HR_Vacation
    {
           public T_HR_Vacation(){


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
           /// Desc:请假类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VPType {get;set;}

           /// <summary>
           /// Desc:请假开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? StartTime {get;set;}

           /// <summary>
           /// Desc:请假结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EndTime {get;set;}

           /// <summary>
           /// Desc:请假时长
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? TimeSpan {get;set;}

           /// <summary>
           /// Desc:请假事由
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VPReason {get;set;}

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

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OperationListID {get;set;}

           /// <summary>
           /// Desc:销假时对于调休的，要把可调休加班时数加上原来的请假时长，再减去新的请假时长
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LastID {get;set;}

           /// <summary>
           /// Desc:是否是修改的
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? VPEdit {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? VPDelete {get;set;}

           /// <summary>
           /// Desc:标记当前销假是修改还是删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EditOrDelete {get;set;}

    }
}
