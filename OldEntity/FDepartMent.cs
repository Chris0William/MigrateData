using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("FDepartMent")]
	[Tenant("oldDb")]
    public partial class FDepartMent
    {
           public FDepartMent(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string FDepartMentId {get;set;}

           /// <summary>
           /// Desc:公司ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Companyid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string FDepartMentName {get;set;}

           /// <summary>
           /// Desc:领导
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FDepartMentLeader {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FDepartMentRemark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FDepartMentExtra {get;set;}

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
           public DateTime? CreateTime {get;set;}

    }
}
