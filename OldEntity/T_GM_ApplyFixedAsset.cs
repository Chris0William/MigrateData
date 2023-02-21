using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///固定资产申请表
    ///</summary>
    [SugarTable("T_GM_ApplyFixedAsset")]
	[Tenant("oldDb")]
    public partial class T_GM_ApplyFixedAsset
    {
           public T_GM_ApplyFixedAsset(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string GID {get;set;}

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
           public string Applicant {get;set;}

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
           public string UseMan {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Company {get;set;}

    }
}
