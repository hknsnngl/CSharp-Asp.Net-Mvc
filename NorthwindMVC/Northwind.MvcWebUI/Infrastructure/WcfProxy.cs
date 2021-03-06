﻿using Northwind.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Northwind.MvcWebUI.Infrastructure
{
    public static class WcfProxy<T>
    {
        public static   T CreateChannel() // T IProducService
        {
            string address = String.Format("http://localhost:49826/{0}.svc?wsdl", typeof(T).Name.Substring(1));
            var binding = new BasicHttpBinding();
            var channel = new ChannelFactory<T>(binding, address);

            return channel.CreateChannel();
        }
    }
}