﻿using Adnc.Infra.Application.Dtos;

namespace Adnc.Ord.Application.Contracts.Dtos
{
    public class OrderSearchPagedDto : SearchPagedDto
    {
        public long? Id { get; set; }
    }
}