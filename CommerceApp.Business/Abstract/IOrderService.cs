﻿using CommerceApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceApp.Business.Abstract
{
    public interface IOrderService
    {
        void Create(Order order);
        List<Order> GetOrders(string userId);
    }
}
