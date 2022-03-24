﻿using System;
namespace LiJiT.Domain.DTO
{
    public  abstract class BaseResponse
    {
        public string MessageCode { get; set; }
        public string Message { get; set; }
        public bool HasError { get; set; }
        public int ListCount { get; set; }

    }
}
