﻿namespace Todo_API.Models.DTO
{
    public class TodoParamsDto
    {
        private const int MaxPageSize = 10;
        public int PageNumber { get; set; } = 1;
        public int _pageSize = 10;


        public int PageSize
        {
            get => _pageSize; 
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
    }
}
