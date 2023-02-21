using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///客户信息表
    ///</summary>
    [SugarTable("t_xm_CustomerInfo")]
	[Tenant("newDb")]
    public partial class t_xm_CustomerInfo
    {
           public t_xm_CustomerInfo(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:客户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CustomerID {get;set;}

           /// <summary>
           /// Desc:客户名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CustomerName {get;set;}

           /// <summary>
           /// Desc:客户编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomerAbbreviation {get;set;}

           /// <summary>
           /// Desc:子公司编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SubsidiaryNumber {get;set;}

           /// <summary>
           /// Desc:合作方向
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Cooperation {get;set;}

           /// <summary>
           /// Desc:多个联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Contact {get;set;}

           /// <summary>
           /// Desc:多个联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel {get;set;}

           /// <summary>
           /// Desc:多个传真
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Fax {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:银行账户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankAccount {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:银行名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankType {get;set;}

           /// <summary>
           /// Desc:纳税识别号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxNo {get;set;}

           /// <summary>
           /// Desc:附件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Attachment {get;set;}

           /// <summary>
           /// Desc:决策分析
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Decision {get;set;}

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
