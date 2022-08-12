﻿using Infrastructure.Domain.Queries;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Manufactures.Application.GarmentSample.GarmentMonitoringSampleStockFlows.Queries
{
	public class GetXlsMonitoringSampleStockFlowQuery : IQuery<MemoryStream>
	{
		public int page { get; private set; }
		public int size { get; private set; }
		public string order { get; private set; }
		public string token { get; private set; }
		public int unit { get; private set; }
		public string ro { get; private set; }
		public string type { get; private set; }
		public DateTime dateFrom { get; private set; }
		public DateTime dateTo { get; private set; }

		public GetXlsMonitoringSampleStockFlowQuery(int page, int size, string order, int unit, string ro, DateTime dateFrom, DateTime dateTo,string type, string token)
		{
			this.page = page;
			this.size = size;
			this.order = order;
			this.unit = unit;
			this.ro = ro;
			this.dateTo = dateTo;
			this.dateFrom = dateFrom;
			this.token = token;
			this.type = type;
		}
	}
}
