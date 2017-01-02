﻿using DialogEngine.EngineModel;
using DialogEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogEngine.Data
{
    public class StatementLinkAccess
    {
        public uint GetStatementLinkByStatementID(StatementLink link, uint statementId)
        {
            return 
                link.Links.Where(l => l.StatementID == statementId)
                .Select(l => l.NextLinkID)
                .FirstOrDefault();
        }

        public StatementLink GetStatementLinkByID(List<StatementLink> links, uint linkId)
        {
            return
                links.Where(l => l.ID == linkId).Select(l => l).FirstOrDefault();
        }
    }
}
