using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///项目评审审核表
    ///</summary>
    [SugarTable("T_RM_CheckTask")]
	[Tenant("newDb")]
    public partial class T_RM_CheckTask
    {
           public T_RM_CheckTask(){


           }
           /// <summary>
           /// Desc:GUID主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:审核人
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string StaffID {get;set;}

           /// <summary>
           /// Desc:链接
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Url {get;set;}

           /// <summary>
           /// Desc:审核状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? State {get;set;}

           /// <summary>
           /// Desc:步骤
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Step {get;set;}

           /// <summary>
           /// Desc:审核时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OperationTime {get;set;}

           /// <summary>
           /// Desc:审核名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TypeName {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EndTime {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateTime {get;set;}

           /// <summary>
           /// Desc:关联各表主键ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OperationID {get;set;}

           /// <summary>
           /// Desc:审核描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Description {get;set;}

           /// <summary>
           /// Desc:是否无效
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Expire {get;set;}

    }
}
