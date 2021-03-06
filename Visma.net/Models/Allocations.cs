﻿using ONIT.VismaNetApi.Lib;
using ONIT.VismaNetApi.Models.CustomDto;
using ONIT.VismaNetApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONIT.VismaNetApi.Models
{
    public class Allocations : DtoProviderBase
    {
        public Allocations()
        {
            DtoFields.Add("operation", new NotDto<ApiOperation>(ApiOperation.Update));
        }
        public ApiOperation operation
        {
            get { return Get(defaultValue: new NotDto<ApiOperation>(ApiOperation.Update)).Value; }
            set { Set(new NotDto<ApiOperation>(value)); }
        }
        public int lineNbr
        {
            get { return Get<int>(); }
            set { Set(value); }
        }

        public LocationSummary location
        {
            get => Get("locationId", new LocationSummary());
            set => Set(value, "locationId");
        }

        public string lotSerialNumber
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public decimal quantity
        {
            get { return Get<decimal>(); }
            set { Set(value); }
        }
        public string uOM
        {
            get { return Get<string>(); }
            set { Set(value); }
        }
        public DateTime expirationDate
        {
            get { return Get<DateTime>(); }
            set { Set(value); }
        }
    }
}
