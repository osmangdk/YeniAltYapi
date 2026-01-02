using CleanApp.Application.Contracts.Persistence;
using CleanApp.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanApp.Application.Features.Test.Queries.GetAllTests;


public class GetAllTestHandler : IRequestHandler<GetAllTestQueryRequest, IList<GetAllTestQueryResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGenericRepository<TestTable,Guid> _genericRepository;
    public GetAllTestHandler(IUnitOfWork unitOfWork, IGenericRepository<TestTable,Guid> genericRepository)
    {
        _unitOfWork = unitOfWork;
        _genericRepository = genericRepository;
    }

    public async Task<IList<GetAllTestQueryResponse>> Handle(GetAllTestQueryRequest request, CancellationToken cancellationToken)
    {
        //var data = await _unitOfWork.GetRepositoryAsync<Test, Guid>().GetAllAsync();
        var data = await _genericRepository.GetAllAsync();

        // Map domain entities to response DTOs; update mapping as needed
        var result = data.Select(d => new GetAllTestQueryResponse()
        {
            // TODO: map properties from d to response
        }).ToList();

        return result;
    }
}
