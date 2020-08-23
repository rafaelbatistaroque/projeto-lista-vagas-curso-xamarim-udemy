using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace appVagas.Modelos
{
    public abstract class EntidadeBase
    {
        [PrimaryKey]
        public string Id => Guid.NewGuid().ToString().Replace("-", "").Substring(0, 12).Trim();
    }
}
