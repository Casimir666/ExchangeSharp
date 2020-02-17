using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeSharp
{
	public class ExchangeFee
	{
		public string Symbol { get; }
		public decimal Maker { get; }
		public decimal Taker { get; }

		public ExchangeFee(string symbol, decimal maker, decimal taker)
		{
			Symbol = symbol;
			Maker = maker;
			Taker = taker;
		}
	}
}
