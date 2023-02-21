using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///固定资产申请表
    ///</summary>
    [SugarTable("t_cg_ApplyFixedAsset")]
	[Tenant("newDb")]
    public partial class t_cg_ApplyFixedAsset
    {
           public t_cg_ApplyFixedAsset(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:申请单号(一个申请单号可包含多个固定资产)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ApplyNo {get;set;}

           /// <summary>
           /// Desc:申请人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplicantName {get;set;}

           /// <summary>
           /// Desc:申请人所属部门
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplicantSector {get;set;}

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
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Company {get;set;}

           /// <summary>
           /// Desc:订单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status {get;set;}

           /// <summary>
           /// Desc:采购类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurchaseType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string reason {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:使用人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UseMan {get;set;}

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

           /// <summary>
           /// Desc:申请类型 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplyType {get;set;}

           /// <summary>
           /// Desc:申请人工号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplicantId {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

    }
}
