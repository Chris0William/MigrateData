using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///固定资产入库表
    ///</summary>
    [SugarTable("t_cg_StorageFixedAsset")]
	[Tenant("newDb")]
    public partial class t_cg_StorageFixedAsset
    {
           public t_cg_StorageFixedAsset(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:入库单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string StorageNo {get;set;}

           /// <summary>
           /// Desc:采购单主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PFAGID {get;set;}

           /// <summary>
           /// Desc:仓库ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarehouseID {get;set;}

           /// <summary>
           /// Desc:入库类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StorageType {get;set;}

           /// <summary>
           /// Desc:申请时间,入库时间等
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? No_Date {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditProcess {get;set;}

           /// <summary>
           /// Desc:订单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Status {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

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
