using MediatR; 
using CleanApp.Domain.Entities;
using CleanApp.Application.Contracts.Persistence;

namespace CleanApp.Application.Features.Test.Queries.GetAllTests;

public class GetAllTestQueryHandler  : IRequestHandler<GetAllTestQueryRequest, IList<GetAllTestQueryResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGenericRepository<TestTable,Guid> _genericRepository;
    public GetAllTestQueryHandler (IUnitOfWork unitOfWork, IGenericRepository<TestTable,Guid> genericRepository)
    {
        _unitOfWork = unitOfWork;
        _genericRepository = genericRepository;
    }

    public async Task<IList<GetAllTestQueryResponse>> Handle(GetAllTestQueryRequest request, CancellationToken cancellationToken)
    {
        //var data = await _unitOfWork.GetRepositoryAsync<Test, Guid>().GetAllAsync();
        var data = await _genericRepository.GetAllAsync();
        throw new NotImplementedException();
    }
}