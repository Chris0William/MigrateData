using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///客户信息表
    ///</summary>
    [SugarTable("T_GM_CustomerInfo")]
	[Tenant("oldDb")]
    public partial class T_GM_CustomerInfo
    {
           public T_GM_CustomerInfo(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public decimal UID {get;set;}

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
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomerAbbreviation {get;set;}

           /// <summary>
           /// Desc:
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
           /// Desc:联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Contact {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Contact2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Contact3 {get;set;}

           /// <summary>
           /// Desc:联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel3 {get;set;}

           /// <summary>
           /// Desc:传真
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Fax {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Fax2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Fax3 {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// Desc:客户信息录入人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InputPerson {get;set;}

           /// <summary>
           /// Desc:客户信息录入时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? InputTime {get;set;}

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
           public string Remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxNo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Attachment {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Decision {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Depute1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Depute2 {get;set;}

    }
}
