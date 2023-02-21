using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///现场信息管理
    ///</summary>
    [SugarTable("T_GW_FieldInfoManagement")]
	[Tenant("oldDb")]
    public partial class T_GW_FieldInfoManagement
    {
           public T_GW_FieldInfoManagement(){


           }
           /// <summary>
           /// Desc:自增主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public decimal ID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:仓库编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarehouseID {get;set;}

           /// <summary>
           /// Desc:现场名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FieldName {get;set;}

           /// <summary>
           /// Desc:现场负责人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FieldPrincipal {get;set;}

           /// <summary>
           /// Desc:地图名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FieldMapName {get;set;}

           /// <summary>
           /// Desc:地图路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FieldMapPath {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:客户满意度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? CustomRating {get;set;}

           /// <summary>
           /// Desc:创建办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InputMan {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? InputTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectDescribe {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Adress {get;set;}

    }
}
