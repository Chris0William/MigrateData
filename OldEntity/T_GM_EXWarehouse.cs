using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_GM_EXWarehouse")]
	[Tenant("oldDb")]
    public partial class T_GM_EXWarehouse
    {
           public T_GM_EXWarehouse(){


           }
           /// <summary>
           /// Desc:出库编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string EXID {get;set;}

           /// <summary>
           /// Desc:出库日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EXDate {get;set;}

           /// <summary>
           /// Desc:出库类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int EXTypeID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectID {get;set;}

           /// <summary>
           /// Desc:对应入库的关联单编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RefrenceNo {get;set;}

           /// <summary>
           /// Desc:操作人
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Operator {get;set;}

           /// <summary>
           /// Desc:操作时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime OperationTime {get;set;}

           /// <summary>
           /// Desc:审核操作流程ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperationListID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IMWarehouse {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EXWarehouse {get;set;}

    }
}
