using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///职位类别
    ///</summary>
    [SugarTable("T_HR_PositionCategory")]
	[Tenant("oldDb")]
    public partial class T_HR_PositionCategory
    {
           public T_HR_PositionCategory(){


           }
           /// <summary>
           /// Desc:职位类别ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string PositionCategoryID {get;set;}

           /// <summary>
           /// Desc:职位类别名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PositionCategoryName {get;set;}

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
           public string CreaterName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EditorName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EditorTime {get;set;}

    }
}
