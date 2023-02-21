using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///间接资产申请表
    ///</summary>
    [SugarTable("t_cg_ApplyIndirect")]
	[Tenant("newDb")]
    public partial class t_cg_ApplyIndirect
    {
           public t_cg_ApplyIndirect(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:ApplyIndirNo
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ApplyIndirNo {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckProcess {get;set;}

           /// <summary>
           /// Desc:申请单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplyMstate {get;set;}

           /// <summary>
           /// Desc:ApplyMan
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplyMan {get;set;}

           /// <summary>
           /// Desc:ApplySector
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplySector {get;set;}

           /// <summary>
           /// Desc:收货人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReceiveMan {get;set;}

           /// <summary>
           /// Desc:采购类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurchaseType {get;set;}

           /// <summary>
           /// Desc:description
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:经办时间
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
           /// Desc:经办人
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
