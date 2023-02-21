using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///记录材料信息的表
    ///</summary>
    [SugarTable("t_xm_InfoMaterial")]
	[Tenant("newDb")]
    public partial class t_xm_InfoMaterial
    {
           public t_xm_InfoMaterial(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:材料编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MaterialID {get;set;}

           /// <summary>
           /// Desc:材料名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MaterialName {get;set;}

           /// <summary>
           /// Desc:是否使用。用于标识用户修改操作，某一物品修改多次后，只有当前正在使用的标识为true
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsEnable {get;set;}

           /// <summary>
           /// Desc:物料类型，固定资产为FA，项目物料为M
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Type {get;set;}

           /// <summary>
           /// Desc:图片路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PicturePath {get;set;}

           /// <summary>
           /// Desc:型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Size {get;set;}

           /// <summary>
           /// Desc:单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Unit {get;set;}

           /// <summary>
           /// Desc:预算价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Price {get;set;}

           /// <summary>
           /// Desc:最小采购价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MinPrice {get;set;}

           /// <summary>
           /// Desc:品牌
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Brand {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:采购周期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurchaseCycle {get;set;}

           /// <summary>
           /// Desc:最小采购量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MinPurchase {get;set;}

           /// <summary>
           /// Desc:成本类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CostType {get;set;}

           /// <summary>
           /// Desc:材质
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Matter {get;set;}

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

           /// <summary>
           /// Desc:审核流程ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OpreationID {get;set;}

    }
}
