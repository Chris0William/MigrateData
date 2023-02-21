using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///入库
    ///</summary>
    [SugarTable("T_GM_IMWarehouse")]
	[Tenant("oldDb")]
    public partial class T_GM_IMWarehouse
    {
           public T_GM_IMWarehouse(){


           }
           /// <summary>
           /// Desc:入库单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string IMID {get;set;}

           /// <summary>
           /// Desc:入库日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime IMDate {get;set;}

           /// <summary>
           /// Desc:入库类型号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int IMTypeID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectID {get;set;}

           /// <summary>
           /// Desc:对应于入库的关联号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RefrenceNo {get;set;}

           /// <summary>
           /// Desc:操作人ID
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
           /// Desc:审核动作ID
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
           public string IMWarehouseID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EXWarehouseID {get;set;}

    }
}
