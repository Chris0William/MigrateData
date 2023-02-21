using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///扣款单表
    ///</summary>
    [SugarTable("t_xm_CutPay")]
	[Tenant("newDb")]
    public partial class t_xm_CutPay
    {
           public t_xm_CutPay(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:UID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UID {get;set;}

           /// <summary>
           /// Desc:扣款单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Numbers {get;set;}

           /// <summary>
           /// Desc:供应商ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SupplierID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:扣款原因
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Reason {get;set;}

           /// <summary>
           /// Desc:扣款金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Amount {get;set;}

           /// <summary>
           /// Desc:是否收到扣款单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? ReceivedState {get;set;}

           /// <summary>
           /// Desc:扣款状态：已收到/未收到
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? State {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckProcess {get;set;}

           /// <summary>
           /// Desc:确认人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Comfirmor {get;set;}

           /// <summary>
           /// Desc:确认时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Comfirmortime {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:所属公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string company {get;set;}

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
           /// Desc:审核状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditState {get;set;}

    }
}
