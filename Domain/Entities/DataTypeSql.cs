using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DataTypeSql
    {

        [Key]
        public String Code { get; set; }
        public SqlDbType Dbtype { get; set; }
        public object Value { get; set; }

        public DataTypeSql(String code, SqlDbType dbtype, object value)
        {
            this.Code = code;
            this.Dbtype = dbtype;
            this.Value = value;
        }
    }
}
