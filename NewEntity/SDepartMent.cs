using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("SDepartMent")]
	[Tenant("newDb")]
    public partial class SDepartMent
    {
           public SDepartMent(){


           }
           /// <summary>
           /// Desc:二级部门id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string SDepartMentId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FDepartMentId {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SDepartMentName {get;set;}

           /// <summary>
           /// Desc:领导
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SDepartMentLeader {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SDepartMentRemark {get;set;}

           /// <summary>
           /// Desc:附加信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SDepartMentExtra {get;set;}

           /// <summary>
           /// Desc:地区
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string DepartMentArea {get;set;}

           /// <summary>
           /// Desc:地点
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string DepartMentPlace {get;set;}

           /// <summary>
           /// Desc:创建人	   
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatePerson {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

    }
}
