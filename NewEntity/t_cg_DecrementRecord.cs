using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///采购减量记录表
    ///</summary>
    [SugarTable("t_cg_DecrementRecord")]
	[Tenant("newDb")]
    public partial class t_cg_DecrementRecord
    {
           public t_cg_DecrementRecord(){


           }
           /// <summary>
           /// Desc:主键id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:采购单id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OGID {get;set;}

           /// <summary>
           /// Desc:采购单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurchaseMNo {get;set;}

           /// <summary>
           /// Desc:审核流程id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Auditingprocess {get;set;}

           /// <summary>
           /// Desc:审核流程名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditingprocessName {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:创建者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

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
           public long? UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:修改者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
