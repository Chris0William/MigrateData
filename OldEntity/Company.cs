using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Company")]
	[Tenant("oldDb")]
    public partial class Company
    {
           public Company(){


           }
           /// <summary>
           /// Desc:公司ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Companyid {get;set;}

           /// <summary>
           /// Desc:公司名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CompanyName {get;set;}

           /// <summary>
           /// Desc:公司负责人可以多个
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyLeader {get;set;}

           /// <summary>
           /// Desc:公司备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:其他
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatePerson {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateDate {get;set;}

    }
}
