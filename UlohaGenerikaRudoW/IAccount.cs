using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlohaGenerikaRudoW
{
    public interface IAccount
    {
        /// <summary>
        /// Zostatok na ucte
        /// </summary>
        decimal Balance { get; set; }

        /// <summary>
        /// Datum vytvorenia uctu
        /// </summary>
        DateTime Created { get; set; }
    }
}
