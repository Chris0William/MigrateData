using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_US_SendMessage")]
    [Tenant("oldDb")]
    public partial class T_US_SendMessage
    {
        public T_US_SendMessage()
        {


        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int no { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? datetime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string context { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        [SugarColumn(ColumnName = "bool")]
        public bool? isTrue { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string type { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Receiver { get; set; }

    }
}
