using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_RM_CheckType")]
	[Tenant("oldDb")]
    public partial class T_RM_CheckType
    {
           public T_RM_CheckType(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int no {get;set;}

           /// <summary>
           /// Desc:GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:审核类型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckTypeName {get;set;}

           /// <summary>
           /// Desc:优先级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Level {get;set;}

           /// <summary>
           /// Desc:模块名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModuleName {get;set;}

           /// <summary>
           /// Desc:有效期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Time_limit {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Creator {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ModifyTime {get;set;}

           /// <summary>
           /// Desc:修改人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Modifier {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Type {get;set;}

    }
}
