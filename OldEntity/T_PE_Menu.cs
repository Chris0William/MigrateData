using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PE_Menu")]
	[Tenant("oldDb")]
    public partial class T_PE_Menu
    {
           public T_PE_Menu(){


           }
           /// <summary>
           /// Desc:菜单ID（GUID）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MenuID {get;set;}

           /// <summary>
           /// Desc:父级菜单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ParentID {get;set;}

           /// <summary>
           /// Desc:菜单内容CN
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TextCN {get;set;}

           /// <summary>
           /// Desc:菜单内容EN
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TextEN {get;set;}

           /// <summary>
           /// Desc:菜单序号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? OrderID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string URL {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ImageURL {get;set;}

           /// <summary>
           /// Desc:是否可见
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Visible {get;set;}

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

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? DefaultURL {get;set;}

    }
}
