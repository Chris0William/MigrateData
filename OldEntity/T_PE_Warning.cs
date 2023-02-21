using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PE_Warning")]
	[Tenant("oldDb")]
    public partial class T_PE_Warning
    {
           public T_PE_Warning(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:最新一次开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LastBeginTime {get;set;}

           /// <summary>
           /// Desc:间隔时长
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Interval {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Reminder {get;set;}

           /// <summary>
           /// Desc:是否禁用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Invalid {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Creator {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Createtime {get;set;}

           /// <summary>
           /// Desc:修改人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Modifier {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ModifyTime {get;set;}

           /// <summary>
           /// Desc:存储过程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StoreProcedure {get;set;}

           /// <summary>
           /// Desc:功能描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Description {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningName {get;set;}

    }
}
