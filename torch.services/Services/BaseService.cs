using System;
using Microsoft.Extensions.Logging;
using torch.database.Models;


namespace torch.services.Services
{
    public class BaseService
    {
        public readonly ILogger _logger;

        public readonly TorchContext _context;

        public BaseService(ILogger logger)
        {
            _logger = logger;
        }

        public BaseService(ILogger logger, TorchContext context)
        {
            _logger = logger;

            _context = context;
        }
    }
}
