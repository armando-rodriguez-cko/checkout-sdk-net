﻿using System.Collections.Generic;

namespace Checkout.Reconciliation
{
    public sealed class StatementReportResponse
    {
        public int? Count { get; set; }

        public IList<StatementData> Data { get; set; }
    }
}