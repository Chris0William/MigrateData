using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///供应商信息表
    ///</summary>
    [SugarTable("t_cg_SupplierInfo")]
	[Tenant("newDb")]
    public partial class t_cg_SupplierInfo
    {
           public t_cg_SupplierInfo(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:供应商ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SupplierID {get;set;}

           /// <summary>
           /// Desc:供应商名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SupplierName {get;set;}

           /// <summary>
           /// Desc:供应商类别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierClass {get;set;}

           /// <summary>
           /// Desc:联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Contact {get;set;}

           /// <summary>
           /// Desc:联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel {get;set;}

           /// <summary>
           /// Desc:传真
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Fax {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// Desc:银行账户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankAccount {get;set;}

           /// <summary>
           /// Desc:主营产品
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MainProduct {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:开户行名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankName {get;set;}

           /// <summary>
           /// Desc:付款周期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaymentCycle {get;set;}

           /// <summary>
           /// Desc:邮箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// Desc:Tax
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tax {get;set;}

           /// <summary>
           /// Desc:银行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Bank {get;set;}

           /// <summary>
           /// Desc:CompanyProperity
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyProperity {get;set;}

           /// <summary>
           /// Desc:是否启用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? isEnable {get;set;}

           /// <summary>
           /// Desc:SupplierGrade
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierGrade {get;set;}

           /// <summary>
           /// Desc:AuditProcess
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditProcess {get;set;}

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
           /// Desc:附件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProtocolFile {get;set;}

           /// <summary>
           /// Desc:评审表
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EvaluationTable {get;set;}

           /// <summary>
           /// Desc:廉洁协议
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HonestAgreement {get;set;}

           /// <summary>
           /// Desc:施工安全/劳动保护/环境保护
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FilePath_1 {get;set;}

           /// <summary>
           /// Desc:施工规范与验收标准
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FilePath_2 {get;set;}

           /// <summary>
           /// Desc:供应商通知函
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FilePath_3 {get;set;}

    }
}
