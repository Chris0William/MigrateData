using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///报价评审明细表
    ///</summary>
    [SugarTable("T_RM_OfferDetail")]
	[Tenant("newDb")]
    public partial class T_RM_OfferDetail
    {
           public T_RM_OfferDetail(){


           }
           /// <summary>
           /// Desc:主键自增id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:关联报价评审表的ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ReferenceId {get;set;}

           /// <summary>
           /// Desc:项目
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Menu {get;set;}

           /// <summary>
           /// Desc:甲方比率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FirstRate {get;set;}

           /// <summary>
           /// Desc:甲方清单金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FirstAmount {get;set;}

           /// <summary>
           /// Desc:乙方比率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SecondRate {get;set;}

           /// <summary>
           /// Desc:乙方清单金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SecondAmount {get;set;}

    }
}
