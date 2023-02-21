using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PE_Permission")]
	[Tenant("oldDb")]
    public partial class T_PE_Permission
    {
           public T_PE_Permission(){


           }
           /// <summary>
           /// Desc:权限ID（GUID）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string PermissionID {get;set;}

           /// <summary>
           /// Desc:权限对应菜单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MenuID {get;set;}

           /// <summary>
           /// Desc:权限动作
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Action {get;set;}

           /// <summary>
           /// Desc:权限描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Description {get;set;}

           /// <summary>
           /// Desc:权限扩展内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Expand {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Creator {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatorID {get;set;}

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
           public string Editor {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EditorID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EditeTime {get;set;}

    }
}
