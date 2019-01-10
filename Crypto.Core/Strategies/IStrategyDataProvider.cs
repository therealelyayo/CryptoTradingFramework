﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Core.Strategies {
    public interface IStrategyDataProvider {
        bool Connect(ExchangeInputInfo info);
        bool Connect(TickerInputInfo info);
        bool Disconnect(ExchangeInputInfo info);
        bool Disconnect(TickerInputInfo info);
    }
}
