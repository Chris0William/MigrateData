using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///员工入职记录表
    ///</summary>
    [SugarTable("T_HR_EntryPosition")]
	[Tenant("oldDb")]
    public partial class T_HR_EntryPosition
    {
           public T_HR_EntryPosition(){


           }
           /// <summary>
           /// Desc:ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string EntryPositionID {get;set;}

           /// <summary>
           /// Desc:员工ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StaffID {get;set;}

           /// <summary>
           /// Desc:入职时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EntryTime {get;set;}

           /// <summary>
           /// Desc:第几次入职
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

    }
}
