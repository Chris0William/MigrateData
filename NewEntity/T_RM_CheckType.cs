using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///项目评审审核类型表
    ///</summary>
    [SugarTable("T_RM_CheckType")]
	[Tenant("newDb")]
    public partial class T_RM_CheckType
    {
           public T_RM_CheckType(){


           }
           /// <summary>
           /// Desc:GUID主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:审核角色名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CheckTypeName {get;set;}

           /// <summary>
           /// Desc:优先级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Level {get;set;}

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
           /// Desc:审核类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Type {get;set;}

           /// <summary>
           /// Desc:审核步骤（新增字段）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Step {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserId {get;set;}

           /// <summary>
           /// Desc:创建者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:修改者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:修改者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsDeleted {get;set;}

    }
}
