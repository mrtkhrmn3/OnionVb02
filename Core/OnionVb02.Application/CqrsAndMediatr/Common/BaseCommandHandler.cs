using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using OnionVb02.Domain.Enums;
using OnionVb02.Domain.Interfaces;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Common
{
    public abstract class BaseCommandHandler<TCommand, TEntity, TResult> 
        : IRequestHandler<TCommand, CommandResult<TResult>>
        where TCommand : ICommand<CommandResult<TResult>>
        where TEntity : class, IEntity
        where TResult : class
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        protected BaseCommandHandler(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public abstract Task<CommandResult<TResult>> Handle(TCommand request, CancellationToken cancellationToken);
    }

    public abstract class BaseCreateCommandHandler<TCommand, TEntity, TResult> 
        : BaseCommandHandler<TCommand, TEntity, TResult>
        where TCommand : ICommand<CommandResult<TResult>>
        where TEntity : class, IEntity
        where TResult : class
    {
        protected BaseCreateCommandHandler(IRepository<TEntity> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public override async Task<CommandResult<TResult>> Handle(TCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(request);
                entity.CreatedDate = DateTime.Now;
                entity.Status = DataStatus.Inserted;

                await _repository.CreateAsync(entity);

                var result = _mapper.Map<TResult>(entity);
                return CommandResult<TResult>.SuccessResult(result, "Veri başarıyla eklendi");
            }
            catch (Exception ex)
            {
                return CommandResult<TResult>.FailureResult($"Veri eklenirken hata oluştu: {ex.Message}");
            }
        }
    }

    public abstract class BaseUpdateCommandHandler<TCommand, TEntity, TResult> 
        : BaseCommandHandler<TCommand, TEntity, TResult>
        where TCommand : ICommand<CommandResult<TResult>>
        where TEntity : class, IEntity
        where TResult : class
    {
        protected BaseUpdateCommandHandler(IRepository<TEntity> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public override async Task<CommandResult<TResult>> Handle(TCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var idProperty = typeof(TCommand).GetProperty("Id");
                if (idProperty == null)
                {
                    return CommandResult<TResult>.FailureResult("Command'da Id property'si bulunamadı");
                }

                var id = (int)idProperty.GetValue(request);
                var originalEntity = await _repository.GetByIdAsync(id);
                if (originalEntity == null)
                {
                    return CommandResult<TResult>.FailureResult("Güncellenecek veri bulunamadı");
                }

                var updatedEntity = _mapper.Map<TEntity>(request);
                updatedEntity.Status = DataStatus.Updated;
                updatedEntity.UpdatedDate = DateTime.Now;
                updatedEntity.CreatedDate = originalEntity.CreatedDate;

                await _repository.UpdateAsync(originalEntity, updatedEntity);

                var result = _mapper.Map<TResult>(updatedEntity);
                return CommandResult<TResult>.SuccessResult(result, "Veri başarıyla güncellendi");
            }
            catch (Exception ex)
            {
                return CommandResult<TResult>.FailureResult($"Veri güncellenirken hata oluştu: {ex.Message}");
            }
        }
    }

    public abstract class BaseDeleteCommandHandler<TCommand, TEntity> 
        : IRequestHandler<TCommand, CommandResult>
        where TCommand : ICommand<CommandResult>
        where TEntity : class, IEntity
    {
        protected readonly IRepository<TEntity> _repository;

        protected BaseDeleteCommandHandler(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task<CommandResult> Handle(TCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entityId = GetEntityId(request);
                var entity = await _repository.GetByIdAsync(entityId);
                
                if (entity == null)
                {
                    return CommandResult.FailureResult("Silinecek veri bulunamadı");
                }

                if (entity.Status == DataStatus.Deleted)
                {
                    return CommandResult.FailureResult("Veri zaten silinmiş durumda");
                }

                entity.Status = DataStatus.Deleted;
                entity.DeletedDate = DateTime.Now;
                await _repository.SaveChangesAsync();

                return CommandResult.SuccessResult("Veri başarıyla silindi");
            }
            catch (Exception ex)
            {
                return CommandResult.FailureResult($"Veri silinirken hata oluştu: {ex.Message}");
            }
        }

        protected abstract int GetEntityId(TCommand request);
    }
}

