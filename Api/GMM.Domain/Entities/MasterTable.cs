﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Domain.Entities
{
    public class MasterTable : IGenerateEntity<MasterTable>
    {

        public string IdMasterTable { get; set; }
        public string IdMasterTableParent { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public string Value { get; set; }
        public string AdditionalOne { get; set; }
        public string AdditionalTwo { get; set; }
        public string AdditionalThree { get; set; }
        public string RecordStatus { get; set; }
        public string UserRecordCreation { get; set; }
        public DateTime RecordCreationDate { get; set; }
        public string UserEditRecord { get; set; }
        public DateTime? RecordEditDate { get; set; }

        public MasterTable RecoverKey()
        {
            return new MasterTable() { IdMasterTable = this.IdMasterTable };
        }
    }

}
