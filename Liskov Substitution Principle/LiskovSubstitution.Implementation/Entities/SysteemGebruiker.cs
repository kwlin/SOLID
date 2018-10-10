using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Implementation.Entities
{
    public class SysteemGebruiker : GebruikerBase
    {
        public long WindowsId { get; set; }

        /// <summary>
        /// Refactorslag 1
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            throw new NotSupportedException();
        }
    }
}
