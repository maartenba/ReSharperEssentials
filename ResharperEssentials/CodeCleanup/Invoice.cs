using System;
using System.Collections;
using System.Linq;
using System.Data;

namespace ResharperEssentials.CodeCleanup
{
    public class Invoice {
        public int Id { get; set; }

        public Invoice(int id) {
            this.Id = id;
        }

        public override string ToString() {
            return $"Id: {Id}";
        }
    }
}