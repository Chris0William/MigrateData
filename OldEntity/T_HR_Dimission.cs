using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///员工离职信息表
    ///</summary>
    [SugarTable("T_HR_Dimission")]
	[Tenant("oldDb")]
    public partial class T_HR_Dimission
    {
           public T_HR_Dimission(){


           }
           /// <summary>
           /// Desc:ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:员工ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StaffID {get;set;}

           /// <summary>
           /// Desc:离职日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? DimissionTime {get;set;}

           /// <summary>
           /// Desc:离职类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DimissionType {get;set;}

           /// <summary>
           /// Desc:离职原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DimissionReason {get;set;}

           /// <summary>
           /// Desc:离职愿意类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReasonType {get;set;}

           /// <summary>
           /// Desc:第几次
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Num {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsValid {get;set;}

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

    }
}
