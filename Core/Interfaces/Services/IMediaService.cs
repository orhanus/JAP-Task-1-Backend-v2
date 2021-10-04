﻿using Common.Enums;
using Core.Models.DTOs;
using Core.Models.Models;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IMediaService
    {
        Task<PaginatedResponseDto<MediaDto>> GetMediaAsync(MediaParams mediaParams, MediaType mediaType);

    }
}
