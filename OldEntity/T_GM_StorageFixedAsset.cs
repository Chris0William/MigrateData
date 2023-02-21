using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///固定资产入库表
    ///</summary>
    [SugarTable("T_GM_StorageFixedAsset")]
	[Tenant("oldDb")]
    public partial class T_GM_StorageFixedAsset
    {
           public T_GM_StorageFixedAsset(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string GID {get;set;}

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
           /// Desc:经办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operator {get;set;}

           /// <summary>
           /// Desc:经办时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OperateTime {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Enclosure {get;set;}

    }
}
