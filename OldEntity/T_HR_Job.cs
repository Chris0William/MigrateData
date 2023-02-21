using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///职位
    ///</summary>
    [SugarTable("T_HR_Job")]
	[Tenant("oldDb")]
    public partial class T_HR_Job
    {
           public T_HR_Job(){


           }
           /// <summary>
           /// Desc:职位ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string JobID {get;set;}

           /// <summary>
           /// Desc:职位名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JobName {get;set;}

           /// <summary>
           /// Desc:职务ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string DutyID {get;set;}

           /// <summary>
           /// Desc:备注
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
           public DateTime? EditorTime {get;set;}

    }
}
